using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IShip
    {
        string ID { get; set; }
        int Length { get; set; }
        int Orientation { get; set; }
        GridCell StartLocation { get; set; }
        GridCell[] SectionLocations { get; set; }
        bool SunkFlag { get; set; }

        void SetOrientation(int orientation);
        void SetStartLocation(GridCell startLocation);
        void UpdateSectionLocations();
        void UpdateSunkFlag();
        bool GetSunkFlag();
    }
}
