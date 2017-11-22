using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace WpfMeterReport
{
    public class GatewayList
    {
        public string MACAddress { get; set; }
        public DateTime LatestDate { get; set; }
        public int MeterCount { get; set; }
        public string City { get; set; }
    }

    public class GatewayCollection : CollectionBase
    {
        /// <summary>  
        /// List of Authors  
        /// </summary>  
        /// <returns></returns>  
        public List<GatewayList> LoadGateways()
        {
            List<GatewayList> gateways = new List<GatewayList>();
            gateways.Add(new GatewayList()
            {
                MACAddress = "2B:EE:A2:B3:C2:88:B3:C2",
                LatestDate = DateTime.Now,
                MeterCount = 5,
                City = "Al Riyadh"
            });
            gateways.Add(new GatewayList()
            {
                MACAddress = "2B:EE:A2:B3:C2:88:B3:C4",
                LatestDate = DateTime.Now,
                MeterCount = 5,
                City = "Al Jeddah"
            });
            gateways.Add(new GatewayList()
            {
                MACAddress = "2C:EE:A2:B3:C2:88:B3:C2",
                LatestDate = DateTime.Now,
                MeterCount = 5,
                City = "Al Dammam"
            });
            return gateways;
        }
    }

    /// <summary>
    /// Interaction logic for GatewayLogs.xaml
    /// </summary>
    public partial class GatewayLogs 
    {
        public GatewayLogs()
        {
            InitializeComponent();
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
            GatewayCollection authors = new GatewayCollection();
            DataGridGatewayLogs.ItemsSource = authors.LoadGateways();
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new MainWindow();
            f.Show();
            this.Close();
        }

        private void ButtonNew_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new Gateway(true);
            f.Show();
            this.Close();
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new Gateway(false);
            f.Show();
            this.Close();
        }
    }
}
