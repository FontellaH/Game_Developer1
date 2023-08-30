class Enemy  // class Enemy
{
    string Name; //field name
    int Health; //field health
    List<Attack> AttackList; //storing info about the enemy and the list of attacks it can use

    public Enemy(string name)  // constructor a method to that is called to make a new Enemy obj
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void AddAttack(Attack attack)  // the method to add the attack to the an enmy
    {
        AttackList.Add(attack);
    }

    public void RandomAttack()  // this is the attack to let me know that they have no attacks left
    {
        if (AttackList.Count == 0)
        {
            Console.WriteLine($"{Name} has no attacks!");
            return;
        }

        Random random = new Random();  // making a random object to make a number
        Attack randomAttack = AttackList[random.Next(AttackList.Count)];  // picking a random Attack in the list

        Console.WriteLine($"{Name} is attacking {randomAttack.Name} for {randomAttack.DamageAmount} damage!");
    }
}