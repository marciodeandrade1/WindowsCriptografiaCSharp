using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace WindowsCriptografiaCSharp
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCodificar_Click(object sender, EventArgs e)
        {
            Criptografia criptografia = new Criptografia(CryptProvider.RC2);  // escolhe o tipo de criptografia, neste caso escolhemos o RC2
            criptografia.Key = "Etec2017"; // chave
            txtCodificado.Text = criptografia.Encrypt(txtOriginal.Text);
        }

        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            Criptografia criptografia = new Criptografia(CryptProvider.RC2);
            criptografia.Key = "Etec2017";
            txtDecodificado.Text = criptografia.Decrypt(txtCodificado.Text);
        }
    }
}
