namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Person> list = JsonFile.readAsCollection<Person>("person.json");
            people_list.DataSource = list;

        }

        private void add_click(object sender, EventArgs e)
        {
            Person person = new Person();
            try
            {
                person.Name = name_box.Text;
                person.Surname = surname_box.Text;
                person.Email = email_box.Text;
                person.Phone = tel_box.Text;
                person.BirthDate = new DateTime(Convert.ToInt32(year_box.Text), Convert.ToInt32(month_box.Text), Convert.ToInt32(day_box.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            List<Person> people;
            if (people_list.DataSource==null)
            {
                people = new List<Person>();
                people.Add(person);
                people_list.DataSource = people;

            }
            else
            {
                people = (List<Person>)people_list.DataSource;
                people.Add(person);
                people_list.DataSource = null;
                people_list.DataSource = people;
            }
        }

        private void people_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (fileName_box.Text == "") MessageBox.Show("Enter file name before you save.");
           else
            {
                List<Person> list = (List<Person>)people_list.DataSource;
                JsonFile.writeCollection<Person>(fileName_box.Text, list);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (fileName_box.Text == "") MessageBox.Show("Enter file name first!");
            else
            {
                var list = JsonFile.readAsCollection<Person>(fileName_box.Text);
                people_list.DataSource = null;
                people_list.DataSource = list;
            }
        }
         
        private void btn_change_Click(object sender, EventArgs e)
        {
            if (fileName_box.Text == "") MessageBox.Show("Enter the file name first.");
            else
            {
                Person person = people_list.SelectedItem as Person;
               if(name_box.Text!="") person.Name = name_box.Text;
                if(surname_box.Text!="") person.Surname = surname_box.Text;
                if(email_box.Text!="")person.Email = email_box.Text;
                if(tel_box.Text!="")person.Phone = tel_box.Text;
                if(year_box.Text!="" && day_box.Text!=""&&month_box.Text!="")person.BirthDate = new DateTime(Convert.ToInt32(year_box.Text), Convert.ToInt32(month_box.Text), Convert.ToInt32(day_box.Text));
            }
        }
    }
}