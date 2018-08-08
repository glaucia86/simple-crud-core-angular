import { Component, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { FuncionarioService } from '../services/funcionarioService.service'

@Component({
    templateUrl: 'fetchfuncionario.component.html'
})

export class FetchFuncionarioComponent {
    public listaFuncionario: FuncionarioData[];

    constructor(public http: Http, private _router: Router, private _funcionarioService: FuncionarioService) {
        this.getObterTodosFuncionarios();
    }

    getObterTodosFuncionarios() {
        this._funcionarioService.getObterTodosFuncionarios().subscribe(data => this.listaFuncionario = data)
    }
}

    

interface FuncionarioData {
    funcionarioId: number;
    nome: string;
    cidade: string;
    departamento: string;
    genero: string;
}