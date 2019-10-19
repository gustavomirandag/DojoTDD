using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.Concurrent;
using AgendaWebApp.Models;

namespace AgendaWebApp.Service
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
