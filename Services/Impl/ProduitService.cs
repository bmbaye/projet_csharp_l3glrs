using gestion_commandes.Datas;
using gestion_commandes.Models;
using Microsoft.EntityFrameworkCore;

namespace gestion_commandes.Services.Impl;

public class ProduitService(ApplicationDbContext context) : IProduitService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Produit> GetProduitByIdAsync(int produitId)
    {
        return await _context.Produits.FirstOrDefaultAsync(p => p.Id == produitId);
    }

    public async Task<IEnumerable<Produit>> GetProduitListAsync()
    {
        return await _context.Produits.ToListAsync();
    }

}
