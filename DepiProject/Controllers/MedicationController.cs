using DepiProject.Models;
using DepiProject.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DepiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicationController : ControllerBase
    {
        private readonly IMedicationRepository _medicationRepository;

        public MedicationController(IMedicationRepository medicationRepository)
        {
            _medicationRepository = medicationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var medications = await _medicationRepository.GetAllAsync();
            return Ok(medications);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var medication = await _medicationRepository.GetByIdAsync(id);
            if (medication == null) return NotFound();
            return Ok(medication);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Medication medication)
        {
            await _medicationRepository.AddAsync(medication);
            return CreatedAtAction(nameof(GetById), new { id = medication.ID }, medication);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Medication medication)
        {
            if (id != medication.ID) return BadRequest();
            await _medicationRepository.UpdateAsync(medication);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _medicationRepository.DeleteAsync(id);
            return NoContent();
        }
    }

}
