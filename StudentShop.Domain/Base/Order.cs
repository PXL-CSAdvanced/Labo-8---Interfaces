using StudentShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StudentShop.Domain.Base
{
    public abstract class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount
        {
            get
            {
                return this.OrderLines
                    .OfType<IHasPrice>()      // pakt alleen de orderlines die IHasPrice implementeren
                    .Sum(line => line.TotalPrice);

                //decimal total = 0m;
                //foreach (var line in this.OrderLines)
                //{
                //    if (line is IHasPrice pricedLine)
                //    {
                //        total += pricedLine.TotalPrice;
                //    }
                //}
                //return total;
            }
        }

        protected Order()
        {
            this.OrderDate = DateTime.Now;
        }

        private int GetNextLineNumber() => this.OrderLines.Count + 1;
        private void AddLine(OrderLine line)
        {
            line.LineNumber = GetNextLineNumber();
            this.OrderLines.Add(line);
        }

        public void AddTextLine(string text)
        {
            OrderLine newLine = new TextLine(text);
            AddLine(newLine);   
        }

        public void AddProductLine(Product product, int quantity) 
        {
            OrderLine newLine = new ProductLine(product.Name, product.Price, quantity);
            AddLine(newLine);
        }

        public string PrintSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bestelnummer:\t{this.OrderNumber}");
            sb.AppendLine($"Klant:\t{this.CustomerName}");
            sb.AppendLine($"Levering:\t{this.DeliveryDate.ToLongDateString()}");
            sb.AppendLine("------------------------------");
            foreach (OrderLine line in this.OrderLines)
            {
                sb.AppendLine(line.Print());
            }
            return sb.ToString();
        }
    }
}
