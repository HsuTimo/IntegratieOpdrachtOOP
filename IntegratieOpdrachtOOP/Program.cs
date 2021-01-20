using ClassLibraryIntegratieOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratieOpdrachtOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CollectieBibliotheek.LoadAll();
                Menu.StartScherm();
                CollectieBibliotheek.SaveAll();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exception: " + e.Message + "\n");
                Console.WriteLine("gevonden in: " + e.Data + "\n");
                Console.ResetColor();
                Console.WriteLine("Contacteer de administrator");
            }
        }
    }
}
