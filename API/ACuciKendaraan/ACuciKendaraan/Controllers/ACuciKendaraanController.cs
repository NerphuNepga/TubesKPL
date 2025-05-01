using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACuciKendaraan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ACuciKendaraanController : ControllerBase
    {
        private static readonly List<ACuciKendaraan> cucikendaraan = new()
        {
            new ACuciKendaraan("Supra","Motor",State.Masuk)
        };
        [HttpGet]
        public IEnumerable<ACuciKendaraan> Get()
        {
            return cucikendaraan;
        }
        [HttpGet("{id}")]
        public ACuciKendaraan GetId(int id)
        {
            return cucikendaraan[id];
        }
        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            cucikendaraan.RemoveAt(id);
            return "Data berhasil dihapus";
        }
        [HttpPost]
        public String Post([FromBody] ACuciKendaraan mhs)
        {
            cucikendaraan.Add(mhs);
            return "Data berhasil ditambah";
        }
        [HttpGet("GetProsesState/{id}")]
        public String GetProsesState(int id)
        {
            return ""+ cucikendaraan[id].GetState();
        }
        [HttpPost("Proses/{id}")]
        public String GetProses(int id, string input)
        {
            return cucikendaraan[id].ProsesLangkah(input);   
        }
    }
}
