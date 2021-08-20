using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using System.Linq;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProfessorController : ControllerBase{
        public List<Professor>Professor = new List<Professor>(){
            new Professor(){
                ID = 1, Nome="Arthur", Sobrenome="Marcatto", telefone="16997981996"
            },
            new Professor(){
                ID = 2, Nome="Daniele", Sobrenome="Marcatto", telefone="16993150772"
            },
            new Professor(){
                ID = 3, Nome="Hilda", Sobrenome="Soares", telefone="16993150772"
            },
            new Professor(){
                ID = 4, Nome="Daiane", Sobrenome="Traldi", telefone="16993150772"
            }
        };
        public ProfessorController(){ }

        [HttpGet]
        public IActionResult get(){
            return Ok(Professor);
        }

        [HttpGet("{ID}")]
        public IActionResult GetById(int ID){
            var professor = Professor.FirstOrDefault(a=>a.ID==ID);
            if (professor == null) return BadRequest("Aluno não encontrado");
            return Ok(professor);
        }  

    }
}