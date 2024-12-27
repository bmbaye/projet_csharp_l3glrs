namespace gestion_commandes.Models
{
    public class Produit
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public int QteStock { get; set; }

        public double Prix { get; set; }

        public int QteSeuil { get; set; }

        public string[]? Images { get; set; }

        public ICollection<Commande>? Commandes { get; set; }

        public ICollection<Panier>? Paniers { get; set; }


    }
}
