using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public interface IShip
    {
        string ID { get; }
        ShipTypes Type { get;}
        int Length { get; }
        bool SunkFlag { get; }
        int Orientation { get; set; }
        (int, int) StartLocation { get; set; }
        BoardSpace[] Sections { get; }

        void PlaceShip(GameBoard refGrid);
        void UpdateSunkFlag();
    }
}
