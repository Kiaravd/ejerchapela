using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sucursal[] sucur = new sucursal[4];
            int cantidad;
           for( int i=0;i<sucur.Length;i++) {
                Console.WriteLine("¿Cuantos empleados tiene la sucursal {0}?", i);
                cantidad = Convert.ToInt32(Console.ReadLine());
                sucur[i] = new sucursal(cantidad);
                sucur[i].numero_sucursal = i + 1;
                
            }

        }
        public class sucursal
        {
            //metodo constructor 
            public sucursal(int cant) {
                string[] nombres_empleados = new string [cant]; 
            }

            //atributos da
            public string[] barrio = { "Almagro", "Balvanera", "Caballito", "Microcentro" } ;
            public int numero_sucursal;
            public int monto_venta;
            public int cantidad_empleados;
            public int cantidad_clientes_mes;
            public string[] nombreEmpleados;
            
            //▪ Cálculo del promedio de ventas
            //▪ Cálculo del promedio de cantidad de empleados
            //▪ Cálculo de la venta total
            //▪ Determinar la venta máxima y que sucursal es.
            //▪ Determinar la venta mínima y que sucursal es.
            // metodos 
            public void promedio_ventas() { }
            public void promedio_empleados() { } 
            public void venta_total() { }  
            public void venta_maxima() { }
            public void venta_minima() { }

        }   

    }
}
