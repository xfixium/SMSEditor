// 
// SMS Editor
// Copyright (C) 2021 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using SMSEditor.Data;

namespace SMSEditor.Controls
{
    public partial class AssetDataEntryControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Project _project = null;

        /// <summary>
        /// Properties
        /// </summary>
        public bool HasData { get { return _project != null; } }

        public AssetDataEntryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Save asset button click
        /// </summary>
        private void btnAsset_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl == btnDataEntrySave)
                SaveDataEntry();
            else if (ctrl == btnDataEntryRemove)
                RemoveDataEntry();
            else if (ctrl == btnImportData)
                ImportData();
            else if (ctrl == btnFormatText)
                FormatText();
        }

        /// <summary>
        /// Asset selection changed
        /// </summary>
        private void lstAssets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == lstDataEntries.Name && lstDataEntries.SelectedItem != null)
                SetDataEntryData(_project.GetDataEntry((lstDataEntries.SelectedItem as GameAsset).ID));

            OnInfoChanged();
        }

        /// <summary>
        /// Asset ID value changed
        /// </summary>
        private void nudAssetID_ValueChanged(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            if (ctrl.Name == nudDataEntryID.Name)
                nudDataEntryHex.Value = nudDataEntryID.Value;
            else if (ctrl.Name == nudDataEntryHex.Name)
                nudDataEntryID.Value = nudDataEntryHex.Value;
        }

        /// <summary>
        /// Use hex check changed
        /// </summary>
        private void chkDataEntryUseHex_CheckedChanged(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            List<byte> data = new List<byte>();
            string[] bytes = txtDataEntry.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string b in bytes)
            {
                try
                {
                    data.Add(chkDataEntryUseHex.Checked ? Convert.ToByte(b) : Convert.ToByte(b, 16));
                }
                catch
                {
                    continue;
                }
            }

            StringBuilder text = new StringBuilder();
            foreach (byte b in data)
                text.Append((chkDataEntryUseHex.Checked ? b.ToString("X2") : b.ToString()) + " ");

            txtDataEntry.Text = text.ToString().TrimEnd();
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        public void LoadData(Project project)
        {
            _project = project;
            if (!HasData)
                return;

            if (_project.DataEntries == null)
                _project.DataEntries = new List<DataEntry>();

            foreach (DataEntry entry in _project.DataEntries)
                entry.SetStatus(null);

            lstDataEntries.Items.AddRange(_project.DataEntries.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
            foreach (ListBox ctrl in new List<ListBox>() { lstDataEntries })
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
        }

        /// <summary>
        /// Saves a new data entry, or updates an existing one
        /// </summary>
        private void SaveDataEntry()
        {
            if (!HasData)
                return;

            DataEntry dataEntry = GetDataEntryData();
            if (dataEntry.Name.Trim() == "")
            {
                MessageBox.Show("Please enter a name for the data entry.");
                return;
            }

            if (_project.DataEntries.Find(x => x.ID == dataEntry.ID) != null)
            {
                _project.DataEntries[_project.DataEntries.FindIndex(x => x.ID == dataEntry.ID)] = dataEntry.DeepClone();
                lstDataEntries.Items[lstDataEntries.SelectedIndex] = dataEntry.DeepClone();
            }
            else
            {
                _project.DataEntries.Add(dataEntry);
                lstDataEntries.Items.Clear();
                LoadData(_project);
                lstDataEntries.SelectedItem = dataEntry;
            }
        }

        /// <summary>
        /// Removes a selected data entry
        /// </summary>
        private void RemoveDataEntry()
        {
            if (!HasData)
                return;

            if (MessageBox.Show("Are you sure you want to remove data entry: " + txtDataEntryName.Text + "?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _project.DataEntries.Remove(_project.DataEntries.Find(x => x.ID == (int)nudDataEntryID.Value));
            lstDataEntries.Items.Clear();
            LoadData(_project);
        }

        /// <summary>
        /// Loads selected data entry data to UI
        /// </summary>
        private DataEntry GetDataEntryData()
        {
            try
            {
                if (!HasData)
                    return null;

                DataEntry dataEntry = new DataEntry();
                dataEntry.ID = (int)nudDataEntryID.Value;
                dataEntry.Name = txtDataEntryName.Text;
                dataEntry.Disable = chkDataEntryDisable.Checked;
                dataEntry.Overwrite = radDataEntryOverwrite.Checked;
                dataEntry.Comments = txtDataEntryComments.Text;
                dataEntry.Data = DataFromText();
                dataEntry.SetStatus(null);
                return dataEntry;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Loads selected data entry data to UI
        /// </summary>
        private void SetDataEntryData(DataEntry dataEntry)
        {
            try
            {
                if (!HasData)
                    return;

                nudDataEntryID.Value = dataEntry.ID;
                txtDataEntryName.Text = dataEntry.Name;
                chkDataEntryDisable.Checked = dataEntry.Disable;
                radDataEntryOverwrite.Checked = dataEntry.Overwrite;
                radDataEntryInsert.Checked = !dataEntry.Overwrite;
                txtDataEntryComments.Text = dataEntry.Comments;
                DataToText(dataEntry.Data);
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Converts data entry text into data
        /// </summary>
        private List<byte> DataFromText()
        {
            List<byte> data = new List<byte>();
            try
            {
                string[] text = txtDataEntry.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string b in text)
                    data.Add(chkDataEntryUseHex.Checked ? Convert.ToByte(b, 16) : Convert.ToByte(b));

                return data;
            }
            catch
            {
                MessageBox.Show("The data may be incorrectly formatted. Please make sure byte entries are separated by a space, and each byte does not exceed the maximum value of 255.");
                return data;
            }
        }

        /// <summary>
        /// Converts data entry data into text
        /// </summary>
        private void DataToText(List<byte> data)
        {
            if (data == null)
                return;

            StringBuilder text = new StringBuilder();
            foreach (byte b in data)
                text.Append((chkDataEntryUseHex.Checked ? b.ToString("X2") : b.ToString()) + " ");

            txtDataEntry.Text = text.ToString().TrimEnd();
        }

        /// <summary>
        /// Imports binary data from an external source
        /// </summary>
        private void ImportData()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Import Data";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                List<byte> data = new List<byte>();
                data.AddRange(File.ReadAllBytes(ofd.FileName));
                DataToText(data);
            }
        }

        // Formats text with spaces
        private void FormatText()
        {
            txtDataEntry.Text = Regex.Replace(txtDataEntry.Text, ".{2}", "$0 ");
        }

        /// <summary>
        /// Trigger info changed event handler
        /// </summary>
        public void OnInfoChanged()
        {
            OnInfoChanged(lstDataEntries.SelectedItem == null ? null : GetDataEntryData());
        }
    }
}
