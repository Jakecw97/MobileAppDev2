using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LP.Models
{
    public class Workout
    {
        [PrimaryKey]
        public int day { get; set; }
        public String   squat { get; set; }
        public String bench { get; set; }
        public String deadlift { get; set; }
        public String overHead { get; set; }
        public String bicep { get; set; }
        public String tricep { get; set; }
      

    }
}
