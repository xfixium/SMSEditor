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
using System.Drawing;
using System.Collections.Generic;

namespace SMSEditor.Data
{
    [Serializable]
    public class Project
    {
        /// <summary>
        /// Properties
        /// </summary>
        public Version Version = null;
        public List<byte> ROM = new List<byte>();
        public List<Sprite> Sprites = new List<Sprite>();
        public List<Palette> Palettes = new List<Palette>();
        public List<Tileset> Tilesets = new List<Tileset>();
        public List<Tilemap> Tilemaps = new List<Tilemap>();
        public List<Palette> PaletteEdits = new List<Palette>();
        public List<Tileset> TilesetEdits = new List<Tileset>();
        public List<Tilemap> TilemapEdits = new List<Tilemap>();
        public List<DataEntry> DataEntries = new List<DataEntry>();

        /// <summary>
        /// Constructors
        /// </summary>
        public Project() { }
        public Project(string path)
        {
            ROM.AddRange(File.ReadAllBytes(path));
            Palettes.AddRange(Palette.GetDefaultPalettes());
        }

        /// <summary>
        /// Loads ROM data
        /// </summary>
        /// <param name="path"></param>
        public void LoadRomData(string path)
        {
            ROM.Clear();
            ROM.AddRange(File.ReadAllBytes(path));
        }

