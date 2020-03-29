export class Persona {
    Identificacion: string;
    Nombres: string;
    Apellidos: string;
    Sexo: string;
    Edad: number;
    Pulsacion: number;

    CalcularPulsacion(){
        this.Pulsacion=0;
        if(this.Sexo.toUpperCase()=='F'){
            this.Pulsacion=(220-this.Edad)/10;
        }else if(this.Sexo.toUpperCase()=='M'){
            this.Pulsacion=(210-this.Edad)/10;
        }
        
    }
}
