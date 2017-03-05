namespace ConverUnidades
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1Desde = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1Hasta = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a Convertir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidad Origen";
            // 
            // listBox1Desde
            // 
            this.listBox1Desde.FormattingEnabled = true;
            this.listBox1Desde.ItemHeight = 20;
            this.listBox1Desde.Items.AddRange(new object[] {
            "--Unidades de Masa--",
            "Tonelada",
            "Kilogramo",
            "Gramo",
            "Miligramo",
            "Libra",
            "Onza",
            "--Unidades de Longitud--",
            "Metro",
            "Yarda",
            "Vara",
            "Milla",
            "Kilometro",
            "Pie",
            "Pulgada",
            "--Unidades de Temperatura--",
            "Centigrados",
            "Fahrenheit",
            "Kelvin",
            "--Unidades de Tiempo--",
            "Horas",
            "Minutos",
            "Segundos",
            "Dia"});
            this.listBox1Desde.Location = new System.Drawing.Point(56, 91);
            this.listBox1Desde.Name = "listBox1Desde";
            this.listBox1Desde.Size = new System.Drawing.Size(220, 164);
            this.listBox1Desde.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unidad Destino";
            // 
            // listBox1Hasta
            // 
            this.listBox1Hasta.FormattingEnabled = true;
            this.listBox1Hasta.ItemHeight = 20;
            this.listBox1Hasta.Items.AddRange(new object[] {
            "--Unidades de Masa--",
            "Tonelada",
            "Kilogramo",
            "Gramo",
            "Miligramo",
            "Libra",
            "Onza",
            "--Unidades de Longitud--",
            "Metro",
            "Yarda",
            "Vara",
            "Milla",
            "Kilometro",
            "Pie",
            "Pulgada",
            "--Unidades de Temperatura--",
            "Centigrados",
            "Fahrenheit",
            "Kelvin",
            "--Unidades de Tiempo--",
            "Horas",
            "Minutos",
            "Segundos",
            "Dia"});
            this.listBox1Hasta.Location = new System.Drawing.Point(368, 91);
            this.listBox1Hasta.Name = "listBox1Hasta";
            this.listBox1Hasta.Size = new System.Drawing.Size(220, 164);
            this.listBox1Hasta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Respuesta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(457, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "CONVERTIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(654, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(271, 210);
            this.dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Eliminar Resultados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 388);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1Hasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1Desde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversor de Unidades";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1Desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1Hasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

