using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ArgosyPack
{
    public class Wem
    {
        public int loadedId;
        public string name { get; set; }
        public uint id { get; set; }
        public uint length { get; set; }
        public byte[] file;

        public Wem(string aName, string aId, BinaryReader aFile, int loadId)
        {
            loadedId = loadId;
            name = Path.GetFileName(aName);
            id = Convert.ToUInt32(aId);
            length = (uint)aFile.BaseStream.Length;
            file = aFile.ReadBytes((int)length);
        }
    }
}
