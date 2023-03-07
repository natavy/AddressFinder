
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressFinder.Model
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }

    }
}
