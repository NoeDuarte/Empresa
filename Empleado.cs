using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Empleado
    {
        private string nombre;
        private string apellidos;
        private string dni;
        private string direccion;
        private int edad;
        private int antiguedad;
        private string telefono;
        protected double salario;
        private Empleado supervisor;



        public Empleado(string nombre, string apellidos, string dni, string direccion, int edad, int antiguedad, string telefono, double salario, Empleado supervisor)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.direccion = direccion;
            this.edad = edad;
            this.antiguedad = antiguedad;
            this.telefono = telefono;
            this.salario = salario;
            this.supervisor = supervisor;
        }
        public void Presentarse()
        {
            Console.WriteLine("Hola, mi nombre es " + this.nombre + " " + this.apellidos + " y mi supervisor es " + this.supervisor.nombre + " " + this.supervisor.apellidos);
        }

        public void CambiarSupervisor(Empleado nuevoSupervisor)
        {
            this.supervisor = nuevoSupervisor;
        }

        public int anioNacimiento()
        {
            int anioNacimiento;


            return anioNacimiento = DateTime.Now.Year - this.edad;


        }


        public double IncrementarSalario()
        {
            double incremento = 0.1 + (this.antiguedad * 0.01);

            if (anioNacimiento() < 1964)
            {
                incremento = +0.05;
            }

            return this.salario *= (1.1 + incremento);


        }

        /* public void IncrementarSalario()
         {
             this.salario *= 1.1;
         }*/
    }
}

