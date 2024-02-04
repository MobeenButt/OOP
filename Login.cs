using System;
using System.IO;
using System.Threading;

namespace MYLOGIN
{
    internal class Login
    {
        const int MaxUsers = 100;
        public string[] users = new string[MaxUsers];
        public string[] passwords = new string[MaxUsers];
        public string[] roles = new string[MaxUsers];
        public int count = 0;

        public void LoginMenu()
        {
            LoadUserRecords();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Sign In");
                Console.WriteLine("2. Sign Up");
                Console.WriteLine("3. Display Users");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SignInMenu();
                        break;
                    case "2":
                        SignUpMenu();
                        break;
                    case "3":
                        Display();
                        break;
                    case "4":
                        SaveUserRecord();
                        Console.WriteLine("Exiting program. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
                Console.Clear();
            }
        }

        public void SignInMenu()
        {
            Console.Clear();
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();
            string role = SignIn(name, password);
            Console.WriteLine("User Role: {0}", role);
            Console.ReadLine();
            Console.Clear();
        }

        public void SignUpMenu()
        {
            Console.Clear();
            Console.Write("Enter new UserName: ");
            string name = Console.ReadLine();
            Console.Write("Enter new Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Role: ");
            string role = Console.ReadLine();
            if (SignUp(name, password, role))
            {
                Console.WriteLine("Sign-Up Successfully...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Failed to Sign-Up. Please Try Again..");
                Console.ReadLine();
            }
        }

        public void Display()
        {
            Console.WriteLine("List of Users: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Username: {users[i]}, Role: {roles[i]}");

            }
            Console.ReadLine();
        }

        public void LoadUserRecords()
        {
            string path = @"D:\OOP\oopLAB\Lab\LAB3\MYLOGIN\Record.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("User records file not found. Creating a new file.");
                SaveUserRecord("defaultUser", "defaultPassword", "defaultRole");
            }

            Console.WriteLine("Loading user records...");
            Thread.Sleep(500);
            Console.Clear();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string record = lines[i];
                users[count] = GetField(record, 1);
                passwords[count] = GetField(record, 2);
                roles[count] = GetField(record, 3);
                ++count;
            }
            Console.Clear();
        }

        public void SaveUserRecord()
        {
            string path = @"D:\OOP\oopLAB\Lab\LAB3\MYLOGIN\Record.txt";
            File.WriteAllLines(path, GetRecords());
        }

        public string SignIn(string name, string password)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                if (users[i] == name && passwords[i] == password)
                {
                    return roles[i];
                }
            }
            return "undefined";
        }

        public bool SignUp(string name, string password, string role)
        {
            for (int i = 0; i < count; i++)
            {
                if (users[i] == name)
                {
                    Console.WriteLine("\t\t\t\t\tUsername already exists. ");
                    Console.WriteLine("Please enter another username.");
                    return false;
                }
            }

            if (count < MaxUsers)
            {
                users[count] = name;
                passwords[count] = password;
                roles[count] = role;
                count++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetField(string record, int field)
        {
            int comma = 1;
            string result = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma = comma + 1;
                }
                else if (comma == field)
                {
                    result = result + record[x];
                }
            }
            return result;
        }

        public string[] GetRecords()
        {
            Console.Clear();
            string[] records = new string[count];
            for (int i = 0; i < count; i++)
            {
                records[i] = $"{users[i]},{passwords[i]},{roles[i]}";
            }
            return records;
        }

        public void SaveUserRecord(string name, string password, string role)
        {
            Console.Clear();
            using (StreamWriter file = new StreamWriter(@"D:\OOP\oopLAB\Lab\LAB3\MYLOGIN\Record.txt", false))
            {
                file.WriteLine($"{name},{password},{role}");
            }
            Console.Clear();
        }
    }
}
//    internal class Login
//    {
//        const int MaxUsers = 100;
//        public string[] users = new string[MaxUsers];
//        public string[] passwords = new string[MaxUsers];
//        public string[] roles = new string[MaxUsers];
//        public int count = 0;
//        public void LoginMenu()
//        {
//            LoadUserRecords();

//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("Choose an option:");
//                Console.WriteLine("1. Sign In");
//                Console.WriteLine("2. Sign Up");
//                Console.WriteLine("3. Display Users");
//                Console.WriteLine("4. Exit");

