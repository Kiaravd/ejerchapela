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
            int sucursal_elegida;
            string nombre;
            string afirmar;
            bool[] consulta = { false, false, false, false };
            sucursal[] sucur = new sucursal[4];
            do 
            {
                Console.WriteLine("¿A cuál sucursal desea ingresar? (ingrese solo el número)");
                Console.WriteLine("Sucursal 1: Almagro");
                Console.WriteLine("Sucursal 2: Balvanera");
                Console.WriteLine("Sucursal 3: Caballito");
                Console.WriteLine("Sucursal 4: Microcentro");
                sucursal_elegida = Convert.ToInt32(Console.ReadLine());
                switch (sucursal_elegida)
                {
                    case 1:
                        if (consulta[0] == false)
                        {
                            Console.WriteLine("Usted ingresó a la sucursal 1: Almagro");
                            Console.WriteLine("Ingresar cantidad de empleados: ");
                            int intermediario = Convert.ToInt16(Console.ReadLine());
                            sucur[0] = new sucursal(intermediario);
                            sucur[0].cantidad_empleados = intermediario;
                            sucur[0].numero_sucursal = 1;
                            Console.WriteLine("Ingresar monto de venta: ");
                            sucur[0].monto_venta = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresar cantidad de clientes que compraron este mes: ");
                            sucur[0].cantidad_clientes_mes = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < sucur[0].cantidad_empleados; i++)
                            {
                                Console.WriteLine("Ingrese nombre del empleado {0}", (i + 1));
                                nombre = Console.ReadLine();
                                sucur[0].nombreEmpleados[i] = nombre;
                            }
                           
                            consulta[0] = true;
                        }
                        else
                        {
                            Console.WriteLine("Ya ingresó los datos de esta sucursal.");
                        }
                        break;
                    case 2:
                        if (consulta[1] == false)
                        {
                            Console.WriteLine("Usted ingresó a la sucursal 2: Balvanera");
                            Console.WriteLine("Ingresar cantidad de empleados: ");
                            int intermediario = Convert.ToInt16(Console.ReadLine());
                            sucur[1] = new sucursal(intermediario);
                            sucur[1].cantidad_empleados = intermediario;
                            sucur[1].numero_sucursal = 2;
                            Console.WriteLine("Ingresar monto de venta: ");
                            sucur[1].monto_venta = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresar cantidad de clientes que compraron este mes: ");
                            sucur[1].cantidad_clientes_mes = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < sucur[1].cantidad_empleados; i++)
                            {
                                Console.WriteLine("Ingrese nombre del empleado {0}", (i + 1));
                                nombre = Console.ReadLine();
                                sucur[1].nombreEmpleados[i] = nombre;
                            }
                           
                            consulta[1] = true;
                        }
                        else
                        {
                            Console.WriteLine("Ya ingresó los datos de esta sucursal.");
                        }
                        break;
                    case 3:
                        if (consulta[2] == false)
                        {
                            Console.WriteLine("Usted ingresó a la sucursal 3: Caballito");
                            Console.WriteLine("Ingresar cantidad de empleados: ");
                            int intermediario = Convert.ToInt16(Console.ReadLine());
                            sucur[2] = new sucursal(intermediario);
                            sucur[2].cantidad_empleados = intermediario;
                            sucur[2].numero_sucursal = 3;
                            Console.WriteLine("Ingresar monto de venta: ");
                            sucur[2].monto_venta = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresar cantidad de clientes que compraron este mes: ");
                            sucur[2].cantidad_clientes_mes = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < sucur[2].cantidad_empleados; i++)
                            {
                                Console.WriteLine("Ingrese nombre del empleado {0}", (i + 1));
                                nombre = Console.ReadLine();
                                sucur[2].nombreEmpleados[i] = nombre;
                            }
                            consulta[2] = true;
                        }
                        else
                        {
                            Console.WriteLine("Ya ingresó los datos de esta sucursal.");
                        }
                        break;
                    case 4:
                        if (consulta[3] == false)
                        {
                            Console.WriteLine("Usted ingresó a la sucursal 4: Microcentro");
                            Console.WriteLine("Ingresar cantidad de empleados: ");
                            int intermediario = Convert.ToInt16(Console.ReadLine());
                            sucur[3] = new sucursal(intermediario);
                            sucur[3].cantidad_empleados = intermediario;
                            sucur[3].numero_sucursal = 4;
                            Console.WriteLine("Ingresar monto de venta: ");
                            sucur[3].monto_venta = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresar cantidad de clientes que compraron este mes: ");
                            sucur[3].cantidad_clientes_mes = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < sucur[3].cantidad_empleados; i++)
                            {
                                Console.WriteLine("Ingrese nombre del empleado {0}", (i + 1));
                                nombre = Console.ReadLine();
                                sucur[3].nombreEmpleados[i] = nombre;
                            }
                            
                            consulta[3] = true;
                        }
                        else
                        {
                            Console.WriteLine("Ya ingresó los datos de esta sucursal.");
                        }
                        break;
                }
                Console.WriteLine("¿Desea agregar otra?");
                afirmar = Console.ReadLine();
            } while (afirmar == "si" || afirmar == "Si" || afirmar == "sI" || afirmar == "SI" || afirmar == "Sí");

            for( int j = 0; j < consulta.Length; j++)
            {
                if (consulta[j] == true)
                {
                    sucur[j].mostrarInfo(j);
                    sucur[j].nombreEmp(sucur[j].cantidad_empleados);
                }
            }

        }
        public class sucursal
        {
            //metodo constructor 
            public sucursal(int cant)
            {
                nombreEmpleados = new string[cant];
            }

            //atributos da
            public string[] barrio = { "Almagro", "Balvanera", "Caballito", "Microcentro" };
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
            public void mostrarInfo(int cant)
            {
                Console.WriteLine("Número de sucursal {0} en {1}", numero_sucursal, barrio[cant]);
                Console.WriteLine("Monto de venta: {0}", monto_venta);
                Console.WriteLine("Cantidad de empleados: {0}", cantidad_empleados);
                Console.WriteLine("Clientes del mes: {0}", cantidad_clientes_mes);
            }
            public void nombreEmp(int cant)
            {
                for (int i = 0; i < cant; i++) Console.WriteLine("Empleado {0}: {1} ", (i + 1), nombreEmpleados[i]);
                Console.WriteLine("-----------------------------");
            }
            public void promedio_ventas() { }
            public void promedio_empleados() { }
            public void venta_total() { }
            public void venta_maxima() { }
            public void venta_minima() { }

        }

    }
}
