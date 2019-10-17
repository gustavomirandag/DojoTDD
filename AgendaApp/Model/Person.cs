using AgendaApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp.Model
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public bool IsValid()
        {
            if (String.IsNullOrWhiteSpace(Name))
                throw new EmptyNameException();
            if (Birthday <= DateTime.Now.AddYears(-150))
                throw new BirthdayTooOldException();

            return true;                                  
        }
    }
}
