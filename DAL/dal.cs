using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace DAL
{
    public class VehicleParkingdal
    {
        string connstr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ParkingProject;Integrated Security=true;";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        

        public avalslotLight checkTwoWheelerSlot()
        {
            avalslotLight av = new avalslotLight();
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                cmd = new SqlCommand("COUNTSLOTlIGHT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@p";
                outparam.SqlDbType = SqlDbType.Int;
                outparam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                var res = cmd.ExecuteNonQuery();
                av.slot = Convert.ToInt32(outparam.Value);

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return av;
        }

        public avalslotHeavy checkFourWheelerSlot()
        {
            avalslotHeavy av = new avalslotHeavy();
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                cmd = new SqlCommand("COUNTSLOT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@p";
                outparam.SqlDbType = SqlDbType.Int;
                outparam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                var res = cmd.ExecuteNonQuery();
                av.slot = Convert.ToInt32(outparam.Value);

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return av;
        }

        public bool InsertVehical(entityLayerReg en)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "insert into vehicle_reg values(@nm,@ent,NULL,@sl,@type,@dur,@fe)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", en.name);
                cmd.Parameters.AddWithValue("@ent", en.ent);
                //cmd.Parameters.AddWithValue("@ext", "null");
                cmd.Parameters.AddWithValue("@sl", en.slot);
                cmd.Parameters.AddWithValue("@type", en.type);
                cmd.Parameters.AddWithValue("@dur", 0);
                cmd.Parameters.AddWithValue("@fe", 0);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool ExitVehical(entityLayerReg en)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "update vehicle_reg set slot=null,ext=@ext,duration=@dur,charge=@fee where vid=@vid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ext", en.ext);
                cmd.Parameters.AddWithValue("@vid", en.vid);
                cmd.Parameters.AddWithValue("@dur", en.duration);
                cmd.Parameters.AddWithValue("@fee", en.charge);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public entityLayerReg ViewVehicle(int vid)
        {
            entityLayerReg en = new entityLayerReg();
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "select * from vehicle_reg where vid=@vid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@vid", vid);
                r = cmd.ExecuteReader();

                if (r.Read())
                {
                    en.ent = r[2].ToString();
                    en.slot = r[4].ToString();
                }
                else
                {
                    throw new Exception("Invalid Vehical");
                }

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return en;


        }

        public bool RemoveSlotAVAL2(string s)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "delete from avalslotlight where slot=@nm";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", s);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool UpdatSlotENG2(string s)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "insert into engslotlight values(@nm)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", s);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool UpdatSlotAVL2(string s)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "insert into avalslotlight values(@nm)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", s);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }


        public bool DeletSlotENG2(string s)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "delete from engslotlight where slot=@nm";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", s);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }


        public bool RemoveSlotAVAL4(string s)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "delete from avalslotheavy where slot=@nm";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", s);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool UpdatSlotENG4(string s)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "insert into engslotheavy values(@nm)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", s);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool UpdatSlotAVL4(string s)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "insert into avalslotheavy values(@nm)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", s);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }


        public bool DeletSlotENG4(string s)
        {
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "delete from engslotheavy where slot=@nm";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", s);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }
    }
}
