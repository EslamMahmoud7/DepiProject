using DepiProject.Models;
using DepiProject.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DepiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillingController : ControllerBase
    {
        private readonly IBillingRepository _billingRepository;

        public BillingController(IBillingRepository billingRepository)
        {
            _billingRepository = billingRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var billings = await _billingRepository.GetAllAsync();
            return Ok(billings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var billing = await _billingRepository.GetByIdAsync(id);
            if (billing == null) return NotFound();
            return Ok(billing);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Billing billing)
        {
            await _billingRepository.AddAsync(billing);
            return CreatedAtAction(nameof(GetById), new { id = billing.ID }, billing);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Billing billing)
        {
            if (id != billing.ID) return BadRequest();
            await _billingRepository.UpdateAsync(billing);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _billingRepository.DeleteAsync(id);
            return NoContent();
        }
    }

}
