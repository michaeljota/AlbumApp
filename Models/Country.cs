using System.Collections.Generic;

namespace AlbumApp.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}