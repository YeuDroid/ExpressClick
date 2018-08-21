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
            try
            {
                send.SendValue(textBox1.Text.Trim());
            }
            catch (Exception)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                send.SendValue("INTRO");
            }
            catch (Exception) { }
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
    }
}
