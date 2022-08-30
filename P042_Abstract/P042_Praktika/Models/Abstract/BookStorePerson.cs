using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Models.Abstract
{
    public abstract class BookStorePerson
    {
        public string Code { get; set; }
        public virtual string PhoneNo { get; set; }
        public virtual string Address { get; set; }
    }
}
