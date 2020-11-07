using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EntryModel:BaseModel
    {
        public string PageName { get; set; }
        public string CanRead { get; set; }
        public string CanWrite { get; set; }
        public string CanDelete { get; set; }
        public string PageID { get; set; }
    }
}
