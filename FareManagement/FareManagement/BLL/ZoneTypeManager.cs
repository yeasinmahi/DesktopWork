using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FareManagement.DAL;

namespace FareManagement.BLL
{
    class ZoneTypeManager
    {
        ZoneTypeGatway zoneTypeGatway = new ZoneTypeGatway();

        public bool InsertZone(string zoneName)
        {
            return zoneTypeGatway.InsertZone(zoneName) > 0;
        }
    }
}
