using System;

namespace TextBasedRPG

{
	public class Player
	{
		//Every player starts with this
		public int Health = 15;
		public string Weapon = "Unarmed";
		public int Level = 0;
		public int Score = 0;
		public string Name = "unknown";
		public string Path = "unknown";
		public int attackPower = 1;

		public Player ()
		{
		}
			
		public void ChosenPath (string noPath)
		{
			Path = noPath;
		}
		
		public void takeDamage (int damage)
		{
			Health = Health - damage;
		}
		public void gainLevel (int exp)
		{
			Level = Level + exp;
		}
		public void scoreIncrease (int points)
		{
			Score = Score + points;
		}
		
		public void foundRubberBoots()
		{
			Health = Health + 5;
		}
		public void defeatBabyEnemy()
		{
			Level = Level + 1;
			Score = Score + 100;
		}
		

	}
}

