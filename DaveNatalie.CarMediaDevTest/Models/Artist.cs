using System.ComponentModel.DataAnnotations;

namespace DaveNatalie.CarMediaDevTest.Models
{
    public class Artist : BaseModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public Artist(string name)
        {
            this.Name = name;
            this.Albums = new HashSet<Album>();
        }

   


    }
}
