using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeviceManagement.Models;
using DeviceManagement.Core;
using System.Reflection;

namespace DeviceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobsController : ControllerBase
    {
        private readonly MobileContext _context;
        private Core.BusinessLL BLL;
        public MobsController()
        {
            BLL = new BusinessLL();
        }
        [HttpGet]
        [Route("Read")]
        public List<Mob> GetMobs()
        {
            return BLL.GetMobs();
        }
        [HttpPost]
        [Route("Post")]
        public void PostMobs([FromBody] Mob mobile)
        {
            BLL.PostMobs(mobile);
        }
        [HttpDelete]
        [Route("Delete")]
        public void DeleteMobile(int MobId)
        {
            BLL.DeleteMobile(MobId);
        }

        //// GET: api/Mobs
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Mob>>> GetMobs()
        //{
        //    return await _context.Mobs.ToListAsync();
        //}

        //// GET: api/Mobs/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Mob>> GetMob(int id)
        //{
        //    var mob = await _context.Mobs.FindAsync(id);

        //    if (mob == null)
        //    {
        //        return NotFound();
        //    }

        //    return mob;
        //}

        //// PUT: api/Mobs/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMob(int id, Mob mob)
        //{
        //    if (id != mob.MobId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(mob).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MobExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Mobs
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Mob>> PostMob(Mob mob)
        //{
        //    _context.Mobs.Add(mob);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetMob", new { id = mob.MobId }, mob);
        //}

        //// DELETE: api/Mobs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteMob(int id)
        //{
        //    var mob = await _context.Mobs.FindAsync(id);
        //    if (mob == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Mobs.Remove(mob);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool MobExists(int id)
        //{
        //    return _context.Mobs.Any(e => e.MobId == id);
        //}
    }
}
