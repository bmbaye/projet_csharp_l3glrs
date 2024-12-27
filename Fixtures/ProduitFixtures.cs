using gestion_commandes.Datas;
using gestion_commandes.Models;
using Microsoft.EntityFrameworkCore;

namespace gestion_commandes.Fixtures;

public class ProduitFixtures
{
    private readonly ApplicationDbContext _context;

    public ProduitFixtures(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Load()
    {
        if (!_context.Produits.Any()) {
            _context.Produits.AddRange(
                new Produit {Libelle = "Produit1", QteStock = 300, Prix = 50000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit2", QteStock = 500, Prix = 2500, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit3", QteStock = 450, Prix = 3000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit4", QteStock = 50, Prix = 6000, Images = ["produit.jpg"], QteSeuil = 10 },
                new Produit { Libelle = "Produit5", QteStock = 300, Prix = 50000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit6", QteStock = 500, Prix = 2500, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit7", QteStock = 450, Prix = 3000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit8", QteStock = 50, Prix = 6000, Images = ["produit.jpg"], QteSeuil = 10 },
                new Produit { Libelle = "Produit9", QteStock = 300, Prix = 50000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit10", QteStock = 500, Prix = 2500, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit11", QteStock = 450, Prix = 3000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit12", QteStock = 50, Prix = 6000, Images = ["produit.jpg"], QteSeuil = 10 },
                new Produit { Libelle = "Produit13", QteStock = 300, Prix = 50000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit14", QteStock = 500, Prix = 2500, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit15", QteStock = 450, Prix = 3000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit16", QteStock = 50, Prix = 6000, Images = ["produit.jpg"], QteSeuil = 10 },
                new Produit { Libelle = "Produit17", QteStock = 300, Prix = 50000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit18", QteStock = 500, Prix = 2500, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit19", QteStock = 450, Prix = 3000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit20", QteStock = 50, Prix = 6000, Images = ["produit.jpg"], QteSeuil = 10 },
                new Produit { Libelle = "Produit21", QteStock = 300, Prix = 50000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit22", QteStock = 500, Prix = 2500, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit23", QteStock = 450, Prix = 3000, Images = ["produit.jpg"], QteSeuil = 50 },
                new Produit { Libelle = "Produit24", QteStock = 50, Prix = 6000, Images = ["produit.jpg"], QteSeuil = 10 }

            );

            _context.SaveChanges();
        }
    }

}
