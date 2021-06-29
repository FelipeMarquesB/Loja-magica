using System;

namespace Aula10
{
    public class Retangulo : Figura 
    {
        private double _altura;
        private double _largura;          

        public Retangulo(double altura, double largura)  
        {       
            this._name = "Retângulo";
            this._altura = altura; 
            this._largura = largura;       

            this.AtualizarArea();
            this.AtualizarPerimetro();       
        }
        private void AtualizarArea() 
        { 
            this._area = this._altura * this._largura;  
        }  
        private void AtualizarPerimetro() 
        { 
            this._perimetro = 2 * ( this._altura + this._largura ); 
        }      
    }
}