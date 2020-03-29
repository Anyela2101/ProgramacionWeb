﻿using System;

namespace Entity
{
    public class Persona
    {
        public string Identificacion {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public int Edad {get;set;}
        public string Sexo {get;set;}
        public decimal Pulsacion {get;set;}

        public void CalcularPulsaciones(){
            if(Sexo.Equals("F")|| Sexo.Equals("f")){
                Pulsacion=(220-Edad)/10;
            }else if (Sexo.Equals("M")|| Sexo.Equals("m")){
                Pulsacion=(210-Edad)/10;
            }
            
        }

    }
}