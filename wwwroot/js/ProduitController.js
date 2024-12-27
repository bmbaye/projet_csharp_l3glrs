import { ProduitModel } from "../models/ProduitModel.js";

const ajout_panier = document.getElementsByClassName('ajouter-panier');

document.addEventListener('DOMContentLoaded', async (even) => {
    ajout_panier.addEventListener('click', async function () {
        const produit_model = new ProduitModel();
        let response = produit_model.findById(ajout_panier.value);
    })
})