using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            txtAddID.Text = generateID();
            refillCustomersList();
            refreshEditPage(currentViewOnEdit);
            refreshDGVCustomer();
        }

        // Form Variables
        public class Customers
        {
            public string id        { set; get; }
            public string address   { set; get; }
            public string name      { set; get; }
            public string zipcode   { set; get; }
            public string phone     { set; get; }
            public string email     { set; get; }
        }
        public static List<Customers> customersList = new List<Customers>();
        public int currentViewOnEdit = 0;

        // Form Functions
        public string generateID()
        {
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                Random rnd = new Random();
                string res = rnd.Next(999999).ToString();
                string sql = "SELECT ID from customer WHERE ID = " + res;
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        string queryRes = "";
                        queryRes = (string)comm.ExecuteScalar();
                        //MessageBox.Show("Hasil query : " + queryRes);
                        if (queryRes == res)
                        {
                            conn.Close();
                            return generateID();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    conn.Close();
                }
                return res;
            }
        }
        public void resetAddField()
        {
            txtAddAddress.Text = txtAddEmail.Text = txtAddZip.Text = txtAddName.Text = txtAddPhone.Text = "";
            txtAddID.Text = generateID();
        }
        public void refillCustomersList()
        {
            customersList = new List<Customers>();
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = "SELECT id, name, address, zip_code, phone_number, email from customer";
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = comm.ExecuteReader();

                        while (reader.Read())
                        {
                            //queryRes = reader.GetString(0);
                            Customers tmp = new Customers();
                            tmp.id = reader.GetString(0);
                            tmp.name = reader.GetString(1);
                            tmp.address = reader.GetString(2);
                            tmp.zipcode = reader.GetString(3);
                            tmp.phone = reader.GetString(4);
                            tmp.email = reader.GetString(5);

                            customersList.Add(tmp);
                        }
                        reader.Close();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }
        public void refreshEditPage(int n)
        {
            if (customersList.Count<=0)
            {
                return;
            }
            txtUpdateID.Text = customersList[n].id;
            txtUpdateAddress.Text = customersList[n].address;
            txtUpdateName.Text = customersList[n].name;
            txtUpdateEmail.Text = customersList[n].email;
            txtUpdatePhone.Text = customersList[n].phone;
            txtUpdateZip.Text = customersList[n].zipcode;

        }
        public void refreshDGVCustomer()
        {
            //var bindingList = new BindingList<Products>(productsList);
            var srcDGVCustomer = new BindingSource();
            srcDGVCustomer.DataSource = customersList;
            DGVCustomer.DataSource = srcDGVCustomer;
        }

        #region add customer
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
                string sql = "insert into customer values (@id, @name, @address, @zipcode, @phone, @email, NOW(), NOW());";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        conn.Open();
                        //MessageBox.Show(conn.ConnectionString);
                        comm.Parameters.AddWithValue("@id", txtAddID.Text);
                        comm.Parameters.AddWithValue("@name", txtAddName.Text);
                        comm.Parameters.AddWithValue("@address", txtAddAddress.Text);
                        comm.Parameters.AddWithValue("@zipcode", txtAddZip.Text);
                        comm.Parameters.AddWithValue("@phone", txtAddPhone.Text);
                        comm.Parameters.AddWithValue("@email", txtAddEmail.Text);

                        if (comm.ExecuteNonQuery() == 1)
                        {
                            using (new CenterWinDialog(this))
                            {

                            }
                            addAlertBox.Visible = true;
                            
                            txtAddName.Focus();

                            Customers tmp = new Customers();
                            tmp.id = txtAddID.Text;
                            tmp.address = txtAddAddress.Text;
                            tmp.name = txtAddName.Text;
                            tmp.zipcode = txtAddZip.Text;
                            tmp.phone = txtAddPhone.Text;
                            tmp.email = txtAddEmail.Text;
                            customersList.Add(tmp);
                            refreshDGVCustomer();
                            resetAddField();
                        }
                        else
                        {
                            using (new CenterWinDialog(this))
                            {

                            }
                            addAlertBox.kind = (FlatUI.FlatAlertBox._Kind)1;
                            addAlertBox.Text = "Oops! Looks like something went wrong.";
                            addAlertBox.Visible = true;
                        }
                        conn.Close();
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.Message.IndexOf("Duplicate") >= 1)
                {

                }
            }
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            resetAddField();
        }
        #endregion


        #region edit customer
        private void firstBtn_Click(object sender, EventArgs e)
        {
            currentViewOnEdit = 0;
            refreshEditPage(currentViewOnEdit);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentViewOnEdit <= 0) return;
            currentViewOnEdit -= 1;
            refreshEditPage(currentViewOnEdit);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentViewOnEdit >= customersList.Count - 1) return;
            currentViewOnEdit += 1;
            refreshEditPage(currentViewOnEdit);
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            currentViewOnEdit = customersList.Count - 1;
            refreshEditPage(currentViewOnEdit);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
                string sql = "update customer set name = @name, address = @address, zip_code = @zipcode, phone_number = @phone, email = @email, updated_at = now() where id = @id;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        conn.Open();
                        //MessageBox.Show(conn.ConnectionString);
                        comm.Parameters.AddWithValue("@id", txtUpdateID.Text);
                        comm.Parameters.AddWithValue("@name", txtUpdateName.Text);
                        comm.Parameters.AddWithValue("@address", txtUpdateAddress.Text);
                        comm.Parameters.AddWithValue("@zipcode", txtUpdateZip.Text);
                        comm.Parameters.AddWithValue("@phone", txtUpdatePhone.Text);
                        comm.Parameters.AddWithValue("@email", txtUpdateEmail.Text);

                        if (comm.ExecuteNonQuery() == 1)
                        {
                            using (new CenterWinDialog(this))
                            {

                            }
                            editAlertBox.Visible = true;
                            editAlertBox.Text = "The data has been successfully updated";
                            txtUpdateName.Focus();
                            refillCustomersList();
                            refreshEditPage(currentViewOnEdit);
                        }
                        else
                        {
                            using (new CenterWinDialog(this))
                            {

                            }
                            addAlertBox.kind = (FlatUI.FlatAlertBox._Kind)1;
                            addAlertBox.Text = "Oops! Looks like something went wrong.";
                            addAlertBox.Visible = true;
                        }
                        conn.Close();
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.Message.IndexOf("Duplicate") >= 1)
                {

                }
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            refreshEditPage(currentViewOnEdit);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
                    string sql = "delete from customer where id = @id;";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand comm = new MySqlCommand(sql, conn))
                        {
                            conn.Open();
                            //MessageBox.Show(conn.ConnectionString);

                            comm.Parameters.AddWithValue("@id", txtUpdateID.Text);

                            if (comm.ExecuteNonQuery() == 1)
                            {
                                using (new CenterWinDialog(this))
                                {

                                }
                                editAlertBox.Visible = true;
                                editAlertBox.Text = "The data has been successfully deleted";
                                txtUpdateName.Focus();
                                refillCustomersList();
                                refreshEditPage(currentViewOnEdit);
                            }
                            else
                            {
                                using (new CenterWinDialog(this))
                                {

                                }
                                addAlertBox.kind = (FlatUI.FlatAlertBox._Kind)1;
                                addAlertBox.Text = "Oops! Looks like something went wrong.";
                                addAlertBox.Visible = true;
                            }
                            conn.Close();
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    if (ex.Message.IndexOf("Duplicate") >= 1)
                    {

                    }
                }
            }
            else
            {

            }
        }
        #endregion



    }
}
