using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 复制全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // MessageBox.Show("Btn Clicked");
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 在加载时，把form1保存起来
            Global.mainForm = this;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            CheckState isChecked = box.CheckState;
            if (isChecked == CheckState.Checked)
            {
                Global.mainForm.richTextBox1.BackColor = Color.Black;
            }
            else
            {
                Global.mainForm.richTextBox1.BackColor = Color.White;
            }
            // MessageBox.Show(sender.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            CheckState isChecked = box.CheckState;
            if (isChecked == CheckState.Checked)
            {
                // choose an image, then show it 
                // Global.mainForm.richTextBox1.BackColor = Color.Black;
                // Global.mainForm.pictureBox1.Visible = true;

                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "所有文件|*.*|图片文件|" +
"*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif|PNG|*.png|JPG|*.jpg;*.jpeg|GIF|*.gif|" +
"BMP|*.bmp|TIF|*.tif";
                fileDialog.InitialDirectory = "F:\\sg_desktop\\screencapture";
                fileDialog.Title = "请选择代码截图";
                fileDialog.ShowDialog();
                // 文件路径
                string filePath = fileDialog.FileName;
                // 设置到pictureBox
                Global.mainForm.pictureBox1.Image = Image.FromFile(filePath);
                Global.mainForm.pictureBox1.Visible = true;
             
            }
            else
            {
                Global.mainForm.pictureBox1.Visible = false;
            }
        }
    }
}
