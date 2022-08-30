using P042_Praktika.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Interface
{
    public interface IInvoiceSenderService
    {
        void Send(Invoice invoice);
    }
}
