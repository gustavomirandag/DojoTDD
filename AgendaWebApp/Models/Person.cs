using AgendaWebApp.Exceptions;
using AgendaWebApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaWebApp.Models
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
            if (String.IsValid(Birthday))
                throw new BirthdayStringException();

            return true;                                  
        }
    }
}
