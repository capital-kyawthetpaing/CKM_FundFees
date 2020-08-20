using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    namespace CKMFundFees.Models
    {
        public class TransactionModel : BaseModel
        {
            public string TransactionDate { get; set; }
            public string TransactionType { get; set; }
            public string Member { get; set; }
            public string Amount { get; set; }
        }
    }
}
