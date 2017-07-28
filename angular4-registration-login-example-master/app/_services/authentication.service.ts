import { Injectable } from '@angular/core';
import { Http, Headers, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { RequestOptions } from "@angular/http/http";

@Injectable()
export class AuthenticationService {
    constructor(private http: Http) { }

 


   login(username: string, password: string){
    
     var headers = new Headers();
      headers.append('Content-Type', 'application/json;charset=utf-8');

       return this.http.post('http://localhost:13484/api/User/validateUser', JSON.stringify({ username: username, password: password }), {
        headers: headers
      })
            .map((response: Response) => {
                // login successful if there's a jwt token in the response
                let user = response.json();
                if (user) {
                    // store user details and jwt token in local storage to keep user logged in between page refreshes
                    localStorage.setItem('currentUser', JSON.stringify(user));
                }

                return user;
            });
    }

    logout() {
        // remove user from local storage to log user out
        localStorage.removeItem('currentUser');
    }
}