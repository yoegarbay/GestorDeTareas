using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsClase
{
    internal class Tarea
    {
        // Atributo privado para el título
        private String titulo;

        // Propiedad pública para acceder y modificar el título
        public String Titulo
        {
            get
            {
                return titulo; // Retorna el valor almacenado
            }

            set
            {
                titulo = value; // Asigna el nuevo valor recibido
            }
        }

        // Atributos privados de la tarea
        private String Descripcion; // Almacena el detalle de la tarea
        private DateTime Fecha;     // Almacena la fecha de vencimiento o creación
        private bool Completada;    // Indica si la tarea está terminada o no

        // Constructor para inicializar todos los campos de la tarea
        public Tarea(String Titulo, String Descripcion, bool Completada, DateTime Fecha)
        {
            this.Titulo = Titulo;           // Asigna el título a través de la propiedad
            this.Descripcion = Descripcion; // Asigna la descripción directamente
            this.Completada = Completada;   // Establece el estado inicial
            this.Fecha = Fecha;             // Establece la fecha recibida
        }
    }
}
