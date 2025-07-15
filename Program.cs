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

            // User operation 
            static void UserOperations()
            {
                // Require login first
                if (currentAccountIndex == -1 && !Login())
                    return;                     // user failed / aborted
                bool inUserMenu = true; // to keep the user in the menu until they choose to exit
                while (inUserMenu)
                {

                    Console.Clear();
                    Console.WriteLine("\n====== User Menu ======");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    //Console.WriteLine("3. Check Balance");
                    //Console.WriteLine("4. Submit Review/Complaint");
                    //Console.WriteLine("5. Transfer Funds");
                    //Console.WriteLine("6. Undo Last Complaint");
                    //Console.WriteLine("7. Request Monthly Statement");
                    //Console.WriteLine("8. Request Loan");
                    //Console.WriteLine("9. Show Last N Transactions");
                    //Console.WriteLine("10. Show Transactions After Date");
                    Console.WriteLine("0. Back to Main Menu");
                    Console.Write("Select option: ");
                    string userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "1": Deposit(); Console.ReadLine(); break;
                        case "2": Withdraw(); Console.ReadLine(); break;
                        //case "3": CheckBalance(); Console.ReadLine(); break;
                        //case "4": submitReview(); Console.ReadLine(); break;
                        //case "5": TransferFunds(); Console.ReadLine(); break;
                        //case "6": UndoLastComplaint(); Console.ReadLine(); break;
                        //case "7": MonthlyStatement(); Console.ReadLine(); break;
                        //case "8": RequestLoan(); Console.ReadLine(); break;
                        //case "9": ShowLastNTransactions(); Console.ReadLine(); break;
                        //case "10": ShowTransactionsAfterDate(); Console.ReadLine(); break;


                        case "0":
                            inUserMenu = false;
                            Logout();               // end session
                            break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }
                }
            }

            // ===========Admin Menu============

            static void AdminMenu()
            {
                bool inAdminMenu = true;
                while (inAdminMenu)
                {
                    Console.Clear();
                    Console.WriteLine("\n====== Admin Menu ======");
                    Console.WriteLine("1. Process Next Account Request");
                    //Console.WriteLine("2. View Submitted Reviews");
                    //Console.WriteLine("3. View All Accounts");
                    //Console.WriteLine("4. View Pending Account Requests");
                    //Console.WriteLine("5. Search by Name or National ID");
                    //Console.WriteLine("6. Delete Account by Number");
                    //Console.WriteLine("7. Show Top 3 Richest Customers");
                    //Console.WriteLine("8. Show Total Bank Balance");
                    //Console.WriteLine("9. Export All Account Info to CSV");
                    //Console.WriteLine("10. Approve/Reject Loan Requests");
                    //Console.WriteLine("11. View Average Feedback Score");

                    Console.WriteLine("0. Back to Main Menu");
                    Console.Write("Select option: ");
                    string adminChoice = Console.ReadLine();

                    switch (adminChoice)
                    {
                        case "1": ProcessNextAccountRequest(); Console.ReadLine(); break;
                        //case "2": ViewReviews(); Console.ReadLine(); break;
                        //case "3": ViewAllAccounts(); Console.ReadLine(); break;
                        //case "4": ViewPendingRequests(); break;
                        //case "5": SearchAccountByNameOrID(); break;
                        //case "6": DeleteAccountByNumber(); Console.ReadLine(); break;
                        //case "7": ShowTopRichestCustomers(); Console.ReadLine(); break;
                        //case "8": ShowTotalBankBalance(); Console.ReadLine(); break;
                        //case "9": ExportAccountsToCsv(); Console.ReadLine(); break;
                        //case "10": ApproveRejectLoans(); Console.ReadLine(); break;
                        //case "11":
                        //    ShowAverageFeedback(); Console.ReadLine(); break;



                            Console.ReadLine();
                            break;
                        case "0": inAdminMenu = false; break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////////


        }


    }
        
}
