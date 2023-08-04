using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    public  class FileProcessing
    {
        private Logging logging;

        public FileProcessing()
        {
            logging = new Logging();
        }

        public void ProcessFile( string filepath)
        {
            // Code to process the file
            Console.WriteLine("***File Processing***\n");
            logging.Log("File processed successfully");
            Console.WriteLine("File processed Successfully");
        }
    }
}
