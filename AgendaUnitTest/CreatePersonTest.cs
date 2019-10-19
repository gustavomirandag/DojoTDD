using AgendaWebApp.Exceptions;
using AgendaWebApp.Model;
using AgendaWebApp.Models;
using AgendaWebApp.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AgendaUnitTest
{
    [TestClass]
    public class CreatePersonTest
    {
        [TestMethod]
        public void CreateAcceptablePersonTest()
        {
            //Prepare
            var agendaService = new AgendaService();
            var person = new Person
            {
                Id = Guid.NewGuid(),
                Name = "João da Silva",
                Birthday = new DateTime(2010, 02, 5, 10, 20, 00)
            };

            //Action/Call Test Function
            bool result = agendaService.AddPerson(person);

            //Assert
            Assert.IsTrue(result); //Se result for verdadeiro => passa no teste
        }

        [TestMethod]
        public void CreatePersonWithEmptyNameTest()
        {
            //Prepare
            var agendaService = new AgendaService();
            var person = new Person
            {
                Id = Guid.NewGuid(),
                Name = "",
                Birthday = new DateTime(2010, 02, 5, 10, 20, 00)
            };

            //Assert Action
            Assert.ThrowsException<EmptyNameException>(() => agendaService.AddPerson(person));
        }

        [TestMethod]
        public void CreatePersonWithInvalidBirthdayTest()
        {
            //Prepare
            var agendaService = new AgendaService();
            var person = new Person
            {
                Id = Guid.NewGuid(),
                Name = "João",
                Birthday = new DateTime(1700, 02, 15, 10, 20, 00)
            };

            //Assert Action
            Assert.ThrowsException<BirthdayTooOldException>(() => agendaService.AddPerson(person));
        }
    }
}
