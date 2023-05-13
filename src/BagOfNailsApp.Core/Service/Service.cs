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

        public float GetTotalWeight(float totalWeight)
        {
            return Bag.totalWeight = totalWeight;
        }

        public float? GetWeights(bool isRandom, float? weight, float totalWeight)
        {
            Random rand = new Random();
            var bagOfNails = new BagOfNails();
            float min = 0;
            float max = totalWeight;
            if (isRandom)
            {
                return Nail.weight = (float) rand.NextDouble() * (max - min) + min;
            }
            else { return Nail.weight = weight; }
        }

        public int GetTotalNailsNumber(float totalWeight, bool isRandom, float weight)
        {
            return (int) (GetTotalWeight(totalWeight)/ GetWeights(isRandom, weight, totalWeight)); 
        }

    }
}
