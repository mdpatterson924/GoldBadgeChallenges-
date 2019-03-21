using System;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_ChallengeTests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        private MenuRepository _menuRepo;

        [TestMethod]
        public void MenuRepository_GetItemsCorrectCount()
        {
            MenuRepository _menuRepo = new MenuRepository();
            Menu itemOne = new Menu();
            Menu itemTwo = new Menu();
            Menu itemThree = new Menu();

            _menuRepo.CreateNewMenuItem(itemOne);
            _menuRepo.CreateNewMenuItem(itemTwo);
            _menuRepo.CreateNewMenuItem(itemThree);

            int actual = _menuRepo.GetMenuList().Count;
            int expected = 3;
            
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] 
        public void MenuRepository_RemoveItemFromList()
        {
            MenuRepository _menuRepo = new MenuRepository();
            Menu itemOne = new Menu();
            Menu itemTwo = new Menu();
            Menu itemThree = new Menu();

            _menuRepo.CreateNewMenuItem(itemOne);
            _menuRepo.CreateNewMenuItem(itemTwo);
            _menuRepo.CreateNewMenuItem(itemThree);

            _menuRepo.RemoveMenuItems(itemOne);
            
            int actual = _menuRepo.GetMenuList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenuRepository_RemoveMenuItemsBySpecifications_BoolShouldReturnTrue()
        {
            MenuRepository _menuRepo = new MenuRepository();
            Menu menu = new Menu(5,"hello"," ","stuff",5.99m);

            _menuRepo.CreateNewMenuItem(menu);

            //Act
            bool actual = _menuRepo.RemoveMenuItemsBySpecifications(5);
            bool expected = true;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
