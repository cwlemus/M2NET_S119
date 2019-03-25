using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2NET_S119_REPASO_M1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] lstCarros = new Vehiculo[3];
            List<Vehiculo> lstCarrosDinamicos = new List<Vehiculo>();
            bool seguir = true;
            Vehiculo carro = null;

            //arreglos
            /*   for (int i = 0; i < lstCarros.Length; i++)
               {
                   carro= new Vehiculo();
                   Console.WriteLine("Ingrese tipo vehiculo");
                   carro.TipoVehiculo = Console.ReadLine();
                   lstCarros[i] = carro;
               }
               foreach (var item in lstCarros)
               {
                   item.Mantenimiento();
               } */
            //listas dinamicas
            while (seguir)
            {
                Console.WriteLine("Ingrese tipo vehiculo");
                carro = new Vehiculo();
                carro.TipoVehiculo = Console.ReadLine();
                Console.WriteLine("Ingrese año del vehiculo");
                carro.Anyo = int.Parse(Console.ReadLine());
                lstCarrosDinamicos.Add(carro);

                Console.WriteLine("desea ingresar otro (s/n)");
                string op = Console.ReadLine();
                if (!op.ToLower().Equals("s"))
                {
                    seguir = false;
                }
            }
            var lstFiltrada = from car in lstCarrosDinamicos where car.Anyo > 2010
                              select new Vehiculo { TipoVehiculo=car.TipoVehiculo,Anyo=car.Anyo};
            foreach (var item in lstFiltrada)
            {
                item.Mantenimiento();
            }
            Console.ReadLine();
        }
    }
    class Vehiculo
    {
        public string TipoVehiculo { get; set; }
        public int Anyo { get; set; }
        public void Mantenimiento()
        {
            Console.WriteLine("Ya es tiempo de afinado Menor para {0} de año {1}",
                this.TipoVehiculo,this.Anyo);
        }
    }
}
