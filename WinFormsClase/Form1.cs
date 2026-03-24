using System;
using System.Windows.Forms;

namespace WinFormsClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cargar categorías en el ComboBox
            cmbCategoria.Items.Add("Trabajo");
            cmbCategoria.Items.Add("Personal");
            cmbCategoria.Items.Add("Estudios");

            cmbCategoria.SelectedIndex = 0;

            // Inicializar contador
            ActualizarContador();
        }

        // BOTÓN AÑADIR TAREA
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Tarea nueva = new Tarea(
                    textBox1.Text,
                    textBox2.Text,
                    false,
                    dateTimePicker1.Value,
                    chkPrioridadAlta.Checked,
                    cmbCategoria.Text
                );

                string prioridad = chkPrioridadAlta.Checked ? "[!] " : "";

                listBox1.Items.Add(
                    $"{prioridad}{textBox1.Text} ({cmbCategoria.Text}) - {dateTimePicker1.Value.ToShortDateString()}"
                );

                textBox1.Clear();
                textBox2.Clear();

                ActualizarContador();
            }
        }

        // BOTÓN MARCAR COMO COMPLETADA
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int indice = listBox1.SelectedIndex;
                string texto = listBox1.Items[indice].ToString();

                if (!texto.Contains("✔"))
                {
                    listBox1.Items[indice] = "✔ " + texto;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un elemento de la lista para marcarlo como completado.");
            }
        }

        // BOTÓN ELIMINAR TAREA
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                ActualizarContador();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento de la lista para eliminarlo.");
            }
        }

        // BOTÓN LIMPIAR CAMPOS
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        // LIMPIAR FORMULARIO
        private void LimpiarFormulario()
        {
            textBox1.Clear();
            textBox2.Clear();
            chkPrioridadAlta.Checked = false;
            cmbCategoria.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        // ACTUALIZAR CONTADOR
        private void ActualizarContador()
        {
            lblContadorTareas.Text = $"Tareas totales: {listBox1.Items.Count}";
        }

        // MÉTODO PARA MARCAR PRIORIDAD ALTA
        private void MarcarPrioridadAlta()
        {
            if (listBox1.SelectedIndex != -1)
            {
                int indice = listBox1.SelectedIndex;
                string texto = listBox1.Items[indice].ToString();

                if (!texto.Contains("[PRIORIDAD ALTA]"))
                {
                    listBox1.Items[indice] = "[PRIORIDAD ALTA] " + texto;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una tarea para marcarla como prioridad alta.");
            }
        }

        // BOTÓN PRIORIDAD ALTA
        private void btnPrioridadAlta_Click(object sender, EventArgs e)
        {
            MarcarPrioridadAlta();
        }
    }
}