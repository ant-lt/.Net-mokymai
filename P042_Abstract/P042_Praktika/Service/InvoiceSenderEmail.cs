using P042_Praktika.Interface;
using P042_Praktika.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Service
{
    public class InvoiceSenderEmail : IInvoiceSenderService
    {
        public void Send(Invoice invoice)
        {
            Console.WriteLine("sending EMAIL");
        }
    }
}
