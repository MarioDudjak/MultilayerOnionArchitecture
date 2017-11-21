import { Injectable } from "@angular/core";
import { Headers, Http, RequestOptions } from "@angular/http";
import { User } from "./user.model";

@Injectable()
export class UserService {
	private apiUrl = "http://localhost:50968/api/user";
    constructor(private http: Http) { }
    
    async createUserAsync(data: User): Promise<User> {
    let body = JSON.stringify(data);
		let headers = new Headers({ "Content-Type": "application/json" });
		let options = new RequestOptions({ headers: headers });
		var query = this.apiUrl + "/create";
        try {

          let response = await this.http.post(query, body, options)
            .toPromise();
          console.log(response.json().data);
          return response.json().data;
        } catch (error) {
          await this.handleErrorAsync(error);
        }
      }
    
    private async handleErrorAsync(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
    }
	
}