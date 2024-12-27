import { Model, WEBROOT } from "../core/Model.js";

export class ProduitModel extends Model {
    async findById(produitId) {
        let response = await this.getData(`${WEBROOT}Produit/${produitId}`);
        return response;
    }
}