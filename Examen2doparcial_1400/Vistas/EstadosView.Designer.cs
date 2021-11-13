
namespace Examen2doparcial_1400.Vistas
{
    partial class EstadosView
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
            this.EstadosDataGridView = new System.Windows.Forms.DataGridView();
            this.ResolverCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CerradoCheckBox = new System.Windows.Forms.CheckBox();
            this.AbiertoCheckBox = new System.Windows.Forms.CheckBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EsperaCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.EstadosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstadosDataGridView
            // 
            this.EstadosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstadosDataGridView.Location = new System.Drawing.Point(0, 352);
            this.EstadosDataGridView.Name = "EstadosDataGridView";
            this.EstadosDataGridView.Size = new System.Drawing.Size(438, 125);
            this.EstadosDataGridView.TabIndex = 0;
            // 
            // ResolverCheckBox
            // 
            this.ResolverCheckBox.AutoSize = true;
            this.ResolverCheckBox.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolverCheckBox.Location = new System.Drawing.Point(150, 103);
            this.ResolverCheckBox.Name = "ResolverCheckBox";
            this.ResolverCheckBox.Size = new System.Drawing.Size(110, 31);
            this.ResolverCheckBox.TabIndex = 1;
            this.ResolverCheckBox.Text = "Sin Resolver";
            this.ResolverCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EsperaCheckBox);
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CerradoCheckBox);
            this.groupBox1.Controls.Add(this.AbiertoCheckBox);
            this.groupBox1.Controls.Add(this.ResolverCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos De Estado";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(117, 69);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(172, 22);
            this.IdTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione Una Opcion:";
            // 
            // CerradoCheckBox
            // 
            this.CerradoCheckBox.AutoSize = true;
            this.CerradoCheckBox.Location = new System.Drawing.Point(150, 210);
            this.CerradoCheckBox.Name = "CerradoCheckBox";
            this.CerradoCheckBox.Size = new System.Drawing.Size(83, 20);
            this.CerradoCheckBox.TabIndex = 3;
            this.CerradoCheckBox.Text = "Cerrado";
            this.CerradoCheckBox.UseVisualStyleBackColor = true;
            // 
            // AbiertoCheckBox
            // 
            this.AbiertoCheckBox.AutoSize = true;
            this.AbiertoCheckBox.Location = new System.Drawing.Point(150, 175);
            this.AbiertoCheckBox.Name = "AbiertoCheckBox";
            this.AbiertoCheckBox.Size = new System.Drawing.Size(77, 20);
            this.AbiertoCheckBox.TabIndex = 2;
            this.AbiertoCheckBox.Text = "Abierto";
            this.AbiertoCheckBox.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(307, 290);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(86, 34);
            this.EliminarButton.TabIndex = 16;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(226, 290);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 34);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(127, 290);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(93, 34);
            this.ModificarButton.TabIndex = 14;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(46, 290);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 34);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // EsperaCheckBox
            // 
            this.EsperaCheckBox.AutoSize = true;
            this.EsperaCheckBox.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsperaCheckBox.Location = new System.Drawing.Point(150, 138);
            this.EsperaCheckBox.Name = "EsperaCheckBox";
            this.EsperaCheckBox.Size = new System.Drawing.Size(95, 31);
            this.EsperaCheckBox.TabIndex = 7;
            this.EsperaCheckBox.Text = "En Espera";
            this.EsperaCheckBox.UseVisualStyleBackColor = true;
            // 
            // EstadosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(441, 479);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EstadosDataGridView);
            this.Name = "EstadosView";
            this.Text = "Estados";
            ((System.ComponentModel.ISupportInitialize)(this.EstadosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button ModificarButton;
        public System.Windows.Forms.Button NuevoButton;
        public System.Windows.Forms.DataGridView EstadosDataGridView;
        public System.Windows.Forms.CheckBox ResolverCheckBox;
        public System.Windows.Forms.CheckBox CerradoCheckBox;
        public System.Windows.Forms.CheckBox AbiertoCheckBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.CheckBox EsperaCheckBox;
    }
}