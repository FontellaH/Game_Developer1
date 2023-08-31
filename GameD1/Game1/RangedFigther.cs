class RangedFighter : Enemy
{

    int Distance;  // Distance field to track how far the enemy is


    public RangedFighter(string name) : base(name)
    {

        Distance = 5;  // Initialize Distance to 5 when creating a RangedFighter instance
        AttackList = new List<Attack>() { new Attack("Shoot an Arrow", 20), new Attack("Throw a knife", 15) };
    }

    public void Dash()
    {
        Distance = 20;  // Set the Distance to 20 when performing a dash
        Console.WriteLine($"{Name} dashes and now has a distance of {Distance}!");
    }

    public override void PerformAttack(Enemy target, Attack chosenAttack)
    {
        if (Distance >= 10)
        {
            base.PerformAttack(target, chosenAttack);
        }
        else
        {
            Console.WriteLine("Sorry, you need to back up to get more distance");
        }
    }

}


