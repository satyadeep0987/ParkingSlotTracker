using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BAL;

namespace VehicleParkingProject
{
    public partial class EnteryFourWheer : System.Web.UI.Page
    {
        VehicleParkingbal bal = new VehicleParkingbal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                entityLayerReg en = new entityLayerReg();
                en.name = txtName.Text;
                en.ent = txtTime.Text;
                en.type = "4-wheeler";
                string s = ddlEntrySLot.SelectedValue.ToString();
                en.slot = s;
                var insert = bal.InsertVehical(en);


                if (insert)
                {
                    var sloten = bal.RemoveSlotAVAL4(s);
                    var slotex = bal.UpdatSlotENG4(s);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "DATA INSERTED", "CallCodeBehind()", true);
                }
                else
                {
                    Label1.Text = "Invalid Details";
                }

            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message.ToString();
            }
        }
    }
}