namespace gestion_commandes.Services.Impl;

using System.Collections.Generic;
using System.Threading.Tasks;
using gestion_commandes.Datas;
using gestion_commandes.Models;
using Microsoft.EntityFrameworkCore;


public class UtilisateurService : IUtilisateurService
{
    private readonly ApplicationDbContext _context;

    public UtilisateurService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Utilisateur>? GetUtilisateurById(int id)
    {
        return await _context.Utilisateurs.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<IEnumerable<Utilisateur>> GetUtilisateursListAsync()
    {
        return await _context.Utilisateurs.ToListAsync();
    }
}
