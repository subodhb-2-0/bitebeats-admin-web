namespace BiteBeats.Core.Entities.Entity
{
    public class BaseDbEntity
    {
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set;}
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set;}
        public bool IsDeleted { get; set; }
    }
}
