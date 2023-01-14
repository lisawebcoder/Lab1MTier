using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//step 2 add librairies
//teacher made us add sqlClient(pckage manger already added)
using System.Data.SqlClient;
//teacher made us add configuration
using System.Configuration;

namespace Lab1Sept27th2022ver1
{
    public partial class Form1 : Form
    {
        //oct 11th 2022--4pm--
        //step 2
        //i not sure about this
        int row = 0;


        //3rd step create var global connection in this section
        // the param InventoryClass is from app.config
        private String connStr = ConfigurationManager.ConnectionStrings["InventoryClass"].ConnectionString;
        //private String connStr = ConfigurationManager.ConnectionStrings["DemoClass"].ConnectionString;

        //sept 29th 2022
        //step 11
        SqlDataAdapter adapt;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }


        


        //5th step double click the form itslef
        private void Form1_Load(object sender, EventArgs e)
        {
            //5th step--this fills on the page load automatically
            //function call
            LoadListView();
            //UpdateGridView();


            //sept 29th 2022
            //step 12
            //data grid view loads start
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            adapt = new SqlDataAdapter("select * from Prodcuts", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();

            //data grid loads ends
        }


        //4th step create function manually in this section
        /**/
        private void LoadListView()
        {
            //connect            
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //query; not sure if we need ;--yes just add the ;
            //String sqlText = "SELECT * FROM Persons;";
            String sqlText = "SELECT * FROM Prodcuts;";

            //connect to DB and query; takes 2 params
            SqlCommand cmd = new SqlCommand(sqlText, conn);

            //pull from the List in the form;clean it 1st
            listView.Items.Clear();
            //this reads data from sql server 2012
            SqlDataReader reader = cmd.ExecuteReader();

            //use the while to loop thru the database
            //declare the var to loop
            /*
            int i = 0;
            while (reader.Read())
            {
                listView.Items.Add(reader["PersonID"].ToString());
                listView.Items[i].SubItems.Add(reader["LastName"].ToString());
                listView.Items[i].SubItems.Add(reader["FirstName"].ToString());
                listView.Items[i].SubItems.Add(reader["Address"].ToString());
                listView.Items[i].SubItems.Add(reader["City"].ToString());
                i++;
                                   

            }
            */

            //reader takes the names from SQL directly
            int i = 0;
            while (reader.Read())
            {
                listView.Items.Add(reader["ProductNameID"].ToString());
                listView.Items[i].SubItems.Add(reader["Price"].ToString());
                listView.Items[i].SubItems.Add(reader["Quantity"].ToString());
                listView.Items[i].SubItems.Add(reader["Category"].ToString());
                //listView.Items[i].SubItems.Add(reader["City"].ToString());
                i++;


            }




            //4th step contd
            //disconnect
            conn.Close();
                  
       

        }
        

        //6th step trying to display data to grid view
        //data grid view function starts--we created it manually--
        private void UpdateGridView()
        {
            //6th step contd try to display in dataGridView 
            /* */
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();                     
            string gridQuery = "SELECT * FROM Prodcuts;";
            SqlCommand cmd = new SqlCommand(gridQuery, conn);
            dataGridView.Rows.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

             //this works only 1 row at a time
             //the reader takes the names from SQL directly
             /* */
            var ID = reader["ProductNameID"].ToString();
            var PRICE = reader["Price"].ToString();
            var QUANTITY = reader["Quantity"].ToString();
            var CATEGORY = reader["Category"].ToString();
            dataGridView.Rows.Add(ID,PRICE,QUANTITY,CATEGORY);


            //for loop thru the rows--doesnt work
            /*
            for(int i = 0;i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells[1].Value.ToString();
                //dataGridView.Rows[i].Cells.AddRange();
            }
            */


            //this didnt work
            /* 
            //DataTable table = new DataTable();
            //dataGridView.DataSource = table; 

           
           DataTable dt = new DataTable(); ///this will initialize every time, a new data table will be created every loop
           dt.Columns.Add("ProductNameID");

           DataRow dr = dt.NewRow();
           for(int i = 1;i < dataGridView.Rows.Count; i++)
           //for (int a = 1; a <= i; a++)
             {
             dr[i] = dataGridView.Rows.Count;
              }
             dt.Rows.Add(dr);

         this.dataGridView.DataSource = dt;

            */



            //this works very little
            /*
            int i = 0;
            while (reader.Read())
            {
                dataGridView.Rows.Add(reader["ProductNameID"].ToString());
                //dataGridView.Rows.Add(reader["QuantityListView"].ToString());
                //dataGridView.Rows[i].Cells["ProductNameListView"].Value;
                //dataGridView.Rows.Add(reader["CategoryListView"].ToString());
                //dataGridView.Rows[i].Cells["PriceListView"].Value;
                //dataGridView.Rows[i].SubItems.Add(reader["Quantity"].ToString());
                //dataGridView.Rows[i].SubItems.Add(reader["Category"].ToString());
                //listView.Items[i].SubItems.Add(reader["City"].ToString());
                //i++;


            }

            */

            conn.Close();
           



            //dataGridView.Rows.Clear();
            //1st--connect and open
            /*
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            //2nd--sql query
            string gridQuery = "SELECT * FROM Persons";
            //3rd--command call
            SqlCommand cmd = new SqlCommand(gridQuery, conn);
            
            SqlDataReader reader = cmd.ExecuteReader();
            //4th--table
            DataTable table = new DataTable();
            dataGridView.DataSource = table;
            //5th--close
            conn.Close();
            */

            /*
            dataGridView.Rows.Add(reader["PersonID"].ToString());
            dataGridView.Rows[i].Cells.Add(reader["LastName"].ToString());
            dataGridView.Rows[i].Cells.Add(reader["FirstName"].ToString());
            dataGridView.Rows[i].Cells.Add(reader["Address"].ToString());
            dataGridView.Rows[i].Cells.Add(reader["City"].ToString());
            i++;
            */
        
        }
        //data grid view function ends





        //step 1 add exit code by double click button in form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //step 7
        //double click the delete button on form to get this event
        //delete func starts
        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //sept 28th 2022 alert for delete
            //solution2
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            //if starts for alert delete
            {                

                try
                {
                    //1st  is the int var created (4times) and 2nd is from SQl 
                    int productNameID = Int32.Parse(listView.SelectedItems[0].Text);
                    String deleteText = "Delete from Prodcuts" +
                        " where productNameID = @ProductNameID;";
                    SqlCommand cmd = new SqlCommand(deleteText, conn);                    
                    cmd.Parameters.AddWithValue("@productNameID", productNameID);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception) { }
                MessageBox.Show(listView.SelectedItems[0].Text);
                //sept 20th 2022 possible change to ask user
                //if they want to delete or not

                conn.Close();
                LoadListView();


                //if ends for alert to delete
            }
            //delete func ends



        }


