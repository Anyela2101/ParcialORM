import{Persona} from './persona'
export class Apoyo {
    constructor(){
        this.persona = new Persona();
    }
    departamento: string;
    ciudad: string;
    valorApoyo: number;
    modalidad: string;
    fecha: Date;
    persona: Persona;
}
