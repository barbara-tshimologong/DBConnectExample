using System;

namespace DBConnectExample
{
    public class Cohort
    {

        public Cohort()
        { }
        public int Id { get; }

        public string Year { get; set; }

        public DateTime StartDate
        {

            get
            {
                return startDate;
            }
            set
            {
                if (value <= DateTime.Now)
                {
                    startDate = DateTime.Now;
                }
                startDate = value;
            }
        }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        private DateTime startDate;

    }
    }
