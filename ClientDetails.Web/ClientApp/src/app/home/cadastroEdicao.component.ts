import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { HomeServico } from "../servicos/home.servico";
import { Contato } from "../modelo/contato";

@Component({
  selector: 'app-home',
  templateUrl: './cadastroEdicao.component.html',
  styleUrls: ["./cadastroEdicao.component.css"],
})

export class CadastroEdicao implements OnInit{

  public contato: Contato;

  ngOnInit(): void {
    var contatoSession = sessionStorage.getItem('contatoSession')
    if(contatoSession){
      this.contato = JSON.parse(contatoSession);
    }else{
      this.contato = new Contato();
    }
  }

  constructor(private homeServico: HomeServico, private router: Router){

  }

  public editar(contato: Contato){
    sessionStorage.setItem('contatoSession', JSON.stringify(contato));
    this.router.navigate(['/']);
  }

  public edicao(){
    this.homeServico.salvar(this.contato)
    .subscribe(
      contatoJson => {
        this.router.navigate(['/']);
      },
      e => {
        console.log(e.error)
      }
    )
  }

}