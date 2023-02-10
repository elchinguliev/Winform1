using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Properties;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        Label bakuLbl=new Label();
        Label bakuDate=new Label();  
        Label londonLbl=new Label();     
        Timer mytimer=new Timer();
        Timer londonTimer=new Timer();  
        Timer bakuTimer=new Timer();
        public Form1()
        {
            InitializeComponent();
            mytimer.Interval=1000;
            mytimer.Tick+=Mytimer_Tick;
            mytimer.Start();
        }

        private void Mytimer_Tick(object sender, EventArgs e)
        {

            //throw new NotImplementedException();
        }

        private void londonbtn_MouseClick(object sender, MouseEventArgs e)
        {
            mytimer.Stop();
            bakuTimer.Stop();
            foreach (var control in Controls)
            {
                if (control is Label)
                {
                    (control as Label).Visible=false;
                }
            }
            this.BackgroundImage=Resources.LLondon;
            londonLbl.Text="London ";
            londonLbl.ForeColor=Color.Black;
            londonLbl.ForeColor=Color.Black;
            londonLbl.Location=new Point(15,560);
            londonLbl.AutoSize=true;
            londonLbl.Font=new Font("Bodoni MT", 39, FontStyle.Bold);
            londonLbl.Visible=true;
            this.Controls.Add(londonLbl);   
            londonTimer.Interval=1000;
            londonTimer.Tick+=LondonTimer_Tick;
            londonTimer.Start();
        }

        private void LondonTimer_Tick(object sender, EventArgs e)
        {
            londonLbl.Text=$"Time : {DateTime.Now.AddHours(-4):HH:mm:ss}";

        }

        private void bakubtn_MouseClick(object sender, MouseEventArgs e)
        {
            mytimer.Stop();
            londonTimer.Stop();
            foreach (var control in Controls)
            {
                if (control is Label)
                {
                    (control as Label).Visible=false;
                }
            }
            this.BackgroundImage=Resources.Bakiu;
            bakuLbl.Text="Baku ";
            bakuLbl.ForeColor=Color.Black;
            bakuLbl.ForeColor=Color.Black;
            bakuLbl.Location=new Point(15, 560);
            bakuLbl.AutoSize=true;
            bakuLbl.Font=new Font("Bodoni MT", 39, FontStyle.Bold);
            bakuLbl.Visible=true;
            bakuDate.Visible=true;
            this.Controls.Add(bakuLbl);
            bakuTimer.Interval=1000;
            bakuTimer.Tick+=BakuTimer_Tick;
            bakuTimer.Start();

        }

        private void BakuTimer_Tick(object sender, EventArgs e)
        {
            bakuLbl.Text=$"Time : {DateTime.Now:HH:mm:ss}";
        }
        

    }
}
