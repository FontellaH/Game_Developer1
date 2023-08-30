class Attack   //created the class Attack
{
    public string Name;  //field name
    public int DamageAmount; //field DamageAmount

    public Attack(string name, int damageAmount)  // constructor a method to that is called to make a new Attack obj
    {
        Name = name;  //value name Assigned
        DamageAmount = AttackDamageAmount(damageAmount);  // value damagedAmount assigned
    }

    int AttackDamageAmount(int damageAmount)  // this method is checking if its too high or low
    {
        if (damageAmount < 5)
        {
            return 5;
        }
        else if (damageAmount > 20)
        {
            return 25;
        }
        return damageAmount;  // if nothing changes it will keep it as it is
    }
}