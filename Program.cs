using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
     class Program
    {
        static void Main(string[] args)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.CreateUser("reshma2417@gmail.com", "resh2417");

            FileProcessing fileProcessing = new FileProcessing();
            fileProcessing.ProcessFile("example.txt");

            Console.ReadKey();
        }
    }
}
