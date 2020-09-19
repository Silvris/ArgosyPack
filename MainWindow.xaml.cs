using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArgosyPack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public NPCKHeader npck = new NPCKHeader();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void On_Loaded()
        {

        }

        private void Import_Wems(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            openFile.Filter = "WWise Wem files (*.wem)|*.wem";
            if (openFile.ShowDialog() == true)
            {
                foreach(string fileName in openFile.FileNames)
                {
                    Wem newWem = MakeWem.MakeWems(fileName, new BinaryReader(File.Open(openFile.FileName,FileMode.Open)));
                    npck.WemList.Add(newWem);
                    npck.wemCount++;
                }
                
            }
        }

        private void Export_File(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "WWise Package file (*.npck, *.pck)|*.npck, *.pck";
            if (saveFile.ShowDialog() == true)
            {
                npck.ExportFile(saveFile.FileName);
            }
            
        }
    }
}
