using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanınaOgrenciNotEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ExamNoteDal _examNoteDal=new ExamNoteDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwExamResult.DataSource = _examNoteDal.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _examNoteDal.Add(
                new ExamNote
                {
                    Name = tbxName.Text,
                    ExamResult = Convert.ToInt32(TbxExamResult.Text),
                    Number = Convert.ToInt32(tbxNumber.Text),
                  
                }) ;
            MessageBox.Show("Note Added!");
        }
    }
}
