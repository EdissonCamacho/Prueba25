
namespace appE2Colsis.Vista
{
    partial class frmHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorario));
            this.lbHorario = new Guna.UI.WinForms.GunaLabel();
            this.cmbCurso = new Guna.UI.WinForms.GunaComboBox();
            this.lbCurso = new Guna.UI.WinForms.GunaLabel();
            this.lblAsignatura = new Guna.UI.WinForms.GunaLabel();
            this.cmbAsignatura = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cmbDia = new Guna.UI.WinForms.GunaComboBox();
            this.txthInicio = new Guna.UI.WinForms.GunaTextBox();
            this.txthFinal = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cmbCursoFiltrar = new Guna.UI.WinForms.GunaComboBox();
            this.gdvFiltro = new System.Windows.Forms.DataGridView();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.Location = new System.Drawing.Point(340, 22);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(116, 33);
            this.lbHorario.TabIndex = 0;
            this.lbHorario.Text = "Horario";
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.Transparent;
            this.cmbCurso.BaseColor = System.Drawing.Color.White;
            this.cmbCurso.BorderColor = System.Drawing.Color.Silver;
            this.cmbCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurso.ForeColor = System.Drawing.Color.Black;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(83, 96);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCurso.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCurso.Size = new System.Drawing.Size(121, 26);
            this.cmbCurso.TabIndex = 2;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCurso.Location = new System.Drawing.Point(33, 101);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(41, 15);
            this.lbCurso.TabIndex = 3;
            this.lbCurso.Text = "Curso:";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAsignatura.Location = new System.Drawing.Point(13, 133);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(64, 15);
            this.lblAsignatura.TabIndex = 5;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // cmbAsignatura
            // 
            this.cmbAsignatura.BackColor = System.Drawing.Color.Transparent;
            this.cmbAsignatura.BaseColor = System.Drawing.Color.White;
            this.cmbAsignatura.BorderColor = System.Drawing.Color.Silver;
            this.cmbAsignatura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsignatura.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAsignatura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAsignatura.ForeColor = System.Drawing.Color.Black;
            this.cmbAsignatura.FormattingEnabled = true;
            this.cmbAsignatura.Location = new System.Drawing.Point(83, 128);
            this.cmbAsignatura.Name = "cmbAsignatura";
            this.cmbAsignatura.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAsignatura.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAsignatura.Size = new System.Drawing.Size(121, 26);
            this.cmbAsignatura.TabIndex = 4;
            this.cmbAsignatura.SelectedIndexChanged += new System.EventHandler(this.cmbAsignatura_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(36, 165);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(24, 15);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Dia";
            // 
            // cmbDia
            // 
            this.cmbDia.BackColor = System.Drawing.Color.Transparent;
            this.cmbDia.BaseColor = System.Drawing.Color.White;
            this.cmbDia.BorderColor = System.Drawing.Color.Silver;
            this.cmbDia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDia.ForeColor = System.Drawing.Color.Black;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(83, 160);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDia.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbDia.Size = new System.Drawing.Size(121, 26);
            this.cmbDia.TabIndex = 6;
            // 
            // txthInicio
            // 
            this.txthInicio.BaseColor = System.Drawing.Color.White;
            this.txthInicio.BorderColor = System.Drawing.Color.Silver;
            this.txthInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthInicio.FocusedBaseColor = System.Drawing.Color.White;
            this.txthInicio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txthInicio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txthInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthInicio.Location = new System.Drawing.Point(83, 193);
            this.txthInicio.Name = "txthInicio";
            this.txthInicio.PasswordChar = '\0';
            this.txthInicio.SelectedText = "";
            this.txthInicio.Size = new System.Drawing.Size(121, 30);
            this.txthInicio.TabIndex = 8;
            // 
            // txthFinal
            // 
            this.txthFinal.BaseColor = System.Drawing.Color.White;
            this.txthFinal.BorderColor = System.Drawing.Color.Silver;
            this.txthFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthFinal.FocusedBaseColor = System.Drawing.Color.White;
            this.txthFinal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txthFinal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txthFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthFinal.Location = new System.Drawing.Point(83, 229);
            this.txthFinal.Name = "txthFinal";
            this.txthFinal.PasswordChar = '\0';
            this.txthFinal.SelectedText = "";
            this.txthFinal.Size = new System.Drawing.Size(121, 30);
            this.txthFinal.TabIndex = 9;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 210);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(65, 15);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Hora Inicio";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(13, 244);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "Hora Final";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AnimationHoverSpeed = 0.07F;
            this.btnRegistrar.AnimationSpeed = 0.03F;
            this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(39, 276);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Size = new System.Drawing.Size(160, 42);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(410, 115);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Curso:";
            // 
            // cmbCursoFiltrar
            // 
            this.cmbCursoFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.cmbCursoFiltrar.BaseColor = System.Drawing.Color.White;
            this.cmbCursoFiltrar.BorderColor = System.Drawing.Color.Silver;
            this.cmbCursoFiltrar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCursoFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursoFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCursoFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCursoFiltrar.ForeColor = System.Drawing.Color.Black;
            this.cmbCursoFiltrar.FormattingEnabled = true;
            this.cmbCursoFiltrar.Location = new System.Drawing.Point(460, 110);
            this.cmbCursoFiltrar.Name = "cmbCursoFiltrar";
            this.cmbCursoFiltrar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCursoFiltrar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCursoFiltrar.Size = new System.Drawing.Size(121, 26);
            this.cmbCursoFiltrar.TabIndex = 13;
            this.cmbCursoFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbCursoFiltrar_SelectedIndexChanged);
            // 
            // gdvFiltro
            // 
            this.gdvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvFiltro.Location = new System.Drawing.Point(346, 165);
            this.gdvFiltro.Name = "gdvFiltro";
            this.gdvFiltro.Size = new System.Drawing.Size(452, 223);
            this.gdvFiltro.TabIndex = 15;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes});
            this.dgvResultado.Location = new System.Drawing.Point(346, 431);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(774, 352);
            this.dgvResultado.TabIndex = 16;
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            // 
            // Martes
            // 
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            // 
            // Miercoles
            // 
            this.Miercoles.HeaderText = "Miercoles";
            this.Miercoles.Name = "Miercoles";
            // 
            // Jueves
            // 
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            // 
            // Viernes
            // 
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            // 
            // frmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 827);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.gdvFiltro);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cmbCursoFiltrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txthFinal);
            this.Controls.Add(this.txthInicio);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.cmbAsignatura);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.lbHorario);
            this.Name = "frmHorario";
            this.Text = "frmHorario";
            this.Load += new System.EventHandler(this.frmHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbHorario;
        private Guna.UI.WinForms.GunaComboBox cmbCurso;
        private Guna.UI.WinForms.GunaLabel lbCurso;
        private Guna.UI.WinForms.GunaLabel lblAsignatura;
        private Guna.UI.WinForms.GunaComboBox cmbAsignatura;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cmbDia;
        private Guna.UI.WinForms.GunaTextBox txthInicio;
        private Guna.UI.WinForms.GunaTextBox txthFinal;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox cmbCursoFiltrar;
        private System.Windows.Forms.DataGridView gdvFiltro;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
    }
}