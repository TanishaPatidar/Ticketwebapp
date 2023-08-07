using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketwebapp.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        // [Display(Name = " ProfilePictureURL")]
        [Required(ErrorMessage = "ProfileImage Url is required")]
        public string ProfilePictureURL { get; set; }

       // [Display(Name = "FullName ")]
        [Required (ErrorMessage ="FullName is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be between 3 to 30 chars")]
        public string FullName { get; set; }

       // [Display(Name = "Bio")]
        public string Bio { get; set; }

        //relationship

        public List<Actor_Movie>Actor_Movies { get; set; }
    }
}
