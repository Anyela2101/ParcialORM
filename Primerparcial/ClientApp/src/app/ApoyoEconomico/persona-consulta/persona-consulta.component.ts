import { Component, OnInit } from '@angular/core';
import {Persona} from '../models/persona';
import {Apoyo} from '../models/apoyo';
import {ApoyoService} from 'src/app/services/apoyo.service';

@Component({
  selector: 'app-persona-consulta',
  templateUrl: './persona-consulta.component.html',
  styleUrls: ['./persona-consulta.component.css']
})
export class PersonaConsultaComponent implements OnInit {
  
  apoyos:Apoyo[]=[];
  apoyoTotal:number=0;
  searchText: string;
  constructor(private apoyoService: ApoyoService) { }

  ngOnInit(): void {
    this.get();
    this.calcular();
  }
  get(){
    this.apoyoService.get().subscribe(result => {
      this.apoyos = result;
    });
    console.log(this.apoyos);
  }
  calcular(){
    var sumador=0;
        this.apoyos.forEach(element => {
           sumador = sumador + element.valorApoyo;
      });
        this.apoyoTotal = sumador;
  }
  
}
