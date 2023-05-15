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

        /*** Implemento il metodo che mi permette di inserire il peso del singolo chiodo. Il metodo permette di inserire il peso all'utente o 
         * provvede alla generazione randomica del peso, a seconda della scelta dell'utente ***/
        public float? GetWeights(bool isRandom, float? weight, float totalWeight)
        {
            Random rand = new Random();
            float min = 0;
            float max = totalWeight;
            if (isRandom)
            {
                return Nail.weight = (float) rand.NextDouble() * (max - min) + min;
            }
            else 
            { 
                return Nail.weight = weight; 
            }
        }

        /*** Implemento il metodo che mi permette di sapere il numero di chiodi nel sacchetto. Il metodo prende il peso totale del sacchetto, il peso unitario 
         * del chiodo (inserito dall'utente o generato casualmente) ed effettua una divisione tra il primo e il secondo dato, restituendo il risultato ***/
        public int GetTotalNailsNumber(float totalWeight, bool isRandom, float weight)
        {
            return (int) (GetTotalWeight(totalWeight) / GetWeights(isRandom, weight, totalWeight)); 
        }
    }
}
