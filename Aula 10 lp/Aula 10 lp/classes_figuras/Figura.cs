namespace Aula10
{
    public class Figura
    {
        protected double _area; 
        protected double _perimetro; 
        protected string _name;

        public string Nome 
        {
            get 
            { 
                return this._name; 
            } 
        }

        public double Area 
        {  
            get 
            { 
                return this._area; 
            }    
        }      

        public double Perimetro 
        {  
            get 
            { 
                return this._perimetro; 
            }  
        }
    }
}