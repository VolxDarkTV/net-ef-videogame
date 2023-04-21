using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
   
    public class Software_house
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? tax_id { get; set; }

        public string? City { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }

        public List<VideoGame> VideoGames { get; set; }

        public Software_house()
        {
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}
