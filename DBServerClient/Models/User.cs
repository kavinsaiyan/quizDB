using System;

namespace DBServerClient.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
