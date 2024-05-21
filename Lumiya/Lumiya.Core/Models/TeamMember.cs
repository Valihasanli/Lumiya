using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumiya.Core.Models
{
    public class TeamMember:BaseEntity
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; } = null!;
        public string Job { get; set; }= null!;
        public string Description { get; set; } = null!;
        public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile? Photofile { get; set; }
    }
}
