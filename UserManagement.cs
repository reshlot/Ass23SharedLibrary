using System;
using MySharedLibrary;
namespace MainApp
{
    public  class UserManagement
    {
        private DataValidation dataValidation;

        public UserManagement()
        {
             dataValidation = new DataValidation();
        }

        public void CreateUser(string email, string password)
        {
            Console.WriteLine("***Data Validation***\n");
            if (dataValidation.IsEmailValid(email))
            {
                // Code to create a new user
                Console.WriteLine("Email:"+email);
                Console.WriteLine("Password:"+password);
            }
            else
            {
                Console.WriteLine("Invalid Email!!!");
                // Handle invalid email
            }
        }
    }
}
