using gestion_commandes.Models.enums;

namespace gestion_commandes.Models
{
    public class Livraison
    {
        public int Id { get; set; }

        public string Adresse { get; set; }

        public DateTime Date { get; set; }

        public EtatLivraison Etat { get; set; }


        public int CommandeId { get; set; }
        public Commande Commande { get; set; }

        public Livreur Livreur { get; set; }

        public int LivreurId { get; set; }
    }
}
