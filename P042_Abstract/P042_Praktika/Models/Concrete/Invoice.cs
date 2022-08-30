using P042_Praktika.Interface;
using P042_Praktika.Models.Abstract;
using P042_Praktika.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Models.Concrete
{
    public class Invoice
    {
        private List<IInvoiceSenderService> _senders;

        public Invoice(List<IInvoiceSenderService> senders)
        {
            if (senders == null)
            {
                _senders = new List<IInvoiceSenderService>
                {
                    new InvoiceSenderEmail(),
                    new InvoiceSenderSms(),
                    new InvoiceSenderPost()
                };
            }
            else
            {
                _senders = senders;
            }
        }

        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public BookStorePerson Buyer { get; set; }
        public BookStoreLegalPerson Seller { get; set; }
        public List<Book> Items { get; set; }
        public void Send()
        {
            foreach (var sender in _senders)
            {
                sender.Send(this);
            }
        }

    }
}
