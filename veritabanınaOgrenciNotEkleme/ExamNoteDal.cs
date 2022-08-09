using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabanınaOgrenciNotEkleme
{
    public class ExamNoteDal
    {
        SqlConnection _connection=new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=StudentNoteResult;integrated security=true");
        public List<ExamNote> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select*from StudentNote", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<ExamNote> examNotes = new List<ExamNote>();
            while (reader.Read())
            {
                ExamNote examNote = new ExamNote
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    ExamResult = Convert.ToInt32(reader["ExamResult"]),
                    Number = Convert.ToInt32(reader["Number"])
                };
                examNotes.Add(examNote);
            }
            reader.Close();
            _connection.Close();
            return examNotes;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(ExamNote examNote)
        {

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Insert into StudentNote values(@name,@number,@examResult)", _connection);
            command.Parameters.AddWithValue("@name", examNote.Name);
            command.Parameters.AddWithValue("@number", examNote.Number);
            command.Parameters.AddWithValue("@examResult", examNote.ExamResult);

            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void Update(ExamNote examNote)
        {

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Update StudentNote set Name=@name,Number=@number,ExamResult=@examResult where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", examNote.Name);
            command.Parameters.AddWithValue("@number", examNote.Number);
            command.Parameters.AddWithValue("@examResult", examNote.ExamResult);
            command.Parameters.AddWithValue("@Id", examNote.Id);

            command.ExecuteNonQuery();

            _connection.Close();

        }
    }

}
