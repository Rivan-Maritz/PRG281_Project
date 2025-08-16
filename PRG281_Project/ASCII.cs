using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    class ASCII
    {
        public void IncomeModuleDisplay()
        {
            //Displays ASCII art for the income module to allow the user to see what module they are in
            //This improves user experience by providing a visual representation of the module
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"  _____                                  __  __           _       _      
 |_   _|                                |  \/  |         | |     | |     
   | |  _ __   ___ ___  _ __ ___   ___  | \  / | ___   __| |_   _| | ___ 
   | | | '_ \ / __/ _ \| '_ ` _ \ / _ \ | |\/| |/ _ \ / _` | | | | |/ _ \
  _| |_| | | | (_| (_) | | | | | |  __/ | |  | | (_) | (_| | |_| | |  __/
 |_____|_| |_|\___\___/|_| |_| |_|\___| |_|  |_|\___/ \__,_|\__,_|_|\___|");
            Console.ResetColor();
            Console.WriteLine("-------------------------------------------------------------------------");
        }

        public void ExpenseModuleDisplay()
        {
            //Displays ASCII art for the expense module to allow the user to see what module they are in
            //This improves user experience by providing a visual representation of the module
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"  ______                                  __  __           _       _      
 |  ____|                                |  \/  |         | |     | |     
 | |__  __  ___ __   ___ _ __  ___  ___  | \  / | ___   __| |_   _| | ___ 
 |  __| \ \/ / '_ \ / _ \ '_ \/ __|/ _ \ | |\/| |/ _ \ / _` | | | | |/ _ \
 | |____ >  <| |_) |  __/ | | \__ \  __/ | |  | | (_) | (_| | |_| | |  __/
 |______/_/\_\ .__/ \___|_| |_|___/\___| |_|  |_|\___/ \__,_|\__,_|_|\___|
             | |                                                          
             |_|                                                          ");
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------------------------------------");
        }

        public void CashModuleDisplay()
        {
            //Displays ASCII art for the net cash module to allow the user to see what module they are in
            //This improves user experience by providing a visual representation of the module
            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"   _____          _       __  __           _       _      
  / ____|        | |     |  \/  |         | |     | |     
 | |     __ _ ___| |__   | \  / | ___   __| |_   _| | ___ 
 | |    / _` / __| '_ \  | |\/| |/ _ \ / _` | | | | |/ _ \
 | |___| (_| \__ \ | | | | |  | | (_) | (_| | |_| | |  __/
  \_____\__,_|___/_| |_| |_|  |_|\___/ \__,_|\__,_|_|\___|");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------");
        }

        public void CashStatsModuleDisplay()
        {
            //Displays ASCII art for the net cash module to allow the user to see what module they are in
            //This improves user experience by providing a visual representation of the module
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"   _____          _        _____ _        _   _     _   _          
  / ____|        | |      / ____| |      | | (_)   | | (_)         
 | |     __ _ ___| |__   | (___ | |_ __ _| |_ _ ___| |_ _  ___ ___ 
 | |    / _` / __| '_ \   \___ \| __/ _` | __| / __| __| |/ __/ __|
 | |___| (_| \__ \ | | |  ____) | || (_| | |_| \__ \ |_| | (__\__ \
  \_____\__,_|___/_| |_| |_____/ \__\__,_|\__|_|___/\__|_|\___|___/");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
