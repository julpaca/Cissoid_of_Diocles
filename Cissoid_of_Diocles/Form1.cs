using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cissoid_of_Diocles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tbStartPoint.Text = "-1";
            tbEndPoint.Text = "1";
            tbCoefficient.Text = "0,3";
            tbStep.Text = "0,02";
        }

        private List<double> CreateXCoordinates(double x1, double x2, double step)
        {
            List<double> allXCoords = new List<double>();
            
            while (x1 <= x2)
            {
                x1 = Math.Round(x1, 6); //!!!
                allXCoords.Add(x1);
                x1 += step;
            }
            return allXCoords;
        }

        private void btnMakeGraph_Click(object sender, EventArgs e)
        {
           gridCoordinates.Rows.Clear();
            graph.Series[0].Points.Clear();
            graph.Series[1].Points.Clear();

            string startPoint = tbStartPoint.Text;
            string endPoint = tbEndPoint.Text;
            string coefficient = tbCoefficient.Text; 
            string step = tbStep.Text;
            //double x, y;

            if (double.TryParse(tbStartPoint.Text, out double x1) && 
                double.TryParse(endPoint, out double x2) && 
                double.TryParse(coefficient, out double a) && 
                double.TryParse(step, out double stp) == true) 
            {
                if ((x1 > x2) || (stp <= 0) || (stp > Math.Abs(x1 - x2)) == true) 
                {
                    MessageBox.Show ("Введённые данные неверны.", "Упс!");
                }
                else
                {
                    List<double> allXCoords = CreateXCoordinates(x1, x2, stp);
                    (bool index, List<Coordinates> coordinates) = AllCoords(allXCoords, a);
                    if(coordinates.Count == 0)
                    {
                        MessageBox.Show("Введённые значения некорректны.", "Упс!");
                    }

                    gridCoordinates.RowCount = coordinates.Count;

                    /*if (coordinates.Count < 50)
                    {
                        gridCoordinates.RowCount = coordinates.Count;
                    }
                    else
                    {
                        gridCoordinates.RowCount = 50;
                    }*/

                    int i = 0;
                    foreach (Coordinates coord in coordinates)
                    {
                        graph.Series[0].Points.AddXY(coord.x, coord.y1);
                        graph.Series[1].Points.AddXY(coord.x, coord.y2);
                        gridCoordinates.Rows[i].Cells[0].Value = coord.x;
                        gridCoordinates.Rows[i].Cells[1].Value = coord.y1;
                        gridCoordinates.Rows[i].Cells[2].Value = coord.y2;
                        i++;
                        /*if (i == 50)
                            break;*/
                    }
                }
            }
            else
            {
                MessageBox.Show("Вводимые данные должны быть типа double.", "Упс!");
            }
        }

        public (bool, List<Coordinates>) AllCoords(List<double> xCoords, double coef)
        {
            bool isDataCorrect = false;
            List<Coordinates> coords = new List<Coordinates>();

            for (int i = 0; i < xCoords.Count; i++)
            {
                double x = xCoords[i];
                if ((2 * coef - x) == 0)
                {
                    isDataCorrect = true;
                    continue;
                }
                else
                {
                    (double y1, double y2) = Coordinates.CissoidOfDiocles(x, coef);
                    Coordinates coordinate = new Coordinates(x, y1, y2);
                    coords.Add(coordinate);
                }
            }
            return (isDataCorrect, coords);
        }
    }
}
