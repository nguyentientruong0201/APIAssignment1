using Microsoft.AspNetCore.Mvc;
using APIAssignment1.DTO;
using APIAssignment1.Interface;

namespace APIAssignment1.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private IToDoTaskService _service;

        public TaskController(IToDoTaskService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public DTOTask Get(int id)
        {
            return _service.GetTask(id);
        }

        [HttpGet]
        public List<DTOTask> Get()
        {
            return _service.GetAllTasks();
        }

        [HttpPost]
        public void Post([FromBody] DTOTask task)
        {
            _service.AddTask(task);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DTOTask task)
        {
            _service.UpdateTask(id, task);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.DeleteTask(id);
        }
    }
}