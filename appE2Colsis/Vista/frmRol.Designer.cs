﻿namespace appE2Colsis.Vista
{
    partial class frmRol
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
            this.lblRol = new Guna.UI.WinForms.GunaLabel();
            this.txtRol = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpfrmrol = new System.Windows.Forms.GroupBox();
            this.rbHabilitadofrm2 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.frm2 = new System.Windows.Forms.Label();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbHabilitadofrm1 = new System.Windows.Forms.RadioButton();
            this.frm1 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.grpEliminarRol = new System.Windows.Forms.GroupBox();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnSeleccionar = new Guna.UI.WinForms.GunaButton();
            this.cmbRol = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvContenidoRol = new System.Windows.Forms.DataGrid();
            this.dgvSeleccionar = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpfrmrol.SuspendLayout();
            this.grpPermisos.SuspendLayout();
            this.grpEliminarRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenidoRol)).BeginInit();
            this.dgvSeleccionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(12, 58);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(85, 17);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Nombre Rol";
            // 
            // txtRol
            // 
            this.txtRol.BackColor = System.Drawing.Color.Transparent;
            this.txtRol.BaseColor = System.Drawing.Color.White;
            this.txtRol.BorderColor = System.Drawing.Color.Silver;
            this.txtRol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRol.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRol.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRol.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRol.Location = new System.Drawing.Point(103, 49);
            this.txtRol.Name = "txtRol";
            this.txtRol.PasswordChar = '\0';
            this.txtRol.Radius = 10;
            this.txtRol.SelectedText = "";
            this.txtRol.Size = new System.Drawing.Size(123, 26);
            this.txtRol.TabIndex = 1;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(60, 91);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(69, 31);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Crear Rol";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpfrmrol);
            this.groupBox1.Controls.Add(this.gunaButton3);
            this.groupBox1.Controls.Add(this.grpPermisos);
            this.groupBox1.Controls.Add(this.gunaButton2);
            this.groupBox1.Controls.Add(this.gunaButton1);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Controls.Add(this.txtRol);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // grpfrmrol
            // 
            this.grpfrmrol.BackColor = System.Drawing.Color.Transparent;
            this.grpfrmrol.Controls.Add(this.rbHabilitadofrm2);
            this.grpfrmrol.Controls.Add(this.radioButton5);
            this.grpfrmrol.Controls.Add(this.frm2);
            this.grpfrmrol.Location = new System.Drawing.Point(15, 232);
            this.grpfrmrol.Name = "grpfrmrol";
            this.grpfrmrol.Size = new System.Drawing.Size(252, 62);
            this.grpfrmrol.TabIndex = 9;
            this.grpfrmrol.TabStop = false;
            // 
            // rbHabilitadofrm2
            // 
            this.rbHabilitadofrm2.AutoSize = true;
            this.rbHabilitadofrm2.Location = new System.Drawing.Point(76, 19);
            this.rbHabilitadofrm2.Name = "rbHabilitadofrm2";
            this.rbHabilitadofrm2.Size = new System.Drawing.Size(72, 17);
            this.rbHabilitadofrm2.TabIndex = 13;
            this.rbHabilitadofrm2.Text = "Habilitado";
            this.rbHabilitadofrm2.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(168, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(83, 17);
            this.radioButton5.TabIndex = 14;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Desabilitado";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // frm2
            // 
            this.frm2.AutoSize = true;
            this.frm2.Location = new System.Drawing.Point(28, 14);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(37, 13);
            this.frm2.TabIndex = 5;
            this.frm2.Text = "frmRol";
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(135, 93);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 10;
            this.gunaButton3.Size = new System.Drawing.Size(107, 29);
            this.gunaButton3.TabIndex = 8;
            this.gunaButton3.Text = "Asignar Permisos";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.label1);
            this.grpPermisos.Controls.Add(this.radioButton2);
            this.grpPermisos.Controls.Add(this.rbHabilitadofrm1);
            this.grpPermisos.Controls.Add(this.frm1);
            this.grpPermisos.Location = new System.Drawing.Point(6, 157);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Size = new System.Drawing.Size(268, 217);
            this.grpPermisos.TabIndex = 4;
            this.grpPermisos.TabStop = false;
            this.grpPermisos.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Permisos";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(168, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Desabilitado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbHabilitadofrm1
            // 
            this.rbHabilitadofrm1.AutoSize = true;
            this.rbHabilitadofrm1.Location = new System.Drawing.Point(76, 47);
            this.rbHabilitadofrm1.Name = "rbHabilitadofrm1";
            this.rbHabilitadofrm1.Size = new System.Drawing.Size(72, 17);
            this.rbHabilitadofrm1.TabIndex = 8;
            this.rbHabilitadofrm1.Text = "Habilitado";
            this.rbHabilitadofrm1.UseVisualStyleBackColor = false;
            // 
            // frm1
            // 
            this.frm1.AutoSize = true;
            this.frm1.Location = new System.Drawing.Point(15, 49);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(60, 13);
            this.frm1.TabIndex = 3;
            this.frm1.Text = "frmPersona";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(82, 380);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(107, 29);
            this.gunaButton2.TabIndex = 7;
            this.gunaButton2.Text = "Asignar Permisos";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // grpEliminarRol
            // 
            this.grpEliminarRol.Controls.Add(this.dgvSeleccionar);
            this.grpEliminarRol.Controls.Add(this.btnSeleccionar);
            this.grpEliminarRol.Controls.Add(this.cmbRol);
            this.grpEliminarRol.Controls.Add(this.gunaLabel1);
            this.grpEliminarRol.Location = new System.Drawing.Point(310, 12);
            this.grpEliminarRol.Name = "grpEliminarRol";
            this.grpEliminarRol.Size = new System.Drawing.Size(276, 426);
            this.grpEliminarRol.TabIndex = 4;
            this.grpEliminarRol.TabStop = false;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(79, 197);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 10;
            this.gunaButton4.Size = new System.Drawing.Size(69, 31);
            this.gunaButton4.TabIndex = 6;
            this.gunaButton4.Text = "Eliminar";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(6, 11);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(213, 15);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "El Rol contiene los siguientes permisos:\r\n";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AnimationHoverSpeed = 0.07F;
            this.btnSeleccionar.AnimationSpeed = 0.03F;
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSeleccionar.BorderColor = System.Drawing.Color.Black;
            this.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionar.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Image = null;
            this.btnSeleccionar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeleccionar.Location = new System.Drawing.Point(25, 109);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSeleccionar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeleccionar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.OnHoverImage = null;
            this.btnSeleccionar.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionar.Radius = 10;
            this.btnSeleccionar.Size = new System.Drawing.Size(69, 31);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BaseColor = System.Drawing.Color.White;
            this.cmbRol.BorderColor = System.Drawing.Color.Silver;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRol.ForeColor = System.Drawing.Color.Black;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(25, 77);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRol.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRol.Size = new System.Drawing.Size(150, 26);
            this.cmbRol.TabIndex = 1;
            
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(22, 49);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(153, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Seleccione el Rol a eliminar:";
            // 
            // dgvContenidoRol
            // 
            this.dgvContenidoRol.AlternatingBackColor = System.Drawing.Color.White;
            this.dgvContenidoRol.BackgroundColor = System.Drawing.Color.White;
            this.dgvContenidoRol.CaptionBackColor = System.Drawing.Color.White;
            this.dgvContenidoRol.DataMember = "";
            this.dgvContenidoRol.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvContenidoRol.Location = new System.Drawing.Point(9, 50);
            this.dgvContenidoRol.Name = "dgvContenidoRol";
            this.dgvContenidoRol.ReadOnly = true;
            this.dgvContenidoRol.Size = new System.Drawing.Size(223, 141);
            this.dgvContenidoRol.TabIndex = 7;
            // 
            // dgvSeleccionar
            // 
            this.dgvSeleccionar.Controls.Add(this.dgvContenidoRol);
            this.dgvSeleccionar.Controls.Add(this.gunaLabel2);
            this.dgvSeleccionar.Controls.Add(this.gunaButton4);
            this.dgvSeleccionar.Location = new System.Drawing.Point(6, 146);
            this.dgvSeleccionar.Name = "dgvSeleccionar";
            this.dgvSeleccionar.Size = new System.Drawing.Size(265, 245);
            this.dgvSeleccionar.TabIndex = 8;
            this.dgvSeleccionar.TabStop = false;
            // 
            // frmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 457);
            this.Controls.Add(this.grpEliminarRol);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRol";
            this.Text = "frmRol";
            this.Load += new System.EventHandler(this.frmRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpfrmrol.ResumeLayout(false);
            this.grpfrmrol.PerformLayout();
            this.grpPermisos.ResumeLayout(false);
            this.grpPermisos.PerformLayout();
            this.grpEliminarRol.ResumeLayout(false);
            this.grpEliminarRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenidoRol)).EndInit();
            this.dgvSeleccionar.ResumeLayout(false);
            this.dgvSeleccionar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblRol;
        private Guna.UI.WinForms.GunaTextBox txtRol;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private System.Windows.Forms.GroupBox grpPermisos;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label frm1;
        private System.Windows.Forms.Label frm2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbHabilitadofrm1;
        private System.Windows.Forms.GroupBox grpfrmrol;
        private System.Windows.Forms.RadioButton rbHabilitadofrm2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEliminarRol;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnSeleccionar;
        private Guna.UI.WinForms.GunaComboBox cmbRol;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGrid dgvContenidoRol;
        private System.Windows.Forms.GroupBox dgvSeleccionar;
    }
}