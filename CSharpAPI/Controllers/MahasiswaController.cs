using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using ServiceInterface.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private readonly IMahasiswaService mahasiswaService;
        public MahasiswaController(IMahasiswaService mahasiswaService)
        {
            this.mahasiswaService = mahasiswaService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Mahasiswa model)
        {
            var result = await mahasiswaService.Create(model);
            return Ok(result);
        }
        [HttpGet]
        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaService.GetAll();
            return result;
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await mahasiswaService.Delete(id);
            return Ok(result);
        }
    }
}
