using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp.Model
{
    public class EmptyNameException : Exception
    {
        public EmptyNameException():base("Empty name is not valid"){}
    }
}
