using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using QRCoder;
using System.Data;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Fractal_Structures
{
    class MainMethods
    {
        public void LoadData(string _case, TextBox textBoxSkala, TextBox textBoxSchleife, TextBox textBox_IFSName,
            TextBox textBox_XShift, TextBox textBox_YShift, BindingSource DatenQuelle)
        {
            // Generation of DataTable
            DataTable pt = new DataTable("IFS");

            string[] colHead = {"Color", "A", "B", "C", "D", "E", "F", "p" };
            DataColumn col0 = new DataColumn();
            col0.DataType = System.Type.GetType("System.String");
            col0.ColumnName = colHead[0];
            pt.Columns.Add(col0);

            for (int i = 1; i < 8; i++)
            {
                DataColumn col = new DataColumn();
                col.DataType = System.Type.GetType("System.Double");
                col.ColumnName = colHead[i];
                pt.Columns.Add(col);
            }
            if (_case == "sirpinski")
            {
                pt.Rows.Add(new Object[] { "Red",   0.5, 0, 0, 0.5, 0.50, 0.00, 0.333 });
                pt.Rows.Add(new Object[] { "Green", 0.5, 0, 0, 0.5, 0.00, 0.00, 0.333 });
                pt.Rows.Add(new Object[] { "Blue",  0.5, 0, 0, 0.5, 0.25, 0.50, 0.334 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0);
                textBox_YShift.Text = Convert.ToString(0);
                textBoxSkala.Text = Convert.ToString(0.95);
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Sierpiński Triangle";

            }
            else if (_case == "koch")
            {
                pt.Rows.Add(new Object[] { "Red",   0.33333,  0.000,  0.000, 0.333, 0.00000, 0.000, 0.25 });
                pt.Rows.Add(new Object[] { "Green", 0.16667, -0.288,  0.288, 0.167, 0.33333, 0.000, 0.25 });
                pt.Rows.Add(new Object[] { "Blue",  0.16667,  0.288, -0.288, 0.167, 0.50000, 0.288, 0.25 });
                pt.Rows.Add(new Object[] { "Lime",  0.33333,  0.000,  0.000, 0.333, 0.66667, 0.000, 0.25 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0);
                textBox_YShift.Text = Convert.ToString(-0.667);
                textBoxSkala.Text = Convert.ToString(0.95); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Koch Curve";
            }
            else if (_case == "Barnsley Fern")
            {
                pt.Rows.Add(new Object[] { "Red",   0.00,  0.00,  0.00, 0.16, 0.00, 0.00, 0.01 });
                pt.Rows.Add(new Object[] { "Green", 0.85,  0.04, -0.04, 0.85, 0.00, 1.60, 0.85 });
                pt.Rows.Add(new Object[] { "Blue",  0.20, -0.26,  0.23, 0.22, 0.00, 1.60, 0.07 });
                pt.Rows.Add(new Object[] { "Lime", -0.15,  0.28,  0.26, 0.24, 0.00, 0.44, 0.07 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0.5);
                textBox_YShift.Text = Convert.ToString(0);
                textBoxSkala.Text = Convert.ToString(0.095); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Barnsley Fern";
            }
            else if (_case == "leaf")
            {
                pt.Rows.Add(new Object[] { "Red", 0.44, 0.32, -0.07, 0.61, -0.001, -0.1, 0.3 });
                pt.Rows.Add(new Object[] { "Green", -0.82, 0.16, -0.16, 0.81, -0.001, 4.0, 0.7 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0.5);
                textBox_YShift.Text = Convert.ToString(0);
                textBoxSkala.Text = Convert.ToString(0.05); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Leaf";
            }
            else if (_case == "Thelypteridaceae")
            {
                pt.Rows.Add(new Object[] { "Red", 0.000, 0.000, 0.000, 0.25, 0.000, -0.4, 0.02 });
                pt.Rows.Add(new Object[] { "Green", 0.950, 0.005, -0.005, 0.93, -0.002, 0.5, 0.84 });
                pt.Rows.Add(new Object[] { "Blue", 0.035, -0.20, 0.160, 0.04, 0.090, 0.02, 0.07 });
                pt.Rows.Add(new Object[] { "Lime", -0.04, 0.200, 0.160, 0.04, 0.083, 0.12, 0.07 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0.5);
                textBox_YShift.Text = Convert.ToString(-0.1);
                textBoxSkala.Text = Convert.ToString(0.125); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Thelypteridaceae";
            }
            else if (_case == "Leptosporangiate")
            {
                pt.Rows.Add(new Object[] { "Red", 0.000, 0.000, 0.000, 0.25, 0.000, -0.14, 0.02 });
                pt.Rows.Add(new Object[] { "Green", 0.850, 0.020, -0.020, 0.83, 0.000, 1.00, 0.84 });
                pt.Rows.Add(new Object[] { "Blue", 0.090, -0.28, 0.300, 0.11, 0.000, 0.60, 0.07 });
                pt.Rows.Add(new Object[] { "Lime", -0.09, 0.280, 0.300, 0.09, 0.000, 0.70, 0.07 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0.5);
                textBox_YShift.Text = Convert.ToString(0);
                textBoxSkala.Text = Convert.ToString(0.17); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Leptosporangiate";
            }
            else if (_case == "tree") // by Paul Bourke 01/1999
            {
                pt.Rows.Add(new Object[] { "Red", 0.01,  0.00,  0.00,  0.45, 0.000, 0.00, 0.05 });
                pt.Rows.Add(new Object[] { "Green", 0.42, -0.42,  0.42,  0.42, 0.000, 0.40, 0.40 });
                pt.Rows.Add(new Object[] { "Blue", 0.42,  0.42, -0.42,  0.42, 0.000, 0.40, 0.40 });
                pt.Rows.Add(new Object[] { "Lime", -0.01,  0.00,  0.00, -0.45, 0.000, 0.40, 0.15 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0.5);
                textBox_YShift.Text = Convert.ToString(0);
                textBoxSkala.Text = Convert.ToString(0.95); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Tree";
            }
            else if (_case == "CantorLab")
            {
                pt.Rows.Add(new Object[] { "Red", 0.333,  0.000, 0.00, 0.333, 0.333, 0.666, 0.14 });
                pt.Rows.Add(new Object[] { "Green", 0.000,  0.333, 1.00, 0.000, 0.667, 0.000, 0.43 });
                pt.Rows.Add(new Object[] { "Blue", 0.000, -0.333, 1.00, 0.000, 0.333, 0.000, 0.43 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0);
                textBox_YShift.Text = Convert.ToString(0);
                textBoxSkala.Text = Convert.ToString(0.95); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Cantor Labyrinth";
            }
            else if (_case == "SirpinskiPenta")
            {
                pt.Rows.Add(new Object[] { "Red", 0.382, 0.000, 0.00, 0.382, 0.3072, 0.6190, 0.2 });
                pt.Rows.Add(new Object[] { "Green", 0.382, 0.000, 0.00, 0.382, 0.6033, 0.4044, 0.2 });
                pt.Rows.Add(new Object[] { "Blue", 0.382, 0.000, 0.00, 0.382, 0.0139, 0.4044, 0.2 });
                pt.Rows.Add(new Object[] { "Lime", 0.382, 0.000, 0.00, 0.382, 0.1253, 0.0595, 0.2 });
                pt.Rows.Add(new Object[] { "DarkCyan", 0.382, 0.000, 0.00, 0.382, 0.4920, 0.0595, 0.2 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0);
                textBox_YShift.Text = Convert.ToString(0);
                textBoxSkala.Text = Convert.ToString(0.95); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Sirpinski Pentagram";
            }
            else if (_case == "VicFractal")
            {
                pt.Rows.Add(new Object[] { "Red", 0.333, 0.000, 0.00, 0.333, 0.000, 0.000, 0.2 });
                pt.Rows.Add(new Object[] { "Green", 0.333, 0.000, 0.00, 0.333, 0.667, 0.000, 0.2 });
                pt.Rows.Add(new Object[] { "Blue", 0.333, 0.000, 0.00, 0.333, 0.000, 0.667, 0.2 });
                pt.Rows.Add(new Object[] { "Lime", 0.333, 0.000, 0.00, 0.333, 0.667, 0.667, 0.2 });
                pt.Rows.Add(new Object[] { "DarkCyan", 0.333, 0.000, 0.00, 0.333, 0.333, 0.333, 0.2 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0);
                textBox_YShift.Text = Convert.ToString(0);
                textBoxSkala.Text = Convert.ToString(0.95); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Vicsek Fractal";
            }
            else if (_case == "SirpinskiCarp")
            {
                pt.Rows.Add(new Object[] { "Red", 0.333, 0.000, 0.00, 0.333, 0.000, 0.000, 0.125 });
                pt.Rows.Add(new Object[] { "Green", 0.333, 0.000, 0.00, 0.333, 0.333, 0.000, 0.125 });
                pt.Rows.Add(new Object[] { "Blue", 0.333, 0.000, 0.00, 0.333, 0.667, 0.000, 0.125 });
                pt.Rows.Add(new Object[] { "Lime", 0.333, 0.000, 0.00, 0.333, 0.000, 0.333, 0.125 });
                pt.Rows.Add(new Object[] { "DarkCyan", 0.333, 0.000, 0.00, 0.333, 0.667, 0.333, 0.125 });
                pt.Rows.Add(new Object[] { "Plum", 0.333, 0.000, 0.00, 0.333, 0.000, 0.667, 0.125 });
                pt.Rows.Add(new Object[] { "Black", 0.333, 0.000, 0.00, 0.333, 0.333, 0.667, 0.125 });
                pt.Rows.Add(new Object[] { "Cyan", 0.333, 0.000, 0.00, 0.333, 0.667, 0.667, 0.125 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0);
                textBox_YShift.Text = Convert.ToString(0);
                textBoxSkala.Text = Convert.ToString(0.95); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Sirpinski Carpet";
            }
            else if (_case == "WinterTree") // by Paul Bourke 01/1999
            {
                pt.Rows.Add(new Object[] { "Red",      0.05,  0.00,  0.00,  0.40, -0.06, -0.47, 0.05 });
                pt.Rows.Add(new Object[] { "Green",   -0.05,  0.00,  0.00, -0.40, -0.06, -0.47, 0.05 });
                pt.Rows.Add(new Object[] { "Blue",     0.03, -0.14,  0.00,  0.26, -0.16, -0.01, 0.05 });
                pt.Rows.Add(new Object[] { "Lime",    -0.03,  0.14,  0.00, -0.26, -0.16, -0.01, 0.05 });
                pt.Rows.Add(new Object[] { "DarkCyan", 0.56,  0.44, -0.37,  0.51,  0.30,  0.15, 0.30 });
                pt.Rows.Add(new Object[] { "Plum",     0.19,  0.07, -0.10,  0.15, -0.20,  0.28, 0.20 });
                pt.Rows.Add(new Object[] { "Black",   -0.33, -0.34, -0.33,  0.34, -0.54,  0.39, 0.30 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0.5);
                textBox_YShift.Text = Convert.ToString(-0.5);
                textBoxSkala.Text = Convert.ToString(0.45); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Winter Tree";
            }
            else // Twindragon
            {
                pt.Rows.Add(new Object[] { "Red", -0.5, 0.5, -0.5, -0.5, 0.0, 0.0, 0.5 });
                pt.Rows.Add(new Object[] { "Green", -0.5, 0.5, -0.5, -0.5, -1.0, -1.0, 0.5 });
                // Shift X, Shift Y, scaling of fractal
                textBox_XShift.Text = Convert.ToString(0.6);
                textBox_YShift.Text = Convert.ToString(-0.6);
                textBoxSkala.Text = Convert.ToString(0.2); 
                int Schleifen = 250000;
                textBoxSchleife.Text = Convert.ToString(Schleifen);
                textBox_IFSName.Text = "Twindragon";
            }
            DatenQuelle.DataSource = pt; 
        }
       
        public void Message(int size, string info, Graphics gr, Single x, Single y)
        {
            Font drawFont = new Font("Microsoft Sans Serif", size, FontStyle.Regular, GraphicsUnit.Point, 0);
            StringFormat drawFormat = new StringFormat();
            gr.TextRenderingHint = TextRenderingHint.AntiAlias;
            gr.DrawString(info, drawFont, Brushes.Black, x, y, drawFormat);
        }
       
        public void GetData (DataGridView Tabelle, double[,] Para)
        {
            // Grap all function paramters in dataGridview
            for (int i = 0; i < 7; i++) // colums
                for (int k = 0; k < Tabelle.Rows.Count; k++) // rows
                    Para[k, i] = Convert.ToDouble(Tabelle.Rows[k].Cells[i+1].Value);
        }

        public SolidBrush[] Farbe(RadioButton radioButton_non)
        {
            SolidBrush[] _color = new SolidBrush[8];

            if (radioButton_non.Checked)
            {
                for(int i = 0; i<8; i++)
                     _color[i] = new SolidBrush(Color.Black);
            }
            else 
            {
                _color[0] = new SolidBrush(Color.Red);
                _color[1] = new SolidBrush(Color.Green);
                _color[2] = new SolidBrush(Color.Blue);
                _color[3] = new SolidBrush(Color.Lime);
                _color[4] = new SolidBrush(Color.DarkCyan);
                _color[5] = new SolidBrush(Color.Plum);
                _color[6] = new SolidBrush(Color.Black);
                _color[7] = new SolidBrush(Color.Cyan);
                //_color[4] = new SolidBrush(Color.LightBlue);
            }
            return _color;
        }
        public void OutPut(PictureBox picbox, Graphics gr, Random rnd, TextBox textBox_XShift, TextBox textBox_YShift, TextBox textBox_Scaling,
            int size, double[,] para, TextBox textBox_IFSName, TextBox textBox_Points,  RadioButton radioButton_non)
        {
            // Starting point + "help"-point
            PointF Punkt = new PointF(size / 2, size / 2);
            PointF Punkt_new = new PointF();
            
            // Definition of color
            SolidBrush[] colorMix = this.Farbe(radioButton_non);
            SolidBrush _color;
            double choice;
            
            // Definition of number of loops
            int loop = Convert.ToInt32(textBox_Points.Text);
            
            // HeadLine of image
            Message(14, textBox_IFSName.Text, gr, 15, 4);

            // Shifts & Scaling of image
            double[] Skalierung = new double[3];
            Skalierung[0] = Convert.ToDouble(textBox_XShift.Text);
            Skalierung[1] = Convert.ToDouble(textBox_YShift.Text);
            Skalierung[2] = Convert.ToDouble(textBox_Scaling.Text);

            // plot now fractal structure
            for (int k = 0; k < loop; k++)
            {
                // random choice of function
                choice = rnd.NextDouble();
                if (choice < para[0,6])
                {
                    Punkt_new.X = (float)(para[0, 0] * Punkt.X + para[0, 1] * Punkt.Y + para[0, 4]);
                    Punkt_new.Y = (float)(para[0, 2] * Punkt.X + para[0, 3] * Punkt.Y + para[0, 5]);
                    _color = colorMix[0];
                }
                else if (choice < (para[0,6]+para[1,6]))
                {
                    Punkt_new.X = (float)(para[1, 0] * Punkt.X + para[1, 1] * Punkt.Y + para[1, 4]);
                    Punkt_new.Y = (float)(para[1, 2] * Punkt.X + para[1, 3] * Punkt.Y + para[1, 5]);
                    _color = colorMix[1];
                }
                else if (choice < (para[0, 6] + para[1, 6] + para[2,6]))
                {
                    Punkt_new.X = (float)(para[2, 0] * Punkt.X + para[2, 1] * Punkt.Y + para[2, 4]);
                    Punkt_new.Y = (float)(para[2, 2] * Punkt.X + para[2, 3] * Punkt.Y + para[2, 5]);
                    _color = colorMix[2];
                }
                else if (choice < (para[0, 6] + para[1, 6] + para[2, 6] + para[3,6]))
                {
                    Punkt_new.X = (float)(para[3, 0] * Punkt.X + para[3, 1] * Punkt.Y + para[3, 4]);
                    Punkt_new.Y = (float)(para[3, 2] * Punkt.X + para[3, 3] * Punkt.Y + para[3, 5]);
                    _color = colorMix[3];
                }
                else if (choice < (para[0, 6] + para[1, 6] + para[2, 6] + para[3, 6] + para[4,6]))
                {
                    Punkt_new.X = (float)(para[4, 0] * Punkt.X + para[4, 1] * Punkt.Y + para[4, 4]);
                    Punkt_new.Y = (float)(para[4, 2] * Punkt.X + para[4, 3] * Punkt.Y + para[4, 5]);
                    _color = colorMix[4];
                }
                else if (choice < (para[0, 6] + para[1, 6] + para[2, 6] + para[3, 6] + para[4, 6] + para[5,6]))
                {
                    Punkt_new.X = (float)(para[5, 0] * Punkt.X + para[5, 1] * Punkt.Y + para[5, 4]);
                    Punkt_new.Y = (float)(para[5, 2] * Punkt.X + para[5, 3] * Punkt.Y + para[5, 5]);
                    _color = colorMix[5];
                }
                else if (choice < (para[0, 6] + para[1, 6] + para[2, 6] + para[3, 6] + para[4, 6] + para[5, 6] + para[6,6]))
                {
                    Punkt_new.X = (float)(para[6, 0] * Punkt.X + para[6, 1] * Punkt.Y + para[6, 4]);
                    Punkt_new.Y = (float)(para[6, 2] * Punkt.X + para[6, 3] * Punkt.Y + para[6, 5]);
                    _color = colorMix[6];
                }
                else
                {
                    Punkt_new.X = (float)(para[7, 0] * Punkt.X + para[7, 1] * Punkt.Y + para[7, 4]);
                    Punkt_new.Y = (float)(para[7, 2] * Punkt.X + para[7, 3] * Punkt.Y + para[7, 5]);
                    _color = colorMix[7];
                }
                Punkt = Punkt_new;
                gr.FillRectangle(_color, (float)(Punkt.X*(size*Skalierung[2]))+20+(float)(size*Skalierung[0]), 
                    (float)(size-(Punkt.Y*(size*Skalierung[2])))+(float)(size*Skalierung[1]), 1, 1); 
                // Transformation of coordination system (shift of 0/0 by +20 and +40 and change of Y direction) + scaling of X and Y direction + individual shift  
                picbox.Invalidate(); // update image in picturBox
            }
        }// Methode, first overload: random jump of particle

        public void LoadIFS(BindingSource Tabelle, TextBox textBox_XShift, TextBox textBox_YShift, TextBox textBox_Scaling,
            TextBox textBox_IFSName, TextBox textBox_Points)
        {
            using (OpenFileDialog ofDlg = new OpenFileDialog())
            {
                // Datei öffnen
                ofDlg.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                if (ofDlg.ShowDialog() == DialogResult.OK)
                {
                    // DataTable hält die gesplitteten CSV-Daten
                    DataTable dt = new DataTable();

                    string[] colHead = { "Color", "A", "B", "C", "D", "E", "F", "p" };
                    DataColumn col0 = new DataColumn();
                    col0.DataType = System.Type.GetType("System.String");
                    col0.ColumnName = colHead[0];
                    dt.Columns.Add(col0);

                    for (int i = 1; i < 8; i++)
                    {
                        DataColumn col = new DataColumn();
                        col.DataType = System.Type.GetType("System.Double");
                        col.ColumnName = colHead[i];
                        dt.Columns.Add(col);
                    }

                    // Datei öffnen, hier als UTF8
                    using (StreamReader sr = new StreamReader(ofDlg.FileName, Encoding.UTF8))
                    {
                        // bis Dateiende lesen
                        while (!sr.EndOfStream)
                        {
                            // Zeile einlesen und anhand des Trennzeichens ";" in einzelne Spalten (stringarray) splitten
                            string[] currentline = sr.ReadLine().Split(new string[] { ";" }, StringSplitOptions.None);
                            //MessageBox.Show(currentline[0]+ "/"+ currentline[1] + "/" + currentline[2] + "/" + currentline[3] + "/" + currentline[4] + "/" + currentline[5] + "/" + currentline[6] + "/" + currentline[7]);
                            dt.Rows.Add(currentline);
                        }
                        // Stream schließen
                        sr.Close();
                    }
                    textBox_IFSName.Text = Convert.ToString(dt.Rows[0][0]);
                    textBox_Points.Text = Convert.ToString(dt.Rows[1][0]);
                    textBox_XShift.Text = Convert.ToString(dt.Rows[2][0]);
                    textBox_YShift.Text = Convert.ToString(dt.Rows[2][1]);
                    textBox_Scaling.Text = Convert.ToString(dt.Rows[2][2]);

                    // Delete first three rows
                    DataRowCollection itemColumns = dt.Rows;
                    itemColumns[0].Delete();
                    itemColumns[0].Delete();
                    itemColumns[0].Delete();

                    // DataTable an das Gitter auf der Oberfläche übergeben und somit anzeigen
                    Tabelle.DataSource = dt;
                }
            }
        }// code sniplet from https://codezentrale.de/csv-daten-einlesen/
    }
}
