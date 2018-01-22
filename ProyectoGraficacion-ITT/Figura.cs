using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregadas
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGraficacion_ITT
{
    class Figura
    {
        Point[] Coordenadas;
        Pen Pen;
        SolidBrush Relleno;


        public Figura(Point[] Coordenadas, Color Contorno, Color Relleno) { this.Coordenadas = Coordenadas; Pen = new Pen(Contorno); this.Relleno = new SolidBrush(Relleno); }

        public void DibujarContorno(PaintEventArgs e)
        {   e.Graphics.DrawPolygon(Pen, Coordenadas);   }
        public void Rellenar (PaintEventArgs e)
        {   e.Graphics.FillPolygon(Relleno, Coordenadas);   }
        public void DibujarFigura(PaintEventArgs e)
        {
            Rellenar(e);
            DibujarContorno(e);
        }
            
        
    }
}
