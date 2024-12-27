export class Model {
    async getData(url) {
        const response = await fetch(url);
        return response.json();
    }
}

export const WEBROOT = "http://localhost:5000/";