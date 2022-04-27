using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelloCS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요~ 귀요미들이 모여있는 3학년 1반 입니다~~!!", "나님이 말씀하시길...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
