using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    class Ship : IShip
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
		}

		public void UpdateSunkFlag()
		{
		}

		public bool GetSunkFlag()
		{
			return sunkFlag;
		}
    }
}
