using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Bunifu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            bunifuFormDock1.SubscribeControlToDragEvents(panel2);
            bunifuPages1.SetPage(Upload_Resume_Page);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e) // Experience
        {
            Follower_Beam.Top = ((Control)sender).Top;  
            bunifuPages1.SetPage(Experience_Page);
        }

        private void bunifuButton2_Click(object sender, EventArgs e) // Education
        {
            Follower_Beam.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(Education_Page);
        }

        private void bunifuButton3_Click(object sender, EventArgs e) // Skills
        {
            Follower_Beam.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(Skills_Page);
        }

        private void bunifuButton4_Click(object sender, EventArgs e) // Programming_Langauges
        {
            Follower_Beam.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(Prog_Languages_Pages);
        }

        private void bunifuButton5_Click(object sender, EventArgs e) // About Me
        {
            Follower_Beam.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(About_Me_Page);
        }

        private void bunifuButton6_Click(object sender, EventArgs e) // Upload Resume
        {
            Follower_Beam.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(Upload_Resume_Page);
        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
