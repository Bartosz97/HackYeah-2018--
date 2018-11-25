using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HackYeah_2018_.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
    
        //[Required]
        //[ForeignKey("Rank")]
        //public int RankId { get; set; }
        //public Rank Rank { get; set; }

        //[Required]
        //[ForeignKey("Ticket")]
        //public int TicketId { get; set; }
     //   public ICollection<Ticket> Tickets { get; set; }
      //  public virtual Rank Rank { get; set; }
       // public virtual ICollection<Ticket> Tickets { get; set; }
        public long Number { get; set; }
        public string Name { get; set; }
    }
}
