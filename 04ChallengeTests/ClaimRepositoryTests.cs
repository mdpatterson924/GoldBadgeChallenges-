using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04Challenge;

namespace _04ChallengeTests
{
    [TestClass]
    public class ClaimRepositoryTests
    {
        private ClaimRepositoryTests claimRepository;

        [TestMethod]
        public void ClaimRepository_GetClaimsCorrectCount()
        {
            ClaimRepository _claimRepo = new ClaimRepository();
            Claim itemOne = new Claim();
           
            _claimRepo.AddClaimToQueue(itemOne);

            int actual = _claimRepo.GetClaimQueue().Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ClaimRepository_RemoveClaimFromQueue()
        {
            ClaimRepository _claimRepo = new ClaimRepository();
            Claim itemOne = new Claim();
            Claim itemTwo = new Claim();

            _claimRepo.AddClaimToQueue(itemOne);
            _claimRepo.AddClaimToQueue(itemTwo);

            _claimRepo.RemoveClaimFromQueue();

            int actual = _claimRepo.GetClaimQueue().Count;
            int expected = 1;
        }
    }
}
