using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface Ship : IShip
    {
		// Instance Variables
		int length;
		gridCell[] sections;
		bool sunkFlag;

		// Constructor Declaration of Class
		Ship(int length)
		{
			this.length = length;
			sections = new gridCell[length];
			sunkFlag = false;
		}

		public void SetShipPosition(GridCell startingPosition, int orientation)
		{
			return;
		}

		public void UpdateSunkFlag();
		{
			return;
		}

		public bool GetSunkFlag();
		{
			return sunkFlag;
		}
    }
}
