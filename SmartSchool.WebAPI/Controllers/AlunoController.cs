using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using System.Linq;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AlunoController : ControllerBase{
        public List<Aluno>Alunos = new List<Aluno>(){
            new Aluno(){
                ID = 1, Nome="Arthur", Sobrenome="Marcatto", telefone="16997981996"
            },
            new Aluno(){
                ID = 2, Nome="Daniele", Sobrenome="Marcatto", telefone="16993150772"
            },
            new Aluno(){
                ID = 3, Nome="Hilda", Sobrenome="Soares", telefone="16993150772"
            },
            new Aluno(){
                ID = 4, Nome="Daiane", Sobrenome="Traldi", telefone="16993150772"
            }
        };
        public AlunoController(){ }

        [HttpGet]
        public IActionResult get(){
            return Ok(Alunos);
        }

        [HttpGet("byID/{id}")]
        public IActionResult GetById(int ID){
            var aluno = Alunos.FirstOrDefault(a=>a.ID==ID);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string Nome){
            var aluno = Alunos.FirstOrDefault(a=>a.Nome.Contains(Nome));
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }

        [HttpGet("byLastName")]
        public IActionResult GetByLastName(string Sobrenome){
            var aluno = Alunos.FindAll(a=>a.Sobrenome.Contains(Sobrenome));
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }        

        [HttpGet("byNameLastName")]
        public IActionResult GetByNameLastName(string Nome, string Sobrenome){
            var aluno = Alunos.FirstOrDefault(a=>a.Nome.Contains(Nome) && a.Sobrenome.Contains(Sobrenome));
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno){
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno){
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno){
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            return Ok();
        }
        


                

    }
}