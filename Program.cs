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

        }

        
    }
        
}
