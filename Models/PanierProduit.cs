using gestion_commandes.Models.enums;

namespace gestion_commandes.Models
{
    public class PanierProduit
    {
        public int Id { get; set; }

        public Produit Produit { get; set; }

        public int ProduitId { get; set; }

        public Panier Panier { get; set; }

        public int Quantite { get; set; }
        public int PanierId { get; set; }

        public EtatPanierProduit Etat {  get; set; }

    }
}
