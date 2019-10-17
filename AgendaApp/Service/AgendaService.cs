using AgendaApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.Concurrent;

namespace AgendaApp.Service
{
    public class AgendaService
    {
        public bool AddPerson(Person person)
        {
            if(!person.IsValid())
                throw new ArgumentException("Invalid parameters.");
            return true;
        }

    }
}