        /// <summary>
        /// Loads palette data
        /// </summary>
        public void LoadPaletteData(Palette palette)
        {
            try
            {
                palette.Colors.Clear();
                byte[] data = ROM.GetRange(palette.ID < 0 ? 0 : palette.ID, palette.Length).ToArray();
                palette.Colors.AddRange(Palette.GetColors(data));
                palette.ActualLength = data.Length;
                if (palette.Colors.Count < 16)
                {
                    for (int i = 0; i < palette.Offset; i++)
                        palette.Colors.Insert(0, Color.Black);

                    Palette partial = Palettes.Find(x => x.ID == palette.PartialPaletteID);
                    if (partial != null)
                    {
                        palette.Colors.RemoveRange(0, palette.Offset);
                        palette.Colors.InsertRange(0, partial.Colors.GetRange(0, palette.Offset));
                    }

                    for (int j = palette.Colors.Count; j < 16; j++)
                        palette.Colors.Add(Color.Black);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Loads tileset data
        /// </summary>
        public void LoadTilesetData(Tileset tileset)
        {
            try
            {
                byte[] data = ROM.GetRange(tileset.ID, tileset.Length).ToArray();
                data = Compression.Decompress(tileset.CompressionType, data);
                tileset.ActualLength = data.Length;
                byte[] row = new byte[4];
                for (int i = 0; i < data.Length; i += 4)
                {
                    for (int j = 0; j < 4; j++)
                        if (i + j < data.Length)
                            row[j] = data[i + j];
                        else
                            break;

                    for (int k = 7; k > -1; k--)
                    {
                        byte pixel = Tileset.GetPixel(row, k);
                        if (tileset.Masked)
                            pixel = pixel == 1 ? (byte)0 : (byte)(pixel / 2);
                        tileset.Pixels.Add(pixel);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Loads tilemap data
        /// </summary>
        public void LoadTilemapData(Tilemap tilemap)
        {
            try
            {
                if (tilemap.ID < 0)
                    return;

                byte[] data = ROM.GetRange(tilemap.ID, tilemap.Length).ToArray();
                data = Compression.Decompress(tilemap.CompressionType, data);
                tilemap.ActualLength = data.Length;
                if (tilemap.UseTileAttributes)
                {
                    for (int i = 0; i < data.Length; i += 2)
                    {
                        byte b1 = data[i];
                        byte b2 = data[i + 1];
                        var id = Tilemap.GetTileID(b1, b2);
                        Tile tile = new Tile
                        {
                            FlipX = (b2 & (1 << 1)) != 0,
                            FlipY = (b2 & (1 << 2)) != 0,
                            UseBGPalette = (b2 & (1 << 3)) != 0 ? false : true,
                            Priority = (b2 & (1 << 4)) != 0,
                            Flags = Tilemap.GetTileFlags(b2),
                            TileID = id < 0 ? 0 : id
                        };
                        tilemap.Tiles.Add(tile);
                    }
                }
                else
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        byte b1 = data[i];
                        Tile tile = new Tile { TileID = b1 };
                        tilemap.Tiles.Add(tile);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets a sprite, by id
        /// </summary>
        /// <param name="id">The id of the sprite</param>
        /// <returns>A sprite, based on id</returns>
        public Sprite GetSprite(int id)
        {
            return Sprites.Find(x => x.ID == id);
        }

        /// <summary>
        /// Gets a data entry, by id
        /// </summary>
        /// <param name="id">The id of the data entry</param>
        /// <returns>A data entry, based on id</returns>
        public DataEntry GetDataEntry(int id)
        {
            return DataEntries.Find(x => x.ID == id);
        }

        /// <summary>
        /// Gets a palette, if an edit exists, that will be retrieved first
        /// </summary>
        /// <param name="id">The id of the palette</param>
        /// <returns>A palette, based on id</returns>
        public Palette GetPalette(int id)
        {
            return GetPalette(id, false);
        }

        /// <summary>
        /// Gets a palette, unless specifically getting the original, if an edit exists, that will be retrieved first
        /// </summary>
        /// <param name="id">The id of the palette</param>
        /// <param name="getOriginal">If only getting the original data, edit data ignored</param>
        /// <returns>A palette, based on id</returns>
        public Palette GetPalette(int id, bool getOriginal)
        {
            if (!getOriginal)
            {
                Palette edit = PaletteEdits.Find(x => x.ID == id);
                if (edit != null)
                    return edit;
            }

            var original = Palettes.Find(x => x.ID == id);
            if (original != null)
                return original.DeepClone();

            return null;
        }

        /// <summary>
        /// Sets palette edit data
        /// </summary>
        /// <param name="palette">The edited palette data</param>
        public void SetPalette(Palette palette)
        {
            Palette search = PaletteEdits.Find(x => x.ID == palette.ID);
            if (search == null)
                PaletteEdits.Add(palette.DeepClone());
            else
                PaletteEdits[PaletteEdits.IndexOf(search)] = palette.DeepClone();
        }

        /// <summary>
        /// Removes a palette, and any palette edits
        /// </summary>
        /// <param name="id">The id of the palette</param>
        public void RemovePalette(int id)
        {
            Palette search = Palettes.Find(x => x.ID == id);
            if (search != null)
                Palettes.Remove(search);

            Palette editSearch = PaletteEdits.Find(x => x.ID == id);
            if (editSearch != null)
                PaletteEdits.Remove(editSearch);
        }

        /// <summary>
        /// Gets a tileset, if an edit exists, that will be retrieved first
        /// </summary>
        /// <param name="id">The id of the tileset</param>
        /// <returns>A tileset, based on id</returns>
        public Tileset GetTileset(int id)
        {
            return GetTileset(id, false);
        }

        /// <summary>
        /// Gets a tileset, unless specifically getting the original, if an edit exists, that will be retrieved first
        /// </summary>
        /// <param name="id">The id of the tileset</param>
        /// <param name="getOriginal">If only getting the original data, edit data ignored</param>
        /// <returns>A tileset, based on id</returns>
        public Tileset GetTileset(int id, bool getOriginal)
        {
            if (!getOriginal)
            {
                Tileset edit = TilesetEdits.Find(x => x.ID == id);
                if (edit != null)
                    return edit;
            }

            var original = Tilesets.Find(x => x.ID == id);
            if (original != null)
                return original.DeepClone();

            return null;
        }

        /// <summary>
        /// Sets tileset edit data
        /// </summary>
        /// <param name="tileset">The edited tileset data</param>
        public void SetTileset(Tileset tileset)
        {
            Tileset search = TilesetEdits.Find(x => x.ID == tileset.ID);
            if (search == null)
                TilesetEdits.Add(tileset.DeepClone());
            else
                TilesetEdits[TilesetEdits.IndexOf(search)] = tileset.DeepClone();
        }

        /// <summary>
        /// Removes a tileset, and any tileset edits
        /// </summary>
        /// <param name="id">The id of the palette</param>
        public void RemoveTileset(int id)
        {
            Tileset search = Tilesets.Find(x => x.ID == id);
            if (search != null)
                Tilesets.Remove(search);

            Tileset editSearch = TilesetEdits.Find(x => x.ID == id);
            if (editSearch != null)
                TilesetEdits.Remove(editSearch);
        }

        /// <summary>
        /// Gets a tilemap, if an edit exists, that will be retrieved first
        /// </summary>
        /// <param name="id">The id of the tilemap</param>
        /// <returns>A tilemap, based on id</returns>
        public Tilemap GetTilemap(int id)
        {
            return GetTilemap(id, false);
        }

        /// <summary>
        /// Gets a tilemap, unless specifically getting the original, if an edit exists, that will be retrieved first
        /// </summary>
        /// <param name="id">The id of the tilemap</param>
        /// <param name="getOriginal">If only getting the original data, edit data ignored</param>
        /// <returns>A tilemap, based on id</returns>
        public Tilemap GetTilemap(int id, bool getOriginal)
        {
            if (!getOriginal)
            {
                Tilemap edit = TilemapEdits.Find(x => x.ID == id);
                if (edit != null)
                    return edit;
            }

            var original = Tilemaps.Find(x => x.ID == id);
            if (original != null)
                return original.DeepClone();

            return null;
        }

        /// <summary>
        /// Sets tilemap edit data
        /// </summary>
        /// <param name="tilemap">The edited tilemap data</param>
        public void SetTilemap(Tilemap tilemap)
        {
            Tilemap search = TilemapEdits.Find(x => x.ID == tilemap.ID);
            if (search == null)
                TilemapEdits.Add(tilemap.DeepClone());
            else
                TilemapEdits[TilemapEdits.IndexOf(search)] = tilemap.DeepClone();
        }

        /// <summary>
        /// Removes a tilemap, and any tilemap edits
        /// </summary>
        /// <param name="id">The id of the palette</param>
        public void RemoveTilemap(int id)
        {
            Tilemap search = Tilemaps.Find(x => x.ID == id);
            if (search != null)
                Tilemaps.Remove(search);

            Tilemap editSearch = TilemapEdits.Find(x => x.ID == id);
            if (editSearch != null)
                TilemapEdits.Remove(editSearch);
        }

        /// <summary>
        /// Gets a list of unique tilesets from the give tilemaps
        /// </summary>
        /// <param name="tilemaps">List of tilemaps to get tilesets from</param>
        /// <returns>A list of unique tilesets</returns>
        public List<Tileset> GetTilesets(List<Tilemap> tilemaps, bool original)
        {
            List<Tileset> tilesets = new List<Tileset>();
            foreach (Tilemap tilemap in tilemaps)
            {
                if (tilesets.Find(x => x.ID == tilemap.TilesetID) != null)
                    continue;

                Tileset tileset = GetTileset(tilemap.TilesetID, original);
                if (tileset == null)
                    continue;

                tilesets.Add(tileset);
            }
            return tilesets;
        }

        /// <summary>
        /// Removes any edits made to the given sprite
        /// </summary>
        /// <param name="id">The sprite id</param>
        public void RevertSprite(int id)
        {
            var sprite = Sprites.Find(x => x.ID == id);
            if (sprite == null)
                return;

            List<Tilemap> tilemaps = new List<Tilemap>();
            foreach (int tilemapID in sprite.TilemapIDs)
            {
                var edit = TilemapEdits.Find(x => x.ID == tilemapID);
                if (edit != null)
                    tilemaps.Add(edit);
            }

            foreach (Tilemap tilemap in tilemaps)
            {
                TilesetEdits.RemoveAll(x => x.ID == tilemap.TilesetID);
                TilemapEdits.RemoveAll(x => x.ID == tilemap.ID);
            }
        }

        /// <summary>
        /// Removes any edits made to the given asset
        /// </summary>
        /// <param name="id">The assey id to revert</param>
        public void RevertAsset(int id)
        {
            PaletteEdits.RemoveAll(x => x.ID == id);
            TilesetEdits.RemoveAll(x => x.ID == id);
            TilemapEdits.RemoveAll(x => x.ID == id);
        }

        /// <summary>
        /// Checks to see if the given asset id already exists
        /// </summary>
        /// <param name="id">The asset id to check</param>
        /// <returns>If the asset exists</returns>
        public bool AssetExists(int id)
        {
            if (Palettes.Find(x => x.ID == id) != null)
                return true;

            if (Tilesets.Find(x => x.ID == id) != null)
                return true;

            if (Tilemaps.Find(x => x.ID == id) != null)
                return true;

            return false;
        }

        /// <summary>
        /// Exports to a .sms binary
        /// </summary>
        public void ExportToBinary(string path)
        {
            List<byte> data = new List<byte>();
            data.AddRange(ROM.ToArray());
            foreach (Palette palette in PaletteEdits.OrderBy(x => x.Location))
            {
                if (palette.Disable || palette.ID < 0)
                    continue;

                int position = palette.Location;
                byte[] bytes = palette.GetPaletteData(false, true, palette.Override);
                if (position > data.Count - 1)
                {
                    var length = (position - data.Count) + bytes.Length;
                    for (int i = 0; i < length; i++)
                        data.Add(0);
                }
                data.RemoveRange(position, bytes.Length);
                data.InsertRange(position, bytes);

                foreach (AssetProperty assetProperty in palette.AssetProperties)
                    if (assetProperty.Position > -1)
                        data[assetProperty.Position] = assetProperty.Value;
            }

            foreach (Tileset tileset in TilesetEdits.OrderBy(x => x.Location))
            {
                if (tileset.Disable || tileset.ID < 0)
                    continue;

                int position = tileset.Location;
                byte[] bytes = tileset.GetTilesetData(false, true, tileset.Override);
                if (position > data.Count - 1)
                {
                    var length = (position - data.Count) + bytes.Length;
                    for (int i = 0; i < length; i++)
                        data.Add(0);
                }
                data.RemoveRange(position, bytes.Length);
                data.InsertRange(position, bytes);

                foreach (AssetProperty assetProperty in tileset.AssetProperties)
                    if (assetProperty.Position > -1)
                        data[assetProperty.Position] = assetProperty.Value;
            }

            foreach (Tilemap tilemap in TilemapEdits.OrderBy(x => x.Location))
            {
                if (tilemap.Disable || tilemap.PlaceHolder || tilemap.ID < 0)
                    continue;

                int position = tilemap.Location;
                byte[] bytes = tilemap.GetTilemapData(false, true, tilemap.Override);
                if (position > data.Count - 1)
                {
                    var length = (position - data.Count) + bytes.Length;
                    for (int i = 0; i < length; i++)
                        data.Add(0);
                }
                data.RemoveRange(position, bytes.Length);
                data.InsertRange(position, bytes);

                foreach (AssetProperty assetProperty in tilemap.AssetProperties)
                    if (assetProperty.Position > -1)
                        data[assetProperty.Position] = assetProperty.Value;
            }

            foreach (DataEntry dataEntry in DataEntries.OrderBy(x => x.ID))
            {
                if (dataEntry.Disable)
                    continue;

                int position = dataEntry.ID;
                if (position > data.Count - 1)
                {
                    var length = (position - data.Count) + (dataEntry.Overwrite ? dataEntry.Data.Count : 0);
                    for (int i = 0; i < length; i++)
                        data.Add(0);
                }
                if (dataEntry.Overwrite)
                    data.RemoveRange(position, dataEntry.Data.Count);

                data.InsertRange(position, dataEntry.Data);
            }

            File.WriteAllBytes(path, data.ToArray());
        }

        /// <summary>
        /// Gets the rom data as an 4bpp image
        /// </summary>
        /// <returns>Rom pixel data</returns>
        public List<byte> GetRomImage()
        {
            List<byte> pixels = new List<byte>();
            for (int i = 0; i < ROM.Count; i += 4)
            {
                for (int k = 7; k > -1; k--)
                {
                    byte pixel = Tileset.GetPixel(ROM.GetRange(i, 4).ToArray(), k);
                    pixels.Add(pixel);
                }
            }

            return pixels;
        }
    }
}
