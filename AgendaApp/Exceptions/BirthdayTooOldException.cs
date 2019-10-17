using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp.Exceptions
{
    public class BirthdayTooOldException : Exception
    {
        public BirthdayTooOldException() : base("Birthday date is too old") { }
    }
}
