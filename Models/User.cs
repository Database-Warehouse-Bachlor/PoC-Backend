

using System.ComponentModel.DataAnnotations;

namespace PoC_backend.Models {
    public class User {

        [Required]
        public string username {get; set;}
        [Required]
        public string password { get; set; }
    }
}