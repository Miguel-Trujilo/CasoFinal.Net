namespace icbfform
{
    partial class registro_de_asistencia
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
            this.lblRegisAsistencia = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtbFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisAsistencia
            // 
            this.lblRegisAsistencia.AutoSize = true;
            this.lblRegisAsistencia.Location = new System.Drawing.Point(325, 46);
            this.lblRegisAsistencia.Name = "lblRegisAsistencia";
            this.lblRegisAsistencia.Size = new System.Drawing.Size(147, 13);
            this.lblRegisAsistencia.TabIndex = 0;
            this.lblRegisAsistencia.Text = "REGISTRO DE ASISTENCIA";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(111, 96);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(114, 142);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "FECHA";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(114, 206);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "ESTADO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmlId,
            this.cmlFecha,
            this.cmlEstado});
            this.dataGridView1.Location = new System.Drawing.Point(114, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // cmlId
            // 
            this.cmlId.HeaderText = "ID";
            this.cmlId.Name = "cmlId";
            this.cmlId.ReadOnly = true;
            // 
            // cmlFecha
            // 
            this.cmlFecha.HeaderText = "FECHA";
            this.cmlFecha.Name = "cmlFecha";
            this.cmlFecha.ReadOnly = true;
            // 
            // cmlEstado
            // 
            this.cmlEstado.HeaderText = "ESTADO";
            this.cmlEstado.Name = "cmlEstado";
            this.cmlEstado.ReadOnly = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(227, 96);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // dtbFecha
            // 
            this.dtbFecha.Location = new System.Drawing.Point(227, 142);
            this.dtbFecha.Name = "dtbFecha";
            this.dtbFecha.Size = new System.Drawing.Size(121, 20);
            this.dtbFecha.TabIndex = 6;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "sleccione",
            "Enfermo",
            "Sano",
            "Dedicado"});
            this.cmbEstado.Location = new System.Drawing.Point(227, 203);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(499, 91);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(499, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // registro_de_asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtbFecha);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblRegisAsistencia);
            this.Name = "registro_de_asistencia";
            this.Text = "registro_de_asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisAsistencia;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlEstado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtbFecha;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEditar;
    }
}