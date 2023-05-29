import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Contato } from "../modelo/contato";
import { Tarefa } from "../modelo/tarefa";
import { Cliente } from "../modelo/cliente";

@Injectable({
  providedIn: "root"
})

export class HomeServico implements OnInit {

  private _baseUrl: string;

  public contatos: Contato[];
  public tarefas: Tarefa[];
  public cliente: Cliente;

  ngOnInit(): void {
    this.contatos = [];
    this.cliente;
    this.tarefas = [];
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public salvar(contato: Contato): Observable<Contato> {
    return this.http.post<Contato>(this._baseUrl + "api/contato", JSON.stringify(contato), { headers: this.headers });
  }

  public obterTodosContatos(): Observable<Contato[]> {
    return this.http.get<Contato[]>(this._baseUrl + "api/contato");
  }
  
  public obterTodasTarefas(): Observable<Tarefa[]> {
    return this.http.get<Tarefa[]>(this._baseUrl + "api/tarefa");
  }

  public obterTodosClientes(): Observable<Cliente> {
    return this.http.get<Cliente>(this._baseUrl + "api/cliente");
  }
}