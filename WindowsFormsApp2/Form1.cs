using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             PrivateFontCollection pfc = new PrivateFontCollection();

        //Select your font from the resources.
        //My font here is "Digireu.ttf"
        int fontLength = Properties.Resources.ArbFONTS_GEDinkum_Regular.Length;

        // create a buffer to read in to
        byte[] fontdata = Properties.Resources.ArbFONTS_GEDinkum_Regular;

        // create an unsafe memory block for the font data
        System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

        // copy the bytes to the unsafe memory block
        Marshal.Copy(fontdata, 0, data, fontLength);

        // pass the font to the font collection
        pfc.AddMemoryFont(data,fontLength);


            button1.Font = new Font(pfc.Families[0], button1.Font.Size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
 
