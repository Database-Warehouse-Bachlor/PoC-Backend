

using System.Collections.Generic;
using PoC_backend.Models;

namespace PoC_Backend.Data {
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Tennant> GetAppCommands()
        {
            var tennants = new List<Tennant> {
                new Tennant{businessId = 123456789, tennantName = "ElProffen", address = "Juraveien 4", city = "Hamresanden", zipcode = 4656, errorLog = "Failed when trying to add invoice", missingData = true},
                new Tennant{businessId = 987654321, tennantName = "Kamo Ent. AS", address = "Håsteins gate 10", city = "Hamresanden", zipcode = 5160, errorLog = "Failed when trying to add invoice", missingData = true},
                new Tennant{businessId = 182746351, tennantName = "Kuldepartner AS", address = "Smårisevadet 19", city = "Hamresanden", zipcode = 6065, errorLog = "", missingData = false},
                new Tennant{businessId = 948327456, tennantName = "NTNU Rørlegger AS", address = "Larsgårdsvegen 2", city = "Hamresanden", zipcode = 6009, errorLog = "", missingData = false}
            };
            return tennants;
        }

        public User getLoginInfo(string username, string password)
        {
           return new User {username = "admin", password = "admin"};
        }

        public Tennant getTennantById(int id)
        {
             return new Tennant{businessId = 123456789, tennantName = "ElProffen", address = "Juraveien 4", city = "Hamresanden", zipcode = 4656, errorLog = "Failed when trying to add invoice", missingData = true};
        }
    }
}