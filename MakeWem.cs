using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArgosyPack
{
    class MakeWem
    {
        public static Wem MakeWems(string name, BinaryReader fs, int loadId)
        {
            Wem newWem = new Wem(name, "0", fs, loadId);
            return newWem;
        }
    }
}
