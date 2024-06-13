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
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace figurageometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
                INF.Clear();
                Datos.Clear();
                Rectangulo.Checked = false;
                Prisma.Checked = false;
                Cuadrado.Checked = false;
                Poligonoirregular.Checked = false;
                Poligonoregular.Checked = false;
                Esfera.Checked = false;
                Cubo.Checked = false;
                Circulo.Checked = false;
                Triangulo.Checked = false;
                if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.Close();
                }
        }
        private void DIBUJAR_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\mine\\FigGEOAVANCE-main\\FigGEOAVANCE-main\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\cuadrado.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Triangulo.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\mine\\FigGEOAVANCE-main\\FigGEOAVANCE-main\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\triangulo.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Circulo.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\mine\\FigGEOAVANCE-main\\FigGEOAVANCE-main\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\circulo.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Cubo.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\mine\\FigGEOAVANCE-main\\FigGEOAVANCE-main\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\cubo.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Esfera.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\mine\\FigGEOAVANCE-main\\FigGEOAVANCE-main\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\esfera.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Poligonoirregular.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\mine\\FigGEOAVANCE-main\\FigGEOAVANCE-main\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\poliIRR.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Poligonoregular.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\mine\\FigGEOAVANCE-main\\FigGEOAVANCE-main\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\poliReg.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Prisma.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\mine\\FigGEOAVANCE-main\\FigGEOAVANCE-main\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\prisma.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Rectangulo.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\mine\\FigGEOAVANCE-main\\FigGEOAVANCE-main\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\rectammgulo.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
        }
        private void INFORMACION_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                INF.Text = "Figura seleccionada: Cuadrado, " + "\n" +
                    "Sus datos son:" + "\n" +
                    "Longitud del lado: "
                    + Datos.Text;
            }
            else if (Triangulo.Checked)
            {
                INF.Text = "Figura seleccionada Triangulo, " +
                    "Sus datos son:"
                    + Datos.Text;
            }
            else if (Rectangulo.Checked)
            {
                INF.Text = "Figura seleccionada Rectangulo, " +
                    "Sus datos son:"
                    + Datos.Text;
            }
            else if (Poligonoregular.Checked)
            {
                INF.Text = "Figura seleccionada Poligono Regular, " +
                    "Sus datos son:"
                    + Datos.Text;
            }
            else if (Poligonoirregular.Checked)
            {
                INF.Text = "Figura seleccionada Poligono Irregular, " +
                    "Sus datos son:"
                    + Datos.Text;
            }
            else if (Circulo.Checked)
            {
                INF.Text = "Figura seleccionada Círculo, " +
                    "Sus datos son:"
                    + Datos.Text;
            }
            else if (Cubo.Checked)
            {
                INF.Text = "Figura seleccionada Cubo, " +
                    "Sus datos son:"
                    + Datos.Text;
            }
            else if (Prisma.Checked)
            {
                INF.Text = "Figura seleccionada Prisma, " +
                    "Sus datos son:"
                    + Datos.Text;
            }
            else if (Esfera.Checked)
            {
                INF.Text = "Figura seleccionada Esfera, " +
                    "Sus datos son:"
                    + Datos.Text;
            }
        }
        private void GUARDAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DATOS GUARDOS" + Datos.Text, "Datos de alumno",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void EXPORTAR_Click(object sender, EventArgs e)
        {
            try //EXCEPCIÓN
            {
                string fileName =
                   @"C:\Users\chipi\Downloads\mine\FigGEOAVANCE-main\FigGEOAVANCE-main\FIGEO-main (1)\FIGEO-main\figurageometrica\Datos\Datos.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = System.IO.File.AppendText(fileName);
                //  writer.WriteLine("Este es un dato nuevo desde guardar");
                writer.WriteLine("Datos: " + INF.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar Datos en el Archivo", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                INF.Text = INF.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (Triangulo.Checked)
            {
                INF.Text = INF.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (Rectangulo.Checked)
            {
                INF.Text = INF.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                      + "\n";
            }
            else if (Poligonoregular.Checked)
            {
                INF.Text = INF.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (Poligonoirregular.Checked)
            {
                INF.Text = INF.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (Circulo.Checked)
            {
                INF.Text = INF.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (Cubo.Checked)
            {
                INF.Text = INF.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
            else if (Prisma.Checked)
            {
                INF.Text = INF.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                  + "\n";
            }
            else if (Esfera.Checked)
            {
                INF.Text = INF.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
        }
    }
}
