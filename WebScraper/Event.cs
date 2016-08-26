using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    public class Event
    {
        public string Artist { get; set; }
        public string City { get; set; }
        public string VenueName { get; set; }
        public DateTime Date { get; set; }
        public Decimal Price { get; set; }
    }
}
