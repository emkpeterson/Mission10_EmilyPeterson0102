using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mission10_EmilyPeterson0102.Data
{
    public class Team
    {
        [Key]
        [Required]
        [DefaultValue(0)]
        public int TeamID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TeamName { get; set; }
        public int ? CaptainID { get; set; }
    }
}
