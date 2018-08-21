/*
 * Creado por SharpDevelop.
 * Usuario: adrian
 * Fecha: 11/09/2017
 * Hora: 01:08 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ExpressClick
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Cantico 1", 0);
            System.Windows.Forms.ListView listaProgramados = new System.Windows.Forms.ListView();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Cantico 2", 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Cantico 3", 0);
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.listaProgramados = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListMusica = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(46, 44);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escriba el cantico:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "INTRO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listaProgramados
            // 
            this.listaProgramados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.listaProgramados.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listaProgramados.LargeImageList = this.imageListMusica;
            this.listaProgramados.Location = new System.Drawing.Point(166, 9);
            this.listaProgramados.Name = "listaProgramados";
            this.listaProgramados.Scrollable = false;
            this.listaProgramados.Size = new System.Drawing.Size(108, 106);
            this.listaProgramados.SmallImageList = this.imageListMusica;
            this.listaProgramados.TabIndex = 7;
            this.listaProgramados.UseCompatibleStateImageBehavior = false;
            this.listaProgramados.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Programados";
            // 
            // imageListMusica
            // 
            this.imageListMusica.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMusica.ImageStream")));
            this.imageListMusica.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMusica.Images.SetKeyName(0, "Music-Library-icon.png");
            // 
            // button3
            // 

            // listaProgramados
            // 
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Cantico 1", 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Cantico 2", 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Cantico 3", 0);

            this.listaProgramados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.listaProgramados.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listaProgramados.LargeImageList = this.imageListMusica;
            this.listaProgramados.Location = new System.Drawing.Point(166, 9);
            this.listaProgramados.Name = "listaProgramados";
            this.listaProgramados.Scrollable = false;
            this.listaProgramados.Size = new System.Drawing.Size(108, 106);
            this.listaProgramados.SmallImageList = this.imageListMusica;
            this.listaProgramados.TabIndex = 7;
            this.listaProgramados.UseCompatibleStateImageBehavior = false;
            this.listaProgramados.View = System.Windows.Forms.View.Tile;
            // 

            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(114, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 44);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Developed by YeuLabs";
            // 
            // MainForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(290, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listaProgramados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Click Canticos";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.ListView listaProgramados;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageListMusica;
        private System.Windows.Forms.Label label1;
    }
}
