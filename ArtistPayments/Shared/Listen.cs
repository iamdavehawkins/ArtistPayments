using System;
namespace ArtistPayments.Shared
{
    public class Listen
    {
        public string EndTime { get; set; }
        public string ArtistName { get; set; }
        public string TrackName { get; set; }
        public int MsPlayed { get; set; }
        public DateTime EndDateTimeUTC
        {
            get
            {
                return DateTime.Parse(EndTime);
            }
        }
        public int Month
        {
            get
            {
                return DateTime.Parse(EndTime).Month;
            }
        }
    }
}
