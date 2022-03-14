
using System;

namespace CodeRefactoring.DuplicatedCode.Refactoring
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public static Time Parse(string admissionDateTime)
        {
            int time;
            int hours;
            int minutes;
            if (!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if (int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
                else
                {
                    throw new ArgumentException("admissionDateTime");
                }

            }
            else
                throw new ArgumentNullException("admissionDateTime");

            return new Time(hours, minutes);
        }
    }

    class DuplicatedCode
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            // Some logic 
            // ...

            Time time = Time.Parse(admissionDateTime);

            // Some more logic 
            // ...
            if (time.Hours < 10)
            {

            }
        }
        public void UpdateAdmission(int admissionId, string name, string admissionDateTime)
        {
            // Some logic 
            // ...

            Time time = Time.Parse(admissionDateTime);

            // Some more logic 
            // ...
            if (time.Hours < 10)
            {

            }
        }


    }
}
