using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSB_steganography_v1
{
    public partial class message_selector : Form
    {
        public message_selector()
        {
            InitializeComponent();
        }


        private void message_selector_Load(object sender, EventArgs e)
        {
            //Form on load function
        }

        private void Select_text_Click(object sender, EventArgs e)
        {
            //Text selector
            Form1.msg = this.Input_text_box.Text;//Передача текста главной форме

            this.Close();
        }

        private void Select_img_Click(object sender, EventArgs e)
        {
            //Img selector

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Return back button
            this.Close();
        }

        private void Input_text_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void OnDefocus(object sender, EventArgs e)
        {
            
            //throw new NotImplementedException();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            Input_text_box.Clear();
            //throw new NotImplementedException();
        }
    }
}
