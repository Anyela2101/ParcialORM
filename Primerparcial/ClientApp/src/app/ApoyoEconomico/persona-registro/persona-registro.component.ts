import { Component, OnInit } from '@angular/core';
import { Apoyo } from '../models/apoyo';
import { ApoyoService } from './../../services/apoyo.service';

@Component({
  selector: 'app-persona-registro',
  templateUrl: './persona-registro.component.html',
  styleUrls: ['./persona-registro.component.css']
})
export class PersonaRegistroComponent implements OnInit {
  apoyo:Apoyo;
  constructor(private apoyoService: ApoyoService) { }

  ngOnInit(): void {
    this.apoyo = new Apoyo();
  }

  add(){
    this.apoyoService.post(this.apoyo).subscribe(a => {
      if (a != null) {
        alert('Persona creada!');
        this.apoyo = a;
      }
    });
    
  }

}
