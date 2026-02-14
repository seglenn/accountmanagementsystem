namespace AccountManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Account Management System");

            string username = "glennlambert";
            string password = "gnnlmbrt123!";

            Console.WriteLine("Enter Username: ");
            string usernameinput = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string passwordinput = Console.ReadLine();

            if (usernameinput == username && passwordinput == password)
            {
                Console.WriteLine("Log in Successfull");
            }
            else
            {
                Console.WriteLine("Incorrect inputs");

            }
        }
    }
}
