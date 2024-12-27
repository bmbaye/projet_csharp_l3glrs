using gestion_commandes.Datas;
using gestion_commandes.Models;
using gestion_commandes.Services;
using Microsoft.AspNetCore.Mvc;

namespace gestion_commandes.Controllers;

public class ProduitController :Controller
{
    private readonly ILogger<ProduitController> _logger;

    private readonly IUtilisateurService _utilisateurService;
    private readonly IProduitService _produitService;
    private readonly IPanierService _panierService;
    private readonly IPanierProduitService _panierProduitService;
    private readonly ApplicationDbContext _context;

    public ProduitController(ILogger<ProduitController> logger, IUtilisateurService utilisateurService, IProduitService produitService, IPanierService panierService, IPanierProduitService panierProduitService, ApplicationDbContext context)
    {
        _logger = logger;
        _utilisateurService = utilisateurService;
        _produitService = produitService;
        _panierService = panierService;
        _panierProduitService = panierProduitService;
        _context = context;
    }

    public async Task<IActionResult> Index( int userId)
    {
        var produits = await _produitService.GetProduitListAsync();
        var user = await _utilisateurService.GetUtilisateurById(userId);
        TempData["userId"] = user.Id;
        var indexModel = new ProductIndexModel
        {
            User = user,
            Products = produits
        };
        return View(indexModel);
    }

    //public async Task<IActionResult> AddBasket(PanierProduit model)
    //{
    //    if (ModelState.IsValid) { 

    //    if(model.Quantite > 0)
    //    {
    //        var produit = await _produitService.GetProduitByIdAsync(model.ProduitId);
    //        var client = await _utilisateurService.GetUtilisateurById(model.Panier.ClientId);
    //        var panier = await _panierService.GetPanierByIdClient(4);

    //        var panierProduit = await _panierProduitService.GetProduitByPanierAndProdAsync(productId, panier.Id);

    //        if(panierProduit != null)
    //        {
    //            panierProduit.Quantite += quantite;

    //        }
    //        else
    //        {

    //            var basket = new PanierProduit
    //            {
    //                Produit = produit,
    //                Quantite = quantite,
    //                ProduitId = productId,
    //                Panier = panier,
    //                PanierId = panier.Id
    //            };

    //            _context.PanierProduits.Add(basket);
    //        }
    //        await _context.SaveChangesAsync();
    //    }
    //    TempData["message"] = "Produit ajoute avec succes !!";
    //    return RedirectToAction("Index", new {userId = clientId});
    //    }
    //}
}
