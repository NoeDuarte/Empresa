using Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Principal
{
    static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("Juan", "García", "12345678A", "Calle Mayor 1", 30, 5, "123456789", 1000, null);
        Empleado empleado2 = new Empleado("María", "López", "87654321B", "Calle Menor 2", 25, 2, "987654321", 800, empleado1);
        Supervisor supervisor1 = new Supervisor("Pedro", "Pérez", "11111111C", "Calle Principal 3", 40, 10, "555555555", 2000, empleado1, "Despacho 1", empleado2, "1234ABC", "Seat", "Ibiza");

        // Incrementar salario de todos los empleados
        empleado1.IncrementarSalario();
        Console.WriteLine  ( empleado2.IncrementarSalario());
       // supervisor1.IncrementarSalario();
        empleado2.Presentarse();
    }
}
