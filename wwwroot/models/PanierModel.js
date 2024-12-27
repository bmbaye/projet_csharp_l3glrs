import { Model, WEBROOT } from "../core/Model.js";

export class PanierModel extends Model {
    async findByClientId(clientId) {
        let response = await this.getData(`${WEBROOT}Panier/${clientId}`);
        return response;
    }
}