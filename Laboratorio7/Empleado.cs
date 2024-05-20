using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7_Formulario
{
    class Arquitecto
    {
        // Atributos
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string CondicionContrato { get; set; } // Estable o Contratado
        public string Especialidad { get; set; } // Estructuras o Recursos Hídricos
        public string TipoActividad { get; set; } // Supervisión de Obras o Supervisión de Vías
        public string TipoAfiliacion { get; set; } // AFP o SNP
        public string Condicion { get; internal set; }

        // Constructor
        public Arquitecto(int codigo, string nombre, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
        {
            Codigo = codigo;
            Nombre = nombre;
            CondicionContrato = condicionContrato;
            Especialidad = especialidad;
            TipoActividad = tipoActividad;
            TipoAfiliacion = tipoAfiliacion;
            
            
        }

        // Método para calcular el sueldo base
        public double CalcularSueldoBase()
        {
            // Obtener los valores de sueldo base según la imagen
            double sueldoBaseEstableObras = 4000;
            double sueldoBaseEstableVias = 6000;
            double sueldoBaseContratadoObras = 2000;
            double sueldoBaseContratadoVias = 4500;

            // Calcular el sueldo base según la condición de contrato y tipo de actividad
            if (CondicionContrato == "Estable")
            {
                if (TipoActividad == "Supervisión de Obras")
                    return sueldoBaseEstableObras;
                else if (TipoActividad == "Supervisión de Vías")
                    return sueldoBaseEstableVias;
            }
            else if (CondicionContrato == "Contratado")
            {
                if (TipoActividad == "Supervisión de Obras")
                    return sueldoBaseContratadoObras;
                else if (TipoActividad == "Supervisión de Vías")
                    return sueldoBaseContratadoVias;
            }

            // Si no se encuentra una combinación válida, retornar 0
            return 0;
        }
    }
}