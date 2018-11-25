using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HackYeah_2018_.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
      //  public virtual User User { get; set; }
        public float Latitude { get; set; }
        public float Length { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

