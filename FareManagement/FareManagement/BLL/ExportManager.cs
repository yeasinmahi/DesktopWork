using FareManagement.DAL;

namespace FareManagement.BLL
{
    class ExportManager
    {
        ExportGatway exportGatway = new ExportGatway();

        public bool ExportToExcel(int zid, string name)
        {
            return exportGatway.ExportToExcel(zid,name);
        }
    }
}
