using MassTransit;
using MassTransitConsumer;
using Microsoft.AspNetCore.Mvc;

namespace MassTransitProducer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IBus _bus;
        public ProductController(IBus _bus)
        {
            this._bus = _bus;
        }
        [HttpPost("CreateProduct")]
        public async Task<IActionResult> Index(Product product)
        {

            try
            {
                await _bus.Publish(product, default);

                return Ok(product);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
