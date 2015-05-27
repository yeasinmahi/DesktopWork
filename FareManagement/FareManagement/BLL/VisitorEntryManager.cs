using FareManagement.DAL;
using FareManagement.Model;

namespace FareManagement.BLL
{
    class VisitorEntryManager
    {
        bool isInsertVisitor = false;
        VisitorEntryGatway visitorEntryGatway = new VisitorEntryGatway();
        public string InsertVisitor(Visitor visitor)
        {
            
            if (visitorEntryGatway.HasEmail(visitor))
            {
                isInsertVisitor = false;
                return @"Email Can Not Be Dublicate";
            }
            else
            {
                if (visitorEntryGatway.InsertVisitor(visitor) > 0)
                {
                    isInsertVisitor = true;
                    return @"Insert Successfull";
                }
                else
                {
                    isInsertVisitor = false;
                    return @"Error In Insert";
                }
            }
        }

        public bool IsInsertVisitor
        {
            get { return isInsertVisitor; }
        }

        public int GetVisitorIdByEmail(Visitor visitor)
        {
            return visitorEntryGatway.GetVisitorIdByEmail(visitor);
        }

        public bool InsertVisitorAndZone(VisitorAndZone visitorAndZone)
        {
            return visitorEntryGatway.InsertVisitorAndZone(visitorAndZone) > 0;
        }
    }
}
