// CSHP220 
// Assignment 2
// By: Roham Pardakhtim

using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            //1.Display to the console, all the passwords that are "hello".Hint: Where
            var pwHello = users.Where(x => x.Password.Contains("hello"));

            Console.WriteLine("Problem 1:");
            foreach (var user in pwHello)
            {
                Console.WriteLine(user.Password);
            }

            //2.Delete any passwords that are the lower-cased version of their Name. Do not just look for "steve".It has to be data - driven.Hint: Remove or RemoveAll
            users.RemoveAll(x => x.Name.ToLower() == x.Password);

            Console.WriteLine("\nProblem 2:");
            foreach (var user in users)
            {
                Console.WriteLine(user.Password);
            }

            //3. Delete the first User that has the password "hello". Hint: First or FirstOrDefault
            users.Remove(users.First(x => x.Password.Contains("hello")));

            //4. Display to the console the remaining users with their Name and Password.
            Console.WriteLine("\nProblem 4:");
            foreach (var user in users)
            {
                Console.WriteLine($"User Name: {user.Name}, User Password: {user.Password}");
            }

        }
    }
}
