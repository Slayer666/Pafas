namespace Pafas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.ComboBox();
            this.genero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.especialidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.extension = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.abdominal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.circuitoAgilidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dosMilMetros = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pruebas Físicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad, N.º años";
            // 
            // edad
            // 
            this.edad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.FormattingEnabled = true;
            this.edad.Items.AddRange(new object[] {
            "Hasta 35",
            "De 36 a 43",
            "De 44 a 51",
            "Mas de 52"});
            this.edad.Location = new System.Drawing.Point(178, 56);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(106, 24);
            this.edad.TabIndex = 2;
            this.edad.Tag = "0";
            // 
            // genero
            // 
            this.genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero.FormattingEnabled = true;
            this.genero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.genero.Location = new System.Drawing.Point(178, 92);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(106, 24);
            this.genero.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genero";
            // 
            // especialidad
            // 
            this.especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialidad.FormattingEnabled = true;
            this.especialidad.Items.AddRange(new object[] {
            "SDA/SYD",
            "OTRAS"});
            this.especialidad.Location = new System.Drawing.Point(178, 126);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(106, 24);
            this.especialidad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Especialidad";
            // 
            // extension
            // 
            this.extension.AccessibleDescription = "";
            this.extension.AccessibleName = "Numero de Extensiones";
            this.extension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extension.FormattingEnabled = true;
            this.extension.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.extension.Location = new System.Drawing.Point(178, 165);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(106, 24);
            this.extension.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nº Extensiones";
            // 
            // abdominal
            // 
            this.abdominal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abdominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abdominal.FormattingEnabled = true;
            this.abdominal.Items.AddRange(new object[] {
            "13",
            "15",
            "17",
            "19",
            "21",
            "23",
            "25",
            "27",
            "29",
            "31",
            "33",
            "35",
            "37",
            "39",
            "41",
            "43",
            "45",
            "47",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70"});
            this.abdominal.Location = new System.Drawing.Point(178, 201);
            this.abdominal.Name = "abdominal";
            this.abdominal.Size = new System.Drawing.Size(106, 24);
            this.abdominal.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nº Abdominales";
            // 
            // circuitoAgilidad
            // 
            this.circuitoAgilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.circuitoAgilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitoAgilidad.FormattingEnabled = true;
            this.circuitoAgilidad.Items.AddRange(new object[] {
            "12.3",
            "12.4",
            "12.5",
            "12.6",
            "12.7",
            "12.8",
            "12.9",
            "13.0",
            "13.1",
            "13.2",
            "13.3",
            "13.4",
            "13.5",
            "13.7",
            "13.9",
            "14.1",
            "14.3",
            "14.5",
            "14.7",
            "14.9",
            "15.1",
            "15.3",
            "15.5",
            "15.7",
            "15.9",
            "16.1",
            "16.3",
            "16.6",
            "16.9",
            "17.2",
            "17.5",
            "17.8",
            "18.1",
            "18.3",
            "18.6",
            "18.9",
            "19.2",
            "19.5",
            "19.8",
            "20.1"});
            this.circuitoAgilidad.Location = new System.Drawing.Point(178, 234);
            this.circuitoAgilidad.Name = "circuitoAgilidad";
            this.circuitoAgilidad.Size = new System.Drawing.Size(106, 24);
            this.circuitoAgilidad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tiempo Cirto. agilidad";
            // 
            // dosMilMetros
            // 
            this.dosMilMetros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dosMilMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosMilMetros.FormattingEnabled = true;
            this.dosMilMetros.Items.AddRange(new object[] {
            "7.30",
            "7.35",
            "7.40",
            "7.45",
            "7.50",
            "8.00",
            "8.10",
            "8.20",
            "8.30",
            "8.40",
            "8.50",
            "9.05",
            "9.20",
            "9.35",
            "9.50",
            "10.05",
            "10.25",
            "10.45",
            "11.05",
            "11.25",
            "11.45",
            "12.15",
            "12.45",
            "13.15",
            "13.45",
            "14.15",
            "14.45",
            "15.15",
            "15.45",
            "16.15",
            "16.45",
            "17.15",
            "17.45",
            "18.15",
            "18.45",
            "19.15",
            "19.45",
            "20.15",
            "21.00",
            "22.00"});
            this.dosMilMetros.Location = new System.Drawing.Point(179, 269);
            this.dosMilMetros.Name = "dosMilMetros";
            this.dosMilMetros.Size = new System.Drawing.Size(105, 24);
            this.dosMilMetros.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "2000 mtrs.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(296, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ayudaToolStripMenuItem.Text = "Menu";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Pafas.Properties.Resources._2014_10_18_183103;
            this.button1.Location = new System.Drawing.Point(15, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 91);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calcular según IG";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dosMilMetros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.circuitoAgilidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.abdominal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.extension);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IG 60-28 - PAFA\'s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox edad;
        private System.Windows.Forms.ComboBox genero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox especialidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox extension;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox abdominal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox circuitoAgilidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dosMilMetros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
    }
}

