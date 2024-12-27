using gestion_commandes.Models;

namespace gestion_commandes.Services;

public interface IPanierProduitService
{
    Task<PanierProduit> GetProduitByPanierAndProdAsync(int produitId, int panierId);

    Task<PanierProduit> Create(PanierProduit panierProduit);
}
