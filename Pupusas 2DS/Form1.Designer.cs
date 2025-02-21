namespace Pupusas_2DS
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
            this.labelPupusas = new System.Windows.Forms.Label();
            this.labelBebidas = new System.Windows.Forms.Label();
            this.comboBoxPupusas = new System.Windows.Forms.ComboBox();
            this.comboBoxBebidas = new System.Windows.Forms.ComboBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPupusas
            // 
            this.labelPupusas.AutoSize = true;
            this.labelPupusas.Location = new System.Drawing.Point(58, 28);
            this.labelPupusas.Name = "labelPupusas";
            this.labelPupusas.Size = new System.Drawing.Size(110, 13);
            this.labelPupusas.TabIndex = 0;
            this.labelPupusas.Text = "Variedad de pupusas ";
            // 
            // labelBebidas
            // 
            this.labelBebidas.AutoSize = true;
            this.labelBebidas.Location = new System.Drawing.Point(334, 28);
            this.labelBebidas.Name = "labelBebidas";
            this.labelBebidas.Size = new System.Drawing.Size(105, 13);
            this.labelBebidas.TabIndex = 1;
            this.labelBebidas.Text = "Variedad de Bebidas";
            // 
            // comboBoxPupusas
            // 
            this.comboBoxPupusas.FormattingEnabled = true;
            this.comboBoxPupusas.Items.AddRange(new object[] {
            "Pupusas Revueltas ",
            "Pupusas Frijol con Queso ",
            "Pupusas de Queso"});
            this.comboBoxPupusas.Location = new System.Drawing.Point(63, 60);
            this.comboBoxPupusas.Name = "comboBoxPupusas";
            this.comboBoxPupusas.Size = new System.Drawing.Size(104, 21);
            this.comboBoxPupusas.TabIndex = 2;
            // 
            // comboBoxBebidas
            // 
            this.comboBoxBebidas.FormattingEnabled = true;
            this.comboBoxBebidas.Items.AddRange(new object[] {
            "Jugos ",
            "Gaseosa",
            "Cerveza ",
            "Agua "});
            this.comboBoxBebidas.Location = new System.Drawing.Point(337, 60);
            this.comboBoxBebidas.Name = "comboBoxBebidas";
            this.comboBoxBebidas.Size = new System.Drawing.Size(95, 21);
            this.comboBoxBebidas.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(29, 139);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(139, 36);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar a la cuenta ";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click_1);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(286, 146);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(152, 39);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "Calcular Total";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(474, 126);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(475, 154);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(79, 20);
            this.textBoxTotal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.comboBoxBebidas);
            this.Controls.Add(this.comboBoxPupusas);
            this.Controls.Add(this.labelBebidas);
            this.Controls.Add(this.labelPupusas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPupusas;
        private System.Windows.Forms.Label labelBebidas;
        private System.Windows.Forms.ComboBox comboBoxPupusas;
        private System.Windows.Forms.ComboBox comboBoxBebidas;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}

