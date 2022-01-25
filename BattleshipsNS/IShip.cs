using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IShip
    {
        string ID { get; }
        int Length { get; }
        int Orientation { get; set; }
        GridCell StartLocation { get; set; }
        GridCell[] SectionLocations { get; }
        bool SunkFlag { get; }

        void UpdateSectionLocations();
        void UpdateSunkFlag();
    }
}
