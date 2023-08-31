class MagicCastor : Enemy
{

    public MagicCastor(string name) : base(name)
    {
        Health = 80; // Set default health to 80
    }

    public void Heal(Enemy target)  // this method is targeting the name of the attacker to to heal them
    {
        target.Health += 40; // Heal the target by adding 40 to their health
        Console.WriteLine($"{Name} is using a healing spell on {target.Name}, to increase the health {target.Health}!");
    }

}