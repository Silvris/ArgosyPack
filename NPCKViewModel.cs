using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ArgosyPack
{
    public class NPCKViewModel
    {
        public ObservableCollection<Wem> wems;

        public NPCKViewModel(List<Wem> npck)
        {
            int i = 0;
            wems = new ObservableCollection<Wem>(npck);
        }

    }
}
