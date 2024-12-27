namespace gestion_commandes.Services;
using gestion_commandes.Models;

public interface IUtilisateurService
{
    Task<IEnumerable<Utilisateur>> GetUtilisateursListAsync();

    Task<Utilisateur> GetUtilisateurById(int id);
}
