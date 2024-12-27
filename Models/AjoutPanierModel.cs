namespace gestion_commandes.Models
{
    public class AjoutPanierModel
    {
        public Utilisateur User { get; set; }
        public Produit Product { get; set; }

        public int Quantite { get; set; }
    }
}
