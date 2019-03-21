using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class ProgramUI
    {
        private Menu _menu;
        private MenuRepository _menuRepo;

        public ProgramUI()
        {
            _menu = new Menu();
            _menuRepo = new MenuRepository();
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Create a New Menu Item\n" +
                    "2. View Menu Item\n" +
                    "3. Remove a Menu Item\n" +
                    "4. Exit Application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        CreateNewMenuItem();
                        break;

                    case 2:
                        ViewMenuItems();
                        break;

                    case 3:
                        RemoveMenuItem();
                        break;

                    case 4:
                        running = false;
                        break;
                }
            }
        }
        private void CreateNewMenuItem()
        {
            Console.WriteLine("Enter the nae of the menu item");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the menu combo number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the description of your item");
            string description = Console.ReadLine();

            Console.WriteLine("Enter your list of Ingredients");
            string ingredients = Console.ReadLine();

            Console.WriteLine("Enter the item price");
            decimal price = decimal.Parse(Console.ReadLine());

            Menu menuToList = new Menu(number, name, description, ingredients, price);

            _menuRepo.CreateNewMenuItem(menuToList);
        }
        private void ViewMenuItems()
        {
            List<Menu> menus = _menuRepo.GetMenuList();
            foreach (Menu menuItems in menus)
            {
                Console.WriteLine($"{menuItems.MealNumber} {menuItems.Description}{menuItems.ListOfIngredients}{menuItems.PriceOfMeal}");
            }
            Console.ReadLine();
        }
        private void RemoveMenuItem()
        {
            Console.Clear();
            ViewMenuItems();

            Console.WriteLine("What is the new combo number you would like to remove?");
            int number = int.Parse(Console.ReadLine());

            bool success = _menuRepo.RemoveMenuItemsBySpecifications(number);
            if (success == true)
            {
                Console.WriteLine($"Combo {number} was successfully removed.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Combo {number} was unable to be removed at this time.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
