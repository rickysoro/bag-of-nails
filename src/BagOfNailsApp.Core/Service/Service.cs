using BagOfNailsApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfNailsApp.Core.Service
{
    public class Service
    {
        public Service() 
        { }

        BagOfNails Bag = new BagOfNails();
        Nail Nail = new Nail();

        public void GetTotalWeight(float totalWeight)
        {
            Bag.totalWeight = totalWeight;
        }

        public void GetWeights(bool isRandom, float? weight)
        {
            Random rand = new Random();
            float min = 0;
            float max = Bag.totalWeight;
            if (isRandom)
            {
                Nail.weight = (float) rand.NextDouble() * (max - min) + min;
            }
            else { Nail.weight = weight; }
            
            Nail.isRandom = isRandom;
        }

        public int GetTotalNailsNumber()
        {
            return (int) (Bag.totalWeight / Nail.weight);
        }

    }
}
