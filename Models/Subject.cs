using System.ComponentModel.DataAnnotations;

namespace Assignment8.Models{

 public class Subject
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Subject_Name { get; set; }

        public string syllabus { get; set; }

        [Range(1,5)]
        public int credits { get; set; }
    }
}

