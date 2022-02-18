using APIAssignment1.DB;
using APIAssignment1.DTO;
using APIAssignment1.Entities;
using APIAssignment1.Interface;

namespace APIAssignment1.Services
{
    public class ToDoTaskService : IToDoTaskService
    {
        private TaskContext _context;

        public ToDoTaskService(TaskContext context)
        {
            _context = context;
        }

        public void AddTask(DTOTask task)
        {
            _context.Tasks.Add(new ToDoTask() { Title = task.Title, IsCompleted = task.IsCompleted });
            _context.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public List<DTOTask> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public DTOTask GetTask(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(int id, DTOTask task)
        {
            throw new NotImplementedException();
        }
    }
}