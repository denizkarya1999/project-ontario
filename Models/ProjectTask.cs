using System.ComponentModel.DataAnnotations;

namespace Project.Ontario.Models
{
    public class ProjectTask
    {
        [Key] [Required]
        public Guid Id { get; set; }
        [Required]
        public string? TaskName { get; set; }
        public string? Description { get; set; }
        [Required]
        public string? TaskCategory { get; set; }
        [Required]
        public int NumberOfDevelopers { get; set; }
        [Required]
        public decimal CostOfTask { get; set; }
        [Required]
        public int EstimatedTime { get; set; }
    }
}
