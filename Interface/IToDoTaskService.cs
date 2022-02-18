using APIAssignment1.DTO;

namespace APIAssignment1.Interface
{
    public interface IToDoTaskService
    {
        void AddTask(DTOTask task);

        List<DTOTask> GetAllTasks();

        DTOTask GetTask(int id);

        void UpdateTask(int id, DTOTask task);

        void DeleteTask(int id);
    }
}