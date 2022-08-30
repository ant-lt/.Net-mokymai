﻿using P042_Praktika.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Models.Concrete
{
    public class PaperbackBook: Book
    {
        public override void SetDataTo(BookHtml bookHtml)
        {
            base.SetDataTo(bookHtml);
            bookHtml.PaperbackPrice = Price.ToString();
        }
    }
}
