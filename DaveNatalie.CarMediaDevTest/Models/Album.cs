using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace DaveNatalie.CarMediaDevTest.Models
{
    public class Album : BaseModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }


        public int? YearReleased { get; set; }

        [Required]
        public long ArtistId { get; set; }

        [JsonIgnore]
        public Artist? Artist { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

        public Album(long artistId, string name)
        {
            this.ArtistId = artistId;
            this.Name = name;    
            this.Songs = new HashSet<Song>();
        }
    }
}
