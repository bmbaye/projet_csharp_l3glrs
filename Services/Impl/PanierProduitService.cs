using gestion_commandes.Datas;
using gestion_commandes.Models;
using Microsoft.EntityFrameworkCore;

namespace gestion_commandes.Services.Impl;

public class PanierProduitService : IPanierProduitService
{
    private readonly ApplicationDbContext _context;

    public PanierProduitService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<PanierProduit> Create(PanierProduit panierProduit)
    {
        _context.PanierProduits.Add(panierProduit);
        await _context.SaveChangesAsync();
        return panierProduit;
    }

    public async Task<PanierProduit> GetProduitByPanierAndProdAsync(int produitId, int panierId)
    {
        return await _context.PanierProduits.FirstOrDefaultAsync(pp => pp.ProduitId == produitId && pp.PanierId == panierId);
    }
}
