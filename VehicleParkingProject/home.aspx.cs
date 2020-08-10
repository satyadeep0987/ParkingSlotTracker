using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BAL;
using System.Text;

namespace VehicleParkingProject
{
    public partial class home : System.Web.UI.Page
    {
        VehicleParkingbal bal = new VehicleParkingbal();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                var stht = bal.checkFourWheelerSlot();
                var stlt = bal.checkTwoWheelerSlot();
                if (stht == null)
                    lblCheck.Text = "Not Available";
                else
                    lblCheck.Text = "Available 4 Wheeler Slot: " + stht.slot.ToString();

                if (stht == null)
                    lblCheck0.Text = "Not Available";
                else
                    lblCheck0.Text = "Available 2 Wheeler Slot: " + stlt.slot.ToString();

                Panel6.Visible = true;
                Panel5.Visible = false;
                Panel7.Visible = false;
            }
            catch(Exception ex)
            {
                GetMessage("warning", ex.Message);
            }
            
        }

        public void GetMessage(string messageType, string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type='text/javascript'>");
            sb.Append("alert('" + messageType + " : " + message + "');");
            sb.Append("</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ajax", sb.ToString(), false);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel5.Visible = true;
            Panel6.Visible = false;
            Panel7.Visible = false;
          
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel7.Visible = true;
            Panel5.Visible = false;
            Panel6.Visible = false;
        }
    }
}