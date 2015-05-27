using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FareManagement.DAL;
using FareManagement.Model;

namespace FareManagement.BLL
{
    class LoadManager
    {
        readonly LoadGatway _loadGatway = new LoadGatway();
        public List<Zone> LoadAllZone()
        {
            return _loadGatway.LoadAllZone();
        }

        public List<Visitor> LoadAllVisitorList(int zid)
        {
            return _loadGatway.LoadAllVisitorList(zid);
        }

        public List<ZoneWiseVisitor> LoadZoneWiseVisitors()
        {
            return _loadGatway.LoadZoneWiseVisitors();
        }

        public string TotalVisitor()
        {
            return _loadGatway.TotalVisitor();
        }
    }
}