        //step 8
        //double click add button to get this event
        //add func starts
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //we gonna write code here ; watch the vid at 2 03 time stop
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //open bracket Try
            try
            {
                // sept 15th 2022 step 2
                //for INSERT its SQl and lbl design name
                int productNameID = Int32.Parse(txtBoxNameID.Text);
                String PRICE = textBoxPrice.Text;
                String QUANTITY = textBoxQuantity.Text;
                String CATEGORY = textBoxCategory.Text;                
                String sqlInsert = "INSERT INTO Prodcuts" + "(ProductNameID, Price , Quantity,Category)" +
                "VALUES(@labelPrdNameIDInput, @labelPriceInput, @labelQuantityInput, @labelCategoryInput);";

                //sept 15th 2022 starts here step 1--input label design name and string var name from above
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@labelPrdNameIDInput", productNameID);
                cmd.Parameters.AddWithValue("@labelPriceInput", PRICE);
                cmd.Parameters.AddWithValue("@labelQuantityInput", QUANTITY);
                cmd.Parameters.AddWithValue("@labelCategoryInput", CATEGORY);
                cmd.ExecuteNonQuery();

                //end bracket of Try
            }
            catch (Exception)
            {

            }

            //here close? yes
            conn.Close();

            //reload data here? yes
            LoadListView();

