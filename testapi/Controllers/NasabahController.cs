using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testapi.Models;
namespace testapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NasabahController : ControllerBase
    {
        private readonly ContextNasabah _context;
        public NasabahController(ContextNasabah context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<MNasabah>> GetNasabah()
        {
            return await _context.Nasabahs.ToListAsync();
        }

        [HttpPost]
        public async Task AddNasabah(MNasabah model)
        {
            
            await _context.Nasabahs.AddAsync(new MNasabah { 
                Nama = model.Nama,
                Alamat = model.Alamat,
                TTL = model.TTL,
                Tgl_Lahir = model.Tgl_Lahir,
                NoKTP = model.NoKTP,
                NoHP = model.NoHP


            });
            await _context.SaveChangesAsync();
        }

        [HttpPut("{id}")]
        public async Task UpdateNasabah(int id, MNasabah model)
        {

            var result = await _context.Nasabahs.FindAsync(id);
            result.Nama = model.Nama;
            result.Alamat = model.Alamat;
            result.TTL = model.TTL;
            result.Tgl_Lahir = model.Tgl_Lahir;
            result.NoKTP = model.NoKTP;
            result.NoHP = model.NoHP;

            await _context.SaveChangesAsync();
        }
        [HttpDelete("{id}")]
        public async Task DeleteProduct(int id)
        {
            var result = await _context.Nasabahs.FindAsync(id);
            _context.Remove(result);
            await _context.SaveChangesAsync();

        }

    }

    
}
