namespace api.Dto.Stock
{
    public class UpdateStockRequestDto
    {

        public string Symbol { get; set; }
        public string CompanyName { get; set; } = string.Empty;

        public decimal Purchase { get; set; }


        public decimal LastDiv { get; set; }
        public string Industry { get; set; }
        public long MarketCap { get; set; }
    }
}