//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        SignInMenu();
//                        break;
//                    case "2":
//                        SignUpMenu();
//                        break;
//                    case "3":
//                        Display();
//                        break;
//                    case "4":
//                        SaveUserRecord();
//                        Console.WriteLine("Exiting program. Goodbye!");
//                        Environment.Exit(0);
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice. Please enter a valid option.");
//                        break;
//                }
//                Console.Clear();
//            }
//        }
//        public void SignInMenu()
//        {
//            Console.Clear();
//            Console.Write("Enter your Name: ");
//            string name = Console.ReadLine();
//            Console.Write("Enter your Password: ");
//            string password = Console.ReadLine();
//            string role = SignIn(name, password);
//            Console.WriteLine("User Role: {0}", role);
//            Console.Clear();
//        }
//        public void SignUpMenu()
//        {
//            Console.Clear();
//            Console.Write("Enter new UserName: ");
//            string name = Console.ReadLine();
//            Console.Write("Enter new Password: ");
//            string password = Console.ReadLine();
//            Console.Write("Enter Role: ");
//            string role = Console.ReadLine();
//            if (SignUp(name, password, role))
//            {
//                Console.WriteLine("Sign-Up Succeessfully...");
//            }
//            else
//            {
//                Console.WriteLine("Failed to Sign-Up.Please Try Again..");

//            }
//        }
//        public void Display()
//        {
//            Console.WriteLine("List of Users: ");
//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine($"Username: {users[i]}, Role: {roles[i]}");
//            }
//        }
//        public void LoadUserRecords()
//        {
//            string path = @"D:\OOP\oopLAB\Lab\LAB3\MYLOGIN\Record.txt";
//            if (!File.Exists(path))
//            {
//                Console.WriteLine("User records file not found. Creating a new file.");
//                SaveUserRecord("defaultUser", "defaultPassword", "defaultRole");
//            }

//            Console.WriteLine("Loading user records...");
//            Thread.Sleep(500);
//            Console.Clear();
//            string[] lines = File.ReadAllLines(path);
//            for (int i = 0; i < lines.Length; i++)
//            {
//                string record = lines[i];
//                users[count] = GetField(record, 1);
//                passwords[count] = GetField(record, 2);
//                roles[count] = GetField(record, 3);
//                ++count;
//            }
//            Console.Clear();
//        }
//        public void SaveUserRecord()
//        {
//            string path = @"D:\OOP\oopLAB\Lab\LAB3\MYLOGIN\Record.txt";
//            File.WriteAllLines(path, GetRecords());
//        }
//        public string SignIn(string name, string password)
//        {
//            Console.Clear();
//            for (int i = 0; i < count; i++)
//            {
//                if (users[i] == name && passwords[i] == password)
//                {
//                    return roles[i];
//                }
//            }
//            return "undefined";
//        }
//        public bool SignUp(string name, string password, string role)
//        {
//            for (int i = 0; i < count; i++)
//            {
//                if (users[i] == name)
//                {
//                    Console.WriteLine("\t\t\t\t\tUsername already exists. ");
//                    Console.WriteLine("Please enter another username.");
//                    return false;
//                }
//            }

//            if (count < MaxUsers)
//            {
//                users[count] = name;
//                passwords[count] = password;
//                roles[count] = role;
//                count++;
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public string GetField(string record, int field)
//        {
//            int comma = 1;
//            string result = "";
//            for (int x = 0; x < record.Length; x++)
//            {
//                if (record[x] == ',')
//                {
//                    comma = comma + 1;
//                }
//                else if (comma == field)
//                {
//                    result = result + record[x];
//                }
//            }
//            return result;
//        }

//        public string[] GetRecords()
//        {
//            Console.Clear();
//            string[] records = new string[count];
//            for (int i = 0; i < count; i++)
//            {
//                records[i] = $"{users[i]},{passwords[i]},{roles[i]}";
//            }
//            return records;
//        }
//        public void SaveUserRecord(string name, string password, string role)
//        {
//            Console.Clear();
//            using (StreamWriter file = new StreamWriter(@"D:\OOP\oopLAB\Lab\LAB3\MYLOGIN\Record.txt", true))
//            {
//                file.WriteLine($"{name},{password},{role}");
//            }
//            Console.Clear();
//        }
//    }
//}
