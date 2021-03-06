﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class User
    {
        protected string name;
        protected string userName;

        public virtual void LogIn()
        {

        }
        protected bool CheckIfNewUser()
        {
            List<string> options = new List<string>() { "Are you a new User?", "yes", "no" };
            UserInterface.DisplayUserOptions(options);
            string input = UserInterface.GetUserInput();
            if(input.ToLower() == "yes" || input.ToLower() == "y")
            {
                return true;
            }
            else if(input.ToLower() == "no" || input.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.Clear();
                UserInterface.DisplayUserOptions("Input not recognized please try again");
                return CheckIfNewUser();
            }
        }
        protected virtual void LogInPreExistingUser()
        {

        }
        protected virtual void RunUserMenus()
        {

        }
        protected IQueryable<Animal> SearchForAnimal()
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var animals = from data in context.Animals select data;

            var searchParameters = GetAnimalCriteria();
            if (searchParameters.ContainsKey(1))
            {
                animals = (from animal in animals where animal.Species.Name == searchParameters[1] select animal);
            }            
            if (searchParameters.ContainsKey(2))
            {
                animals = (from animal in animals where animal.Name == searchParameters[2] select animal);
            }
            if (searchParameters.ContainsKey(3))
            {
                animals = (from animal in animals where animal.Age == int.Parse(searchParameters[3]) select animal);
            }
            if (searchParameters.ContainsKey(4))
            {
                animals = (from animal in animals where animal.Demeanor == searchParameters[4] select animal);
            }
            if (searchParameters.ContainsKey(5))
            {
                bool parameter = GetBoolParamater(searchParameters[5]);
                animals = (from animal in animals where animal.KidFriendly == parameter select animal);
            }
            if (searchParameters.ContainsKey(6))
            {
                bool parameter = GetBoolParamater(searchParameters[6]);
                animals = (from animal in animals where animal.PetFriendly == parameter select animal);
            }
            if (searchParameters.ContainsKey(7))
            {
                animals = (from animal in animals where animal.Weight == int.Parse(searchParameters[7]) select animal);
            }
            if (searchParameters.ContainsKey(8))
            {
                animals = (from animal in animals where animal.AnimalId == int.Parse(searchParameters[8]) select animal);
            }
            return animals;
        }
        protected bool GetBoolParamater(string input)
        {
            if (input.ToLower() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected Dictionary<int, string> GetAnimalCriteria()
        {
            Dictionary<int, string> searchParameters = new Dictionary<int, string>();
            bool isSearching = true;
            while (isSearching)
            {
                Console.Clear();
                List<string> options = new List<string>() { "Select Search Criteia: (Enter number and choose finished when finished)", "1. Species", "2. Name", "3. Age", "4. Demeanor", "5. Kid friendly", "6. Pet friendly", "7. Weight", "8. ID", "9. Finished" };
                UserInterface.DisplayUserOptions(options);
                string input = UserInterface.GetUserInput();
                if (input.ToLower() == "10" || input.ToLower() == "finished")
                {
                    isSearching = false;
                    continue;
                }
                else
                {
                    searchParameters = UserInterface.EnterSearchCriteria(searchParameters, input);
                }
            }
            return searchParameters;
        }
    }
}
