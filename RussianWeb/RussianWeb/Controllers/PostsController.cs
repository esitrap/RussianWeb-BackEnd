using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RussianWeb.Models;

namespace RussianWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly RussianWebDbContext _context;

        public PostsController(RussianWebDbContext context)
        {
            _context = context;
        }

        // GET: api/Posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        // // GET: api/Posts/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<Post>> GetPost(string id)
        // {
        //     var post = await _context.Posts.FindAsync(id);

        //     if (post == null)
        //     {
        //         return NotFound();
        //     }

        //     return post;
        // }

        //**//
        // GET: api/Posts/lkfls
        [HttpGet("{onvan}")]
        public async Task<ActionResult<Post>> GetPost(string onvan)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(x => x.Onvan == onvan);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }
        //**//

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(string id, Post post)
        {
            if (id != post.Onvan)
            {
                return BadRequest();
            }

            _context.Entry(post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Posts
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPost", new { id = post.Onvan }, post);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Post>> DeletePost(string id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return post;
        }

        private bool PostExists(string id)
        {
            return _context.Posts.Any(e => e.Onvan == id);
        }
    }
}
