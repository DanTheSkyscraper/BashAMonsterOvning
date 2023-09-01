using Bash;

Player one = new Player();
Player two = new Player();
Enemy spider = new Enemy();
Enemy boar = new Enemy();

one.Health = 200;
two.Health = 250;
one.Damage = 25;
two.Damage = 50;

one.Health -= two.Damage;

spider.Endurance = 25;
boar.Endurance = 75;
spider.Strength = 7;
boar.Strength = 15;






Console.ReadLine();