using System.ComponentModel.DataAnnotations;

namespace gestion_commandes.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }

        [Required()]
        [Length(1, 35)]
        public string Nom { get; set; }

        [Required()]
        [Length(1, 50)]
        public string Prenom { get; set; }

        public Compte Compte { get; set; }

        public int CompteId { get; set; }



    }
}
