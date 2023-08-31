class McleeFighter : Enemy   //inh
{
   

    public McleeFighter(string name) : base(name)  // added the base to inharent the enemy class
    {

        Health = 120;

    }

    public void Rage()
    {
        if (AttackList.Count == 0)  // this is the attack to let me know that they have no attacks left
        {
            Console.WriteLine($"{Name} has no attacks left!");
            return;
        }

        Random random = new Random();
        Attack randomAttack = AttackList[random.Next(AttackList.Count)];
        int extraDamage = 10;

        Console.WriteLine($"{Name} is going into a ballistic rage and attacked {randomAttack.Name} for {randomAttack.DamageAmount + extraDamage} damage!");
    }
}