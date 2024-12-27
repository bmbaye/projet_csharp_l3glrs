using gestion_commandes.Models.enums;

namespace gestion_commandes.Models
{
    public class Panier
    {
        public int Id { get; set; }

        public ICollection<Produit> Produits { get; set; }

        public Client Client { get; set; }

        public int ClientId { get; set; }

        public EtatPanier Etat { get; set; }

    }
}
