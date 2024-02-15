using System;
using System.IO;
using System.Threading;

namespace RAILWAY
{
    internal class railway
    {
        const int MaxUsers = 100;
        public string[] users = new string[MaxUsers];
        public string[] passwords = new string[MaxUsers];
        public string[] roles = new string[MaxUsers];
        public int count = 0;

        // declaring arrays
       public int numTrains = 0;
     const int MAX_TRAINS = 100;
       public string[] names = new string[MAX_TRAINS];
       public string[] destinations = new string[MAX_TRAINS];
       public int[] departureTimes = new int[MAX_TRAINS];
        public void LoadUserRecords()
        {
            string path = @"D:\OOP\RAILWAY\railwayrecord.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("User records file not found. Creating a new file.");
                SaveUserRecord("defaultUser", "defaultPassword", "defaultRole");
            }
            else
            {
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
                    count++;
                }
            }
        }

        public void SaveUserRecords()
        {
            string path = @"D:\OOP\RAILWAY\railwayrecord.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < count; i++)
                {
                    writer.WriteLine($"{users[i]},{passwords[i]},{roles[i]}");
                }
            }
        }


        public string SignIn(string name, string password)
        {
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
                SaveUserRecords();
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
            string[] records = new string[count];
            for (int i = 0; i < count; i++)
            {
                records[i] = $"{users[i]},{passwords[i]},{roles[i]}";
            }
            return records;
        }

        public void SaveUserRecord(string name, string password, string role)
        {
            using (StreamWriter file = new StreamWriter(@"D:\OOP\RAILWAY\railwayrecord.txt", true))
            {
                file.WriteLine($"{name},{password},{role}");
            }
        }


     /*   //public string ReadPassword()
        //{
        //    string password = "";
        //    ConsoleKeyInfo key = Console.ReadKey(true);

        //    while (key.Key != ConsoleKey.Enter)
        //    {
        //        password = password + key.KeyChar;
        //        Console.Write("*");
        //        key = Console.ReadKey(true);
        //    }

        //    Console.WriteLine();
        //    return password;
        //}*/

        public void CLEAR()
        {
            Console.Clear();
        }


        //    ////Home //   
        public void Home()
        {
            Console.WriteLine("Our Services:");
            Console.WriteLine("JAFFAR EXPRESS");
            Console.WriteLine("YAAD-GAR-EXPRESS");
            Console.WriteLine("GREEN TRAIN");
            Console.WriteLine("PAK-TRAIN ");
            Console.WriteLine("Press any key Continue");
            Console.ReadLine();
        }

        public void TIMINGS()
        {
            string op;
            Console.WriteLine(" 1. Enter Train:");
            Console.WriteLine(" 2. Location");
            Console.WriteLine(" 3. Back");
            op = Console.ReadLine();

            if (op != "1" && op != "2" && op != " 3")
            {
                Console.WriteLine("Invalid option. Please enter a valid option.");
                CLEAR();
            }

            if (op == "1")
            {
                Console.WriteLine(" Name: ");
                string name;
                name = Console.ReadLine();
                if (name == "JAFFAR EXPRESS")
                {
                    Console.WriteLine(" Train Arrive At 10AM");
                }
                else if (name == "YAAD-GAR-EXPRESS")
                {
                    Console.WriteLine("Train is on time. ");
                }
                else if (name == "PAK-TRAIN")
                {
                    Console.WriteLine("Train is late due to Rain!");
                }
                else if (name == "GREEN TRAIN")
                {
                    Console.WriteLine(" Train arrives at 2AM");
                }
                else
                {
                    Console.WriteLine("Invalid Name");
                }
            }
            else if (op == "2")
            {
                string location;
                Console.WriteLine("Enter Location: ");
                location = Console.ReadLine();

                if (location == "Lahore")
                {
                    Console.WriteLine(" JAFFAR EXPRESS is coming soon! ");
                    TIMINGS();
                }
                else if (location == "Karachi")
                {
                    Console.WriteLine(" YAAD-GAR-EXPRESS is on its Way!");
                    TIMINGS();
                }
                else if (location == "Peshawar")
                {
                    Console.WriteLine(" GREEN TRAIN arrives soon! ");
                    TIMINGS();
                }
                else if (location == "Multan")
                {
                    Console.WriteLine(" Train is OUT OF ORDER! ");
                }
                else
                {
                    Console.WriteLine("Invalid Location");
                }
            }
            else if (op == "3")
            {
                USER();
            }

            CLEAR();
        }
       public void USER()
        {
            CLEAR();
            Console.WriteLine(" 1. Home");
            Console.WriteLine(" 2. Train Timings");
            Console.WriteLine(" 3. Rates");
            Console.WriteLine(" 4. Info");
            Console.WriteLine(" 5. EBooking");
            Console.WriteLine(" 6. Feedback");
            Console.WriteLine(" 7. Logout");
            string opt;
            Console.WriteLine("Choose Your Option...");
            opt = Console.ReadLine();
            if (opt == "1")
            {
                Home();
                USER();
            }
            else if (opt == "2")
            {
                TIMINGS();
                USER();
            }
            else if (opt == "3")
            {
                RATE();
                USER();
            }
            else if (opt == "4")
            {
                INFO();
                USER();
            }
            else if (opt == "5")
            {
                ETICKET();
                USER();
            }
        }
      public void RATE()
        {

            Console.WriteLine(new string('-', 70));
            Console.WriteLine("{0,-30}{1,-30}{2,-10}", "City", "Train", "Ticket Rate");
            Console.WriteLine("{0,-30}{1,-30}{2,-10}", "Lahore-to-Karachi", "JAFFAR EXPRESS", "Rs 4500");
            Console.WriteLine("{0,-30}{1,-30}{2,-10}", "Lahore-to-Multan", "PAK-TRAIN", "Rs 4500");
            Console.WriteLine("{0,-30}{1,-30}{2,-10}", "Karachi-to-Multan", "YAAD-GAR-EXPRESS", "Rs 4200");
            Console.WriteLine("{0,-30}{1,-30}{2,-10}", "Karachi-to-Lahore", "JAFFAR EXPRESS", "Rs 4200");
            Console.WriteLine("{0,-30}{1,-30}{2,-10}", "Multan-to-Lahore", "GREEN TRAIN", "Rs 4000");
            Console.WriteLine("{0,-30}{1,-30}{2,-10}", "Peshawar-to-Karachi", "JAFFAR EXPRESS", "Rs 4500");
            Console.WriteLine("{0,-30}{1,-30}{2,-10}", "Peshawar-to-Lahore", "YAAD-GAR-EXPRESS", "Rs 4500");
            Console.WriteLine("{0,-30}{1,-30}{2,-10}", "Gujranwala-to-Lahore", "PAK-TRAIN", "Rs 4500");
            Console.WriteLine("Press any key to Continue...");
            Console.ReadLine();

            CLEAR();
        }
        public void ETICKET()
        {
            CLEAR();
            const int MAX_PASSENGERS = 10;
            int numTickets;

            Console.Write("Enter the number of tickets: ");
            while (!int.TryParse(Console.ReadLine(), out numTickets) || numTickets <= 0 || numTickets > MAX_PASSENGERS)
            {
                Console.WriteLine("Invalid input. Please enter a valid number of tickets (1 to 10).");
            }

            string[] passengerNames = new string[MAX_PASSENGERS];
            string[] cnics = new string[MAX_PASSENGERS];
            string[] locations = new string[MAX_PASSENGERS];
            int[] nums = new int[MAX_PASSENGERS];
            int[] totalAmounts = new int[MAX_PASSENGERS];

            Console.WriteLine("\t\t\t\tPASSENGERS DETAILS");

            for (int i = 0; i < numTickets; i++)
            {
                Console.WriteLine($"Enter Name for Passenger {i + 1}: ");
                passengerNames[i] = Console.ReadLine();

                Console.WriteLine($"Enter CNIC for Passenger {i + 1}: ");
                cnics[i] = Console.ReadLine();

                bool validLocation = false;
                while (!validLocation)
                {
                    Console.WriteLine($"Enter Location for Passenger {i + 1}: ");
                    locations[i] = Console.ReadLine();

                    if (locations[i] != "Lahore" && locations[i] != "Gujranwala" && locations[i] != "Peshawar" && locations[i] != "Karachi" && locations[i] != "Multan")
                    {
                        Console.WriteLine("Invalid Location. Please enter a valid location (Lahore, Gujranwala, Peshawar, Karachi, Multan): ");
                    }
                    else
                    {
                        validLocation = true;
                    }
                }

                nums[i] = 1;

                if (locations[i] == "Lahore")
                {
                    totalAmounts[i] = nums[i] * 4500;
                }
                else if (locations[i] == "Karachi")
                {
                    totalAmounts[i] = nums[i] * 4200;
                }
                else if (locations[i] == "Peshawar")
                {
                    totalAmounts[i] = nums[i] * 4500;
                }
                else if (locations[i] == "Multan")
                {
                    totalAmounts[i] = nums[i] * 4000;
                }
                else if (locations[i] == "Gujranwala")
                {
                    totalAmounts[i] = nums[i] * 4500;
                }
            }

            DisplayInfo(passengerNames, cnics, locations, nums, totalAmounts, numTickets);
            Console.ReadLine(); // Wait for user input before clearing the console
            CLEAR();
        }

        //    ////Displaying information of of e-ticket
        public void DisplayInfo(string[] names, string[] cnics, string[] locations, int[] nums, int[] totalAmounts, int numTickets)
        {

            Console.WriteLine("Ticket Details");

            for (int i = 0; i < numTickets; i++)
            {
                Console.WriteLine("Passenger " + (i + 1) + " Name: " + names[i]);
                Console.WriteLine("Passenger " + (i + 1) + " CNIC: " + cnics[i]);
                Console.WriteLine("Passenger " + (i + 1) + " Location: " + locations[i]);
                Console.WriteLine("Passenger " + (i + 1) + " Number of Tickets: " + nums[i]);
                Console.WriteLine("Passenger " + (i + 1) + " Total Amount: " + totalAmounts[i]);
                Console.WriteLine("-----------------------------------------");
            }
        }
      public void INFO()
        {
            Console.Clear();
          
            Console.WriteLine("Pakistan Railways is the national, state-owned railway company of Pakistan in Lahore. Founded in 1861 as the North Western State Railway and headquartered in Lahore, it owns 7,490 kilometres of operational track across Pakistan, stretching from Torkham to Karachi, offering both freight and passenger services.");
            Console.WriteLine("\t\t\t\n\n\n\n Press any key to Continue");
            Console.ReadLine();
        }
        /////Admin Menu
      public void ADMIN()
        {
            CLEAR();
            Console.WriteLine("  1. Add New Train");
            Console.WriteLine("  2. View added Trains ");
            Console.WriteLine("  3. Available Trains");
            Console.WriteLine("  4. Info");
            Console.WriteLine("  5. Helpline");
            Console.WriteLine("  6. E-Ticket");
            Console.WriteLine("  7. Remove Added Trains");
            Console.WriteLine("  8. Logout");
            Console.WriteLine("  9. Exit");
            string opt;
            Console.WriteLine("Choose Your Option...");
            opt = Console.ReadLine();
            if (opt == "1")
            {
                ADDTRAIN();
                ADMIN();

            }
            else if (opt == "2")
            {
                VIEWTRAINS(names, destinations, departureTimes, numTrains);
                ADMIN();
            }
            else if (opt == "3")
            {
             
                ADMIN();
            }
            else if (opt == "7")
            {
                REMOVETRAIN(names, destinations, departureTimes, ref numTrains);
                ADMIN();

            }
          
            else if (opt == "4")
            {
                INFO();
                ADMIN();
            }
            else if (opt == "8")
            {
                Console.Clear();

            }
            else if (opt == "6")
            {
                ETICKET();
                ADMIN();
            }
            else
            {
                Console.WriteLine("Invalid Option!Try Again....");
            }
        }
        ///Adding new Train
       public void ADDTRAIN()
        {
            CLEAR();
            if (numTrains < MAX_TRAINS)
            {
                Console.WriteLine("Enter Train Details: ");
                Console.WriteLine("Train Name: ");
                names[numTrains] = Console.ReadLine();

                Console.WriteLine("Destination: ");
                destinations[numTrains] = Console.ReadLine();

                Console.WriteLine("Departure Time (in 24-hour format, e.g., 1400): ");

                while (!int.TryParse(Console.ReadLine(), out departureTimes[numTrains]) || departureTimes[numTrains] < 0 || departureTimes[numTrains] > 2359)
                {
                    Console.WriteLine("Invalid input. Please enter a valid departure time in 24-hour format (e.g., 1400): ");

                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    
                   

                    Console.WriteLine();
                }

                Console.WriteLine("Train added successfully!");
                numTrains++;
            }
            else
            {
                Console.WriteLine("Maximum number of trains reached. Cannot add more trains.");
            }
        }
        // Remove Added Train funct
       public void REMOVETRAIN(string[] names, string[] destinations, int[] departureTimes, ref int numTrains)
        {

            CLEAR();
            /// give acess to remove added trains

            if (numTrains > 0)
            {
                VIEWTRAINS(names, destinations, departureTimes, numTrains); // Display the list of trains for reference

                string trainName, destination;
                Console.WriteLine("\nEnter the name of the train to remove: ");
                trainName = Console.ReadLine();
                Console.WriteLine("\nEnter the destination of the train to remove: ");
                destination = Console.ReadLine();

                bool found = false;
                for (int i = 0; i < numTrains; ++i)
                {
                    if (names[i] == trainName || destinations[i] == destination)
                    {
                        // Shift elements to remove the train
                        for (int j = i; j < numTrains - 1; j++)
                        {
                            names[j] = names[j + 1];
                            destinations[j] = destinations[j + 1];
                            departureTimes[j] = departureTimes[j + 1];
                        }

                        // Decrement the number of trains
                        numTrains--;

                        Console.WriteLine("Train " + trainName + "  removed successfully!\n");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Train " + trainName + " not found. No changes made.\n");
                }
            }
            else
            {
                Console.WriteLine("No trains to remove.\n");
            }

            Console.Clear();
        }
        // VIEW ADDED TRAIN Funcitons
       public void VIEWTRAINS(string[] names, string[] destinations, int[] departureTimes, int numTrains)
        {
            CLEAR();
            if (numTrains > 0)
            {
                Console.WriteLine("\n===== List of Added Trains =====\n");
                Console.WriteLine("{0,-15} {1,-15} {2,-20}", "Train Name", "Destination", "Departure Time");

                for (int i = 0; i < numTrains; ++i)
                {
                    Console.WriteLine("{0,-15} {1,-15} {2,-20}", names[i], destinations[i], departureTimes[i]);
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No trains added yet.\n");
                Thread.Sleep(800);
                Console.WriteLine("Press any key to Continue...");
                Console.ReadKey();
            }
        }


    }
}

