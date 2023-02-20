using System.ComponentModel.DataAnnotations;

namespace Sample_MVCWebApp.Models
{
    public class AddressViewModel
    {
        public int Id { get; set; }

        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class AddressViewModel
    {
        public int Id { get; set; }

        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
    }
}
