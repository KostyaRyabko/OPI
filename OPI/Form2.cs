using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OPI
{
    public partial class Form_inp_out : Form
    {
        String Filename1 = "students";
        String Filename2 = "teachers";
        String Filename3;
        int o = 0;     
        public Form_inp_out()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void surname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && surname.Text != "" && patronymic.Text != "" && form_d.Text != "")
            {
                Filename3 = surname.Text + " " + name.Text + " " + patronymic.Text;

                var Reader = new StreamReader(Filename1, Encoding.Default);

                string[] line = new string[Filename1.Length];
                int tr = 0;
                for (int i = 0; i < Filename1.Length; i++)
                {
                    line[i] = Reader.ReadLine();
                    if (line[i] == Filename3)
                    {
                        tr++;
                        break;
                    }
                    else
                        tr = 0;
                }
                Reader.Close();

                var Reader2 = new StreamReader(Filename2, Encoding.Default);

                string[] line2 = new string[Filename2.Length];
                int tr2 = 0;
                for (int j = 0; j < Filename2.Length; j++)
                {
                    line2[j] = Reader2.ReadLine();
                    if (line2[j] == Filename3)
                    {
                        tr2++;
                        break;
                    }
                    else
                        tr2 = 0;
                }

                Reader2.Close();

                if (tr == 0 && form_d.Text == "Студент")
                    File.AppendAllText(Filename1, "\n" + Filename3, Encoding.Default);
                if (tr2 == 0 && form_d.Text == "Сотрудник кафедры")
                    File.AppendAllText(Filename2, "\n" + Filename3, Encoding.Default);
                if (tr == 0 && form_d.Text == "Сотрудник и студент")
                    File.AppendAllText(Filename1, "\n" + Filename3, Encoding.Default);
                if (tr2 == 0 && form_d.Text == "Сотрудник и студент")
                    File.AppendAllText(Filename2, "\n" + Filename3, Encoding.Default);

                File.WriteAllText(Filename3, string.Empty);

                File.AppendAllText(Filename3, surname.Text + "\n", Encoding.Default);
                File.AppendAllText(Filename3, name.Text + "\n", Encoding.Default);
                File.AppendAllText(Filename3, patronymic.Text + "\n", Encoding.Default);
                File.AppendAllText(Filename3, dateTimePicker1.Text + "\n", Encoding.Default);
                File.AppendAllText(Filename3, form_d.Text + "\n", Encoding.Default);
                File.AppendAllText(Filename3, group.Text + "\n", Encoding.Default);
                File.AppendAllText(Filename3, status.Text + "\n", Encoding.Default);

                MessageBox.Show("Изминение прошло успешно!", "Успех!", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Не все поля были заполнены!", "Ошибка!", MessageBoxButtons.OK);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void patronymic_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void form_d_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (form_d.Text == "Сотрудник кафедры")
            {
                group.Enabled = false;
                status.Enabled = false;
            }
            else
            {
                group.Enabled = true;
                status.Enabled = true;
            }
        }

        private void group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && surname.Text != "" && patronymic.Text != "" && form_d.Text != "")
            { 
                Filename3 = surname.Text + " " + name.Text + " " + patronymic.Text;

            var Reader = new StreamReader(Filename1, Encoding.Default);

            string[] line = new string[Filename1.Length];
            bool tr = true, f = true;
            string ff;
            ff = Reader.ReadLine();
            if (ff == "")
                f = false;
            for (int i = 0; i < Filename1.Length; i++)
            {
                line[i] = Reader.ReadLine();                
                if (line[i] == Filename3)
                {
                    MessageBox.Show("Такой человек уже занесён!", "Ошибка!", MessageBoxButtons.OK);
                    tr = false;
                    break;
                }
                else
                    tr = true;
            }
            var Reader2 = new StreamReader(Filename2, Encoding.Default);

            string[] line2 = new string[Filename2.Length];
            bool tr2 = true, f1 = true;
            string ff1;
            ff1 = Reader2.ReadLine();
            if (ff1 == "")
                f1 = false;
            for (int i = 0; i < Filename2.Length; i++)
            {
                line2[i] = Reader.ReadLine();
                if (line[i] == Filename3)
                {
                    MessageBox.Show("Такой человек уже занесён!", "Ошибка!", MessageBoxButtons.OK);
                    tr2 = false;
                    break;
                }
                else
                    tr2 = true;
            }
            Reader.Close();
            Reader2.Close();
                if (tr == true && tr2 == true)
                {
                    File.WriteAllText(Filename3, string.Empty);

                    File.AppendAllText(Filename3, surname.Text + "\n", Encoding.Default);
                    File.AppendAllText(Filename3, name.Text + "\n", Encoding.Default);
                    File.AppendAllText(Filename3, patronymic.Text + "\n", Encoding.Default);
                    File.AppendAllText(Filename3, dateTimePicker1.Text + "\n", Encoding.Default);
                    File.AppendAllText(Filename3, form_d.Text + "\n", Encoding.Default);
                    File.AppendAllText(Filename3, group.Text + "\n", Encoding.Default);
                    File.AppendAllText(Filename3, status.Text + "\n", Encoding.Default);

                    if (form_d.Text == "Студент")
                        File.AppendAllText(Filename1, "\n" + Filename3, Encoding.Default);
                    if (form_d.Text == "Сотрудник кафедры")
                        File.AppendAllText(Filename2, "\n" + Filename3, Encoding.Default);
                    if (form_d.Text == "Сотрудник и студент")
                        File.AppendAllText(Filename1, "\n" + Filename3, Encoding.Default);
                    if (form_d.Text == "Сотрудник и студент")
                        File.AppendAllText(Filename2, "\n" + Filename3, Encoding.Default);
                    MessageBox.Show("Операция выполнена успешно!", "Успех!", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Не все поля были заполнены!", "Ошибка!", MessageBoxButtons.OK);
            }    
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
