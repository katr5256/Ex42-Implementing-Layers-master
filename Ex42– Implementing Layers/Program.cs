using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42__Implementing_Layers
{
    public class Program
    {
        Menu menu = new Menu();

        static void Main(string[] args)
        {
            Program pro = new Ex42__Implementing_Layers.Program();
            pro.Run();
        }

        private void Run()
        {
            menu.RunMenu();
        }
    }
}
