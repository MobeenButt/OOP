using System;
namespace Login
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("                                     \"Login Menu\"                             ");
            Console.WriteLine("                                       1.Sign In");
            Console.WriteLine("                                       2.Sign Up");
            Console.WriteLine("                                       3.Exit");




            int count = 0;
            int userArrSize = 100;
            string[] users = new string[userArrSize];
            string[] passwords = new string[userArrSize];
            string[] roles = new string[userArrSize];

            string option;



            while (true)
            {
                Console.Write("Enter your option: ");
                option = Console.ReadLine();

                string username, password, role;

                if (option == "1")
                {
                    Console.Write("Enter your Name: ");
                    username = Console.ReadLine();
                    Console.Write("Enter your Password: ");
                    password = Console.ReadLine();
                    string result = Signin(username, password, users, passwords, roles, count);
                    Console.WriteLine("User Role: " + result);
                }
                else if (option == "2")
                {
                    Console.Write("Enter your Name: ");
                    username = Console.ReadLine();
                    Console.Write("Enter your Password: ");
                    password = Console.ReadLine();
                    Console.Write("Enter your Role: ");
                    role = Console.ReadLine();

                    while (role != "Admin" && role != "User")
                    {
                        Console.WriteLine("Invalid role! Please enter 'Admin' or 'User': ");
                        role = Console.ReadLine();
                    }

                    if (Signup(username, password, role, users, passwords, roles, ref count, userArrSize))
                    {
                        Console.WriteLine($"Congratulations! Sign-Up Successful as {role}.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid! Unable to Sign-Up.");


                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

            }
        }



        static string Signin(string name, string password, string[] user, string[] passwords, string[] role, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (user[i] == name && passwords[i] == password)
                {
                    return role[i];
                }

            }
            return "Unidentified!";
        }





        static bool Signup(string username, string password, string role, string[] users, string[] passwords, string[] roles, ref int count, int userArrSize)
        {
            // check if username already exists
            for (int i = 0; i < count; i++)
            {
                if (users[i] == username)
                {
                    Console.WriteLine("Username already exists! Please enter another username.");
                    return false;
                }
            }

            // check if there is space for a new user because max users are declared
            if (count < userArrSize)
            {
                users[count] = username;
                passwords[count] = password;
                roles[count] = role;
                count++;

                return true;
            }
            else
            {
                Console.WriteLine("User limit reached. Unable to Sign-Up.");
                return false;
            }
        }





    }
}
