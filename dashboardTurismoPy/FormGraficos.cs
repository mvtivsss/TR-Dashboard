using dashboardTurismoPy.DTO;
using dashboardTurismoPy.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.GridHelperClasses;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace dashboardTurismoPy
{
    public partial class FormGraficos : Form
    {
        public FormGraficos()
        {
            InitializeComponent();
            //Create a new instance of PDF document
            PdfDocument document = new PdfDocument();
        }

        private async void ReserveClient_Click(object sender, EventArgs e)
        {
            //var reservations = await RestHelper.getAllReserves();
            //List<Estadistica> a = new List<Estadistica>();
            //foreach (var item in reservations)
            //{
            //    a.Add(new Estadistica(Convert.ToInt32(item.ClientId),Convert.ToInt32(item.TotalReserve)));

            //}
            
            
            graficogen.Titles.Clear();
            graficogen.Series.Clear();
            graficogen.ResetAutoValues();
            graficogen.Series.Add("ReservaMes").IsVisibleInLegend = false;
            graficogen.Series["ReservaMes"].ChartType = SeriesChartType.Bar;
            graficogen.Text = "CantidadReservasMes";
            graficogen.Titles.Add("Cantidad de reservas por año");
            
            //graficogen.Series["ReservaMes"].XValueMember = "Year";
            //graficogen.Series["ReservaMes"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            //graficogen.Series["ReservaMes"].YValueMembers = "Total";
            //graficogen.Series["ReservaMes"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            //graficogen.Series["ReservaMes"].Points.AddXY("ENERO", 34);
            //graficogen.Series["ReservaMes"].Points.AddXY("FEBRERO", 53);
            //graficogen.Series["ReservaMes"].Points.AddXY("MARZO", 13);
            //graficogen.Series["ReservaMes"].Points.AddXY("ABRIL", 22);
            //graficogen.Series["ReservaMes"].Points.AddXY("MAYO", 48);
            //graficogen.Series["ReservaMes"].Points.AddXY("JUNIO", 31);
            //graficogen.Series["ReservaMes"].Points.AddXY("JULIO", 85);
            graficogen.Series["ReservaMes"].Points.AddXY("AGOSTO", 30);
            graficogen.Series["ReservaMes"].Points.AddXY("SEPTIEMBRE", 50);
            graficogen.Series["ReservaMes"].Points.AddXY("OCTUBRE", 23);
            graficogen.Series["ReservaMes"].Points.AddXY("NOVIEMBRE", 65);
            graficogen.Series["ReservaMes"].Points.AddXY("DICIEMBRE", 100);
            graficogen.Palette = ChartColorPalette.SeaGreen;
            graficogen.Series["ReservaMes"].ResetIsValueShownAsLabel();
            graficogen.Series[0].Color.ToArgb();

            graficogen.Update();
            MessageBox.Show("Grafico Generado Correctamente ! ");
        }

        private async void ReservePrice_Click(object sender, EventArgs e)
        {
            var reservations = await RestHelper.getAllReserves();
            //List<Estadistica> a = new List<Estadistica>();
            //foreach (var item in reservations)
            //{
                //a.Add(new Estadistica());
                graficogen.Titles.Clear();
                graficogen.Series.Clear();
                graficogen.ResetAutoValues();
                graficogen.Series.Add("ReservaPrecio").IsVisibleInLegend = false;
                graficogen.Titles.Add("Total de reservas por año");
                graficogen.Text = "TotalReservasAño";
                graficogen.Series["ReservaPrecio"].ChartType = SeriesChartType.Area;
                //graficogen.Series["ReservaPrecio"].Points.AddXY("ENERO", item.TotalReserve);
                //graficogen.Series["ReservaPrecio"].Points.AddXY("FEBRERO", 2342340);
                //graficogen.Series["ReservaPrecio"].Points.AddXY("MARZO", 6564440);
                //graficogen.Series["ReservaPrecio"].Points.AddXY("ABRIL", 1233000);
                //graficogen.Series["ReservaPrecio"].Points.AddXY("MAYO", 343425);
                //graficogen.Series["ReservaPrecio"].Points.AddXY("JUNIO", 354500);
                //graficogen.Series["ReservaPrecio"].Points.AddXY("JULIO", 2342354);
                graficogen.Series["ReservaPrecio"].Points.AddXY("AGOSTO", 435345);
                graficogen.Series["ReservaPrecio"].Points.AddXY("SEPTIEMBRE", 5000000);
                graficogen.Series["ReservaPrecio"].Points.AddXY("OCTUBRE", 2300000);
                graficogen.Series["ReservaPrecio"].Points.AddXY("NOVIEMBRE", 6500000);
                graficogen.Series["ReservaPrecio"].Points.AddXY("DICIEMBRE", 10000000);
                graficogen.Palette = ChartColorPalette.SeaGreen;
                graficogen.Update();

                MessageBox.Show("Grafico Generado Correctamente ! ");
            //}
        }

        private void exportToPdf_Click(object sender, EventArgs e)
        {
            //Create a new instance of PDF document
            PdfDocument document = new PdfDocument();
            document.PageSettings.Margins.All = 0;
            //Save chart as image
            string imagepath = Path.Combine(Application.StartupPath, "../../ImagesPDF/");
            if (!File.Exists(imagepath + graficogen.Text + ".jpg"))
            {
                graficogen.SaveImage(imagepath + graficogen.Text + ".jpg", ChartImageFormat.Jpeg);
            }
            //Create PDF image from saved image
            PdfImage image = new PdfBitmap(imagepath + graficogen.Text + ".jpg");
            //Initialize an object for the PDF document
            document = new PdfDocument();
            //Create a page
            PdfPage page = document.Pages.Add();
            //Draw chart as image
            page.Graphics.DrawImage(image, new RectangleF(0, 20, 300, 250));
            //Save and close PDF document
            if (!File.Exists(imagepath + graficogen.Text + ".pdf"))
            {
                MessageBox.Show("Pdf creado satisfactoriamente !");
            }
            else
            {
                MessageBox.Show("Pdf Actualizado !");
            }
            document.Save(imagepath + graficogen.Text + ".pdf");
            document.Close(true);
        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("turismorealalieninc@gmail.com", "Turismo Real SPA.");
            MailAddress to = new MailAddress(txtEmailTo.Text, "Cliente");
            List<MailAddress> cc = new List<MailAddress>();
            //cc.Add(new MailAddress("mvarancibia68@gmail.com", "Matias Vergara"));
            //cc.Add(new MailAddress("marckfuentes2009@hotmail.com", "Marcos Fuentes"));
            //cc.Add(new MailAddress("mitchi.jpg@gmail.com", "Miguel Rojas"));
            //cc.Add(new MailAddress("christian.vimu@gmail.com", "Christian Villarroel"));
            SendEmail("Envío de Gráficos", "Hola ! Estamos muy contentos de enviarte un reporte de estadisticas de la empresa Turismo Real SPA, Adjuntamos las imagenes respecto a los gráficos.", from, to, cc);
            MessageBox.Show("Email enviado Correctamente ! ");
        }

        protected void SendEmail(string _subject, string _body, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "turismorealalieninc@gmail.com",
                    Password = "turismo.-"
                }
            };   //smtp.gmail.com // For Gmail
                 //smtp.live.com // Windows live / Hotmail
                 //smtp.mail.yahoo.com // Yahoo
                 //smtp.aim.com // AIM
                 //my.inbox.com // Inbox
            MailMessage Msg = new MailMessage();
            Msg.From = _from;
            Msg.To.Add(_to);
            //Msg.CC.Add(_cc[0]);
            //Msg.CC.Add(_cc[1]);
            //Msg.CC.Add(_cc[2]);
            //Msg.CC.Add(_cc[3]);
            Msg.Subject = _subject;
            Msg.Body = _body;
            string imagepath = Path.Combine(Application.StartupPath, "..//..//ImagesPDF//TotalReservasAño.jpg");
            //string folder = Path.GetFileName(Application.StartupPath + "..//..//ImagesPDF/");
            string[] allfiles = Directory.GetFiles("../../ImagesPDF/", "*.*", SearchOption.AllDirectories);
            Attachment data = new Attachment(imagepath);
            
            // Add time stamp information for the file.
            //ContentDisposition disposition = data.ContentDisposition;
            //disposition.CreationDate = System.IO.File.GetCreationTime(imagepath);
            //disposition.ModificationDate = System.IO.File.GetLastWriteTime(imagepath);
            //disposition.ReadDate = System.IO.File.GetLastAccessTime(imagepath);
            
            // Add the file attachment to this email message.
            
            foreach (string item in allfiles)
            {
                Attachment data1 = new Attachment(item);
                MessageBox.Show(item);
                Msg.Attachments.Add(data1);
            }
            
            // Send our email.
            client.Send(Msg);
        }
    }
}
