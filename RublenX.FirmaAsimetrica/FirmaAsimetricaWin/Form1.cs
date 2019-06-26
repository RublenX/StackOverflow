using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaAsimetricaWin
{
    public partial class Form1 : Form
    {
        public string RutaFicheroClaveCifrado { get; set; }

        public string RutaFicheroClaveDescifrado { get; set; }

        public Form1()
        {
            InitializeComponent();

            ofd.InitialDirectory = Application.StartupPath;

            RutaFicheroClaveCifrado = Path.Combine(Application.StartupPath, "clavePublica.xml");
            RutaFicheroClaveDescifrado = Path.Combine(Application.StartupPath, "clavePrivada.xml");
        }

        private void BtnCargarLlaveCifrado_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.RutaFicheroClaveCifrado = ofd.FileName;
            }
        }

        private void BtnCargarLlaveDescifrado_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.RutaFicheroClaveDescifrado = ofd.FileName;
            }
        }

        private void BtnCifrar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCifrado.Text = new FirmaAsimetrica().Cifrar(RutaFicheroClaveCifrado, this.txtParaCifrar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Cifrando el Texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDescifrar_Click(object sender, EventArgs e)
        {
            try
            {
                txtDescrifrado.Text = new FirmaAsimetrica().Descifrar(RutaFicheroClaveDescifrado, this.txtCifrado.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Descifrando el Texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGenerarLlaves_Click(object sender, EventArgs e)
        {
            new FirmaAsimetrica().CrearClavesXml();
        }

        private void BtnFirmar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCifrado.Text = new FirmaAsimetrica().Firmar(RutaFicheroClaveCifrado, this.txtParaCifrar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Descifrando el Texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnValidarFirma_Click(object sender, EventArgs e)
        {
            try
            {
                bool valido = new FirmaAsimetrica().ValidarFirma(RutaFicheroClaveDescifrado, this.txtCifrado.Text, this.txtParaCifrar.Text);
                MessageBox.Show(valido ? "Válido" : "No Válido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Descifrando el Texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
