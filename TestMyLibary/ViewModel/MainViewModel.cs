using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestMyLibary.ViewModel.Helper;
using ProjectLib;
using System.IO;

namespace TestMyLibary.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        #region Св-ва
        public BindableCommand AddCommand { get; set; }
        public BindableCommand AddSecondComand { get; set; }
        /*string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);*/ // Если прочитаете, можете коментом сказать как дать себе доступ к созданию файла на рабочем столе?

        public MainViewModel()
        {
            AddCommand = new BindableCommand(_ => Serialze());
            AddSecondComand = new BindableCommand(_ => ReadFromFile());

        }
        string textFile = "запуск";
        public string TextInFile
        {
            get { return textFile; }
            set { textFile = value; OnPropertyChanged(); }
        }
        #endregion

        public void Serialze()
        {

            Json.MySerialize("json.json", textFile);
            MessageBox.Show("Сохранили");
        }
        private void ReadFromFile()
        {
            TextInFile = Json.ReadFromFile<string>("json.json");

        }

    }
}
