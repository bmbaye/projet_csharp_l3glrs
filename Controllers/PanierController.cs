using gestion_commandes.Models;
using gestion_commandes.Services;
using gestion_commandes.Services.Impl;
using Microsoft.AspNetCore.Mvc;

namespace gestion_commandes.Controllers
{
    public class PanierController : Controller
    {
        private readonly ILogger<PanierController> _logger;
        private readonly IProduitService _produitService;
        private readonly IUtilisateurService _utilsateurService;
        private readonly IPanierService _panierService;
        private readonly IPanierProduitService _panierProduitService;

        public PanierController(ILogger<PanierController> logger, IProduitService produitService, IUtilisateurService utilsateurService, IPanierService panierService, IPanierProduitService panierProduitService) { 
            _logger = logger;
            _produitService = produitService;
            _utilsateurService = utilsateurService;
            _panierService = panierService;
            _panierProduitService = panierProduitService;
        }

        public async Task<IActionResult> AjoutForm(int produitId) {
            var produit = await _produitService.GetProduitByIdAsync(produitId);
            var panierProduit = new PanierProduit
            {
                Produit = produit,
            };
            if (TempData["userId"] != null)
            {
                TempData["userId"] =(int)TempData["userId"];
            }
            return View("Ajout", panierProduit);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToPanier([Bind("Quantite")] PanierProduit panierProduit)
        {
            if (ModelState.IsValid)
            {
                var client = _utilsateurService.GetUtilisateurById((int)TempData["userId"]);

                var panier =await  _panierService.GetPanierByIdClient(client.Id);
                panierProduit.Panier = panier;

                var panierProduitAdded = await _panierProduitService.Create(panierProduit);
                if(panierProduitAdded != null)
                {
                    return RedirectToAction(nameof(AjoutForm));
                }

            }
            return View("Ajout", panierProduit);

        }
    }


}
