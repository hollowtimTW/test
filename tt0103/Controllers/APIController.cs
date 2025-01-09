using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tt0103.Models;

namespace tt0103.Controllers
{
    [Route("api")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly ESQtempdatabasedbContext _dbContext;
        public APIController(ESQtempdatabasedbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("Record")]
        public IActionResult GetRecords()
        {
            var res = _dbContext.Records.ToList();
            return Ok(res);
        }

        [HttpGet("Category")]
        public IActionResult GetCategories()
        {
            var res = _dbContext.Categories.ToList();
            return Ok(res);
        }

        [HttpPost("Category")]
        public IActionResult AddCategory([FromBody] Category category)
        {
            var existingCategory = _dbContext.Categories.FirstOrDefault(p => p.CategoryName == category.CategoryName);
            if (existingCategory != null)
            {
                return BadRequest("已有相同名稱");
            }

            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return Ok(category);
        }

        [HttpDelete("Category/{CategoryId}")]
        public IActionResult DelCategory(int CategoryId)
        {
            var res = _dbContext.ChildCategories.Where(p => p.CategoryId == CategoryId).ToList();
            return Ok(res);
        }


        [HttpGet("ChildCategory/{CategoryId}")]
        public IActionResult GetChildCategories(int CategoryId)
        {
            var res = _dbContext.ChildCategories.Where(p => p.CategoryId == CategoryId).ToList();
            return Ok(res);
        }
    }
}
