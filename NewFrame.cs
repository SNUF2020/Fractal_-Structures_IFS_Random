using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fractal_Structures
{
    class NewFrame : Form
    {
        // private StatusBar myStatusBar;

        private MainMenu myMainMenu;

        private MenuItem myMItemSafe;

        public PictureBox Field;

        public LinkLabel LinkText;

        public NewFrame(int size)
        {
            // caption bar text and icon of NewFrame
            this.Text = "Output Window";
            this.Icon = new Icon("C:/Users/user/source/repos/00_Data/01_Icons/Win10_Icons/imageres_106.ico");
            //
            //-----------------------------------------------------------------------
            //
            // MainMenu = container for MenuIltems at top end of frame
            myMainMenu = new MainMenu();
            myMItemSafe = new MenuItem();
            // Lables of items
            myMItemSafe.Text = "Safe Image";
            // Eventhandler click on MenueItem
            myMItemSafe.Click += new EventHandler(myMenuEvent);
            // First menue level:
            myMainMenu.MenuItems.Add(myMItemSafe);
            // allocation of myMainMenu to menu of class Frames06
            this.Menu = myMainMenu;
            //
            //--------------------------------------------------------------------------
            //
            // settings of NewFrame
            this.MaximizeBox = false;                            // Set the MaximizeBox to false to remove the maximize box.
            this.MinimizeBox = false;                            // Set the MinimizeBox to false to remove the minimize box.
            this.StartPosition = FormStartPosition.CenterScreen; // Set the start position of the form to the center of the screen.
            this.AutoSize = false;
            this.Size = new Size(size+40, size+80);
            //
            //-----------------------------------------------------------------------------
            //
            // feature #1: pictureBox 
            this.Field = new PictureBox()
            {
                Size = new Size(size, size)
            };
            Bitmap FieldBitmap = new Bitmap(size, size); //PixelFormat.Format64bppArgb);
            Field.Image = FieldBitmap;
            //Field.BackColor = Color.White;
            Controls.Add(Field);
            //
            //------------------------------------------------------------------------------------
            /*
            // StatusBar at lower end of frame
            myStatusBar = new StatusBar();
            myStatusBar.Text = ifs_name;
            myStatusBar.SizingGrip = true;
            Controls.Add(myStatusBar);
            */
        } // constructor of NewFrame, first overload

        public NewFrame()
        {
            // caption bar text and icon of NewFrame
            this.Text = "Information Window";
            this.Icon = new Icon("C:/Users/user/source/repos/00_Data/01_Icons/Win10_Icons/imageres_81.ico");
            //
            //-----------------------------------------------------------------------
            //
            // settings of NewFrame
            this.MaximizeBox = false;                            // Set the MaximizeBox to false to remove the maximize box.
            this.MinimizeBox = false;                            // Set the MinimizeBox to false to remove the minimize box.
            this.StartPosition = FormStartPosition.CenterScreen; // Set the start position of the form to the center of the screen.
            this.AutoSize = false;
            this.Size = new Size(520, 300);
            //
            //-----------------------------------------------------------------------------
            //
            // feature #1: Labels with information 
            Label HeadLine = new Label()
            {
                Size = new Size(500, 20),
                Location = new Point(5,10),
                Text = "Iterated Function System (IFS) and Chaos Game",
                AutoSize = false,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            Controls.Add(HeadLine);

            Label InfoText = new Label()
            {
                Size = new Size(500, 120),
                Location = new Point(5, 40),
                Text = 
                "In mathematics, iterated function systems (IFSs) are a method of constructing fractals. \n" +
                "The most common algorithm to compute IFS fractals is called the \"chaos game\". "+
                "It consists of picking a random point in the plane, then iteratively applying one of the "+
                "functions chosen at random from the function system to transform the point to get a next point.\n" +
                "(Source: Wikipedia)",
                AutoSize = false,
                Font = new Font("Arial", 10, FontStyle.Regular)
            };
            Controls.Add(InfoText);

            LinkText = new LinkLabel()
            {
                Size = new Size(500, 200),
                Location = new Point(5, 160),
                Text = " https://en.wikipedia.org/wiki/Iterated_function_system/ ",
                AutoSize = false,
                Font = new Font("Arial", 10, FontStyle.Regular)
            };
            LinkText.LinkClicked += new LinkLabelLinkClickedEventHandler(linkText_LinkClicked);
            Controls.Add(LinkText);
        } // constructor of NewFrame, second overload

        private void myMenuEvent(object sender, System.EventArgs e)
        {
            if (sender.Equals(myMItemSafe))
                SafeImage();
        }

        private void linkText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                LinkText.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Iterated_function_system");
            }
            catch
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void SafeImage()
        {
            // Displays a SaveFileDialog so the user can save the Image
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg|Gif Image|*.gif|Icon Image|*.ico";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                using (FileStream fs = (System.IO.FileStream) saveFileDialog1.OpenFile())
                {
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.

                    ImageFormat imageFormat = null;
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            imageFormat = ImageFormat.Png;
                            break;
                        case 2:
                            imageFormat = ImageFormat.Bmp;
                            break;
                        case 3:
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case 4:
                            imageFormat = ImageFormat.Gif;
                            break;
                        case 5:
                            imageFormat = ImageFormat.Icon;
                            break;
                        default:
                            throw new NotSupportedException("File extension is not supported");
                    }
                    this.Field.Image.Save(fs, imageFormat);
                    fs.Close();
                }
            }
        }

    }
}
