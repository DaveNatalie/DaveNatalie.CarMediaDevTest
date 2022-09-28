using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DaveNatalie.CarMediaDevTest.Models
{
    public class Song : BaseModel
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int? Track { get; set; }

        [Required]
        public long AlbumId { get; set; }

        [JsonIgnore]
        public Album? Album { get; set; }



        public Song(long albumId, string name)
        {
            this.AlbumId = albumId;
            this.Name = name;
        }

    }
}
