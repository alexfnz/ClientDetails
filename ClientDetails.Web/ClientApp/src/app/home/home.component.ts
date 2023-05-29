import { Component, OnInit } from '@angular/core';
import { Contato } from '../modelo/contato';
import { Tarefa } from '../modelo/tarefa';
import { Cliente } from '../modelo/cliente';
import { HomeServico } from '../servicos/home.servico';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ["./home.component.css"],
})

export class HomeComponent implements OnInit {

  public contatos: Contato[];
  public contato: Contato;
  public tarefas: Tarefa[];
  public cliente: Cliente;

  ngOnInit(): void {
    
    var contatoSession = sessionStorage.getItem('contatoSession')
    if(contatoSession){
      this.contato = JSON.parse(contatoSession);
    }else{
      this.contato = new Contato();
    }
    
  }

  constructor(private homeServico: HomeServico, private router: Router){
    this.homeServico.obterTodasTarefas().subscribe(
      tarefas => {
        this.tarefas = tarefas
      },
      err => {
        console.log(err.error)
      }
    );

    this.homeServico.obterTodosContatos().subscribe(
      contatos => {
        this.contatos = contatos
      },
      err => {
        console.log(err.error)
      }
    );

    this.homeServico.obterTodosClientes().subscribe(
      cliente => {
        this.cliente = cliente
      },
      err => {
        console.log(err.error)
      }
    );
  }

  public editar(contato: Contato){
    sessionStorage.setItem('contatoSession', JSON.stringify(contato));
    this.router.navigate(['/cadastroEdicao']);
  }

}