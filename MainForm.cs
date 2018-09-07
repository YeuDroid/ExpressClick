/*
 * Creado por SharpDevelop.
 * Usuario: adrian
 * Fecha: 11/09/2017
 * Hora: 01:08 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExpressClick
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        SocketPipeSender send = new SocketPipeSender();
       
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
           

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }


        void TextBox1TextChanged(object sender, EventArgs e)
        {

        }
        void Button1Click(object sender, EventArgs e)
        {
            //minimizar
            this.WindowState = FormWindowState.Minimized;
            //
            try
            {
                send.SendValue(textBox1.Text.Trim());
            }
            catch (Exception)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.ContextMenuStrip.Show(MousePosition);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        void CrearControlListView()
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            return;

            //version 2
            if(this.Size.Width == 185)
            { this.Size = new Size(307, 181); }
            else this.Size = new Size(185,181);
        }

        private void introNiñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //niños  
            send.SendValue("NIÑOS");
        }

        private void introCancionesJWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //canciones jw
            send.SendValue("JWCAN");
        }

        private void introCanticosPopularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODABIA NO DINSPONIBLE");
            return;
            this.WindowState = FormWindowState.Minimized;
            //c asambleas
            send.SendValue("INTRO-ASA");
        }


        private void introCanticosRetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //canticos retmro
            send.SendValue("RETRO");
        }
    }
}
