using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formatif.Models
{
    public class BaseDeDonnees
    {
        public List<Animal> Animaux { get; set; }
        public BaseDeDonnees()
        {
            Animaux = new List<Animal>();

            Animaux.Add(new Animal() { Id = 1, Nom = "Pig", Poids = 120, Nourriture = "Carottes" });
            Animaux.Add(new Animal() { Id = 2, Nom = "Cow", Poids = 800, Nourriture = "Blé" });
            Animaux.Add(new Animal() { Id = 3, Nom = "Chicken", Poids = 1, Nourriture = "Graines" });
            Animaux.Add(new Animal() { Id = 4, Nom = "Sheep", Poids = 100, Nourriture = "Blé" });
            Animaux.Add(new Animal() { Id = 5, Nom = "Creeper", Poids = 80, Nourriture = "Larme de joueur" });
        }
    }
}
