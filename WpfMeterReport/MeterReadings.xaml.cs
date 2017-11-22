using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace WpfMeterReport
{
    public class Meter
    {
        public string SerialNumber { get; set; }
        public DateTime LatestReadingDate { get; set; }
        public string City { get; set; }
        public string MeterType { get; set; }
    }

    public class MeterCollection : CollectionBase
    {
        /// <summary>  
        /// List of Authors  
        /// </summary>  
        /// <returns></returns>  
        public List<Meter> LoadMeters()
        {
            List<Meter> meters = new List<Meter>();
            meters.Add(new Meter()
            {
                SerialNumber = "0524187456",
                LatestReadingDate = DateTime.Now,
                City = "Al Riyadh",
                MeterType = "Sensus"
            });
            meters.Add(new Meter()
            {
                SerialNumber = "0524184168",
                LatestReadingDate = DateTime.Now,
                City = "Al Dammam",
                MeterType = "Elster"
            });
            meters.Add(new Meter()
            {
                SerialNumber = "0524189872",
                LatestReadingDate = DateTime.Now,
                City = "Al Jeddah",
                MeterType = "Sensus"
            });
            return meters;
        }
    }
    /// <summary>
    /// Interaction logic for MeterReadings.xaml
    /// </summary>
    public partial class MeterReadings 
    {
        public MeterReadings()
        {
            InitializeComponent();
        }

        private void MeterReading_Loaded(object sender, RoutedEventArgs e)
        {
            MeterCollection meters = new MeterCollection();
            DataGridMeter.ItemsSource = meters.LoadMeters();
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new MainWindow();
            f.Show();
            this.Close();
        }

        private void ButtonNew_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new Meters(true);
            f.Show();
            this.Close();
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            var f = new Meters(false);
            f.Show();
            this.Close();
        }
    }
}
