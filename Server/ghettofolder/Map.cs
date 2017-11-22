using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Map
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte[] MapToByte { get; set; }
        [Required, StringLength(maximumLength:255)]
        public string MapName { get; set; }
    }
}
