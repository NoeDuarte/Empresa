using Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Supervisor : Empleado
{
    private string despacho;
    private Empleado secretario;
    private string matricula;
    private string marca;
    private string modelo;

    public Supervisor(string nombre, string apellidos, string dni, string direccion, int edad, int antiguedad, string telefono, double salario, Empleado supervisor, string despacho, Empleado secretario, string matricula, string marca, string modelo) : base(nombre, apellidos, dni, direccion, edad, antiguedad, telefono, salario, supervisor)
    {
        this.despacho = despacho;
        this.secretario = secretario;
        this.matricula = matricula;
        this.marca = marca;
        this.modelo = modelo;
    }
    public void CambiarSecretario(Empleado nuevoSecretario)
    {
        this.secretario = nuevoSecretario;
    }

    public void CambiarCoche(string matricula, string marca, string modelo)
    {
        this.matricula = matricula;
        this.marca = marca;
        this.modelo = modelo;
    }

    public void IncrementarSalario()
    {
        base.IncrementarSalario();
        this.salario *= 1.2;
    }
}