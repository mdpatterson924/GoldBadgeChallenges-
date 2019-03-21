using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Challenge
{
    
   public class ClaimRepository
    {

        private Queue<Claim> queue;  

        public ClaimRepository()
        {
            queue = new Queue<Claim>();
        }
        public Queue<Claim> GetClaimQueue()
        {
            return queue;
        }
        public void AddClaimToQueue(Claim claim)
        {
            queue.Enqueue(claim);
        }
        public void RemoveClaimFromQueue()
        {
            queue.Dequeue();
        }
    }
}
