using gestion_commandes.Models.enums;

namespace gestion_commandes.Models
{
    public class Commande
    {
        public int Id { get; set; }

        public double Montant { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;

        public Validation Validation { get; set; }

        public EtatCommande EtatCommande { get; set; }

        public Client Client { get; set; }

        public int ClientId { get; set; }

        public ICollection<Produit>? Produits { get; set; }

        public Livraison Livraison { get; set; }

        public Paiement Paiement { get; set; }






    }
}
