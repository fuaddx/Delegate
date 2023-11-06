using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{
    internal class Exam
    {
        public Student Student { get; set; }
        public byte Point { get; set; }
        public string Subject { get; set; }

        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }

        public double Duration
        {
            get
            {
                TimeSpan duration = EndTime - StartTime;
                return duration.TotalHours;
            }
        }
        public override string ToString()
        {
            return $"Student: {Student.Name}\nSubject: {Subject}\nPoint: {Point} Score\nDuration: {Duration} Hours";
        }
    }
}
