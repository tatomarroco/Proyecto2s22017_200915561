namespace Proyecto2s22017CSharp
{
    partial class Admin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.btnXUser = new System.Windows.Forms.Button();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.btnMostrarUsers = new System.Windows.Forms.Button();
            this.tpHabitaciones = new System.Windows.Forms.TabPage();
            this.pbHabitaciones = new System.Windows.Forms.PictureBox();
            this.btnMostrarHab = new System.Windows.Forms.Button();
            this.tpCalendario = new System.Windows.Forms.TabPage();
            this.pbCalendario = new System.Windows.Forms.PictureBox();
            this.btnMostrarCalendario = new System.Windows.Forms.Button();
            this.tpReserva = new System.Windows.Forms.TabPage();
            this.lblFormato = new System.Windows.Forms.Label();
            this.txnAnho = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.pbReservaciones = new System.Windows.Forms.PictureBox();
            this.btnMostrarReservaciones = new System.Windows.Forms.Button();
            this.tpPagos = new System.Windows.Forms.TabPage();
            this.pbPagos = new System.Windows.Forms.PictureBox();
            this.btnMostrarPagos = new System.Windows.Forms.Button();
            this.tpHistorial = new System.Windows.Forms.TabPage();
            this.pbHistorial = new System.Windows.Forms.PictureBox();
            this.btnMostrarHistorial = new System.Windows.Forms.Button();
            this.tpTop5 = new System.Windows.Forms.TabPage();
            this.btnTop5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLoadUsers = new System.Windows.Forms.Button();
            this.btnLoadRooms = new System.Windows.Forms.Button();
            this.btnLoadReservation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            this.tpHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHabitaciones)).BeginInit();
            this.tpCalendario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendario)).BeginInit();
            this.tpReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReservaciones)).BeginInit();
            this.tpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagos)).BeginInit();
            this.tpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistorial)).BeginInit();
            this.tpTop5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrador";
            // 
            // label1
            // 
            this.label1.Image = global::Proyecto2s22017CSharp.Properties.Resources.close;
            this.label1.Location = new System.Drawing.Point(869, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 35);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpUsuarios);
            this.tabControl1.Controls.Add(this.tpHabitaciones);
            this.tabControl1.Controls.Add(this.tpCalendario);
            this.tabControl1.Controls.Add(this.tpReserva);
            this.tabControl1.Controls.Add(this.tpPagos);
            this.tabControl1.Controls.Add(this.tpHistorial);
            this.tabControl1.Controls.Add(this.tpTop5);
            this.tabControl1.Location = new System.Drawing.Point(16, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 449);
            this.tabControl1.TabIndex = 1;
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.AutoScroll = true;
            this.tpUsuarios.Controls.Add(this.btnXUser);
            this.tpUsuarios.Controls.Add(this.pbUsuarios);
            this.tpUsuarios.Controls.Add(this.btnMostrarUsers);
            this.tpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuarios.Size = new System.Drawing.Size(868, 423);
            this.tpUsuarios.TabIndex = 0;
            this.tpUsuarios.Text = "Usuarios";
            this.tpUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnXUser
            // 
            this.btnXUser.Location = new System.Drawing.Point(107, 9);
            this.btnXUser.Name = "btnXUser";
            this.btnXUser.Size = new System.Drawing.Size(95, 23);
            this.btnXUser.TabIndex = 2;
            this.btnXUser.Text = "Eliminar Usuario";
            this.btnXUser.UseVisualStyleBackColor = true;
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.pbUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbUsuarios.Location = new System.Drawing.Point(6, 44);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(856, 373);
            this.pbUsuarios.TabIndex = 1;
            this.pbUsuarios.TabStop = false;
            // 
            // btnMostrarUsers
            // 
            this.btnMostrarUsers.Location = new System.Drawing.Point(6, 9);
            this.btnMostrarUsers.Name = "btnMostrarUsers";
            this.btnMostrarUsers.Size = new System.Drawing.Size(95, 23);
            this.btnMostrarUsers.TabIndex = 0;
            this.btnMostrarUsers.Text = "Mostrar Usuarios";
            this.btnMostrarUsers.UseVisualStyleBackColor = true;
            this.btnMostrarUsers.Click += new System.EventHandler(this.btnMostrarUsers_Click);
            // 
            // tpHabitaciones
            // 
            this.tpHabitaciones.AutoScroll = true;
            this.tpHabitaciones.Controls.Add(this.pbHabitaciones);
            this.tpHabitaciones.Controls.Add(this.btnMostrarHab);
            this.tpHabitaciones.Location = new System.Drawing.Point(4, 22);
            this.tpHabitaciones.Name = "tpHabitaciones";
            this.tpHabitaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tpHabitaciones.Size = new System.Drawing.Size(868, 423);
            this.tpHabitaciones.TabIndex = 1;
            this.tpHabitaciones.Text = "Habitaciones";
            this.tpHabitaciones.UseVisualStyleBackColor = true;
            // 
            // pbHabitaciones
            // 
            this.pbHabitaciones.BackColor = System.Drawing.Color.Transparent;
            this.pbHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHabitaciones.Location = new System.Drawing.Point(6, 42);
            this.pbHabitaciones.Name = "pbHabitaciones";
            this.pbHabitaciones.Size = new System.Drawing.Size(856, 373);
            this.pbHabitaciones.TabIndex = 3;
            this.pbHabitaciones.TabStop = false;
            // 
            // btnMostrarHab
            // 
            this.btnMostrarHab.Location = new System.Drawing.Point(6, 7);
            this.btnMostrarHab.Name = "btnMostrarHab";
            this.btnMostrarHab.Size = new System.Drawing.Size(132, 23);
            this.btnMostrarHab.TabIndex = 2;
            this.btnMostrarHab.Text = "Mostrar Habitaciones";
            this.btnMostrarHab.UseVisualStyleBackColor = true;
            this.btnMostrarHab.Click += new System.EventHandler(this.btnMostrarHab_Click);
            // 
            // tpCalendario
            // 
            this.tpCalendario.Controls.Add(this.pbCalendario);
            this.tpCalendario.Controls.Add(this.btnMostrarCalendario);
            this.tpCalendario.Location = new System.Drawing.Point(4, 22);
            this.tpCalendario.Name = "tpCalendario";
            this.tpCalendario.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalendario.Size = new System.Drawing.Size(868, 423);
            this.tpCalendario.TabIndex = 2;
            this.tpCalendario.Text = "Calendario";
            this.tpCalendario.UseVisualStyleBackColor = true;
            // 
            // pbCalendario
            // 
            this.pbCalendario.BackColor = System.Drawing.Color.Transparent;
            this.pbCalendario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCalendario.Location = new System.Drawing.Point(6, 42);
            this.pbCalendario.Name = "pbCalendario";
            this.pbCalendario.Size = new System.Drawing.Size(856, 373);
            this.pbCalendario.TabIndex = 3;
            this.pbCalendario.TabStop = false;
            // 
            // btnMostrarCalendario
            // 
            this.btnMostrarCalendario.Location = new System.Drawing.Point(6, 7);
            this.btnMostrarCalendario.Name = "btnMostrarCalendario";
            this.btnMostrarCalendario.Size = new System.Drawing.Size(116, 23);
            this.btnMostrarCalendario.TabIndex = 2;
            this.btnMostrarCalendario.Text = "Mostrar Calendario";
            this.btnMostrarCalendario.UseVisualStyleBackColor = true;
            // 
            // tpReserva
            // 
            this.tpReserva.Controls.Add(this.lblFormato);
            this.tpReserva.Controls.Add(this.txnAnho);
            this.tpReserva.Controls.Add(this.txtMes);
            this.tpReserva.Controls.Add(this.lblDia);
            this.tpReserva.Controls.Add(this.txtDia);
            this.tpReserva.Controls.Add(this.pbReservaciones);
            this.tpReserva.Controls.Add(this.btnMostrarReservaciones);
            this.tpReserva.Location = new System.Drawing.Point(4, 22);
            this.tpReserva.Name = "tpReserva";
            this.tpReserva.Size = new System.Drawing.Size(868, 423);
            this.tpReserva.TabIndex = 5;
            this.tpReserva.Text = "Reservaciones Por Dia";
            this.tpReserva.UseVisualStyleBackColor = true;
            this.tpReserva.Click += new System.EventHandler(this.tpReserva_Click);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.Location = new System.Drawing.Point(34, 27);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(119, 15);
            this.lblFormato.TabIndex = 8;
            this.lblFormato.Text = "     DD    MM  AAAA";
            // 
            // txnAnho
            // 
            this.txnAnho.Location = new System.Drawing.Point(116, 7);
            this.txnAnho.Name = "txnAnho";
            this.txnAnho.Size = new System.Drawing.Size(35, 20);
            this.txnAnho.TabIndex = 7;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(82, 7);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(35, 20);
            this.txtMes.TabIndex = 6;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(8, 9);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(40, 13);
            this.lblDia.TabIndex = 5;
            this.lblDia.Text = "Fecha:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(48, 7);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(35, 20);
            this.txtDia.TabIndex = 4;
            // 
            // pbReservaciones
            // 
            this.pbReservaciones.BackColor = System.Drawing.Color.Transparent;
            this.pbReservaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbReservaciones.Location = new System.Drawing.Point(6, 46);
            this.pbReservaciones.Name = "pbReservaciones";
            this.pbReservaciones.Size = new System.Drawing.Size(856, 369);
            this.pbReservaciones.TabIndex = 3;
            this.pbReservaciones.TabStop = false;
            // 
            // btnMostrarReservaciones
            // 
            this.btnMostrarReservaciones.Location = new System.Drawing.Point(179, 7);
            this.btnMostrarReservaciones.Name = "btnMostrarReservaciones";
            this.btnMostrarReservaciones.Size = new System.Drawing.Size(136, 23);
            this.btnMostrarReservaciones.TabIndex = 2;
            this.btnMostrarReservaciones.Text = "Mostrar Reservaciones";
            this.btnMostrarReservaciones.UseVisualStyleBackColor = true;
            // 
            // tpPagos
            // 
            this.tpPagos.Controls.Add(this.pbPagos);
            this.tpPagos.Controls.Add(this.btnMostrarPagos);
            this.tpPagos.Location = new System.Drawing.Point(4, 22);
            this.tpPagos.Name = "tpPagos";
            this.tpPagos.Size = new System.Drawing.Size(868, 423);
            this.tpPagos.TabIndex = 3;
            this.tpPagos.Text = "Registro De Pagos";
            this.tpPagos.UseVisualStyleBackColor = true;
            // 
            // pbPagos
            // 
            this.pbPagos.BackColor = System.Drawing.Color.Transparent;
            this.pbPagos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPagos.Location = new System.Drawing.Point(6, 42);
            this.pbPagos.Name = "pbPagos";
            this.pbPagos.Size = new System.Drawing.Size(856, 373);
            this.pbPagos.TabIndex = 3;
            this.pbPagos.TabStop = false;
            // 
            // btnMostrarPagos
            // 
            this.btnMostrarPagos.Location = new System.Drawing.Point(6, 7);
            this.btnMostrarPagos.Name = "btnMostrarPagos";
            this.btnMostrarPagos.Size = new System.Drawing.Size(95, 23);
            this.btnMostrarPagos.TabIndex = 2;
            this.btnMostrarPagos.Text = "Mostrar Pagos";
            this.btnMostrarPagos.UseVisualStyleBackColor = true;
            // 
            // tpHistorial
            // 
            this.tpHistorial.Controls.Add(this.pbHistorial);
            this.tpHistorial.Controls.Add(this.btnMostrarHistorial);
            this.tpHistorial.Location = new System.Drawing.Point(4, 22);
            this.tpHistorial.Name = "tpHistorial";
            this.tpHistorial.Size = new System.Drawing.Size(868, 423);
            this.tpHistorial.TabIndex = 4;
            this.tpHistorial.Text = "Historial";
            this.tpHistorial.UseVisualStyleBackColor = true;
            // 
            // pbHistorial
            // 
            this.pbHistorial.BackColor = System.Drawing.Color.Transparent;
            this.pbHistorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHistorial.Location = new System.Drawing.Point(6, 42);
            this.pbHistorial.Name = "pbHistorial";
            this.pbHistorial.Size = new System.Drawing.Size(856, 373);
            this.pbHistorial.TabIndex = 3;
            this.pbHistorial.TabStop = false;
            // 
            // btnMostrarHistorial
            // 
            this.btnMostrarHistorial.Location = new System.Drawing.Point(6, 7);
            this.btnMostrarHistorial.Name = "btnMostrarHistorial";
            this.btnMostrarHistorial.Size = new System.Drawing.Size(95, 23);
            this.btnMostrarHistorial.TabIndex = 2;
            this.btnMostrarHistorial.Text = "Mostrar Historial";
            this.btnMostrarHistorial.UseVisualStyleBackColor = true;
            // 
            // tpTop5
            // 
            this.tpTop5.Controls.Add(this.btnTop5);
            this.tpTop5.Controls.Add(this.label5);
            this.tpTop5.Controls.Add(this.label4);
            this.tpTop5.Controls.Add(this.label3);
            this.tpTop5.Controls.Add(this.listBox3);
            this.tpTop5.Controls.Add(this.listBox2);
            this.tpTop5.Controls.Add(this.listBox1);
            this.tpTop5.Location = new System.Drawing.Point(4, 22);
            this.tpTop5.Name = "tpTop5";
            this.tpTop5.Padding = new System.Windows.Forms.Padding(3);
            this.tpTop5.Size = new System.Drawing.Size(868, 423);
            this.tpTop5.TabIndex = 6;
            this.tpTop5.Text = "Top 5";
            this.tpTop5.UseVisualStyleBackColor = true;
            // 
            // btnTop5
            // 
            this.btnTop5.Location = new System.Drawing.Point(46, 17);
            this.btnTop5.Name = "btnTop5";
            this.btnTop5.Size = new System.Drawing.Size(96, 23);
            this.btnTop5.TabIndex = 6;
            this.btnTop5.Text = "Mostrar Top 5";
            this.btnTop5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Habitaciones + Rentaron";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Habitaciones c/+Extras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuarios + Gastaron";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(587, 86);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(228, 277);
            this.listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(317, 86);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(228, 277);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 277);
            this.listBox1.TabIndex = 0;
            // 
            // btnLoadUsers
            // 
            this.btnLoadUsers.Location = new System.Drawing.Point(20, 58);
            this.btnLoadUsers.Name = "btnLoadUsers";
            this.btnLoadUsers.Size = new System.Drawing.Size(91, 23);
            this.btnLoadUsers.TabIndex = 2;
            this.btnLoadUsers.Text = "Cargar Usuarios";
            this.btnLoadUsers.UseVisualStyleBackColor = true;
            this.btnLoadUsers.Click += new System.EventHandler(this.btnLoadUsers_Click);
            // 
            // btnLoadRooms
            // 
            this.btnLoadRooms.Location = new System.Drawing.Point(117, 58);
            this.btnLoadRooms.Name = "btnLoadRooms";
            this.btnLoadRooms.Size = new System.Drawing.Size(118, 23);
            this.btnLoadRooms.TabIndex = 3;
            this.btnLoadRooms.Text = "Cargar Habitaciones";
            this.btnLoadRooms.UseVisualStyleBackColor = true;
            this.btnLoadRooms.Click += new System.EventHandler(this.btnLoadRooms_Click);
            // 
            // btnLoadReservation
            // 
            this.btnLoadReservation.Location = new System.Drawing.Point(241, 58);
            this.btnLoadReservation.Name = "btnLoadReservation";
            this.btnLoadReservation.Size = new System.Drawing.Size(130, 23);
            this.btnLoadReservation.TabIndex = 4;
            this.btnLoadReservation.Text = "Cargar Reservaciones";
            this.btnLoadReservation.UseVisualStyleBackColor = true;
            this.btnLoadReservation.Click += new System.EventHandler(this.btnLoadReservation_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(904, 567);
            this.Controls.Add(this.btnLoadReservation);
            this.Controls.Add(this.btnLoadRooms);
            this.Controls.Add(this.btnLoadUsers);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            this.tpHabitaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHabitaciones)).EndInit();
            this.tpCalendario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendario)).EndInit();
            this.tpReserva.ResumeLayout(false);
            this.tpReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReservaciones)).EndInit();
            this.tpPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPagos)).EndInit();
            this.tpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHistorial)).EndInit();
            this.tpTop5.ResumeLayout(false);
            this.tpTop5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpUsuarios;
        private System.Windows.Forms.TabPage tpHabitaciones;
        private System.Windows.Forms.Button btnLoadUsers;
        private System.Windows.Forms.TabPage tpCalendario;
        private System.Windows.Forms.Button btnMostrarUsers;
        private System.Windows.Forms.TabPage tpReserva;
        private System.Windows.Forms.TabPage tpPagos;
        private System.Windows.Forms.TabPage tpHistorial;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.PictureBox pbHabitaciones;
        private System.Windows.Forms.Button btnMostrarHab;
        private System.Windows.Forms.PictureBox pbCalendario;
        private System.Windows.Forms.Button btnMostrarCalendario;
        private System.Windows.Forms.TextBox txnAnho;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.PictureBox pbReservaciones;
        private System.Windows.Forms.Button btnMostrarReservaciones;
        private System.Windows.Forms.PictureBox pbPagos;
        private System.Windows.Forms.Button btnMostrarPagos;
        private System.Windows.Forms.PictureBox pbHistorial;
        private System.Windows.Forms.Button btnMostrarHistorial;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.TabPage tpTop5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLoadRooms;
        private System.Windows.Forms.Button btnLoadReservation;
        private System.Windows.Forms.Button btnTop5;
        private System.Windows.Forms.Button btnXUser;
    }
}

