namespace _10._03.classwork._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { 
                MessageBox.Show("������! ������� �� ����� ���� ������");
            }
            else { 
            listBox1.Items.Add(String.Format("{0}, {2}, �������� {1}, ����� {3}, {4}, �. {5}.", textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text));
            }
        }
    }
}