using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsClase
{
    /// <summary>
    /// Clase encargada de administrar una lista de tareas mediante un arreglo interno.
    /// </summary>
    internal class GestorTareas
    {
        // --- Atributos privados ---
        private Tarea[] tareas;   // Arreglo que almacenará los objetos de tipo Tarea
        private int tamaño;       // Capacidad máxima del arreglo
        private int elementos;    // Contador de tareas actualmente almacenadas

        //Constructor que inicializa el gestor con una capacidad específica.
        //Cantidad máxima de tareas que podrá manejar.
        public GestorTareas(int Tamaño)
        {
            this.tamaño = Tamaño;
            this.tareas = new Tarea[Tamaño];
            this.elementos = 0; // Inicializamos el contador de elementos en cero
        }


        public bool AñadirTarea(Tarea nuevaTarea)
        {
            if (elementos < tamaño && nuevaTarea != null)
            {
                tareas[elementos] = nuevaTarea;
                elementos++;
                return true;
            }
            return false;
        }

        public bool EliminarTarea(int indice)
        {
            if (indice >= 0 && indice < elementos)
            {
                for (int i = indice; i < elementos - 1; i++)
                {
                    tareas[i] = tareas[i + 1];
                }
                tareas[elementos - 1] = null;
                elementos--;
                return true;
            }
            return false;
        }


        public bool MarcarComoCompletada(int indice)
        {
            if (indice >= 0 && indice < elementos)
            {
                return true;
            }
            return false;
        }
    }
}
