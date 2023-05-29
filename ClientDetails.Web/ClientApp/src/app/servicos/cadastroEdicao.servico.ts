import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Inject, Injectable, OnInit } from "@angular/core";
import { Contato } from "../modelo/contato";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root"
})

export class CadastroEdicaoServico implements OnInit{

  private _baseUrl: string;

  ngOnInit(): void {
    
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string){
    this._baseUrl = baseUrl;
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public salvar(contato: Contato): Observable<Contato> {
    return this.http.post<Contato>(this._baseUrl + "api/contato/salvar", JSON.stringify(contato), { headers: this.headers });
  }
}