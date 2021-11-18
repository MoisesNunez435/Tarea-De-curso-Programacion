using System;
using System.Collections.Generic;
using System.Text;

namespace Domaain
{
    public class Empleado { 
    public int Id { get; set; }
    public string NombreCompleto { get; set; }
    public double SalarioBase { get; set; }
    public int HorasExtras { get; set; }
    public double SalarioAnual => SalarioBase * 12;
    public double IngresoHorasExtras => Math.Round((2 * (SalarioBase / 240)) * SalarioBase);
    public double TotalDeIngreso => IngresoHorasExtras + SalarioBase; 
    public double InssLaboral => Math.Round(TotalDeIngreso * 0.07,3);
    public double InssPatronal => Math.Round((TotalDeIngreso * 0.215),3);
    public double IR => Math.Round(CalcularIR(SalarioBase),3); 
    public double Deducciones => InssLaboral + IR;
    public double RecibirNeto => TotalDeIngreso - Deducciones;

    public double CalcularIR(double Salario)
    {
        double exceso = 0;
        double sumabase = 0;
        double porcentaje = 0;
        double SalarioAnual = Salario * 12;
        double IR = 0;
        if (SalarioAnual >= 1 && SalarioAnual <= 100000)
        {
            IR = SalarioAnual / 12;
            return IR;

        }
        else if (SalarioAnual >= 100001 && SalarioAnual <= 200000)
        {

            exceso = SalarioAnual - 100000;
            porcentaje = exceso * 0.15;
            //sumamos la base y dividimos entre 12
            IR = porcentaje / 12;
            return IR;
        }
        else if (SalarioAnual >= 200001 && SalarioAnual <= 350000)
        {
            exceso = SalarioAnual - 200000;
            porcentaje = exceso * 0.20f;
            sumabase = porcentaje + 15000;
            IR = sumabase / 12;
            return IR;
        }
        else if (SalarioAnual >= 350001 && SalarioAnual <= 500000)
        {
            exceso = SalarioAnual - 350000;
            porcentaje = exceso * 0.25f;
            sumabase = porcentaje + 45000;
            IR = sumabase / 12;
            return IR;
        }
        else if (SalarioAnual >= 500001)
        {
            exceso = SalarioAnual - 500000;
            porcentaje = exceso * 0.30f;
            sumabase = porcentaje + 82500;
            IR = sumabase / 12;
            return IR;
        }
        return IR;
    }

}
}
