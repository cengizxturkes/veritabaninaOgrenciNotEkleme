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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            ExamNote examNote = new ExamNote
            {
                ExamResult = Convert.ToInt32(TbxExamResultUpdate.Text),
                Number = Convert.ToInt32(tbxNumberUpdate.Text),
                Name = tbxNameUpdate.Text,
                Id = Convert.ToInt32(dgwExamResult.CurrentRow.Cells[0].Value),
            };
            _examNoteDal.Update(examNote); 
            dgwExamResult.DataSource = _examNoteDal.GetAll();
            MessageBox.Show("Updated");
           
        }

        private void dgwExamResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text=dgwExamResult.CurrentRow.Cells[1].Value.ToString();  
            tbxNumberUpdate.Text=dgwExamResult.CurrentRow.Cells[2].Value.ToString();  
            TbxExamResultUpdate.Text=dgwExamResult.CurrentRow.Cells[3].Value.ToString();  
        }
    }
}
