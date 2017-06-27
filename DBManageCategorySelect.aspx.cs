using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShop
{
    public partial class DBManageCategorySelect : System.Web.UI.Page
    {
        private string CS = WebConfigurationManager.ConnectionStrings["PetsCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            FillCategoryList();
        }
        private void FillCategoryList()
        {
            CategoryLists.Items.Clear();
            string selectSQL = "SELECT petSale FROM Categories";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListItem newItem = new ListItem();
                    newItem.Text = reader["petSale"].ToString();
                    CategoryLists.Items.Add(newItem);
                }
                reader.Close();
            }
            catch (Exception err)
            {
                lblResults.Text = "Error reading list of categories";
                lblResults.Text += err.Message;
               
            }
            finally
            {
                con.Close();
            }
        }
    }
}