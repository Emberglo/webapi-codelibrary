using System;
using System.Collections.Generic;
using apilibrary.Models;
using apilibrary.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace apilibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly LibraryService _cs;

        public LibraryController(LibraryService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            try
            {
                return Ok(_cs.GetAll());
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{index}")]
        public ActionResult<Book> GetOne(int index)
        {
            try
            {
                return Ok(_cs.GetOne(index));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Book> Create([FromBody] Book newBook)
        {
            try
            {
                return Ok(_cs.Create(newBook));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{index}")]
        public ActionResult<String> Delete(int index)
        {
            try
            {
                return Ok(_cs.Delete(index));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{index}")]
        public ActionResult<Book> Edit(int index, [FromBody] Book editedBook)
        {
            try
            {
                return Ok(_cs.Edit(index, editedBook));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

    }
}