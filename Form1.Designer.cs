
namespace _1ºActividadADATconEntity
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtChampions = new System.Windows.Forms.TextBox();
            this.lblChampions = new System.Windows.Forms.Label();
            this.txtLigas = new System.Windows.Forms.TextBox();
            this.lblLigas = new System.Windows.Forms.Label();
            this.txtCopasRey = new System.Windows.Forms.TextBox();
            this.lblCopasRey = new System.Windows.Forms.Label();
            this.txtSupercopas = new System.Windows.Forms.TextBox();
            this.lblSupercopas = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(596, 290);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 290);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre del Equipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 290);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtChampions
            // 
            this.txtChampions.Location = new System.Drawing.Point(148, 316);
            this.txtChampions.Name = "txtChampions";
            this.txtChampions.Size = new System.Drawing.Size(100, 20);
            this.txtChampions.TabIndex = 5;
            // 
            // lblChampions
            // 
            this.lblChampions.AutoSize = true;
            this.lblChampions.Location = new System.Drawing.Point(12, 316);
            this.lblChampions.Name = "lblChampions";
            this.lblChampions.Size = new System.Drawing.Size(59, 13);
            this.lblChampions.TabIndex = 4;
            this.lblChampions.Text = "Champions";
            // 
            // txtLigas
            // 
            this.txtLigas.Location = new System.Drawing.Point(148, 342);
            this.txtLigas.Name = "txtLigas";
            this.txtLigas.Size = new System.Drawing.Size(100, 20);
            this.txtLigas.TabIndex = 7;
            // 
            // lblLigas
            // 
            this.lblLigas.AutoSize = true;
            this.lblLigas.Location = new System.Drawing.Point(12, 342);
            this.lblLigas.Name = "lblLigas";
            this.lblLigas.Size = new System.Drawing.Size(32, 13);
            this.lblLigas.TabIndex = 6;
            this.lblLigas.Text = "Ligas";
            // 
            // txtCopasRey
            // 
            this.txtCopasRey.Location = new System.Drawing.Point(148, 368);
            this.txtCopasRey.Name = "txtCopasRey";
            this.txtCopasRey.Size = new System.Drawing.Size(100, 20);
            this.txtCopasRey.TabIndex = 9;
            // 
            // lblCopasRey
            // 
            this.lblCopasRey.AutoSize = true;
            this.lblCopasRey.Location = new System.Drawing.Point(12, 368);
            this.lblCopasRey.Name = "lblCopasRey";
            this.lblCopasRey.Size = new System.Drawing.Size(76, 13);
            this.lblCopasRey.TabIndex = 8;
            this.lblCopasRey.Text = "Copas del Rey";
            // 
            // txtSupercopas
            // 
            this.txtSupercopas.Location = new System.Drawing.Point(148, 394);
            this.txtSupercopas.Name = "txtSupercopas";
            this.txtSupercopas.Size = new System.Drawing.Size(100, 20);
            this.txtSupercopas.TabIndex = 11;
            // 
            // lblSupercopas
            // 
            this.lblSupercopas.AutoSize = true;
            this.lblSupercopas.Location = new System.Drawing.Point(12, 394);
            this.lblSupercopas.Name = "lblSupercopas";
            this.lblSupercopas.Size = new System.Drawing.Size(64, 13);
            this.lblSupercopas.TabIndex = 10;
            this.lblSupercopas.Text = "Supercopas";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(596, 332);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(596, 368);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtSupercopas);
            this.Controls.Add(this.lblSupercopas);
            this.Controls.Add(this.txtCopasRey);
            this.Controls.Add(this.lblCopasRey);
            this.Controls.Add(this.txtLigas);
            this.Controls.Add(this.lblLigas);
            this.Controls.Add(this.txtChampions);
            this.Controls.Add(this.lblChampions);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtChampions;
        private System.Windows.Forms.Label lblChampions;
        private System.Windows.Forms.TextBox txtLigas;
        private System.Windows.Forms.Label lblLigas;
        private System.Windows.Forms.TextBox txtCopasRey;
        private System.Windows.Forms.Label lblCopasRey;
        private System.Windows.Forms.TextBox txtSupercopas;
        private System.Windows.Forms.Label lblSupercopas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

