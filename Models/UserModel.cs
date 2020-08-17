using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserModel : BaseModel
    {
        public string MemberID { get; set; }
        public String MemberName { get; set; }
        public String Password { get; set; }
    }
}
