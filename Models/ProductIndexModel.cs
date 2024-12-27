namespace gestion_commandes.Models;

public class ProductIndexModel
{
    public Utilisateur User { get; set; }

    public IEnumerable<Produit> Products { get; set; }

    public IEnumerable<PanierProduit> PanierProduit { get; set; }
}
