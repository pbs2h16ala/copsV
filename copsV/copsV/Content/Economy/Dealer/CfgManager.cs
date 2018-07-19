using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;

namespace copsV.Content.Economy.Dealer
{
    class CfgManager
    {

        public void Main()
        {
            readPlayerStats();
        }

        public static void readPlayerStats()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("cfg/dealerConfig.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
