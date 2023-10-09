using ToDo.Domain.Enums;

namespace ToDo.Domain.Entities
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } = null!;
        public string TaskDescription { get; set; } = null!;
        public PriorityEnum Priority { get; set; }
        public StatusEnum Status { get; set; }
    }
}
