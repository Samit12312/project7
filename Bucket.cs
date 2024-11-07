using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class Bucket
    {
        int capacity;
        int amount;
        public Bucket(int capacity)
        {
            this.capacity = capacity;
        }
        void Empty()
        {
            this.amount = 0;
        }
        void Fill() 
        {
            this.amount = capacity;
        }
        void PourIntro(Bucket bucket) 
        {
           if (bucket.capacity - bucket.amount > this.amount)
            {
                bucket.amount += this.amount;
                this.amount = 0;
            }
           else
            {
                int am = bucket.capacity - bucket.amount;
                bucket.amount += am;
                this.amount -= am;
            }
        }
        public override string ToString() 
        {
            string b = $"capacity = {this.capacity} amount = {this.amount}";
            return b;
            
        }

    }
}
