namespace WinFormsApp1
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

        private void add_click(object sender, EventArgs e)
        {
            Person person = new Person();
            try
            {
                person.Name = name_box.Text;
                person.Surname=surname_box.Text;
                person.Email=email_box.Text;
                person.Phone=tel_box.Text;
                person.BirthDate = new DateTime(Convert.ToInt32(year_box.Text), Convert.ToInt32(month_box.Text), Convert.ToInt32(day_box.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}