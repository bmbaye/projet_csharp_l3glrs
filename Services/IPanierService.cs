using gestion_commandes.Models;

namespace gestion_commandes.Services;

public interface IPanierService
{
    Task<IEnumerable<Panier>> GetPaniersListAsync();

    Task<Panier> GetPanierByIdClient(int clientId);
}
