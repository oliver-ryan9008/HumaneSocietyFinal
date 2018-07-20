using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        public static HumaneSocietyDataContext context = new HumaneSocietyDataContext();


        public static Client GetClient(string userName, string password)
        {
            var client = (from c in context.Clients where c.UserName.Equals(userName) && c.Password.Equals(password) select c).First();
            return client;
        }
        public static void Adopt(Animal animal, Client client)
        {

        }

        public static Animal GetAnimalByID(int iD)
        {
            Animal animal = (from a in context.Animals where a.AnimalId.Equals(iD) select a).First();
            return animal;

        }

        public static List<Client> RetrieveClients()
        {
            var clients = context.Clients.ToList();
            return clients;
        }

        public static List<USState> GetStates()
        {
            var states = context.USStates.ToList();
            return states;
        }

        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            Client client = new Client();

        }

        public static void UpdateClient(Client client)
        {


        }

        public static void UpdateUsername(Client client)
        {
            try
            {
                Client person = (from p in context.Clients where p.ClientId.Equals(client.ClientId) select p).First();
                person.UserName = client.UserName;
                context.SubmitChanges();
            }
            catch
            {


            }
        }

        public static void UpdateEmail(Client client)
        {
            try
            {
                Client person = (from p in context.Clients where p.ClientId.Equals(client.ClientId) select p).First();
                person.Email = client.Email;
                context.SubmitChanges();
            }
            catch
            {


            }
        }

        public static void UpdateAddress(Client client)
        {
            try
            {
                Client person = (from p in context.Clients where p.ClientId.Equals(client.ClientId) select p).First();
                person.Address = client.Address;
                context.SubmitChanges();
            }
            catch
            {


            }
        }
        public static void UpdateFirstName(Client client)
        {
            try
            {
                Client person = (from p in context.Clients where p.ClientId.Equals(client.ClientId) select p).First();
                person.FirstName = client.FirstName;
                context.SubmitChanges();
            }
            catch
            {


            }
        }

        public static void UpdateLastName(Client client)
        {

            try
            {
                Client person = (from p in context.Clients where p.ClientId.Equals(client.ClientId) select p).First();
                person.LastName = client.LastName;
                context.SubmitChanges();
            }
            catch
            {


            }
        }

        public static void GetUserAdoptionStatus(Client client)
        {

        }

        public static void RunEmployeeQueries(Employee employee, string update)
        {

        }

        public static bool UpdateAdoption(bool a, Adoption adoption)
        {
            return true;
        }

        public static Adoption GetPendingAdoptions()
        {


            return adoptions;
        }

        public static void GetShots(Animal animal)
        {

        }

        public static void UpdateShot(string an, Animal animal)
        {

        }

        public static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
        {

        }

        public static void RemoveAnimal(Animal animal)
        {
<<<<<<< HEAD

=======
            var animals = context.Animals.ToList();
            context.GetTable<Animal>().DeleteOnSubmit(animal);
            context.SubmitChanges();
>>>>>>> 836364b9e99be25abc92aa8cf28952a593404580
        }

        public static Species GetSpecies(string species)
        {
            return GetSpecies(species);// need to fix this. just fixing errors
        }
        public static DietPlan GetDietPlan(string species)
        {
            DietPlan dietPlan = new DietPlan();
            return dietPlan;
        }


        public static void AddUsernameAndPassword(Employee employee)
        {

        }

        public static bool CheckEmployeeUserNameExist(string userName)
        {
            Employee foundUserName = (from u in context.Employees where u.UserName.Equals(userName) select u).First();
            return true;
        }
        public static Employee EmployeeLogin(string userName, string password)
        {
            var employee = context.Employees.Where(e => e.UserName == userName && e.Password == password).Single();
            return employee;
        }

        public static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            var employee = context.Employees.Where(e => e.Email == email && e.EmployeeNumber == employeeNumber).Single();
            return employee;

        }


        //public static void METHOD NAME(Client client)
        //{

        //} 








    }
}
