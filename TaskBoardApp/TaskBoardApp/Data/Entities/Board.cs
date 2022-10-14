namespace TaskBoardApp.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static TaskBoardApp.Data.DataConstants.Board;

    public class Board
    {
        public Board()
        {
            this.Tasks=new HashSet<Task>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxBoardName)]
        public string Name { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
