using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ArgosyPack
{
    public class Wem
    {
        public string name;
        public uint id;
        public uint length;
        public byte[] file;

        public Wem(string aName, string aId, BinaryReader aFile)
        {
            name = aName;
            id = Convert.ToUInt32(aId);
            length = (uint)aFile.BaseStream.Length;
            file = aFile.ReadBytes((int)length);
        }
    }
}
