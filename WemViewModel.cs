using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ArgosyPack
{
    public class WemViewModel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public uint Id { get; set; }
        public uint Length { get; set; }



        public WemViewModel(string aName, uint aId, uint aLength)
        {
            Name = aName;
            Id = aId;
            Length = aLength;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
