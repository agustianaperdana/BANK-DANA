using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testapi.Models;
namespace testapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //test git
    public class TestController : ControllerBase
    {
        private readonly ContextNasabah _context;
        public TestController(ContextNasabah context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<MTest01>> GetTest()
        {
            return await _context.test01s.ToListAsync();
        }


        [HttpPost]
        public async Task AddTest(MTest01 model)
        {

            await _context.test01s.AddAsync(new MTest01
            {
                Nama = model.Nama,
                Status = model.Status,
                Created = model.Created,
                Updated = model.Updated,
              


            });
            await _context.SaveChangesAsync();
        }

        [HttpPut("{id}")]
        public async Task UpdateTest(int id, MTest01 model)
        {

            var result = await _context.test01s.FindAsync(id);
            result.Nama = model.Nama;
            result.Status = model.Status;
            result.Created = model.Created;
            result.Updated = model.Updated;
         

            await _context.SaveChangesAsync();
        }
        [HttpDelete("{id}")]
        public async Task DeleteTest(int id)
        {
            var result = await _context.test01s.FindAsync(id);
            _context.Remove(result);
            await _context.SaveChangesAsync();

        }

    }


}
