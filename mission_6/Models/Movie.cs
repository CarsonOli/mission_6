using System.ComponentModel.DataAnnotations;

namespace mission_6.Models
{
    public enum Rating
    {
        G,
        PG,
        [Display(Name = "PG-13")]
        PG13,
        R
    }

    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        [StringLength(50)]
        public string Director { get; set; }

        [Required]
        [Range(1888, 2100)]
        public int ReleaseYear { get; set; }

        [Required]
        public Rating Rating { get; set; }

        // optional
        public bool? Edited { get; set; }

        [StringLength(50)]
        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
