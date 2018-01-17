using System;

namespace TMF.Maps
{
    public class GPSPacket
    {
        static char[] _delimiterChars = { ',' };
        private bool _valid;
        private DateTime _time;
        private bool _fix;
        private double _lat, _lon;
        public string _gpsData;

        public double Latitude
        {
            get { return _lat; }
            set { _lat = value; }
        }

        public double Longitude
        {
            get { return _lon; }
            set { _lon = value; }
        }

        public DateTime PacketTime
        {
            get { return _time; }
            set { _time = value; }
        }

        public bool Fix
        {
            get { return _fix; }
            set { _fix = value; }
        }

        public bool IsValid
        {
            get { return _valid; }
            set { _valid = value; }
        }

        public GPSPacket()
        {
            _time = DateTime.Now;
            _valid = false;
            _lat = _lon = 0;
        }
        public GPSPacket(string packet)
        {
            _time = DateTime.Now;
            _gpsData = packet;

            string[] PacketTokens = packet.Split(new char[] { ',' });
            try
            {
                _lat = GetLatitude(PacketTokens[2], PacketTokens[3]);
                _lon = GetLongitude(PacketTokens[4], PacketTokens[5]);

                //Check the fix - if fix is greater than zero then the fix quality is good, else there is no fix
                _fix = (int.Parse(PacketTokens[6]) > 0);
            }
            catch
            {
                _valid = false;
            }
        }
        public bool UpdateGPS(string packet)
        {
            //Example packet: $GPGGA,012711,3749.2776,S,14502.4100,E,1,07,02.04,000039.3,M,-001.8,M,,*7D
            _time = DateTime.Now;
            _gpsData = packet;

            string[] PacketTokens = packet.Split(_delimiterChars);
            try
            {
                _lat = GetLatitude(PacketTokens[2], PacketTokens[3]);
                _lon = GetLongitude(PacketTokens[4], PacketTokens[5]);

                //Check the fix - if fix is greater than zero then the fix quality is good, else there is no fix
                _fix = ((PacketTokens[6]) == "A");
                _valid = _fix;
                return _valid;
            }
            catch
            {
                //MessageBox.Show("Chill");
                _valid = false;
                return _valid;
            }
        }
        private double GetLongitude(string longitudeToken, string direction)
        {
            //Longtitude token: DDDMM.mmm,E
            //Decimal Degrees = DDD + (MM.mmm / 60)
            string Degrees = longitudeToken.Substring(0, 3);
            string Minutes = longitudeToken.Substring(3);
            double Longtitude = double.Parse(Degrees) + (double.Parse(Minutes) / 60.0);
            //direction: E or W
            //If direction is West: * -1
            if (!direction.Equals("E", StringComparison.OrdinalIgnoreCase)) Longtitude = -Longtitude;
            return Longtitude;
        }
        private double GetLatitude(string latitudeToken, string direction)
        {
            //Latitude token: DDMM.mmm,N
            //Decimal Degrees = DD + (MM.mmm / 60)
            string Degrees = latitudeToken.Substring(0, 2);
            string Minutes = latitudeToken.Substring(2);
            double Latitude = double.Parse(Degrees) + (double.Parse(Minutes) / 60.0);
            //direction: N or S
            //If direction is South: * -1
            if (!direction.Equals("N", StringComparison.OrdinalIgnoreCase)) Latitude = -Latitude;
            return Latitude;
        }
    }
}
