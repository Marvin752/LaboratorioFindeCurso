using LaboratorioEnClase.Data;
using LaboratorioEnClase.Data.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LaboratorioEnClase
{
    public partial class Form1 : Form
    {
        private string[] compania = {
            "Atari",
            "Coleco",
            "Mattel",
            "Microsoft",
            "Nintendo",
            "Ouya Inc.",
            "Sega",
            "Sony"
        };
        public Form1()
        {
            InitializeComponent();
        }
        private ConexionPro consolas = new ConexionPro();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCompañia.Items.AddRange(compania);
        }

        private void buttonProbar_Click(object sender, EventArgs e)
        {
            if (consolas.probarConexion())
            {
                MessageBox.Show("Si se pudo 🧐🧐");
            }
            else
            {
                MessageBox.Show("Nel Pastel 🦁🦁");
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            dataGridViewTabla.DataSource = consolas.imprimir();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            //insertar usando la clase Usuario
        }
    }
}
//Nos quedamos en la parte donde debiamos insertar los usuarios con el Model