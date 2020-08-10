using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DAL;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BAL
{
    public class VehicleParkingbal
    {
        VehicleParkingdal dal = new VehicleParkingdal();

        public avalslotLight checkTwoWheelerSlot()
        {
            return dal.checkTwoWheelerSlot();
        }


        public avalslotHeavy checkFourWheelerSlot()
        {
            return dal.checkFourWheelerSlot();
        }

        public bool InsertVehical(entityLayerReg en)
        {
            if (String.IsNullOrEmpty(en.name.ToString()) || String.IsNullOrEmpty(en.ent.ToString()))
            { return false; }
            else
            return dal.InsertVehical(en);
        }

        public bool ExitVehical(entityLayerReg en)
        {
            return dal.ExitVehical(en);
        }
        public entityLayerReg ViewVehicle(int vid)
        {
            return dal.ViewVehicle(vid);
        }


            public bool RemoveSlotAVAL2(string s)
        {
            return dal.RemoveSlotAVAL2(s);
        }

        public bool UpdatSlotENG2(string s)
        {
            return dal.UpdatSlotENG2(s);
        }

        public bool UpdatSlotAVL2(string s)
        {
            return dal.UpdatSlotAVL2(s);
        }

        public bool DeletSlotENG2(string s)
        {
            return dal.DeletSlotENG2(s);
        }

        public bool RemoveSlotAVAL4(string s)
        {
            return dal.RemoveSlotAVAL4(s);
        }

        public bool UpdatSlotENG4(string s)
        {
            return dal.UpdatSlotENG4(s);
        }

        public bool UpdatSlotAVL4(string s)
        {
            return dal.UpdatSlotAVL4(s);
        }

        public bool DeletSlotENG4(string s)
        {
            return dal.DeletSlotENG4(s);
        }
    }
}
