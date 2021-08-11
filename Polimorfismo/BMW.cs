using System;
namespace Polimorfismo
{
     class BMW:Auto
    {
        //variables
        private string marca = "BMW";

        //PROPIEDAD

        public string Modelo { get; set; }

        //Constructor

        public BMW(int hp, string color,string modelo) : base(hp, color)
        {
            this.Modelo = modelo;
        }
        
    }
}
