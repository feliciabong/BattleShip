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
		public void TestForShipThatHasBeenSelected ()
		{
			//default selection of ship is 'tug'
			Assert.IsTrue (DeploymentController.SelectedShip == ShipName.Tug);
			Assert.IsFalse (DeploymentController.SelectedShip == ShipName.Submarine);

			//the name of the ship occupying 2 rows is the 'submarine'
			DeploymentController.ShipSelection (2);
			Assert.IsTrue (DeploymentController.SelectedShip == ShipName.Submarine);
			Assert.IsFalse (DeploymentController.SelectedShip == ShipName.Tug);

			//the name of the ship occupying 3 rows is the 'destroyer'
			DeploymentController.ShipSelection (3);
			Assert.IsTrue (DeploymentController.SelectedShip == ShipName.Destroyer);
			Assert.IsFalse (DeploymentController.SelectedShip == ShipName.Submarine);

			//the name of the ship occupying 4 rows is the 'battleship'
			DeploymentController.ShipSelection (4);
			Assert.IsTrue (DeploymentController.SelectedShip == ShipName.Battleship);
			Assert.IsFalse (DeploymentController.SelectedShip == ShipName.Destroyer);

			//the name of the ship occupying 5 rows is the 'aircraftcarrier'
			DeploymentController.ShipSelection (5);
			Assert.IsTrue (DeploymentController.SelectedShip == ShipName.AircraftCarrier);
			Assert.IsFalse (DeploymentController.SelectedShip == ShipName.Battleship);
		}
	}
}

