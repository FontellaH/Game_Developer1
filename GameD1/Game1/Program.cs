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

//   Creating another enemy
Enemy enemy2 = new Enemy("Enemy2");
enemy2.AddAttack(punch); //adding the method punch and throwAttack
enemy2.AddAttack(throwAttack);

bandit.PerformAttack(enemy2, punch); // bandit is attacking the enemy2 with the punch method



//McleeFigther Attack List
McleeFighter enemy3 = new McleeFighter("Enemy3");

Attack punch1 = new Attack("Punch", 20);
Attack kick = new Attack("Kick", 15);
Attack tackle = new Attack("Tackle", 25);

// Add attacks to enemy's attack list
enemy3.AddAttack(punch1);
enemy3.AddAttack(kick);
enemy3.AddAttack(tackle);


//Ranged Fighter Attack List
RangedFighter enemy4 = new RangedFighter("Enemy4");

Attack arrowShot = new Attack("Arrow Shot", 20);
Attack throwKnife = new Attack("Throw a Knife", 15);

enemy4.AddAttack(arrowShot);
enemy4.AddAttack(throwKnife);



//MagicCator Attack List 

MagicCastor enemy5 = new MagicCastor("Enemy5");

Attack fireball2 = new Attack("Fireball2", 25);
Attack lightningBolt = new Attack("Lightning Bolt", 20);
Attack staffStrike = new Attack("Staff Strike", 10);

// Add the attacks to the AttackList of the Magic Caster
enemy5.AddAttack(fireball2);
enemy5.AddAttack(lightningBolt);
enemy5.AddAttack(staffStrike);