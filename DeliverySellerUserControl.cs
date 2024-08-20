using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace OrderAndDeliveryManagement
{
    public partial class DeliverySellerUserControl : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");


        public int ID
        {
            get => int.Parse(id_label.Text);
            set => id_label.Text = value.ToString();
        }
        public string Username
        {
            get => User_label.Text;
            set => User_label.Text = value;
        }
        public string OrderDate
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public decimal TotalPrice
        {
            get => decimal.Parse(label3.Text);
            set => label3.Text = value.ToString();
        }
        public string Status
        {
            get => comboBox1.SelectedItem?.ToString();
            set => comboBox1.SelectedItem = value;
        }
        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }
        public bool IsRadioButtonChecked
        {
            get { return radioButton1.Checked; }
        }

        public DeliverySellerUserControl()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += (s, e) => OnStatusChanged?.Invoke(this, EventArgs.Empty);
        }

    public event EventHandler OnStatusChanged;

        private void button1_Click(object sender, EventArgs e)
        {

            int selectedOrderId = ID; // Retrieve the selected OrderId based on your application logic
            
                // Create an instance of SellerDetails form
                SellerDetails detailsForm = new SellerDetails(selectedOrderId);

                // Load the order details for the selected order ID
                detailsForm.LoadOrderDetails();

                // Show the SellerDetails form
                detailsForm.ShowDialog();
        }
        

        private void id_label_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
