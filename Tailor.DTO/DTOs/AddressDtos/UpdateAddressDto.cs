using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.AddressDtos
{
    public class UpdateAddressDto
    {
        // [Required] Güncellenecek kaydı belirtmek için zorunludur.
        public int Id { get; set; }

        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        // Varsayılan adres durumunun güncellenmesi.
        public bool IsDefault { get; set; }
    }
}
