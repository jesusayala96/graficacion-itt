using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoGraficacion_ITT
{
    public partial class frmMain : Form
    {
        #region Locales
        List<Figura> ADibujar;
        Point[] ListaCoordenadas;
        Figura Nuevo;
        public PictureBox Huella;
        Point[] Posiciones;
        int Contador = 0;
        string Destino;
        #region Colores
        Color ContornoEdificio = Color.Black;
        Color RellenoEdificio = Color.FromArgb(189, 189, 189);
        Color Transparente = Color.Transparent;
        Color Pasto = Color.FromArgb(76, 175, 80);
        Color RellenoEspecial = Color.FromArgb(255, 235, 59);
        Color Cancha = Color.FromArgb(121, 85, 72);
        #endregion
        #endregion

        public frmMain()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ADibujar = new List<Figura>();
            CargarExtras();
            CargarEdificios();

        }
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            CargarTodo(e);
        }

        #region Magia
        private void CargarEdificios() {

            #region Edificios Chidos
            //Biblioteca
            ListaCoordenadas = new Point[]
            {
                new Point(205,160), new Point(265,160), new Point(265,230), new Point(205,230)
            };
            Nuevo = new Figura(ListaCoordenadas,ContornoEdificio,RellenoEdificio);
            ADibujar.Add(Nuevo);

            //Calafornix
            ListaCoordenadas = new Point[]
            {
                new Point(215,240),new Point(215,277),new Point(200,277), new Point(200,281), new Point(182,282), new Point(181,278), new Point(170,282), new Point(170,275), new Point(135,280), new Point(138,288), new Point(105,292), new Point(100,270), new Point(95,275), new Point(96,265), new Point(90,265), new Point(90,247), new Point(97,240), new Point(102,240), new Point(108,221), new Point(172,241), new Point(174,234), new Point(180,236), new Point(180,230), new Point(200,235), new Point(200,240)

            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //Oficinas?
            ListaCoordenadas = new Point[]{
                new Point(230,290), new Point(270,290), new Point(270,300), new Point(268,299), new Point(268,315), new Point(165,315), new Point(165, 300), new Point(230,300)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //Pape
            ListaCoordenadas = new Point[]{
                new Point(175,459), new Point(254,459), new Point(254,474), new Point(175,474)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //Entrada
            ListaCoordenadas = new Point[]{
                new Point(325,435), new Point(390,435), new Point(390,467), new Point(368,467), new Point(368,483), new Point(387,483), new Point(387,520), new Point(320,520), new Point(320, 483), new Point (340,483), new Point(340,465), new Point(325,465)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //Cafe
            ListaCoordenadas = new Point[]
            {
                new Point(160,570), new Point(255,570), new Point(255,590), new Point(160,590)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //PingPong
            ListaCoordenadas = new Point[]
            {
                new Point(260,355),new Point(280,355), new Point(280,420), new Point(260,420)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //Baños
            ListaCoordenadas = new Point[]{
                new Point(305,300), new Point(395,300), new Point(395,323), new Point(305,323)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //Gym
            ListaCoordenadas = new Point[]{
                new Point(270,162), new Point(288,162), new Point(288,175), new Point(270,175)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //QuienSabe
            ListaCoordenadas = new Point[]{
                new Point(305,130), new Point(347,130), new Point(347,174), new Point(305,174)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);
            #endregion

            #region Salones
            //600's
            ListaCoordenadas = new Point[]{
                new Point(360,45),new Point(440,25),new Point(450,60),new Point(370,80)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //500
            ListaCoordenadas = new Point[]{
                new Point(240,260), new Point(295,260), new Point(295,280), new Point(240,280)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //400
            ListaCoordenadas = new Point[]{
                new Point(325,250), new Point(410,250), new Point(410,275), new Point(325,275)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //300
            ListaCoordenadas = new Point[]{
                new Point(63,339), new Point(172,339), new Point(172,358), new Point(63,358)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //200
            ListaCoordenadas = new Point[]{
                new Point(62,398), new Point(170,398), new Point(170,420), new Point(62,420)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //100
            ListaCoordenadas = new Point[]{
                new Point(87,443), new Point(166,443), new Point(166,465), new Point(87,465)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);
            #endregion

            #region ZonaIndustrial
            //Industrial
            ListaCoordenadas = new Point[]{
                new Point(87,485), new Point(140,485), new Point(140,528), new Point(87,528)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //Industrial2
            ListaCoordenadas = new Point[]{
                new Point(87,543), new Point(136,543), new Point(136,585), new Point(87,585)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //C1
            ListaCoordenadas = new Point[]{
                new Point(40,483), new Point(60,483), new Point(60,525), new Point(40,525)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //C2
            ListaCoordenadas = new Point[]{
                new Point(65,487), new Point(80,487), new Point(80,517), new Point(65,517)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);
            #endregion

            #region ZonaBioQuimica
            //BioQuimica1
            ListaCoordenadas = new Point[]{
                new Point(410,85),new Point(465,85),new Point(465,100),new Point(410,100)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //BioQuimica2
            ListaCoordenadas = new Point[]{
                new Point(430,115),new Point(480,115),new Point(480,165),new Point(440,165),new Point(440,155),new Point(430,155)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //B3
            ListaCoordenadas = new Point[]{
                new Point(380,120), new Point(403,120), new Point(403,165), new Point(380,165)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //B4
            ListaCoordenadas = new Point[]{
                new Point(380,175), new Point(403,175), new Point(403,185), new Point(430,185), new Point(430,175), new Point(450, 175), new Point(450,185), new Point(452,185), new Point(452,225), new Point(380,225)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);
            #endregion

            #region Laboratorios
            //LabMate
            ListaCoordenadas = new Point[]{
                new Point(180,510), new Point(295,510), new Point(295,533), new Point(180,533)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //Electro
            ListaCoordenadas = new Point[]{
                new Point(290,185), new Point(338,185), new Point(338,225), new Point(290,225)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //LabSistemas
            ListaCoordenadas = new Point[]{
                new Point(310,345), new Point(357,345), new Point(360,335), new Point(410,335), new Point(410,370), new Point(310,370)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);

            //LabFisica
            ListaCoordenadas = new Point[]{
                new Point(55,567), new Point(80,567), new Point(80,588), new Point(83,588), new Point(83,592), new Point(98,592), new Point(98,605), new Point(98,625), new Point(48,625), new Point(48,605), new Point(55,603)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, RellenoEdificio);
            ADibujar.Add(Nuevo);
            #endregion

        }
        private void CargarExtras() {

            #region Contorno
            //Tec
            ListaCoordenadas = new Point[]
            {
                new Point(14,700), new Point(32,700), new Point(472,515), new Point(488,56), new Point(453,0), new Point(416,0), new Point(44,126)
            };
            Nuevo = new Figura(ListaCoordenadas, ContornoEdificio, Transparente);
            ADibujar.Add(Nuevo);
            #endregion

       
        }
        private void CargarTodo(PaintEventArgs e) {

            foreach (Figura c in ADibujar)
            {
                c.DibujarFigura(e);
            }
        }
        #endregion

        #region Clic's
        private void GestionClic(MouseButtons e, string nombre)
        {
            Destino = nombre;
           
            if (e == MouseButtons.Left)
            {
                frmVistas Nueva = new frmVistas(nombre);
                Nueva.Focus();
                Nueva.Show();
            }
            else if (e == MouseButtons.Right)
            {
                if (Huella != null)
                    this.Controls.Remove(Huella);
                
                Huella = new PictureBox();
                Huella.BorderStyle = BorderStyle.None;
                Huella.Height = 10;
                Huella.Width = 10;
                Huella.Location = new Point(465,510);
                Huella.Load("Person.png");
                Huella.SizeMode = PictureBoxSizeMode.StretchImage;
                                
                this.Controls.Add(Huella);
                AsignarPosiciones(nombre);
                Movimiento.Start();
              
          
            }
        }
        private void btnVista600_MouseDown(object sender, MouseEventArgs e)
        {
            GestionClic(e.Button,btnVista600.Name);
            
        }
        private void btnVistaBiblioteca_MouseDown(object sender, MouseEventArgs e)
        {
            GestionClic(e.Button, btnVistaBiblioteca.Name);
        }
        private void btnVistaCalafornix_MouseDown(object sender, MouseEventArgs e)
        {
            GestionClic(e.Button, btnVistaCalafornix.Name);
        }
        private void btnVista300_MouseDown(object sender, MouseEventArgs e)
        {
            GestionClic(e.Button, btnVista300.Name);
        }
        private void btnVistaEntrada_MouseDown(object sender, MouseEventArgs e)
        {
            GestionClic(e.Button, btnVistaEntrada.Name);
        }
        #endregion

        #region Botones
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido!\nClic Derecho -> Camino\nClicl Izquierdo -> Vistas");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto generado por:\nJesús Ayala\nPara la materia de Graficación\nImpartida por Arnulfo Trasviña");
        }
        #endregion

        public void AsignarPosiciones(string Hacia)
        {
            switch (Hacia)
            {
                case "btnVistaEntrada":
                    Posiciones = new Point[] { new Point(465, 510), new Point(455, 500), new Point(445, 490), new Point(435, 480), new Point(425, 470), new Point(415, 470), new Point(405, 470), new Point(395, 470), new Point(393, 470) };
                    break;
                case "btnVista300":
                    Posiciones = new Point[] { new Point(465, 510), new Point(455, 500), new Point(445, 490), new Point(435, 480), new Point(425, 470), new Point(415, 470), new Point(405, 470), new Point(395, 470), new Point(390, 470), new Point(380, 470), new Point(370, 470), new Point(360, 470), new Point(350, 470), new Point(340, 470), new Point(310, 470), new Point(300, 470), new Point(290, 470), new Point(280, 470), new Point(270, 470), new Point(260, 470), new Point(250, 470), new Point(240, 470), new Point(230, 470), new Point(220, 470), new Point(210, 470), new Point(210, 460), new Point(210, 450), new Point(210, 440), new Point(210, 430), new Point(210, 420), new Point(210, 410), new Point(210, 400), new Point(210, 390), new Point(200, 390), new Point(190, 390), new Point(180, 390), new Point(180, 380), new Point(180, 370), new Point(180, 360), new Point(170, 360), new Point(160, 360), new Point(150, 360), new Point(140, 360), new Point(130, 360), new Point(120, 360), new Point(110, 360) };
                    break;
                case "btnVistaCalafornix":
                    Posiciones = new Point[] { new Point(465, 510), new Point(455, 500), new Point(445, 490), new Point(435, 480), new Point(425, 470), new Point(415, 470), new Point(405, 470), new Point(395, 470), new Point(390, 470), new Point(380, 470), new Point(370, 470), new Point(360, 470), new Point(350, 470), new Point(340, 470), new Point(310, 470), new Point(300, 470), new Point(290, 470), new Point(280, 470), new Point(270, 470), new Point(260, 470), new Point(250, 470), new Point(240, 470), new Point(230, 470), new Point(220, 470), new Point(210, 470), new Point(210, 460), new Point(210, 450), new Point(210, 440), new Point(210, 430), new Point(210, 420), new Point(210, 410), new Point(210, 400), new Point(210, 390), new Point(200, 390), new Point(190, 390), new Point(180, 390), new Point(180, 380), new Point(180, 370), new Point(180, 360), new Point(170, 360), new Point(160, 360), new Point(150, 360), new Point(140, 360), new Point(130, 360), new Point(130,350), new Point(130,340), new Point(130,330), new Point(130,320), new Point(130,310), new Point(130,300), new Point(120,300), new Point(110,300), new Point(100,300), new Point(90,300), new Point(80,300), new Point(75,300), new Point(75,290), new Point(75,280), new Point(75,270), new Point(75,260) ,new Point(75,250)  };
                    break;
                case "btnVistaBiblioteca":
                    Posiciones = new Point[] { new Point(465, 510), new Point(455, 500), new Point(445, 490), new Point(435, 480), new Point(425, 470), new Point(415, 470), new Point(405, 470), new Point(395, 470), new Point(390, 470), new Point(380, 470), new Point(370, 470), new Point(360, 470), new Point(350, 470), new Point(340, 470), new Point(310, 470), new Point(300, 470), new Point(290, 470), new Point(280, 470), new Point(270, 470), new Point(260, 470), new Point(250, 470), new Point(240, 470), new Point(230, 470), new Point(220, 470), new Point(210, 470), new Point(210, 460), new Point(210, 450), new Point(210, 440), new Point(210, 430), new Point(210, 420), new Point(210, 410), new Point(210, 400), new Point(210, 390), new Point(200, 390), new Point(190, 390), new Point(180, 390), new Point(180, 380), new Point(180, 370), new Point(180, 360), new Point(180,350), new Point(180,340), new Point(180,330), new Point(180,320), new Point(190,320), new Point(200,320), new Point(210,320), new Point(220,320), new Point(230,320), new Point(230,310), new Point(230,300), new Point(230,290), new Point(230,280), new Point(230,270), new Point(230,260), new Point(230,250), new Point(230,240), new Point(230,245) };
                    break;
                case "btnVista600":
                    Posiciones = new Point[] { new Point(465, 510), new Point(455, 500), new Point(445, 490), new Point(435, 480), new Point(425, 470), new Point(415, 470), new Point(405, 470), new Point(395, 470), new Point(390, 470), new Point(380, 470), new Point(370, 470), new Point(360, 470), new Point(350, 470), new Point(340, 470), new Point(310, 470), new Point(300, 470), new Point(290, 470), new Point(280, 470), new Point(270, 470), new Point(260, 470), new Point(250, 470), new Point(240, 470), new Point(230, 470), new Point(220, 470), new Point(210, 470), new Point(210, 460), new Point(210, 450), new Point(210, 440), new Point(210, 430), new Point(210, 420), new Point(210, 410), new Point(210, 400), new Point(210, 390), new Point(200, 390), new Point(190, 390), new Point(180, 390), new Point(180, 380), new Point(180, 370), new Point(180, 360), new Point(180, 350), new Point(180, 340), new Point(180, 330), new Point(180, 320), new Point(190, 320), new Point(200, 320), new Point(210, 320), new Point(220, 320), new Point(230, 320), new Point(230, 310), new Point(230, 300), new Point(230, 290), new Point(230, 280), new Point(230, 270), new Point(230, 260), new Point(230, 250), new Point(230, 240), new Point(240,245), new Point(250,245),new Point(260,245), new Point(270,245), new Point(280,245), new Point(290,245), new Point(300,245), new Point(310,245), new Point(320,245), new Point(330,245), new Point(340,245), new Point(350,245), new Point(360,245), new Point(370,245), new Point(380,245), new Point(390,245), new Point(400,245), new Point(410,245), new Point(410,235), new Point(410,225), new Point(410,215), new Point(410,205), new Point(410,195), new Point(410,185), new Point(410,175), new Point(410,165), new Point(410,155), new Point (410,145), new Point(410,135), new Point(410,125), new Point(410,115), new Point(410,110), new Point(410,100), new Point(400,100), new Point(390,100), new Point(380,100), new Point(375,100), new Point(375,95), new Point(370,90), new Point(375,85), new Point(378,85), new Point(384,84), new Point(390,84), new Point(395,84) };
                    break;

            }
            //MoverPictureBox(Posiciones);
        }
    

        private void Movimiento_Tick(object sender, EventArgs e)
        {
            if (Contador < Posiciones.Length)
            {
                Huella.Location = Posiciones[Contador];
                Contador++;
            }
            else
            {
                Contador = 0;
                Movimiento.Stop();

                MessageBox.Show("Has llegado a tu destino!, " + Destino);
            }
        }
    }
}
//Ayala Sandoval #14211403