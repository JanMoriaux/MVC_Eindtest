using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_VideoVerhuur.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "\"Naam\" is een verplicht veld")]
        [MaxLength(50,ErrorMessage = "\"Naam\" is maximaal 50 letters lang")]
        [NaamValidation(ErrorMessage = "\"Naam\" bevat ongeldige tekens")]
        public string Naam { get; set; }
        [Required(ErrorMessage = "\"Postcode\" is een verplicht veld")]
        [Range(1000,9999,ErrorMessage = "Gelieve een waarde tussen 1000 en 9999 in te voeren")]
        public int PostCode{ get; set; }
    }
}