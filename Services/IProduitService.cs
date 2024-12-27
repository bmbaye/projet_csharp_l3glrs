using gestion_commandes.Models;

namespace gestion_commandes.Services;

public interface IProduitService
{
    Task<IEnumerable<Produit>> GetProduitListAsync();

    Task<Produit> GetProduitByIdAsync(int produitId);

}
