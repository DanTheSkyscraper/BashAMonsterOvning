namespace Bash;
public class Enemy
{
    public int Endurance = 100;
    public int Strength = 10;

    public int maxEndurance = 100;

    public Enemy()
    {
        maxEndurance = new Random().Next(50, 110); //Randomize Endurance for enemies

        ResetEndurance();
    }

    public void ResetEndurance()
    {
        Endurance = maxEndurance;
    }

    //Health:int
    //Damage:int
}