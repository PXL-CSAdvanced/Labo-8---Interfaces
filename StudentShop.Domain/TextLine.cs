using StudentShop.Domain.Base;
using StudentShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Domain
{
    public class TextLine : OrderLine, ICanPrint
    {
        public string Text { get; set; }

        internal TextLine(string text) 
        { 
            this.Text = text;
        }

        public override string Print()
        {
            return this.Text;
        }
    }
}
