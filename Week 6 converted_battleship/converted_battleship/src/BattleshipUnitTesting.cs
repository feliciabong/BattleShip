using System;
using NUnit.Framework;
using SwinGameSDK;


namespace BattleShips
{
	[TestFixture()]

	public class BattleshipUnitTesting
	{
		[Test ()]
		public void TestSetupMenuAction ()
		{
			MenuController.PerformSetupMenuAction (1);

			Assert.IsFalse(GameController.AiSetting == AIOption.Easy);  
			Assert.IsTrue (GameController.AiSetting == AIOption.Medium); 
			Assert.IsFalse (GameController.AiSetting == AIOption.Hard);
		}

		[Test()]
		public void TestMouseClickPositionSyncsWithPositionClicked ()
		{
			Point2D mouse = SwinGame.MousePosition ();
			int row = 0;
			int col = 0;
			mouse.Y = 280;
			mouse.X = 560;
			row = Convert.ToInt32(Math.Floor((mouse.Y - UtilityFunctions.FIELD_TOP) / (UtilityFunctions.CELL_HEIGHT + UtilityFunctions.CELL_GAP)));
			col = Convert.ToInt32(Math.Floor((mouse.X - UtilityFunctions.FIELD_LEFT) / (UtilityFunctions.CELL_WIDTH + UtilityFunctions.CELL_GAP)));
			if (row >= 0 & row < 40)
			{
				if (col >= 0 & col < 40)
				{
					UtilityFunctions.Message = "The ship is deployed";
				}
			}
			Assert.IsTrue(UtilityFunctions.Message == "The ship is deployed");
		}
	}
}

