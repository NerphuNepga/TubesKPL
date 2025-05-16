using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TubesKPL;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ACuciKendaraanController : ControllerBase
    {
        ProsesCuci proses = new TubesKPL.ProsesCuci();

        private static readonly List<ACuciKendaraan> cucikendaraan = new()
        {
            new ACuciKendaraan("Supra", "Motor")
        };

        [HttpGet]
        public IEnumerable<ACuciKendaraan> Get()
        {
            // Postcondition
            var result = cucikendaraan;
            Debug.Assert(result != null, "Postcondition failed: result should not be null");
            return result;
        }

        [HttpGet("{id}")]
        public ActionResult<ACuciKendaraan> GetId(int id)
        {
            // Precondition
            if (id < 0 || id >= cucikendaraan.Count)
                return NotFound("ID di luar jangkauan.");

            var kendaraan = cucikendaraan[id];
            Debug.Assert(kendaraan != null, "Postcondition failed: kendaraan should not be null");
            return kendaraan;
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            // Precondition
            if (id < 0 || id >= cucikendaraan.Count)
                return NotFound("ID tidak valid.");

            cucikendaraan.RemoveAt(id);

            // Postcondition
            Debug.Assert(cucikendaraan.Count >= 0, "Postcondition failed: invalid list state after deletion");

            return "Data berhasil dihapus";
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] ACuciKendaraan kendaraan)
        {
            // Precondition
            if (kendaraan == null)
                return BadRequest("Data kendaraan tidak boleh null.");
            if (string.IsNullOrWhiteSpace(kendaraan.namaKendaraan) || string.IsNullOrWhiteSpace(kendaraan.jenisKendaraan))
                return BadRequest("Nama dan Tipe tidak boleh kosong.");

            cucikendaraan.Add(kendaraan);

            // Postcondition
            Debug.Assert(cucikendaraan.Contains(kendaraan), "Postcondition failed: data tidak ditambahkan");

            return "Data berhasil ditambah";
        }

        [HttpPost("Proses/{id}")]
        public ActionResult<string> Proses(int id, [FromQuery] string input)
        {
            // Precondition
            if (id < 0 || id >= cucikendaraan.Count)
                return NotFound("ID kendaraan tidak ditemukan.");
            if (string.IsNullOrWhiteSpace(input))
                return BadRequest("Input proses tidak boleh kosong.");

            var result = proses.kerjakanAPI(cucikendaraan[id], input);

            // Postcondition
            Debug.Assert(!string.IsNullOrWhiteSpace(result), "Postcondition failed: result tidak valid");

            return result;
        }
    }
}
