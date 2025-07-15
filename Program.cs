namespace MiniBankSystemOOP
{
    internal class Program
    {


        // List for accounts object 
        List<Account> accountsList = new List<Account>();
        // queue for account requests
        Queue<Account> accountRequests = new Queue<Account>();
        static void Main(string[] args)
        {

            // main menu 
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("\n====== SafeBank System Main Menu ======");
                Console.WriteLine("1. User Menu");
                Console.WriteLine("2. Admin Menu");
                Console.WriteLine("0. Exit");
                Console.Write("Select option: ");
                string mainChoice = Console.ReadLine();

                switch (mainChoice)
                {
                    case "1": UserMenu(); break;
                    case "2": AdminMenu(); break;
                    case "0":
                        SaveAccountInformationToFile();
                        SaveReviewsToFile();// Save reviews to file before exiting


                        running = false;
                        break;
                    default: Console.WriteLine("Invalid choice."); break;
                }
            }

            Console.WriteLine("Thank you for using SafeBank!");

            // ===========User Menu===========
            static void UserMenu()
            {
                bool inUserMenu = true; // to keep the user in the menu until they choose to exit
                while (inUserMenu)
                {

                    Console.Clear();
                    Console.WriteLine("\n====== User Menu ======");
                    Console.WriteLine("1. Create Account");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("0. Back to Main Menu");
                    Console.Write("Select option: ");
                    string userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "1": CreateAccount(); Console.ReadLine(); break;
                        //case "2":                           // Admin Menu
                        //    if (AdminLogin())               // ← ask for credentials first
                        //        AdminMenu();                // open menu only on success
                        //    break;

                        case "2":
                            Login();
                            // Require login first
                            if (currentAccountIndex == -1 && !Login())
                            { return; }                // user failed / aborted
                            else
                            {
                                // If login is successful, show user operations menu
                                UserOperations(); // Call the user operations method to show the user menu
                            }
                            break;
                        case "0":
                            inUserMenu = false;
                            Logout();               // end session
                            break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }
                }
            }

        }

        
    }
        
}
