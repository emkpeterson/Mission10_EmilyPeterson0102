using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_EmilyPeterson0102.Data
{
    public class Bowler
    {
        [Key]
        [Required]
        [DefaultValue(0)]
        public int BowlerID { get; set; }
        [MaxLength(50)]
        public string ? BowlerLastName { get; set; }
        [MaxLength(50)]
        public string ? BowlerFirstName { get; set; }
        [MaxLength(1)]
        public string ? BowlerMiddleInit { get; set; }
        [MaxLength(50)]
        public string ? BowlerAddress { get; set; }
        [MaxLength(50)]
        public string ? BowlerCity { get; set; }
        [MaxLength(2)]
        public string ? BowlerState { get; set; }
        [MaxLength(10)]
        public string ? BowlerZip { get; set; }
        [MaxLength(14)]
        public string ? BowlerPhoneNumber { get; set; }
        [ForeignKey("Team")]
        public int ? TeamID { get; set; }

    }
}
