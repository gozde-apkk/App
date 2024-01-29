using api.Data;
using api.Dto.Stock;
using api.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var stocks = _context.Stock.ToList().Select(s => s.ToStockDto());
            return Ok(stocks); 
        }

        [HttpGet("{id}")]
        public IActionResult GetStockById(int id) 
        {
            var stock = _context.Stock.Find(id);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock.ToStockDto());
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateStockRequestDto stockDto)
        {
            var stockModel = stockDto.ToStockFromCreateDTO();
            _context.Stock.Add(stockModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetStockById), new {id = stockModel.Id}, stockModel.ToStockDto());

        }
    }

}
