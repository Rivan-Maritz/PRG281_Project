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

        public void InventoryAddModuleDisplay()
        {
            //Displays ASCII art for the net cash module to allow the user to see what module they are in
            //This improves user experience by providing a visual representation of the module
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"  _____                      _                                 _     _   __  __           _       _      
 |_   _|                    | |                       /\      | |   | | |  \/  |         | |     | |     
   | |  _ ____   _____ _ __ | |_ ___  _ __ _   _     /  \   __| | __| | | \  / | ___   __| |_   _| | ___ 
   | | | '_ \ \ / / _ \ '_ \| __/ _ \| '__| | | |   / /\ \ / _` |/ _` | | |\/| |/ _ \ / _` | | | | |/ _ \
  _| |_| | | \ V /  __/ | | | || (_) | |  | |_| |  / ____ \ (_| | (_| | | |  | | (_) | (_| | |_| | |  __/
 |_____|_| |_|\_/ \___|_| |_|\__\___/|_|   \__, | /_/    \_\__,_|\__,_| |_|  |_|\___/ \__,_|\__,_|_|\___|
                                            __/ |                                                        
                                           |___/                                                         ");
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        }

        public void InventoryLowStockModuleDisplay()
        {
            //Displays ASCII art for the net cash module to allow the user to see what module they are in
            //This improves user experience by providing a visual representation of the module
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"  _____                      _                     _                      _____ _             _      __  __           _       _      
 |_   _|                    | |                   | |                    / ____| |           | |    |  \/  |         | |     | |     
   | |  _ ____   _____ _ __ | |_ ___  _ __ _   _  | |     _____      __ | (___ | |_ ___   ___| | __ | \  / | ___   __| |_   _| | ___ 
   | | | '_ \ \ / / _ \ '_ \| __/ _ \| '__| | | | | |    / _ \ \ /\ / /  \___ \| __/ _ \ / __| |/ / | |\/| |/ _ \ / _` | | | | |/ _ \
  _| |_| | | \ V /  __/ | | | || (_) | |  | |_| | | |___| (_) \ V  V /   ____) | || (_) | (__|   <  | |  | | (_) | (_| | |_| | |  __/
 |_____|_| |_|\_/ \___|_| |_|\__\___/|_|   \__, | |______\___/ \_/\_/   |_____/ \__\___/ \___|_|\_\ |_|  |_|\___/ \__,_|\__,_|_|\___|
                                            __/ |                                                                                    
                                           |___/                                                                                     ");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
        }

        public void InventoryViewModuleDisplay()
        {
            //Displays ASCII art for the net cash module to allow the user to see what module they are in
            //This improves user experience by providing a visual representation of the module
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"  _____                      _                    __      ___                 __  __           _       _      
 |_   _|                    | |                   \ \    / (_)               |  \/  |         | |     | |     
   | |  _ ____   _____ _ __ | |_ ___  _ __ _   _   \ \  / / _  _____      __ | \  / | ___   __| |_   _| | ___ 
   | | | '_ \ \ / / _ \ '_ \| __/ _ \| '__| | | |   \ \/ / | |/ _ \ \ /\ / / | |\/| |/ _ \ / _` | | | | |/ _ \
  _| |_| | | \ V /  __/ | | | || (_) | |  | |_| |    \  /  | |  __/\ V  V /  | |  | | (_) | (_| | |_| | |  __/
 |_____|_| |_|\_/ \___|_| |_|\__\___/|_|   \__, |     \/   |_|\___| \_/\_/   |_|  |_|\___/ \__,_|\__,_|_|\___|
                                            __/ |                                                             
                                           |___/                                                              ");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
        }

        public void InventoryRemoveModuleDisplay()
        {
            //Displays ASCII art for the net cash module to allow the user to see what module they are in
            //This improves user experience by providing a visual representation of the module
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"  _____                      _                     _____                                 __  __           _       _      
 |_   _|                    | |                   |  __ \                               |  \/  |         | |     | |     
   | |  _ ____   _____ _ __ | |_ ___  _ __ _   _  | |__) |___ _ __ ___   _____   _____  | \  / | ___   __| |_   _| | ___ 
   | | | '_ \ \ / / _ \ '_ \| __/ _ \| '__| | | | |  _  // _ \ '_ ` _ \ / _ \ \ / / _ \ | |\/| |/ _ \ / _` | | | | |/ _ \
  _| |_| | | \ V /  __/ | | | || (_) | |  | |_| | | | \ \  __/ | | | | | (_) \ V /  __/ | |  | | (_) | (_| | |_| | |  __/
 |_____|_| |_|\_/ \___|_| |_|\__\___/|_|   \__, | |_|  \_\___|_| |_| |_|\___/ \_/ \___| |_|  |_|\___/ \__,_|\__,_|_|\___|
                                            __/ |                                                                        
                                           |___/                                                                         ");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }

    }
}
