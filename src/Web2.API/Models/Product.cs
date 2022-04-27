using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web2.API.Models
{
    public class Product
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DefaultValue(false)]
        public bool IsComplete { get; set; }
    }
}
