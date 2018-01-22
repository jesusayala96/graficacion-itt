using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGraficacion_ITT
{
    public partial class frmVistas : Form
    {
        #region Locales
        Color Edificio = Color.FromArgb(204, 220, 154);
        Color Ventanas = Color.FromArgb(54, 69, 76);
        Color Piso = Color.FromArgb(227, 219, 194);
        Color Amarillo = Color.FromArgb(248, 237, 197);
        string Presionada = "Arriba";
        List<Figura> ADibujar;
        Figura Nuevo;
        Point[] ListaCoordenadas;
        string Titulo;
        #endregion

        #region Magia
        public frmVistas()
        {
            InitializeComponent();

        }
        public frmVistas(string Titulo)
        {
            InitializeComponent();
            this.Text = Titulo;
            this.Titulo = Titulo;

        }
        private void pbxVista_Paint(object sender, PaintEventArgs e)
        {
            e.Dispose();
            ADibujar.Clear();

            switch (Titulo)
            {
                #region Calafornix
                case "btnVistaCalafornix":
                    if (Presionada == "Arriba")
                    {
                        CargarCalafornixA();
                        CargarTodo(e);
                        #region Calafornix
                        // Create string to draw.
                        String drawString = "TEATRO CALA_FORNIX";

                        // Create font and brush.
                        Font drawFont = new Font("Segoue UI Black", 16);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);

                        // Create point for upper-left corner of drawing.
                        float x = 223;
                        float y = 208;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
                        #endregion
                    }
                    else if (Presionada == "Izquierda")
                    {
                        CargarCalafornixB();
                        CargarTodo(e);

                    }
                    else if (Presionada == "Derecha")
                    {
                        CargarCalafornixC();
                        CargarTodo(e);
                    }
                    break;
                #endregion
                    //Listo
                #region 600
                case "btnVista600":
                    if (Presionada == "Arriba")
                    {
                        Cargar600A();
                        CargarTodo(e);
                        #region 600's
                        // Create string to draw.
                        String drawString = "600";

                        // Create font and brush.
                        Font drawFont = new Font("Segoue UI Black", 16);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);

                        // Create point for upper-left corner of drawing.
                        float x = 490;
                        float y = 130;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
                        #endregion
                    }
                    else if (Presionada == "Izquierda")
                    {
                        Cargar600B();
                        CargarTodo(e);
                    }
                    else if (Presionada == "Derecha")
                    {
                        Cargar600C();
                        CargarTodo(e);
                    }
                    break;
                #endregion
                    //Listo
                #region 300
                case "btnVista300":
                    if (Presionada == "Arriba")
                    {
                        Cargar300B();
                        CargarTodo(e);
                    }
                    else if (Presionada == "Derecha")
                    {
                        Cargar300A();
                        CargarTodo(e);
                        #region 300's
                        // Create string to draw.
                        String drawString = "308";

                        // Create font and brush.
                        Font drawFont = new Font("Segoue UI Black", 18);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);

                        // Create point for upper-left corner of drawing.
                        float x = 305;
                        float y = 50;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
                        e.Graphics.DrawString("307", drawFont, drawBrush, 375, 50);
                        #endregion
                    }
                    else if (Presionada=="Izquierda")
                    { Cargar300C();
                        CargarTodo(e);
                    }
                    break;
                #endregion

                #region Entrada
                case "btnVistaEntrada":
                    if (Presionada == "Derecha")
                    {
                        CargarEntradaA();
                        CargarTodo(e);
                    }
                    else if (Presionada == "Arriba")
                    {
                        CargarEntradaB();
                        CargarTodo(e);
                    }
                    else if (Presionada=="Izquierda")
                    {
                        CargarEntradaC();
                        CargarTodo(e);
                    }
                    break;
                #endregion
                    //Listo

                #region Biblioteca
                case "btnVistaBiblioteca":
                    if (Presionada == "Izquierda")
                    {
                        CargarBibliotecaA();
                        CargarTodo(e);
                    }
                    else if (Presionada == "Arriba")
                    {
                        CargarBibliotecaB();
                        CargarTodo(e);
                    }
                    else if (Presionada=="Derecha")
                    {
                        CargarbibliotecaC();
                        CargarTodo(e);
                    }
                    break;
                    #endregion
                    //Listo
            }

        }
        private void frmVistas_Load(object sender, EventArgs e)
        {
            ADibujar = new List<Figura>();

        }
        private void CargarTodo(PaintEventArgs e)
        {
            foreach (Figura c in ADibujar)
            {
                c.DibujarFigura(e);
            }
        }
        #endregion

        #region Dibujos
        #region 600's
        private void Cargar600A()
        {
            //Cielo
            ListaCoordenadas = new Point[]
            {
                new Point(0,0), new Point(720,0), new Point(720,310), new Point(0,310)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);
            //Carretera
            ListaCoordenadas = new Point[]
            {
                new Point(0,310), new Point(720,308), new Point(720,540), new Point(0,540)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.FromArgb(154, 140, 121));
            ADibujar.Add(Nuevo);


            #region Tierra
            //
            ListaCoordenadas = new Point[]
            {
                new Point(0,431), new Point(425,406), new Point(436,338), new Point(644,338), new Point(644,310),new Point(0,310)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.FromArgb(239, 219, 177));
            ADibujar.Add(Nuevo);

            //
            ListaCoordenadas = new Point[]
            {
                new Point(0,442), new Point(366,419), new Point(366,408), new Point(0,430)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.FromArgb(99, 210, 247));
            ADibujar.Add(Nuevo);

            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(366,408), new Point(428,393), new Point(435,336), new Point(443,337), new Point(446,341), new Point(444,400), new Point(428,411), new Point(366,419)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.FromArgb(237, 184, 72));
            ADibujar.Add(Nuevo);

            //
            ListaCoordenadas = new Point[]
            {
                new Point(426,412), new Point(720,404), new Point(720,395), new Point(618,333),new Point(445,336), new Point(442,401)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.FromArgb(116, 165, 187));
            ADibujar.Add(Nuevo);

            //
            ListaCoordenadas = new Point[]
            {
                new Point(619,332), new Point(707,388), new Point(717,382), new Point(716,376), new Point(622,324), new Point(619,326)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.FromArgb(237, 184, 72));
            ADibujar.Add(Nuevo);

            #endregion
            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(30,120), new Point(642,111), new Point(647,317), new Point(27,317)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            //Muro
            ListaCoordenadas = new Point[]
            {
                new Point(642,301), new Point(644,327), new Point(720,320), new Point(720,300)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.FromArgb(190, 117, 144));
            ADibujar.Add(Nuevo);


            #region Lineas
            //Lineas
            ListaCoordenadas = new Point[]
            {
                new Point(74,152), new Point(642,152)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);
            //Lineas
            ListaCoordenadas = new Point[]
            {
                new Point(74,196), new Point(643,196)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);
            //Lineas
            ListaCoordenadas = new Point[]
            {
                new Point(68,282), new Point(646,282)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);
            #endregion Linea
            #region Marco
            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(274,129), new Point(376,129), new Point(379,317), new Point(273,317)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(266,109), new Point(390,109), new Point(376,129), new Point(274,129)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(266,109), new Point(274,129), new Point(273,316), new Point(265,313)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(390,109), new Point(376,129), new Point(378,317), new Point(391,317)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);
            #endregion
            #region Ventanas
            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(280,146), new Point(371,146), new Point(371,218), new Point(280,218)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(255, 253, 208));
            ADibujar.Add(Nuevo);

            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(280,235), new Point(371,235), new Point(371,315), new Point(280,315)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(255, 253, 208));
            ADibujar.Add(Nuevo);

            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(288,159), new Point(367,159), new Point(367,198), new Point(288,198)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(40, 54, 72));
            ADibujar.Add(Nuevo);

            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(288,247), new Point(368,247), new Point(368,313), new Point(288,313)          };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(40, 54, 72));
            ADibujar.Add(Nuevo);


            #endregion
        }
        private void Cargar600B()
        {
            //Cielo
            ListaCoordenadas = new Point[]
            {
                new Point(0,0), new Point(700,0), new Point(700,190), new Point(0,190)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);

            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(281,95), new Point(636,214), new Point(628,471), new Point(254,489)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Piso);
            ADibujar.Add(Nuevo);

            //Ventanas
            ListaCoordenadas = new Point[]
            {
                new Point(280,92), new Point(635,215), new Point(631,268), new Point(275,195)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);

            //Ventanas
            ListaCoordenadas = new Point[]
            {
                new Point(266,358), new Point(572,366), new Point(569,395), new Point(261,409)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);





            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(0,34), new Point(0,453), new Point(152,499), new Point(220,504), new Point(254,505), new Point(286,47), new Point(700,212), new Point(632,212), new Point(283,91), new Point(285,47), new Point(700,212), new Point(700,454), new Point(628,458), new Point(637,213), new Point(700,212), new Point(700,160), new Point(404,0), new Point(70,0)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);
            //Columnas
            ListaCoordenadas = new Point[]
            {
                new Point(422,119), new Point(400,484), new Point(345,484), new Point(365,118)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            //Columnas
            ListaCoordenadas = new Point[]
            {
                new Point(494,164), new Point(543,165), new Point(524,469), new Point(477,471)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            //Columnas
            ListaCoordenadas = new Point[]
            {
                new Point(583,191), new Point(621,191), new Point(607,456), new Point(567,455)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            //Columna
            ListaCoordenadas = new Point[]
            {
                new Point(275,193), new Point(357,212), new Point(390,252), new Point(411,254), new Point(414,224), new Point(488,239), new Point(513,272), new Point(535,275), new Point(536,251), new Point(577,259), new Point(603,288), new Point(616,289), new Point(616,268), new Point(628,271), new Point(679,314), new Point(680,337), new Point(269,298)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Piso);
            ADibujar.Add(Nuevo);

            //Columna
            ListaCoordenadas = new Point[]
            {
                new Point(0,520), new Point(700,430), new Point(700,472), new Point(397,540), new Point(0,540)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Piso);
            ADibujar.Add(Nuevo);

        }
        private void Cargar600C() {
        
            ListaCoordenadas = new Point[]
           {
               new Point(40,86), new Point(500,120), new Point(500,377), new Point(20,374)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.DeepSkyBlue);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
       {
              new Point(52,27), new Point(500,70),  new Point(500,126), new Point(500,372), new Point(330,336), new Point(344,178), new Point(500,127), new Point(344,178), new Point(38,173)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.DarkBlue);
            ADibujar.Add(Nuevo);


            #region Lineas
            ListaCoordenadas = new Point[]
           {
               new Point(51,89), new Point(501,119)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(36,254), new Point(499,271)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
              new Point(131,95), new Point(107,375)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(218,102), new Point(204,258)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(299,107), new Point(281,374)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);
            ListaCoordenadas = new Point[]
           {
               new Point(378,112), new Point(359,372)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(454,120), new Point(435,375)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);
            #endregion

            

            #region
            ListaCoordenadas = new Point[]
           {
               new Point( 0,0),new Point(0,453), new Point(500,439), new Point(500,392), new Point(17,400), new Point(46,86), new Point(500,119), new Point(46,86), new Point(53,27), new Point(500,69), new Point(500,0)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(500,0), new Point(500,392)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(500,377), new Point(18,376), new Point(18,399), new Point(500,390), new Point(500,379)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);
            #endregion
        }
        #endregion
        #region Calafornix-
        private void CargarCalafornixA()
        {
            //Cielo
            ListaCoordenadas = new Point[]
            {
                new Point(0,0), new Point(720,0), new Point(720,374), new Point(0,374)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);

            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(230,155), new Point(326,152), new Point(330,132), new Point(464,132), new Point(468,150), new Point(630,156), new Point(623,180), new Point(230,185)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(150,150), new Point(232,143), new Point(286,177), new Point(286,184), new Point(230,184), new Point(150,184)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Amarillo);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(232,143), new Point(232,184)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Transparent);
            ADibujar.Add(Nuevo);

            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(515,140), new Point(608,142), new Point(610,180), new Point(515,180), new Point(475,180), new Point(475,173)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Amarillo);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(515,140), new Point(515,180)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Transparent);
            ADibujar.Add(Nuevo);




            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(42,350), new Point(78,185), new Point(653,180), new Point(690,368)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //TeatroCalafornix
            ListaCoordenadas = new Point[]
            {
                new Point(190,274), new Point(195,193), new Point(510,191), new Point(509,274)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);



            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(211,348), new Point(213,280), new Point(197,275), new Point(197,238), new Point(505,238), new Point(505,277), new Point(495,282), new Point(498,352), new Point(490,350), new Point(225,345)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Amarillo);
            ADibujar.Add(Nuevo);

            //Puerta
            ListaCoordenadas = new Point[]
            {
                new Point(224,345), new Point(228,252), new Point(490,250), new Point(490,350)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Ventanas);
            ADibujar.Add(Nuevo);

            #region 

            //Piso
            ListaCoordenadas = new Point[]
            {
                new Point(0,360), new Point(85,345), new Point(210,350), new Point(227,342), new Point(490,350), new Point
                (496,353), new Point(597,357), new Point(720,372), new Point(720,540), new Point(0,540)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Piso);
            ADibujar.Add(Nuevo);

            //Linea
            ListaCoordenadas = new Point[]
            {
                new Point(68,540), new Point(350,350)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Brown, Color.SandyBrown);
            ADibujar.Add(Nuevo);

            //Linea
            ListaCoordenadas = new Point[]
            {
                new Point(550,540), new Point(426,347)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Brown, Color.SandyBrown);
            ADibujar.Add(Nuevo);

            //Linea
            ListaCoordenadas = new Point[]
            {
                new Point(0,472), new Point(720,490)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Brown, Color.SandyBrown);
            ADibujar.Add(Nuevo);

            //Linea
            ListaCoordenadas = new Point[]
            {
                new Point(0,418), new Point(720,424)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Brown, Color.SandyBrown);
            ADibujar.Add(Nuevo);

            //Linea
            ListaCoordenadas = new Point[]
            {
                new Point(0,362), new Point(720,380)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Brown, Color.SandyBrown);
            ADibujar.Add(Nuevo);
            #endregion


        }
        private void CargarCalafornixB()
        {
            #region Cielo
            //Cielo
            ListaCoordenadas = new Point[]
            {
                new Point(0,0), new Point(720,0), new Point(720,266), new Point(0,266)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);
            //Piso
            ListaCoordenadas = new Point[]
            {
                new Point(0,507), new Point(720,418), new Point(720,540), new Point(0,540)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Piso);
            ADibujar.Add(Nuevo);
            #endregion
            #region Edificio
            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(300,112), new Point(414,4), new Point(424,7), new Point(428,25), new Point(524,50), new Point(526,43), new Point(532,44), new Point(583,267), new Point(458,277), new Point(307,171)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(452,205), new Point(466,458), new Point(424,459), new Point(403,203)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(403,183), new Point(424,460), new Point(365,469), new Point(348,174)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(348,148), new Point(364,469), new Point(296,479), new Point(280,138)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(278,110), new Point(296,479), new Point(206,494), new Point(195,92)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(194,59), new Point(206,494), new Point(72,512), new Point(98,44)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);
            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(99,2), new Point(72,512), new Point(36,517), new Point(0,78), new Point(0,0)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //Teatro
            ListaCoordenadas = new Point[]
            {
                new Point(0,0), new Point(46,91), new Point(36,517), new Point(0,525)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);
            #endregion

            ListaCoordenadas = new Point[]
            {
                new Point(452,274), new Point(557,250), new Point(617,266), new Point(656,214), new Point(720,233), new Point(720,435), new Point(650,434), new Point(580,450), new Point(465,458)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);
            #region Ventanas
            ListaCoordenadas = new Point[]
            {
                new Point(96,297), new Point(176,300), new Point(179,380), new Point(98,380)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
                        {
                new Point(202,320), new Point(267,320), new Point(270,397), new Point(204,397)
                        };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);
            ListaCoordenadas = new Point[]
            {
                new Point(290,343), new Point(336,343), new Point(339,412), new Point(292,412)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(360,360), new Point(400,360), new Point(403,422), new Point(362,422)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);






            #endregion

            ListaCoordenadas = new Point[]
            {
                new Point(417,384), new Point(445,385), new Point(450,457), new Point(425,460)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Amarillo);
            ADibujar.Add(Nuevo);
            #region CuadroVentana
            ListaCoordenadas = new Point[]
            {
                new Point(382,438), new Point(436,432), new Point(438,448), new Point(380,454)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(385,420), new Point(390,454), new Point(306,466), new Point(304,428)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(311,405), new Point(314,468), new Point(213,481), new Point(211,414)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(75,392), new Point(220,385), new Point(220,483), new Point(70,497)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);


            #endregion

            ListaCoordenadas = new Point[]
            {
                new Point(630,352), new Point(700,343), new Point(720,341), new Point(720,430), new Point(710,436), new Point(658,436), new Point(636,414)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(656,349), new Point(683,330), new Point(720,325), new Point(720,342), new Point(700,343)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);
        }
        private void CargarCalafornixC() {
            //Cielo
            ListaCoordenadas = new Point[]
            {
                new Point(0,0), new Point(720,0), new Point(720,286), new Point(0,286)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);
            //Pasto
            ListaCoordenadas = new Point[]
            {
                new Point(0,450), new Point(720,450), new Point(720,540), new Point(0,540)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.Green);
            ADibujar.Add(Nuevo);

            //
            ListaCoordenadas = new Point[]
            {
                new Point(268,37), new Point(277,128), new Point(0,0), new Point(145,0)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //Camino
            ListaCoordenadas = new Point[]
            {
                new Point(200,438), new Point(405,508), new Point(405,540), new Point(147,540), new Point(77,438)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Piso);
            ADibujar.Add(Nuevo);


            //Ventanas
            ListaCoordenadas = new Point[]
            {
                new Point (102,331), new Point(97,440), new Point(134,440),new Point(141,334), new Point(141,357), new Point(183,359), new Point(178,438), new Point(204,438), new Point(207,340),new Point(102,331),new Point(207,340), new Point(207,360), new Point(106,354),new Point(207,360), new Point(205,438), new Point(179,439), new Point(183,357), new Point(140,355), new Point(134, 441), new Point(204,438), new Point(208,340)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.LightSteelBlue);
            ADibujar.Add(Nuevo);


            //Blanco
            ListaCoordenadas = new Point[]
            {
                new Point(128,58), new Point(288,110), new Point(290,304), new Point(210,323), new Point(106,313), new Point(108,284), new Point(290,304), new Point(108,284), new Point
                (128,58)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);
            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(99,482), new Point(131,34), new Point(0,0), new Point(0,487)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            //Edificio
            ListaCoordenadas = new Point[]
            {
                new Point(208,324),new Point(205,438), new Point(296,478), new Point(296,470), new Point(307,472), new Point(304,354), new Point(307,472), new Point(404,467), new Point(400,120), new Point(299,88), new Point(307,467), new Point(299,88), new Point(282,108), new Point(287,109), new Point(290,305)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);




        }
        #endregion
        #region 300's 
        private void Cargar300A()
        {
            ListaCoordenadas = new Point[]
             {
                new Point(0,0), new Point(720,0), new Point(720,540), new Point(0,540)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(5,397), new Point(717,384)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.DarkGreen, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(65,209), new Point(64,529)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.DarkGreen, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(119,528), new Point(121,213)
           };

            ListaCoordenadas = new Point[]
           {
                new Point(180,214), new Point(176,530)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.DarkGreen, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(543,218), new Point(542,540)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.DarkGreen, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(600,219), new Point(600,542)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.DarkGreen, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(657,219), new Point(658,540)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.DarkGreen, Color.LightGreen);
            ADibujar.Add(Nuevo);
            Nuevo = new Figura(ListaCoordenadas, Color.DarkGreen, Color.LightGreen);
            ADibujar.Add(Nuevo);
            #region Ventanas
            ListaCoordenadas = new Point[]
           {
                new Point(14,75), new Point(124,75), new Point(124,209), new Point(14,209)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Ventanas);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(124,75), new Point(289,75), new Point(289,209), new Point(124,209)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Ventanas);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(431,80), new Point(594,85), new Point(594,217), new Point(431,217)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Ventanas);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(595,85), new Point(711,87), new Point(711,218), new Point(595,216)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Ventanas);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(11,140), new Point(711,151)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.LightGreen, Color.LightGreen);
            ADibujar.Add(Nuevo);
            #endregion
            #region Puertas
            ListaCoordenadas = new Point[]
           {
                new Point(293,75), new Point(354,75), new Point(354,538), new Point(293,538)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Edificio);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
                new Point(366,75), new Point(427,75), new Point(427,538), new Point(366,538)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Edificio);
            ADibujar.Add(Nuevo);
            #endregion
        }
        private void Cargar300B() {

            ListaCoordenadas = new Point[]
            {
                new Point(0,313), new Point(720,313), new Point(720,540), new Point(0,540)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.Green);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(0,0), new Point(720,0), new Point(720,313), new Point(0,313)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(128,312), new Point(73,379), new Point(0,376), new Point(0,407), new Point(720,431), new Point(720,396), new Point(260,377), new Point(159,316)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.GhostWhite);
            ADibujar.Add(Nuevo);

          




            ListaCoordenadas = new Point[]
            {
                new Point(257,102), new Point(720,128), new Point(720,386), new Point(236,358), new Point(222,352), new Point(158,317), new Point(162,260)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.GhostWhite);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(111,93), new Point(265,94), new Point(186,218), new Point(128,216)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(105,236), new Point(238,244), new Point(165,288), new Point(130,288)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(88,215), new Point(234,219), new Point(248,104), new Point(107,100), new Point(101,67), new Point(720,97), new Point(720,126), new Point(269,107), new Point(255,223), new Point(720,247), new Point(720,262), new Point(256,247), new Point(243,355), new Point(226,357), new Point(237, 248), new Point(106,236)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
          {
                new Point(66,452), new Point(53,494), new Point(99,538), new Point(720,540), new Point(720,513), new Point(613,468)
          };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Wheat);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(228,471), new Point(306,473), new Point(296,418), new Point(318,419), new Point(320,412), new Point(311,388), new Point(216,386), new Point(220,414), new Point(237,416)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(394,470), new Point(435, 474), new Point(480,0), new Point(446,0)
               };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);
        }
        private void Cargar300C()
        {

            ListaCoordenadas = new Point[]
   {
       new Point(0,540), new Point(0,360), new Point(720,322), new Point(720,393), new Point(327,420), new Point(482,540)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Piso);
            ADibujar.Add(Nuevo);


            ListaCoordenadas = new Point[]
   {
       new Point(333,425), new Point(486,540), new Point(720,540), new Point(720,398)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.ForestGreen);
            ADibujar.Add(Nuevo);


            ListaCoordenadas = new Point[]
{
    new Point(361,259), new Point(503,219), new Point(720,219), new Point(720,368), new Point(528,377), new Point(371,348)
};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.NavajoWhite);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
{
    new Point(285,235), new Point(365,240), new Point(503,190), new Point(507,219), new Point(356,260), new Point(287,262)
};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Green);
            ADibujar.Add(Nuevo);


            ListaCoordenadas = new Point[]
   {
       new Point(0,171), new Point(720,199), new Point(720,218), new Point(528,215), new Point(527,375), new Point(490,367), new Point(481,216), new Point(286,213), new Point(288,392), new Point(0,411)
   };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Green);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
{
    new Point(0,133), new Point(720,171), new Point(720,199), new Point(0,173)
};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
{
    new Point(289,214), new Point(444,214), new Point(359,244), new Point(287,238)
};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);


            ListaCoordenadas = new Point[]
{
    new Point(0,0), new Point(2833,0), new Point(720,49), new Point(720,170), new Point(0,135)
};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
{
    new Point(150,9), new Point(217,16), new Point(216,145), new Point(148,145)
};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
{
    new Point(607,37), new Point(658,48), new Point(661,170), new Point(612,170)
};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
{
    new Point(0,125), new Point(720,162), new Point(720,172), new Point(0,135)
};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Brown);
            ADibujar.Add(Nuevo);



        }
        #endregion
        #region Entrada
        public void CargarEntradaA()
        {
           #region
            ListaCoordenadas = new Point[]
             {
                new Point(0,0), new Point(720,0), new Point(720,540), new Point(0,540)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
             {
                new Point(0,300), new Point(720,300), new Point(720,540), new Point(0,540)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.Green);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(0,220), new Point(0,254), new Point(395,92), new Point(720,200), new Point(720,188), new Point(345,45)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
                         {
                             new Point(0,188), new Point(300,0), new Point(412,0), new Point(720,144), new Point(720,188), new Point(350,56), new Point(349,44), new Point(0,220), new Point(0,188), new Point(0,220), new Point(0,248)};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(0,250), new Point(390,90),new Point(720,189), new Point(720,400), new Point(315,455), new Point(292,451), new Point(293,431), new Point(0,386)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(0,250), new Point(293,140), new Point(284,220), new Point(0,276)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
          {
              new Point(168,297), new Point(291,279), new Point(295,373), new Point(164,373)
          };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
                      {
              new Point(353,90), new Point(370,85), new Point(720,200), new Point(720,275), new Point(407,234), new Point(404,129), new Point(368,117), new Point(357,115)
          };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Ventanas);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
          {
              new Point(312,106), new Point(316,456),new Point(294,450), new Point(290,109)
          };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
          {
              new Point(312,106), new Point(404,128)
          };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);
            ListaCoordenadas = new Point[]
                      {
              new Point(312,107), new Point(404,129), new Point(310,126)
                      };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);
            #endregion
            ListaCoordenadas = new Point[]
             {
                new Point(222,158), new Point(241,147), new Point(240,428), new Point(210,426)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
             {
                new Point(132,185) ,new Point(150,184), new Point(148,415), new Point(130,413)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
             {
                 new Point(142,256), new Point(142,298), new Point(0,282), new Point(0,245)
                };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);
        }
        public void CargarEntradaB() {
            #region 
            ListaCoordenadas = new Point[]
       {
           new Point(0,270), new Point(58,236), new Point(0,235), new Point(0,226), new Point(60,197), new Point(126,202), new Point(143,192), new Point(212,192), new Point(228,200), new Point(294,199), new Point(404,226), new Point(404,233), new Point(314,232), new Point(404,286), new Point(404,387), new Point(0,387)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Piso);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(0,0), new Point(405,0), new Point(405,200), new Point(0,200)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
       {
           new Point(40,0), new Point(112,84), new Point(110,202), new Point(88,200), new Point(66,196), new Point(0,228), new Point(0,0)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
       {
           new Point(244,152), new Point(243,201), new Point(292,199), new Point(404,229), new Point(405,124)

       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);


            ListaCoordenadas = new Point[]
       {
           new Point(0,64), new Point(405,74), new Point(405,125), new Point(0,116), new Point(405,125), new Point(311,152), new Point(0,141)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            #endregion
            ListaCoordenadas = new Point[]
       {
           new Point(183,234), new Point(189,234), new Point(195,256), new Point(343,254), new Point(195,256), new Point(200,285), new Point(402,286), new Point(200,285), new Point(214,354), new Point(402,356), new Point(214,354), new Point(220,387), new Point(197,386), new Point(193,365), new Point(0,362), new Point(193,365), new Point(187,286), new Point(0,286), new Point(187,286), new Point(184,256), new Point(27,254), new Point(184,256)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
       {
         new Point(0,226), new Point(404,233), new Point(404,244), new Point(0,237)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.SandyBrown);
            ADibujar.Add(Nuevo);


            ListaCoordenadas = new Point[]
       {
           new Point(181,153), new Point(185,153), new Point(186,158), new Point(192,158), new Point(188,163), new Point(186,163), new Point(186,176), new Point(201,176), new Point(193,184), new Point(186,184), new Point(186,200), new Point(217,202), new Point(218,211), new Point(147,210), new Point(147,202), new Point(153,200), new Point(176,199), new Point(179,199), new Point(179,184), new Point(174,184), new Point(166,176), new Point(181,176), new Point(181,163), new Point(178,163), new Point(174,158), new Point(180,153)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);


        }
        public void CargarEntradaC() {
            ListaCoordenadas = new Point[]
       {
           new Point(0,266), new Point(0,538), new Point(720,540), new Point(720,294), new Point(120,250)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Piso);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
       {
           new Point(0,116), new Point(720,128), new Point(721,296), new Point(119,248), new Point(0,264)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
       {
           new Point(0,66), new Point(0,117), new Point(160,136), new Point(720,130), new Point(720,0), new Point(344,0), new Point(459,95), new Point(150,100)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.SandyBrown);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
       {
           new Point(0,67), new Point(149,102), new Point(148,0), new Point(149,102), new Point(464,96), new Point(344,0), new Point(0,0)
       };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);



            ListaCoordenadas = new Point[]
   {
       new Point(37,317), new Point(63,300), new Point(139,285), new Point(226,284), new Point(319,294), new Point(340,312), new Point(347,348), new Point(293,371), new Point(180,382), new Point(50,369),new Point(37,355)
   };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Brown);
            ADibujar.Add(Nuevo);


            ListaCoordenadas = new Point[]
   {
       new Point(61,315), new Point(92,300), new Point(151,296), new Point(233,290), new Point(312,300), new Point(324,311), new Point(314,322), new Point(252,333), new Point(158,337), new Point(67,323), new Point(61,312)
    };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightSkyBlue);
            ADibujar.Add(Nuevo);

            //Fuente
            ListaCoordenadas = new Point[]
       {
           new Point(186,104), new Point(205,107), new Point(206,125), new Point(240,130), new Point(242,140), new Point(210,157), new Point(220,205), new Point(262,206), new Point(266,218), new Point(240,238), new Point(216,241), new Point(215,289), new Point(228,318), new Point(171,321) , new Point(177,301), new Point(183,299), new Point(187,243), new Point(162,239), new Point(128,214), new Point(132,204), new Point(179,207), new Point(181,155), new Point(167,150), new Point(155,130), new Point(163,124), new Point(187,125)};
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Brown);
            ADibujar.Add(Nuevo);




        }
        #endregion
        #region Biblioteca 
        private void CargarBibliotecaA()
        {
            ListaCoordenadas = new Point[]
             {
                new Point(0,0), new Point(720,0), new Point(720,395), new Point(0,395)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
             {
                 new Point(0,0), new Point(256,0), new Point(598,202), new Point(592,270), new Point(0,50)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
             {
                 new Point(0,150), new Point(586,292), new Point(583,394), new Point(0,441)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
             {
                 new Point(0,52), new Point(0,151), new Point(90,175), new Point(64,415), new Point(246,390), new Point(259,227), new Point(303,229), new Point
                 (586,295), new Point(590,270)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightBlue);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(156,110), new Point(181,120), new Point(166,425), new Point(130,434)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(0,440), new Point(669,381), new Point(720,384), new Point(720,540), new Point(0,540)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Green);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(280,38), new Point(278,137), new Point(349,128), new Point(356,118), new Point(354,29)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
           {
               new Point(277,34), new Point(271,132), new Point(343,124), new Point(354,112), new Point(354,24)
           };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.White);
            ADibujar.Add(Nuevo);

            

        }
        private void CargarBibliotecaB() {

            ListaCoordenadas = new Point[]
             {
                new Point(720,140),new Point(0,140), new Point(0,0), new Point(720,0)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Transparent, Color.SkyBlue);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
             {
                 new Point(0,105), new Point(720,120), new Point(720,260), new Point(0,245)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.FromArgb(223, 209, 148));
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
             {
                 new Point(0,245), new Point(720,260), new Point(720,515), new Point(0,500)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Edificio);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                 new Point(22,249), new Point(29,249), new Point(36,505), new Point(21,505)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(171,255) , new Point(182,254), new Point(182,506), new Point(174,504)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(245, 254),  new Point(251,254), new Point(253,312), new Point(244,311)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(327,256), new Point(335,504), new Point(324,504), new Point(318,258)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(466,259), new Point(475,257), new Point(484,502), new Point(476,501)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(534,261), new Point(541,261), new Point(545,315), new Point(539,315)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(603,260), new Point(616,260), new Point(626,499), new Point(615,500)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(0,507), new Point(0,514), new Point(720,507), new Point(720,502)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
               new Point(0,308), new Point(0,318), new Point(720,322), new Point(720,316)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(0,244), new Point(720,258), new Point(720,266), new Point(0,254)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Color.White);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(359,77), new Point(364,73), new Point(415,74), new Point(419,77), new Point(416,107), new Point(410,110), new Point(359,107), new Point(353,105)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
                new Point(370,109), new Point(369,113), new Point(373,113)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo); ListaCoordenadas = new Point[]
             {
                 new Point(388,115), new Point(391,110), new Point(394,115)
             };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.Black);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
            {
               new Point(0,515), new Point(720,509), new Point(720,540), new Point(0,540)
            };
            Nuevo = new Figura(ListaCoordenadas, Color.White, Piso);
            ADibujar.Add(Nuevo);

        }
        private void CargarbibliotecaC() {
            ListaCoordenadas = new Point[]
                 {
                     new Point(100,0), new Point(203,0), new Point(190,430), new Point(100,466)
                 };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
                 {
                     new Point(203,0), new Point(190,430), new Point(298,446), new Point(330,0)
                     };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightGreen);
            ADibujar.Add(Nuevo);
            ListaCoordenadas = new Point[]
                 {
                     new Point(330,0), new Point(288,540), new Point(315,540), new Point(360,0), new Point(315,540), new Point(372,540), new Point(405,490), new Point(405,0)
                     };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
                {
                    new Point(197,293), new Point(106,316), new Point(106,328), new Point(300,395), new Point(300,381), new Point(106,315),new Point(300,381), new Point(304,315), new Point(305,321)
                    };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightSeaGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
               {
                   new Point(356,402), new Point(355,418), new Point(404,435), new Point(405,415), new Point(356,402), new Point(405,415), new Point(405,364)
                   };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightSeaGreen);
            ADibujar.Add(Nuevo);

            ListaCoordenadas = new Point[]
               {
                   new Point(202,71), new Point(400,63), new Point(395,114), new Point(198,115)

                   };
            Nuevo = new Figura(ListaCoordenadas, Color.Black, Color.LightSeaGreen);
            ADibujar.Add(Nuevo);
        }
        #endregion
        #endregion


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.Focused)
                return base.ProcessCmdKey(ref msg, keyData);
            if ((keyData != Keys.Up) & (keyData != Keys.Down) & (keyData != Keys.Left) & (keyData != Keys.Right))
                return base.ProcessCmdKey(ref msg, keyData);
            try
            {
                switch (keyData)
                {
                    case Keys.Up:
                        Presionada = "Arriba";
                        break;
                    case Keys.Right:
                        Presionada = "Derecha";
                        break;
                    case Keys.Left:
                        Presionada = "Izquierda";
                        break;
                }
                this.Name = Presionada;
                pbxVista.Refresh();
            }
            catch { }
            return true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navegación entre vistas por medio del teclado\nFlecha Arriba->Vista A\nFlecha Izquierda -> Vista B\nFlecha Derecha -> Vista C ");
        }
    }

}