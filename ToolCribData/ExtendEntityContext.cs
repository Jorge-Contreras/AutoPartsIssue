using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolCribData
{
    public partial class GeneralTablesEntities
    {
        public Transactions_Not_Entered GetNextPartToUpdate()
        {

            return this.Transactions_Not_Entered.OrderBy(y => y.PartNumber).FirstOrDefault();

        }

        public bool CheckIfZero()
        {

            if (this.Transactions_Not_Entered.Count() == 0) { return true; } else { return false; }

        }


        public void PartUpdated(Guid PartId)
        {

            var PartToUpdate = this.TranDetails.Where(x => x.TranDetailID == PartId).FirstOrDefault();

            PartToUpdate.MasonUpdated = true;
            PartToUpdate.Comment = "";
            this.SaveChanges();
        }

        public void PartError(Guid PartId)
        {
            var PartToUpdate = this.TranDetails.Where(x => x.TranDetailID == PartId).FirstOrDefault();
            PartToUpdate.MasonUpdated = true;
            PartToUpdate.Comment= "ManualEntry";
            this.SaveChanges();
        }


        public List<Transactions_Not_Entered> GetAllTransactions()
        {

            return this.Transactions_Not_Entered.ToList();


        }

        public List<Manual_Entry_Transactions> GetAllManualTransactions()
        {

            return this.Manual_Entry_Transactions.ToList();


        }


        public List<string> GetAllPendingTransactions()
        {
            var returnDic = new List<String>();
            var ManualEntryCount = Transactions_Not_Entered.Count();
            if (ManualEntryCount == 0)
            {
                returnDic.Add("No Pending Transactions");

            }
            else
            {
               returnDic= this.Transactions_Not_Entered.OrderBy(y => y.PartNumber).Select(x => x.Qty + " -- " + x.PartNumber + "--" + x.Description).ToList();
            }

            return returnDic;
        }

        public Dictionary<Guid,string> GetAllManualEntry()
        {
            var returnDic = new Dictionary<Guid,String>();
            var ManualEntryCount = Manual_Entry_Transactions.Count();
            if (ManualEntryCount==0)
            {
                returnDic.Add(Guid.NewGuid(), "No Manual Entries");

            }
            else{
                returnDic = this.Manual_Entry_Transactions.ToDictionary(x => x.TranDetailID, x => x.Qty + " -- " + x.PartNumber + "--" + x.Department + "--" + x.Description);
                
            
            }

            return returnDic;
            
        }

    }
}
