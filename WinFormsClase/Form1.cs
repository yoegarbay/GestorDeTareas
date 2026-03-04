namespace WinFormsClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botón Añadir (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // Creamos la tarea con tus parámetros
                Tarea nueva = new Tarea(textBox1.Text, textBox2.Text, false, dateTimePicker1.Value);

                // Agregamos el texto a la lista. 
                // Importante: No guardamos el objeto 'nueva', guardamos el string para que sea simple.
                listBox1.Items.Add(textBox1.Text + " - " + dateTimePicker1.Value.ToShortDateString());

                textBox1.Clear();
                textBox2.Clear();
            }
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            // Verificamos si hay algo seleccionado en la lista
            if (listBox1.SelectedIndex != -1)
            {
                int indice = listBox1.SelectedIndex;
                string texto = listBox1.Items[indice].ToString();

                // Si el texto seleccionado no tiene el check, se lo ponemos
                if (!texto.Contains("✔"))
                {
                    // Actualizamos la línea seleccionada en tu diseño
                    listBox1.Items[indice] = "✔ " + texto;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un elemento de la lista para marcarlo como completado.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Verificamos si hay un elemento seleccionado en el ListBox físico
            if (listBox1.SelectedIndex != -1)
            {
                // Esto elimina la película o tarea que seleccionaste con el ratón
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento de la lista para eliminarlo.");
            }
        }
    }
}
