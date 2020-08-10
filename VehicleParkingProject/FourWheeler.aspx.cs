using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BAL;

namespace VehicleParkingProject
{
    public partial class FourWheeler : System.Web.UI.Page
    {
        VehicleParkingbal bal = new VehicleParkingbal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                var stht = bal.checkFourWheelerSlot();
                
                if (stht == null)
                    Label1.Text = "Not Available";
                else
                    Label1.Text = "Available 4 Wheeler Slot: " + stht.slot.ToString();

       
            }
            catch (Exception ex)
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
    }
}