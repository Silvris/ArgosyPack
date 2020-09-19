using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArgosyPack
{
    class MakeWem
    {
        public static Wem MakeWems(string name, BinaryReader fs)
        {
            Wem newWem = new Wem(name, "0", fs);
            return newWem;
        }
    }
}
