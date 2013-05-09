using System;
using System.Collections.Generic;
using System.Text;

namespace CardReader
{
    public class TimeInOutEntity
    {
        private DateTime workingDay;
        private int employeeID;
        private string timeOut;
        private string timeIn;

        public TimeInOutEntity()
        {
            
        }

        public DateTime WorkingDay
		{
			get 
			{
                return workingDay;
			}
			set 
			{
                workingDay = value;
			}
		}
        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public string TimeOut
        {
            get
            {
                return timeOut;
            }
            set
            {
                timeOut = value;
            }
        }
        public string TimeIn
        {
            get
            {
                return timeIn;
            }
            set
            {
                timeIn = value;
            }
        }
    }
}
