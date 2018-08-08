import { Injectable, Inject } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Router } from '@angular/router';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw'; 

@Injectable()
export class FuncionarioService {
    funcionarioAppUrl: string = "";

    constructor(private _http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.funcionarioAppUrl = baseUrl;
    }

    // Método responsável para fazer tratamento de error:
    handleError(error: Response) {
        console.log(error);
        return Observable.throw(error);
    }

    // (GET): Método responsável por Retornar Lista de Cidades:
    getRetornarListaCidades() {
        return this._http.get(this.funcionarioAppUrl + 'api/Funcionario/RetornarListaCidades')
            .map(res => res.json())
            .catch(this.handleError);
    }

    // (GET) Método responsável por Retornar Todos os Funcionários:
    getObterTodosFuncionarios() {
        return this._http.get(this.funcionarioAppUrl + 'api/Funcionario/Index')
            .map((response: Response) => response.json())
            .catch(this.handleError);
    }

    // (GET) Método responsável por Retornar determinado Funcionário por Id:
    getObterFuncionarioPorId(id: number) {
        return this._http.get(this.funcionarioAppUrl + 'api/Funcionario/Retornar/' + id)
            .map((response: Response) => response.json())
            .catch(this.handleError);
    }

    // (POST) Método responsável por Salvar/Criar um Novo Funcionário:
    postAdicionarFuncionario(funcionario) {
        return this._http.post(this.funcionarioAppUrl + 'api/Funcionario/Adicionar', funcionario)
            .map((response: Response) => response.json())
            .catch(this.handleError);
    }

    // (PUT) Método responsável por Atualizar o Funcionário:
    putAtualizarFuncionario(funcionario) {
        return this._http.put(this.funcionarioAppUrl + 'api/Funcionario/Atualizar', funcionario)
            .map((response: Response) => response.json())
            .catch(this.handleError);
    }

    // (DELETE)
}