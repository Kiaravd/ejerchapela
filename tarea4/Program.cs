using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tarea4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ind;
            int sucursal_elegida;
            string[] barrio = { "Almagro", "Balvanera", "Caballito", "Microcentro" };
            string nombre;
            string afirmar;
            bool[] consulta = { false, false, false, false };
            List<int?> ventas = new List<int?>() { null, null, null, null };
            sucursal[] sucur = new sucursal[4];
            do
            {
                Console.WriteLine("¿A cuál sucursal desea ingresar? (ingrese solo el número)");
                Console.WriteLine("Sucursal 1: Almagro");
                Console.WriteLine("Sucursal 2: Balvanera");
                Console.WriteLine("Sucursal 3: Caballito");
                Console.WriteLine("Sucursal 4: Microcentro");
                sucursal_elegida = Convert.ToInt32(Console.ReadLine());
                ind = sucursal_elegida - 1;
                if (consulta[ind] == false)
                {
                    Console.WriteLine("Usted ingresó a la sucursal {0}: {1}", sucursal_elegida, barrio[ind]);
                    Console.WriteLine("Ingresar cantidad de empleados: ");
                    int intermediario = Convert.ToInt16(Console.ReadLine());
                    sucur[ind] = new sucursal(intermediario);
                    sucur[ind].cantidad_empleados = intermediario;
                    sucur[ind].numero_sucursal = 1;
                    Console.WriteLine("Ingresar monto de venta: ");
                    sucur[ind].monto_venta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresar cantidad de clientes que compraron este mes: ");
                    sucur[ind].cantidad_clientes_mes = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < sucur[ind].cantidad_empleados; i++)
                    {
                        Console.WriteLine("Ingrese nombre del empleado {0}", (i + 1));
                        nombre = Console.ReadLine();
                        sucur[ind].nombreEmpleados[i] = nombre;
                    }
                    consulta[ind] = true;
                }
                else
                {
                    Console.WriteLine("Ya ingresó los datos de esta sucursal.");
                }

                Console.WriteLine("¿Desea agregar otra?");
                afirmar = Console.ReadLine();
            } while (afirmar == "si" || afirmar == "Si" || afirmar == "sI" || afirmar == "SI" || afirmar == "Sí" || afirmar == "sí");
            int promedio = 0;
            int sum_emp = 0;
            int cantidad = 0;
            for (int j = 0; j < consulta.Length; j++)
            {
                if (consulta[j] == true)
                {
                    cantidad++;
                    sucur[j].mostrarInfo(j, barrio[j]);
                    sucur[j].nombreEmp(sucur[j].cantidad_empleados);
                    promedio += sucur[j].monto_venta;
                    ventas[j] = sucur[j].monto_venta;
                    sum_emp += sucur[j].cantidad_empleados;
                }
            }
            sucur[ind].promedio_ventas(promedio, cantidad);
            sucur[ind].venta_max_min(ventas.Min(), ventas.Max(), barrio[ventas.IndexOf(ventas.Min())], barrio[ventas.IndexOf(ventas.Max())]);
            sucur[ind].promedio_empleados(sum_emp, cantidad);
            sucur[ind].ventas_por_empleado(sum_emp, ventas.Sum(x => Convert.ToInt32(x)));
        }
        public class sucursal
        {
            //metodo constructor 
            public sucursal(int cant)
            {
                nombreEmpleados = new string[cant];
            }

            //atributos da
            
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
            public void mostrarInfo(int indice, string barrio)
            {
                Console.WriteLine("Número de sucursal {0} en {1}", numero_sucursal, barrio[indice]);
                Console.WriteLine("Monto de venta: {0}", monto_venta);
                Console.WriteLine("Cantidad de empleados: {0}", cantidad_empleados);
                Console.WriteLine("Clientes del mes: {0}", cantidad_clientes_mes);
            }
            public void nombreEmp(int cant)
            {
                for (int i = 0; i < cant; i++) Console.WriteLine("Empleado {0}: {1} ", (i + 1), nombreEmpleados[i]);
                Console.WriteLine("-----------------------------");
            }
            public void promedio_ventas(int suma, int cantidad) { Console.WriteLine("El promedio de ventas es: {0}", (suma/cantidad)); }

            public void promedio_empleados(int cant_emp, int cant_sucur) { Console.WriteLine("El promedio de empleados es: {0}", (cant_emp / cant_sucur)); }
            
            public void venta_max_min(int? min, int? max, string sucur_menor, string sucur_mayor) {
                Console.WriteLine("La sucursal con la venta máxima es {0} con valor de venta {1}", sucur_mayor, max);
                Console.WriteLine("La sucursal con la venta menor es {0} con valor de venta {1}", sucur_menor, min);
            }
            
            public void ventas_por_empleado(int cant_emp, int cant_ventas) {
                Console.WriteLine("El promedio de ventas por empleado es {0}", ( cant_ventas / cant_emp));
            }
        }

    }
}
