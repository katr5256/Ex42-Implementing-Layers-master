using System;

namespace Ex42__Implementing_Layers
{
    public class Menu
    {
        private Controller Controller = new Controller();
        private void show()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Insert Pet");
            Console.WriteLine("2. Show all Pets");
            Console.WriteLine("3. Insert Owner");
            Console.WriteLine("4. Find owner by last name ");
            Console.WriteLine("5. Find Owner by Email");
            Console.WriteLine("0. Exit");
        }

        public void RunMenu()
        {
            Show();
            string input = GetUserInput();
                switch(input)
                {
                    case "1":
                        do
                        {
                        Console.Clear();
                        Controller.InsertPet();
                        break;
                } while (true);
                RunMenu();
                break;
            case "2":
                do
                {
                        Console.Clear();
                        Controller.ShowPets();
                        Console.WriteLine("");
                        break;
                } while (true);
                RunMenu();
                break;

            case "3":
                do
                {
                    Console.Clear();
                    Controller.InsertOwner();
                    break;

                    } while (true);
                    RunMenu();
                    break;

            case "4":
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Insert last name");
                        Controller.FindOwnerByLastName(GetUserInput());
                        Console.WriteLine("");
                        break;
                    } while (true);
                    RunMenu();
                    break;
                case "5":
                    Console.WriteLine("Insert email");
                    Console.WriteLine("Insert name");
                    Controller.FindOwnerByEmail(GetUserInput(), GetUserInput());
                    break;
                case "0":
                    break;
                default:
                    do
                    {
                        Console.WriteLine("??");
                        Console.WriteLine("\n");
                        break;
                    } while (true);
                    RunMenu();
                    break;
            }
        }
    }
}
private string GetUserInput()
{
string input = Console.ReadLine();
return input;
}
