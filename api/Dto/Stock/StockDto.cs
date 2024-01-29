using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        public string Symbol { get; set; } 
        public string CompanyName { get; set; } = string.Empty;

        public decimal Purchase { get; set; }  
        

        public decimal LastDiv { get; set; }
        public string Industry { get; set; }
        public long MarketCap { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}