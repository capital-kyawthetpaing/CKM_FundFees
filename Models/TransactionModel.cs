using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TransactionModel : BaseModel
    {
        public string TransactionID { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string Amount { get; set; }
        public string Remarks { get; set; }
    }
}
