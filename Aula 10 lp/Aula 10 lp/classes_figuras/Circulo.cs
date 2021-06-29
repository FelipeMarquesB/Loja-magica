using System;

namespace Aula10
{
    public class Circulo : Figura 
    {
        private double _raio; 
        
        public double Raio 
        {
            get
            {
                return this._raio;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Raio inválido");
                }
                else
                {
                    this._raio = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }

        public Circulo(double raio)  
        { 
            this._name = "Círculo";   
            this.Raio = raio; 
        }

        private void AtualizarArea() 
        { 
            this._area = Math.PI * this._raio * this._raio; 
        }  

        private void AtualizarPerimetro() 
        { 
            this._perimetro = 2 * Math.PI * this._raio; 
        }        
    }
}