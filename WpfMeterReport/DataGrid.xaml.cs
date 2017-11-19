using System;
using System.Windows;

namespace WpfMeterReport
{
    public class Record
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri Website { get; set; }
        public bool IsBillionaire { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
    /// <summary>
    /// Interaction logic for DataGrid.xaml
    /// </summary>
    public partial class DataGrid : Window
    {
        public DataGrid()
        {
            InitializeComponent();
            //DataGridXaml.CurrentItem["FirstName"]
        }
    }
}