            //sept 18th 2022
            //clean fields here? yes
            CleanFields();

        }
        //add func ends

        //step 9
        //sept 28th 2022
        //this is to reset input fields to empty

        //reset input fields code starts
        private void CleanFields()
        {
            txtBoxNameID.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            textBoxCategory.Text = "";            
            txtBoxNameID.Focus();
        }

       //reset input fields code ends 


        //step 10
        //double click the edit button to get this event func
        private void btnEdit_Click(object sender, EventArgs e)
        {


            //when using try block this must be outside the block
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            try
            {

                //SqlConnection conn = new SqlConnection(connStr);
                //conn.Open();
                //sept 17th 2022 3rd attempt
                //Sept 17th 2022 at 10am Trying this 1st attempt
                //for UPDATE 1st is SQL and 2nd is label input design name(but ID is reverse?--no)
                String sqlUpdate = ("UPDATE Prodcuts SET Price=@labelPriceInput, Quantity=@labelQuantityInput, Category=@labelCategoryInput where ProductNameID=@labelPrdNameIDInput;");
                //String sqlUpdate = ("UPDATE Prodcuts SET Price=@labelPriceInput, Quantity=@labelQuantityInput, Category=@labelCategoryInput where labelPrdNameIDInput=@ProductNameID;");

                // sept 20th 2022 2nd possible change
                //String sqlUpdate = "UPDATE Persons" + "SET LastName=@lastName, FirstName=@firstName, Address=@address, City=@City" + "where personID=@PersonID;";


                //sept 20th 2022  1st change
                //modify and add this and test if ok or then comment out
                //sept 24th 2022--yes it works just select the number 1st b4 edit
                int productNameID = Int32.Parse(listView.SelectedItems[0].Text);

                
                String PRICE = textBoxPrice.Text;
                String QUANTITY = textBoxQuantity.Text;
                String CATEGORY = textBoxCategory.Text;
                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                //1st is dsign label name and 2nd is var name above
                cmd.Parameters.AddWithValue("@labelPrdNameIDInput", productNameID);
                cmd.Parameters.AddWithValue("@labelPriceInput", PRICE);
                cmd.Parameters.AddWithValue("@labelQuantityInput", QUANTITY);
                cmd.Parameters.AddWithValue("@labelCategoryInput", CATEGORY);
                cmd.ExecuteNonQuery();

                
            }

            //sept 18th 2022 The Catch Block starts
            catch (Exception)
            {

            }
            //show message
            MessageBox.Show("Updated");

            //here close? yes
            conn.Close();

            //reload data here? yes
            LoadListView();

            //sept 18th 2022
            //clean fields here? yes
            CleanFields();

            //sept 18th 2022 The Catch Block extended ends



        }


        //sept 29th 2022
        //step 14
        //button Event --but i need dynamic code
        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter a name in thext box");

        }
        //sept 29th 2022
        //step 15
        //txtSearchBox TextChanged Event 
        private void txSearchtBox_TextChanged(object sender, EventArgs e)
        {
            //1st is from SQL and
            //2nd is from the text box search design name
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            adapt = new SqlDataAdapter("select * from Prodcuts where Category like '" + txSearchtBox.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();

        }

        //oct 11th 2022--4pm--
        //step 1
        //this is the get amount button but
        //i forgot to give it a good name
        //so its called button1
        private void button1_Click(object sender, EventArgs e)
        {
            string id;
            double price, totalPriceByQuantity, taxRate, totaltaxes, quantity, total;
            

            id = textBoxxID.Text;           

            if (radioBtnTax.Checked == true)
            {
                //write code for w/ taxes
                price = double.Parse(textBoxxPrice.Text);
                quantity = double.Parse(textBoxxQuantity.Text);               
                totalPriceByQuantity = price * quantity;
                taxRate = double.Parse(textBoxxTaxRate.Text);
                totaltaxes = totalPriceByQuantity * (taxRate/100);
                total = totalPriceByQuantity + totaltaxes;
                //this will display in the textbox files after button clicked?
                //textBoxx are design names
                textBoxxTotal.Text = "" + total;
                //display on grid
                DGV_data.Rows.Add();
                DGV_data.Rows[row].Cells[0].Value = textBoxxID.Text;
                DGV_data.Rows[row].Cells[1].Value = textBoxxPrice.Text;
                DGV_data.Rows[row].Cells[2].Value = textBoxxQuantity.Text;
                DGV_data.Rows[row].Cells[3].Value = textBoxxTaxRate.Text;
                DGV_data.Rows[row].Cells[4].Value = textBoxxTotal.Text;
                row++;
            }
            else if (radioBtnNoTax.Checked == true)
            {
                //write code for w/out taxes
                
                price = double.Parse(textBoxxPrice.Text);
                quantity = double.Parse(textBoxxQuantity.Text);
                totalPriceByQuantity = price * quantity;
                //taxRate = double.Parse(textBoxxTaxRate.Text);
                //totaltaxes = totalPriceByQuantity * (taxRate / 100);
                total = totalPriceByQuantity ;
                //this will display in the textbox files after button clicked?
                //textBoxx are design names
                textBoxxTotal.Text = "" + total;
                //display on grid
                DGV_data.Rows.Add();
                DGV_data.Rows[row].Cells[0].Value = textBoxxID.Text;
                DGV_data.Rows[row].Cells[1].Value = textBoxxPrice.Text;
                DGV_data.Rows[row].Cells[2].Value = textBoxxQuantity.Text;
                //DGV_data.Rows[row].Cells[3].Value = textBoxxTaxRate.Text;
                DGV_data.Rows[row].Cells[4].Value = textBoxxTotal.Text;
                row++;
            }



        }
    }
}
