﻿namespace appExamen.net
{
    partial class Contenedor
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
            this.Nuevo = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.DGVproductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Tipo = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(64, 161);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Nuevo.TabIndex = 0;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(230, 161);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(596, 161);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(410, 161);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 2;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // DGVproductos
            // 
            this.DGVproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproductos.Location = new System.Drawing.Point(165, 211);
            this.DGVproductos.Name = "DGVproductos";
            this.DGVproductos.Size = new System.Drawing.Size(475, 150);
            this.DGVproductos.TabIndex = 4;
            this.DGVproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproductos_CellClick);
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Location = new System.Drawing.Point(64, 90);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(230, 90);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 6;
            // 
            // Tipo
            // 
            this.Tipo.Location = new System.Drawing.Point(576, 90);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(100, 20);
            this.Tipo.TabIndex = 8;
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(410, 90);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Cantidad.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.DGVproductos);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Nuevo);
            this.Name = "Contenedor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Contenedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.DataGridView DGVproductos;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Tipo;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

