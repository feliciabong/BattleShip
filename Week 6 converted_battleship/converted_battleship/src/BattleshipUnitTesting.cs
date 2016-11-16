using System;
using NUnit.Framework;
using SwinGameSDK;


namespace BattleShips
{
	public class BattleshipUnitTesting
	{
		[Test()]
		public void MenuSetuptAction ()
		{
			MenuController.PerformSetupMenuAction (1);

			Assert.IsFalse(GameController.AiSetting == AIOption.Easy);  
			Assert.IsTrue (GameController.AiSetting == AIOption.Medium); 
			Assert.IsFalse (GameController.AiSetting == AIOption.Hard);

		}
	}
}

