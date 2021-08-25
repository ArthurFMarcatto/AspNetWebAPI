using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProfessorController : ControllerBase
    {
        private readonly SmartContext _context;
        public ProfessorController(SmartContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult get()
        {
            return Ok(_context.Professores);
        }

        [HttpGet("{ID}")]
        public IActionResult GetById(int ID)
        {
            var professor = _context.Professores.FirstOrDefault(a => a.ID == ID);
            if (professor == null) return BadRequest("Professor não encontrado");
            return Ok(professor);
        }
        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {

            var pro = _context.Professores.AsNoTracking().FirstOrDefault(a => a.ID == id);
            if (pro == null) return BadRequest("Professor não encontrado!");
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var pro = _context.Professores.AsNoTracking().FirstOrDefault(a => a.ID == id);
            if (pro == null) return BadRequest("Professor não encontrado!");
            
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _context.Professores.FirstOrDefault(a => a.ID == id);
            if (professor == null) return BadRequest("Professor não encontrado!");
            _context.Remove(professor);
            _context.SaveChanges();
            return Ok();
        }


    }
}