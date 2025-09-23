using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
    public class Direction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte direction_id { get; set; }
        [Required]
        public string direction_name { get; set; }
        
    }
}
