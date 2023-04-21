using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class VideoGame
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Overview { get; set; }

        public string? Release_date { get; set; }

        
        public DateTime Created_at { get; set; }

        
        public DateTime Updated_at { get; set; }

        
        public int Software_houseId { get; set; }

        public Software_house Software_house { get; set; }

        public VideoGame()
        {
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}
