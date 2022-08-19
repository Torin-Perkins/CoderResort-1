using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoderResort.Models
{
    public class Reserve
    {
        public int ReserveId { get; set; }

        [Required(ErrorMessage = "Please enter your first name!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your address!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your zip code!")]
        public int ZipCode { get; set; }

        public int RoomId { get; set; }
    }
}
