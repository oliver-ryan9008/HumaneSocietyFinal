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
        private static Adoption adoptions;


        public static void GetClient(string userName, string password)
        {



        }
        public static void Adopt(Animal animal, Client client)
        {

        }

        public static void GetAnimalByID(int iD)
        {


        }

        public static void RetrieveClients()
        {

        }

        public static void GetStates()
        {


        }

        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {

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

        }

        public static Species GetSpecies()
        {
            return GetSpecies();// need to fix this. just fixing errors
        }
        public static DietPlan GetDietPlan()
        {
            return GetDietPlan();// need to fix this. just fixing errors
        }

        public static void AddAnimal(Animal animal)
        {

        }

        public static void AddUsernameAndPassword(Employee employee)
        {

        }

        public static bool CheckEmployeeUserNameExist(string userName)
        {
            Employee foundUserName = (from u in context.Employees where u.UserName.Equals(userName) select u).First();

            return true;
        }
        //public static void EmployeeLogin(UserEmployee userName, UserEmployee password)
        //{

        //}

        //public static void RetrieveEmployeeUser(UserEmployee email, UserEmployee employeeNumber)
        //{

        //}
        //public static void UpdateFirstName(Client client)
        //{

        //} 


        //NULL OPERATORS
        //
        //
        //
        //
        //
        //
        //
        //
        //





    }
}
