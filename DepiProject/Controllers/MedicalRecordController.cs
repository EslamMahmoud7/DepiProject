using DepiProject.Models;
using DepiProject.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DepiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicalRecordController : ControllerBase
    {
        private readonly IMedicalRecordRepository _medicalRecordRepository;

        public MedicalRecordController(IMedicalRecordRepository medicalRecordRepository)
        {
            _medicalRecordRepository = medicalRecordRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var medicalRecords = await _medicalRecordRepository.GetAllAsync();
            return Ok(medicalRecords);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var medicalRecord = await _medicalRecordRepository.GetByIdAsync(id);
            if (medicalRecord == null) return NotFound();
            return Ok(medicalRecord);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MedicalRecord medicalRecord)
        {
            await _medicalRecordRepository.AddAsync(medicalRecord);
            return CreatedAtAction(nameof(GetById), new { id = medicalRecord.ID }, medicalRecord);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MedicalRecord medicalRecord)
        {
            if (id != medicalRecord.ID) return BadRequest();
            await _medicalRecordRepository.UpdateAsync(medicalRecord);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _medicalRecordRepository.DeleteAsync(id);
            return NoContent();
        }
    }

}
