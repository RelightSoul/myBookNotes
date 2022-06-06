using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.ProcessMultipleExceptions
{
    public class CarIsDeadException : Exception
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause, DateTime time):base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

    }
}
