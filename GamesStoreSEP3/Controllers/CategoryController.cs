using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesStoreSEP3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _categoryContext;

        public CategoryController(DataContext categoryContext)
        {
            _categoryContext = categoryContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categoryContext.Categories.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Category>>> GetCategoryById(int id)
        {

            var category = await _categoryContext.Categories.FindAsync(id);
            if (category == null)
                return BadRequest("Game not found");
            return Ok(category); 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Category>>> DeleteCategory(int id)
        {
            var category = await _categoryContext.Categories.FindAsync(id);
            if (category == null)
                return BadRequest("Category not found");

            _categoryContext.Categories.Remove(category);
            await _categoryContext.SaveChangesAsync();

            return Ok(await _categoryContext.Categories.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Category>>> AddCategory(Category category)
        {
            _categoryContext.Categories.Add(category);
            await _categoryContext.SaveChangesAsync();

            return Ok(await _categoryContext.Games.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Category>>> UpdateCategory(Category request)
        {
            var category = await _categoryContext.Categories.FindAsync(request.Id);
            if (category == null)
                return BadRequest("Category not found");

            category.Id = request.Id;
            category.Name = request.Name;
            category.Url = request.Url;


            await _categoryContext.SaveChangesAsync();

            return Ok(await _categoryContext.Categories.ToListAsync());
        } 
    }    
}

