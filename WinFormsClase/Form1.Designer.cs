namespace WinFormsClase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            chkPrioridadAlta = new CheckBox();
            cmbCategoria = new ComboBox();
            lblContadorTareas = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(150, 252);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(480, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 334);
            listBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(123, 398);
            button1.Name = "button1";
            button1.Size = new Size(204, 40);
            button1.TabIndex = 5;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 7;
            label2.Text = "Titulo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 80);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 123);
            textBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 9;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(12, 252);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 10;
            label4.Text = "Fecha";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(589, 398);
            button2.Name = "button2";
            button2.Size = new Size(204, 40);
            button2.TabIndex = 11;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(355, 398);
            button3.Name = "button3";
            button3.Size = new Size(204, 40);
            button3.TabIndex = 12;
            button3.Text = "Completada";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // chkPrioridadAlta
            // 
            chkPrioridadAlta.AutoSize = true;
            chkPrioridadAlta.Location = new Point(12, 312);
            chkPrioridadAlta.Name = "chkPrioridadAlta";
            chkPrioridadAlta.Size = new Size(83, 19);
            chkPrioridadAlta.TabIndex = 13;
            chkPrioridadAlta.Text = "checkBox1";
            chkPrioridadAlta.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(129, 316);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 14;
            // 
            // lblContadorTareas
            // 
            lblContadorTareas.AutoSize = true;
            lblContadorTareas.Location = new Point(270, 322);
            lblContadorTareas.Name = "lblContadorTareas";
            lblContadorTareas.Size = new Size(38, 15);
            lblContadorTareas.TabIndex = 15;
            lblContadorTareas.Text = "label1";
            // 
            // button4
            // 
            button4.Location = new Point(270, 353);
            button4.Name = "button4";
            button4.Size = new Size(157, 23);
            button4.TabIndex = 16;
            button4.Text = "btnLimpiarCampos";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foto_pppp;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(lblContadorTareas);
            Controls.Add(cmbCategoria);
            Controls.Add(chkPrioridadAlta);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private CheckBox chkPrioridadAlta;
        private ComboBox cmbCategoria;
        private Label lblContadorTareas;
        private Button button4;
    }
}
