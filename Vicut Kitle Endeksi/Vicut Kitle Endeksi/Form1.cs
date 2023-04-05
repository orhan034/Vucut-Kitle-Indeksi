namespace Vicut_Kitle_Endeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, indeks = 0;
            string isim = textBox1.Text;
            kilo = Convert.ToDouble(textkilo.Text);
            boy = Convert.ToDouble(textBoy.Text);

            indeks = (kilo / (boy * boy));
            if (indeks < 18)
            {
                picturezayif.Visible = true;
                picturegiris.Visible = false;
                picturenormal.Visible = false;
                pictureobez.Visible = false;
                picturefazla.Visible = false;
                lblisim.Text = isim;
                lblsonuc.Text = indeks.ToString();
                lblmesaj.Text = "Zayýf";
            }
            else if (indeks > 18 && indeks < 24)
            {
                picturezayif.Visible = false;
                picturegiris.Visible = false;
                picturenormal.Visible = true;
                pictureobez.Visible = false;
                picturefazla.Visible = false;
                lblisim.Text = isim;
                lblsonuc.Text = indeks.ToString();
                lblmesaj.Text = "Normal";
            }
            else if (indeks > 24 && indeks < 30)
            {
                picturezayif.Visible = false;
                picturegiris.Visible = false;
                picturenormal.Visible = false;
                picturefazla.Visible = true;
                pictureobez.Visible = false;
                lblisim.Text = isim;
                lblsonuc.Text = indeks.ToString();
                lblmesaj.Text = "Kilolu";
            }
            else if (indeks > 30)
            {
                picturezayif.Visible = false;
                picturegiris.Visible = false;
                picturenormal.Visible = false;
                picturefazla.Visible = false;
                pictureobez.Visible = true;
                lblisim.Text = isim;
                lblsonuc.Text = indeks.ToString();
                lblmesaj.Text = "Obez";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}