using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal_Structures
{
    public partial class Form1 : Form
    {
        // Program for fractal structures by Iterated Function Systems (IFS)
        // 
        // Keeping Form1 as lean as possible all methodes are in class "MainMethodes"
        // QR-code from additional ressource (image)
        // Async mode for outPut-methode due to long-term calculation of motion freezing windows
        // Draw graphic in image of picturebox -> for visible image after mooving behind other windows etc. Invalidate methode is necessary

        // S.N.U.F 30.03.2020
        // Last change: 28.04.2020
        // Version 1.0

        // General reference and definition section
        MainMethods MM0 = new MainMethods();            // Generation of MainMathode instance      
        BindingSource dataSheet = new BindingSource();  // Generation of bindigsource for dataGridview
        Random rand = new Random();                     // generation of instance of Random-class. in case of (number) = defined random value
        public int size = 600;                                 // definition of scale of playground / window
        public double[,] Para = new double[8, 7];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Definition of datasource for dataGridView and initialization of bindingsource
            dataGridView2.DataSource = dataSheet;
            MM0.LoadData("sirpinski", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet); // initial filling with sirpinski-parameter set
        }

        private void radioButton_Sirpinski_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("sirpinski", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_Koch_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("koch", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_BarnFern1_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("Barnsley Fern", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_BarnFern2_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("Thelypteridaceae", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_BarnFern3_CheckedChanged(object sender, EventArgs e)
        {
           MM0.LoadData("Leptosporangiate", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_BarnFern4_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("leaf", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_Tree_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("tree", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_TwinDragon_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("Twindragon", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_CantorLab_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("CantorLab", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_SirPenta_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("SirpinskiPenta", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_Vic_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("VicFractal", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_SirCarp_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("SirpinskiCarp", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }

        private void radioButton_Tree2_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("WinterTree", textBox_Scaling, textBox_Points, textBox_IFSName, textBox_XShift, textBox_YShift, dataSheet);
        }
        //
        // ------------------------------------------------------------------------------------------------------------------------------
        //
        // Control of allowed input for textBoxes...
        private void textBox_XShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !char.IsPunctuation(e.KeyChar);
        } // Control of allowed input - not complete safe (e.g. ; or : still alowed) - found no solution (assume "tryparse" could work)

        private void textBox_YShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !char.IsPunctuation(e.KeyChar);
        } // Control of allowed input - not complete safe (e.g. ; or : still alowed) - found no solution (assume "tryparse" could work)

        private void textBox_Scaling_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !char.IsPunctuation(e.KeyChar);
        } // Control of allowed input - not complete safe (e.g. ; or : still alowed) - found no solution (assume "tryparse" could work)

        private void textBox_Points_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
        } // Control of allowed input

        private void textBox_IFSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
        } // Control of allowed input
        //
        // ------------------------------------------------------------------------------------------------------------------
        //
        // Definition of ToolStripButtons
        private async void toolStripButton_Start_Click(object sender, EventArgs e)
        {
            // new instance: new frame: new instance of NewFrame
            NewFrame outputWin = new NewFrame(size);
            outputWin.Show();

            // Generation of Graphics instance correlated to image in picturebox
            Graphics g = Graphics.FromImage(outputWin.Field.Image);
            //g.Clear(Color.White);

            // Grap parameters from dataGridview2 (they could be modified by user)
            MM0.GetData(dataGridView2, Para);

            // Random Jump by IFS
            await Task.Run(() => MM0.OutPut(outputWin.Field, g, rand, 
                textBox_XShift, textBox_YShift, textBox_Scaling, size, Para, textBox_IFSName, textBox_Points, radioButton_non));
            // methode running in async mode -> no freezing of desktop due to long-time calculation duration of this methode

            // Dispose graphic instance
            g.Dispose();
        } // calculation of fractal structure by given parameters

        private void toolStripButton_Safe_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Data table
            using (SaveFileDialog sfDlg = new SaveFileDialog())
            {
                sfDlg.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                if (sfDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // generate instance if stringbuilder for later writing of csv.file
                        StringBuilder sbOutput = new StringBuilder();

                        // generate string table w/ 3 + dataGrid-rows
                        string[][] inaOutput = new string[3 + dataGridView2.Rows.Count][];

                        // first row: name of IFS
                        inaOutput[0] = new string[] { textBox_IFSName.Text };

                        // first row: number of iterations
                        inaOutput[1] = new string[] { textBox_Points.Text };

                        // second row: x-shift, y-shift and scaling factor
                        inaOutput[2] = new string[] { textBox_XShift.Text, textBox_YShift.Text, textBox_Scaling.Text };

                        // next rows: ifs parameters
                        for (int i = 0; i < dataGridView2.Rows.Count; i++) // rows
                        {
                            inaOutput[i + 3] = new string[8];
                            for (int k = 0; k < 8; k++) // colums
                            {
                                inaOutput[i + 3][k] = Convert.ToString(dataGridView2.Rows[i].Cells[k].Value);
                            }
                        }
                        for (int i = 0; i < inaOutput.GetLength(0); i++)
                            sbOutput.AppendLine(string.Join(";", inaOutput[i]));

                        // Create and write the csv file
                        File.WriteAllText(sfDlg.FileName, sbOutput.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }// Safe

        private void toolStripButton_Load_Click(object sender, EventArgs e)
        {
            // Align radiobutton array 
            radioButton_ImportIFS.Checked = true;
            // Load IFS from disk
            MM0.LoadIFS(dataSheet, textBox_XShift, textBox_YShift, textBox_Scaling, textBox_IFSName, textBox_Points);
        }

        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Program-End with Exit-Button

        private void toolStripButton_Info_Click(object sender, EventArgs e)
        {
            NewFrame Info = new NewFrame();
            Info.Show();
        }
    } // Form1
}
