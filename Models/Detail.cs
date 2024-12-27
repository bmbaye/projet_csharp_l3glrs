namespace gestion_commandes.Models
{
    public class Detail
    {
        public int Id { get; set; }

        public Commande Commande { get; set; }

        public int Quantite { get; set; }

        public int CommandeId { get; set; }

        public Produit Produit { get; set; }

        public int ProduitId { get; set; }


    }
}
