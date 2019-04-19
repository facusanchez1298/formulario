namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.radioVaron = new System.Windows.Forms.RadioButton();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.radioNoBinario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(106, 75);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(260, 75);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 393);
            this.dataGridView1.TabIndex = 4;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(106, 12);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(103, 20);
            this.textNombre.TabIndex = 5;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(106, 38);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(103, 20);
            this.textApellido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(37, 41);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(43, 13);
            this.labelApellido.TabIndex = 8;
            this.labelApellido.Text = "apellido";
            // 
            // radioVaron
            // 
            this.radioVaron.AutoSize = true;
            this.radioVaron.Location = new System.Drawing.Point(238, 15);
            this.radioVaron.Name = "radioVaron";
            this.radioVaron.Size = new System.Drawing.Size(52, 17);
            this.radioVaron.TabIndex = 9;
            this.radioVaron.TabStop = true;
            this.radioVaron.Text = "varon";
            this.radioVaron.UseVisualStyleBackColor = true;
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Location = new System.Drawing.Point(296, 15);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(50, 17);
            this.radioMujer.TabIndex = 9;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            // 
            // radioNoBinario
            // 
            this.radioNoBinario.AutoSize = true;
            this.radioNoBinario.Location = new System.Drawing.Point(354, 15);
            this.radioNoBinario.Name = "radioNoBinario";
            this.radioNoBinario.Size = new System.Drawing.Size(71, 17);
            this.radioNoBinario.TabIndex = 9;
            this.radioNoBinario.TabStop = true;
            this.radioNoBinario.Text = "no binario";
            this.radioNoBinario.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 491);
            this.Controls.Add(this.radioNoBinario);
            this.Controls.Add(this.radioMujer);
            this.Controls.Add(this.radioVaron);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonCerrar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.RadioButton radioVaron;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.RadioButton radioNoBinario;
    }
}