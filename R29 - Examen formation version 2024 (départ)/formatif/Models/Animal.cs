using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace formatif.Models
{
    public class Animal
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Entrez un nom."),Display(Name = "Le nom de l’animal ")]
        public string Nom { get; set; }
        [Required(ErrorMessage ="Entrez une poids. "),Display(Name = "Le Poids de l’animal "),Range(minimum:0.5 ,maximum:2000,ErrorMessage = "Entre 0.5 et 2000.")]
        public double Poids { get; set; }
        [Required(ErrorMessage = "Indiquer la nourriture. ") ,Display(Name = "Le Nourriture de l’animal "),MaxLength(30,ErrorMessage = "30 caractères maximum.")]
        public string Nourriture { get; set; }
    }
}
