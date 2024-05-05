using System.Drawing.Imaging;

namespace pryPerezEtapa1
{
    public partial class frmFirma : Form
    {
        private List<List<Point>> dibujos = new List<List<Point>>();
        private List<Point> dibujoActual = new List<Point>();
        private bool estaDibujando;

        public frmFirma()
        {
            InitializeComponent();
        }

        private void PicDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Comenzar un nuevo dibujo
                estaDibujando = true;
                dibujoActual = new List<Point>();
            }
        }

        private void PicDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            if (estaDibujando)
            {
                // Agregar el punto al dibujo actual
                dibujoActual.Add(e.Location);
                // Redibujar el control
                picDibujo.Invalidate();
            }
        }

        private void PicDibujo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Detener el dibujo y agregar el dibujo actual a la lista de dibujos
                estaDibujando = false;
                dibujos.Add(dibujoActual);
            }
        }

        private void PicDibujo_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar todos los dibujos guardados
            foreach (List<Point> drawing in dibujos)
            {
                if (drawing.Count > 1)
                {
                    Pen pen = new Pen(Color.Black, 2);
                    e.Graphics.DrawLines(pen, drawing.ToArray());

                }
            }
            // Dibujar el dibujo actual si se está dibujando
            if (estaDibujando && dibujoActual.Count > 1)
            {
                Pen pen = new Pen(Color.Black, 2);
                e.Graphics.DrawLines(pen, dibujoActual.ToArray());
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una nueva imagen con el mismo tamaño que el control picDibujo
                Bitmap drawingBitmap = new Bitmap(picDibujo.Width, picDibujo.Height);
                // Dibujar el contenido del control picDibujo en la imagen
                picDibujo.DrawToBitmap(drawingBitmap, picDibujo.ClientRectangle);

                // Obtener la ruta de la carpeta "FIRMAS" dentro del directorio del proyecto
                string folderPath = Path.Combine(Application.StartupPath, "FIRMAS");
                // Si la carpeta no existe, crearla
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Obtengo la fecha y la hora 
                string fechaFirma = DateTime.Now.ToString("yyyy.MM.dd.HH.mm");

                // Combinar la ruta de la carpeta con el nombre del archivo
                string firma = Path.Combine(folderPath, fechaFirma + ".png");

                // Guardar la imagen como un archivo PNG
                drawingBitmap.Save(firma, ImageFormat.Png);

                // Liberar los recursos de la imagen
                drawingBitmap.Dispose();
                MessageBox.Show("Firma grabada " + fechaFirma);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dibujos.Clear();
            picDibujo.Invalidate();
        }
    }
}
