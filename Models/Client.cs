using System.ComponentModel.DataAnnotations;

namespace gestion_commandes.Models
{
    public class Client : Utilisateur
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [Length(9, 9)]
        [RegularExpression(@"^(77|78|76|75)[0-9]{7}$", ErrorMessage = "Le telephone est dans un mauvais format !!")]
        public string? Telephone { get; set; }

        public string? Adresse { get; set; }

        public ICollection<Commande>? Commandes { get; set; }

        public ICollection<Panier> Paniers { get; set; }

    }
}
