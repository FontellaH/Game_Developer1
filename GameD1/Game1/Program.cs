// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");



// Create attack instances
Attack fireball = new Attack("Fireball", 20); //attack with the name "Fireball" and damage 20.
Attack punch = new Attack("Punch", 10);  // attack with the name "Punch" and damage 10.
Attack throwAttack = new Attack("Throw", 15);  //attack with the name "Throw" and damage 15.


// Create enemy instance
Enemy bandit = new Enemy("Bandit");


 // Add attacks to enemy's attack list
        bandit.AddAttack(fireball);
        bandit.AddAttack(punch);
        bandit.AddAttack(throwAttack);

        // Test random attack
        for (int i = 0; i < 5; i++)  //set var to equal 0... and keeps running the loop until it reaches 5 and it will stop
        {
            bandit.RandomAttack(); //generating random attacks
        }
