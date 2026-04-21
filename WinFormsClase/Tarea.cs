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

        public string Descripcion { get; set; }
        public List<string> Etiquetas { get; set; } = new List<string>();

        // Atributos privados de la tarea
        private String Descripcion; // Almacena el detalle de la tarea
        private DateTime Fecha;     // Almacena la fecha de vencimiento o creación
        private bool Completada;    // Indica si la tarea está terminada o no
        private bool EsPrioridadAlta;
        private String Categoria;

        // Constructor para inicializar todos los campos de la tarea
        public Tarea(string Titulo, string Descripcion, bool Completada, DateTime Fecha, bool EsPrioridadAlta, string Categoria)
        {
            this.Titulo = Titulo;
            this.Descripcion = Descripcion;
            this.Completada = Completada;
            this.Fecha = Fecha;
            this.EsPrioridadAlta = EsPrioridadAlta;
            this.Categoria = Categoria;
        }
    }
}
