using System;

namespace TextBasedRPG

{
	public class BabyEnemy
	{
		public int BabyHealth = 100;
		public string BabyWeapon = "Bottle";
		public int BabyAttack = 5;

		public BabyEnemy ()
		{
		}

		public void BabyRage ()
		{
			BabyAttack = BabyAttack + 1;
		}
		public void resetAttack ()
		{
			BabyAttack = 0;
		}
		public void BabyHit (int hit)
		{
			BabyHealth = BabyHealth - hit;
		}

	}
}

