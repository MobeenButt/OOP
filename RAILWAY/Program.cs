using System;

namespace RAILWAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            railway railwaySystem = new railway();
            railwaySystem.LoadUserRecords();

            bool Login = false;
            string role = "";

            while (!Login)
            {
                Console.WriteLine("1. Sign In");
                Console.WriteLine("2. Sign Up");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        //string password = railwaySystem.ReadPassword();
                        string password = Console.ReadLine();
                        role = railwaySystem.SignIn(username, password);
                        if (role != "undefined")
                        {
                            Login = true;
                            Console.WriteLine($"Welcome, {username}!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid username or password.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter username:");
                        string newUsername = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        string newPassword = Console.ReadLine();
                        //string newPassword = railwaySystem.ReadPassword();
                        Console.WriteLine("Enter role:");
                        string newRole = Console.ReadLine();
                        
                        bool signUpResult = railwaySystem.SignUp(newUsername, newPassword, newRole);
                        
                        if (signUpResult)
                        {
                            Console.WriteLine("User signed up successfully.");
                            
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Failed to sign up. Please try again later.");
                        }
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }

            //  call other functions based on the role.
            if (role == "Admin")
            {
                railwaySystem.ADMIN();
            }
            else if(role=="User")
            {
                railwaySystem.USER();
            }
        }
    }
}
