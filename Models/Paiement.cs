using gestion_commandes.Models.enums;

namespace gestion_commandes.Models
{
    public class Paiement
    {
        public int Id { get; set; }

        public TypePaiement Type {  get; set; }

        public double Montant { get; set; }

        public string Reference { get; set; }
        public DateTime Date { get; set; }

        public Commande Commande { get; set; }

        public int CommandeId { get; set; }

    }
}
