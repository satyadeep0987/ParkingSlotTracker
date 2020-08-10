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
    public partial class ExitFourWheeler : System.Web.UI.Page
    {
        entityLayerReg en = new entityLayerReg();
        VehicleParkingbal bal = new VehicleParkingbal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnView_Click(object sender, EventArgs e)
        {

            var v = bal.ViewVehicle(Convert.ToInt32(DropDownList1.SelectedValue));
            if (v != null)
            {
                txtEntrytime.Text = v.ent.ToString();

                txtExitSlot.Text = v.slot.ToString();
            }
        }

        protected void btnCal_Click(object sender, EventArgs e)
        {
            string entry = "";
            string exit = "";
            int cal = 0;
            int charge = 0;
            exit = txtTime.Text;
            var v = bal.ViewVehicle(Convert.ToInt32(DropDownList1.SelectedValue));
            if (v != null)
            {
                entry = v.ent.ToString();

            }

            DateTime d1 = DateTime.Parse(entry);
            DateTime d = DateTime.Parse(exit);

            //Label1.Text = entry + "--" + exit;

            TimeSpan duration = DateTime.Parse(exit).Subtract(DateTime.Parse(entry));

            txtDur.Text = duration.ToString();
            cal = int.Parse(duration.Hours.ToString());
            //Label1.Text = cal.ToString();
            charge = 50 * (cal);
            if (charge == 0)
                txtCharge.Text = "50";
            else
                txtCharge.Text = charge.ToString();


        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            entityLayerReg en = new entityLayerReg();
            en.ext = txtTime.Text;
            en.duration = txtDur.Text;
            en.charge = long.Parse(txtCharge.Text);
            en.vid = Convert.ToInt32(DropDownList1.SelectedValue);
            string s = txtExitSlot.Text;
            var v = bal.ExitVehical(en);
            if (v)
            {
                var sloten = bal.DeletSlotENG4(s);
                var slotex = bal.UpdatSlotAVL4(s);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "DATA EXITED", "CallCodeBehind()", true);
            }
            else
            {
                Label1.Text = "Invalid Details";
            }
        }
    }
}