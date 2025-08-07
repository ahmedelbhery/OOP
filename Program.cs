using ConsoleApp1.Pank_System; 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank System Started...\n");
            
            BankAccount account1 = new BankAccount(
                fullName: "Ahmed Albhery",
                nationalID: "12345678901234",
                phoneNumber: "01012345678",
                address: "Cairo, Egypt",
                balance: 10000
            );
            
            BankAccount account2 = new BankAccount(
                fullName: "Sara Adel",
                nationalID: "98765432109876",
                phoneNumber: "01123456789",
                address: "Alexandria, Egypt",
                balance: 8000
            );
            
            Console.WriteLine("Account 1 Details:");
            account1.ShowAccountDetails();
            Console.WriteLine();
            
            Console.WriteLine("Account 2 Details:");
            account2.ShowAccountDetails();
            
            Console.ReadKey();
        }
    }
}