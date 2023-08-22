using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3POE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buscarboton_Click(object sender, EventArgs e)
        {
            //utilizar la clase OpenFileDialog para ver la ventana

            OpenFileDialog abrir = new OpenFileDialog();

            //Filtrar para abrir imagenes jpg

            abrir.Filter = "JPEG (*.JPG) |* JPG";

            //verificar ventana y mostrarla
            //showDialog abre una ventana, el if valida la respuesta
            //en la ventana

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                //validaciones sobre ventana img
                pictureBox1.Image = Image.FromFile(abrir.FileName);

            }
        }

        private bool isImg = true;

        private void buscarboton2_Click(object sender, EventArgs e)
        {
            if (isImg == true)
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\marth\source\repos\practica3POE\imagenes\imagennayeon.jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom; // ajusta la imagen en el picturebox
                isImg = false;
            }
            else
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\marth\source\repos\practica3POE\imagenes\image5.jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                isImg = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isImg == true)
            {
                pictureBox3.Image = Image.FromFile(@"C:\Users\marth\source\repos\practica3POE\imagenes\imagennayeon.jpg");
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                isImg = false;
            }
            else
            {
                pictureBox3.Image = Image.FromFile(@"C:\Users\marth\source\repos\practica3POE\imagenes\image5.jpg");
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                isImg = true;
            }
        }
    }
}

