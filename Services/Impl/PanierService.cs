using gestion_commandes.Datas;
using gestion_commandes.Models;
using Microsoft.EntityFrameworkCore;

namespace gestion_commandes.Services.Impl;

public class PanierService : IPanierService
{
    private readonly ApplicationDbContext _context;

    public PanierService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Panier> GetPanierByIdClient(int clientId)
    {
        return await _context.Paniers.FirstOrDefaultAsync(p => p.ClientId == clientId);
    }

    public async Task<IEnumerable<Panier>> GetPaniersListAsync()
    {
        return await _context.Paniers.ToListAsync();
    }
}
