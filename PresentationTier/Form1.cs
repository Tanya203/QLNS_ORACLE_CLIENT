using CLIENT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var responce = await BenefitAPI.GetAll();
            string text = null;
            List<Benefit> benefit = JsonConvert.DeserializeObject<List<Benefit>>(responce);
            foreach( Benefit b in benefit )
            {
                text += $"[ - BN_ID: {b.BnId}" +
                    $"  - BenefitName: {b.BenefitName}" +
                    $"  - Amount: {b.Amount}" +
                    $"\n\n]";
            }
            richTextBox1.Text = text;
        }
    }
}
