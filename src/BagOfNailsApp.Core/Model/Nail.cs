namespace BagOfNailsApp.Core.Model;

/*** Ho una bilancia e un sacco pieno di chiodi. Quanti chiodi ho nel sacco? ***/
public class Nail
{
    public float? weight;

    public bool isRandom;

    public Nail(float weight)
    {
        weight = weight;
    }

    public Nail()
    {
    }

    public float Weight { get; set; }

}

