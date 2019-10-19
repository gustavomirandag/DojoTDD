using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp.Exceptions
{
    public class BirthdayStringException : Exception
    {
        public BirthdayStringException() : base("Birthday should be defined as a DateTime") { }
    }
}
