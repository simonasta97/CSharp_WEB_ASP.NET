namespace TaskBoardApp.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static TaskBoardApp.Data.DataConstants.Task;

    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxTaskTitle)]
        public string Title { get; set; }

        [Required]
        [MaxLength(MaxTaskDescription)]
        public string Description { get; set; }

        public DateTime? CreatedOn { get; set; }

        [ForeignKey(nameof(Board))]
        public int BoardId { get; set; }

        public virtual Board Board { get; set; }

        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; }
        public virtual User Owner { get; set; }
    }
}
