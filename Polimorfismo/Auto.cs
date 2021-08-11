using System;
namespace Polimorfismo
{
   class Auto
    {
        //Propiedades
        public int HP { get; set; }
        public string Color { get; set; }


        //Constuctor parametrizado

        public Auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        //Métodos

        public void MostrarDetalles()

        {
            Console.WriteLine("HP: {0} - Color: {1}", HP,Color);
        }

    }
}
