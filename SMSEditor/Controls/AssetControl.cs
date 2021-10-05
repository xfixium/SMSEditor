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

using System.Windows.Forms;
using SMSEditor.Data;

namespace SMSEditor.Controls
{
    public class AssetControl : UserControl
    {
        /// <summary>
        /// Events
        /// </summary>
        public event AssetsChangedHandler AssetsChanged;
        public delegate void AssetsChangedHandler();
        public event InfoChangedHandler InfoChanged;
        public delegate void InfoChangedHandler(GameAsset asset);

        /// <summary>
        /// Asset data changed
        /// </summary>
        protected virtual void OnAssetsChanged()
        {
            AssetsChanged?.Invoke();
        }

        /// <summary>
        /// Asset information changed
        /// </summary>
        protected virtual void OnInfoChanged(GameAsset asset)
        {
            InfoChanged?.Invoke(asset);
        }

        /// <summary>
        /// Get game asset item based on given id, for the given combobox
        /// </summary>
        /// <param name="id">The id to search for</param>
        /// <param name="ctrl">The combobox to search</param>
        /// <returns>A game asset, if found, null if not</returns>
        public object ItemByID(int id, ComboBox ctrl)
        {
            foreach (object item in ctrl.Items)
                if ((item as GameAsset).ID == id)
                    return item as GameAsset;

            return null;
        }

        /// <summary>
        /// Get game asset item based on given id, for the given combobox
        /// </summary>
        /// <param name="id">The id to search for</param>
        /// <param name="ctrl">The listbox to search</param>
        /// <returns>A game asset, if found, null if not</returns>
        public GameAsset ItemByID(int id, ListBox ctrl)
        {
            foreach (object item in ctrl.Items)
                if ((item as GameAsset).ID == id)
                    return item as GameAsset;

            return null;
        }

        /// <summary>
        /// Gets the selected compression type from a CompressionType combobox
        /// </summary>
        /// <param name="ctrl">Combobox to get the selected CompressionType from</param>
        /// <returns>The selected CompressionType</returns>
        public CompressionType GetCompressionType (ComboBox ctrl)
        {
            return (CompressionType)ctrl.SelectedItem.GetType().GetProperty("value").GetValue(ctrl.SelectedItem, null);
        }

        /// <summary>
        /// Sets the selected compression type from the given CompressionType
        /// </summary>
        /// <param name="ctrl">Combobox to set the selected CompressionType to</param>
        /// <param name="type">The CompressionType to set</param>
        public void SetCompressionType(ComboBox ctrl, CompressionType type)
        {
            foreach (var item in ctrl.Items)
            {
                var t = item.GetType().GetProperty("value").GetValue(item, null);
                if (t.ToString() == type.ToString())
                    ctrl.SelectedItem = item;
            }
        }
    }
}
