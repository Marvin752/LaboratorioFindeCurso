﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioEnClase.Data.DataAcces
{
    public class ConsolasPros
    {
            public int id_consola { get; set; }
            public string Nombre { get; set; }
            public string Compania { get; set; }
            public DateTime Fecha_lanzamiento { get; set; }
            public byte Generacion { get; set; }


            // Constructor sin parámetros
            public ConsolasPros() { }

            // Constructor con parámetros
            public ConsolasPros(int id, string nombre, string compania, DateTime fecha_lanzamiento, byte generacion)
            {
                id_consola = id;
                Nombre = nombre;
                Compania = compania;
                Fecha_lanzamiento = fecha_lanzamiento;
                Generacion = generacion;

            }
            // Método para mostrar información del JUEGO
            public override string ToString()
            {
                return $"ID: {id_consola}, Nombre: {Nombre}, Compañia {Compania}, Fecha de Lanzamiento {Fecha_lanzamiento}, Generación {Generacion}";
            }
        }
}
