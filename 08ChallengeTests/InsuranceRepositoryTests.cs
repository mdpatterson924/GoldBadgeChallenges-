using System;
using _08Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08ChallengeTests
{
    [TestClass]
    public class InsuranceRepositoryTests
    {
        private InsuranceRepository _inRepo = new InsuranceRepository();

        [TestMethod]
        public void InsuranceRepository_GetItemsCorrectCount()
        {
            //InsuranceRepository _inRepo = new InsuranceRepository();
            Driver itemOne = new Driver();
            Driver itemTwo = new Driver();

            _inRepo.CreateNewDriver(itemOne);
            _inRepo.CreateNewDriver(itemTwo);

            int actual = _inRepo.GetDriverList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsuranceRepository_RemoveDriver()
        {
            Driver itemOne = new Driver();
            Driver itemTwo = new Driver();

            _inRepo.CreateNewDriver(itemOne);
            _inRepo.CreateNewDriver(itemTwo);

            _inRepo.RemoveDriver(itemTwo);

            int actual = _inRepo.GetDriverList().Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
