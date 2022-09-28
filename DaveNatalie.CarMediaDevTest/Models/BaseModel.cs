using System.Data;

namespace DaveNatalie.CarMediaDevTest.Models
{
    public abstract class BaseModel
    {
        public long Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? LastModified { get; set; }

        public BaseModel()
        {
            this.Created = DateTimeOffset.UtcNow;
        }
    }
}
