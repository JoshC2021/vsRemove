using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAngualrTestJustin.Models
{
    public class TestingGarbo
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; } // match string


        // can remove when done to clean api call
        [ForeignKey("UserId")] // Column Name
        public ApplicationUser ApplicationUser { get; set; }

    }
}
