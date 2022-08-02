using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Model;

namespace Urgent_Manager.Controller
{
    public class UrgentController : UserController
    {
        // Insert Urgent Into Urgent Table

        public void InsertUrgent(UrgentModel urgent)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Urgent (UrgentUnico,DateUrgent,Shift,UrgentStatus,Alimentation,UserFinished,FinishedDate) VALUES(@Urgent,@Date,@Shift,@Status,@Alimentation,@UserFinished,@FinishedDate)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);

                cmd.Parameters.AddWithValue("@Urgent", urgent.UrgentUnico);
                cmd.Parameters.AddWithValue("@Date", urgent.DateUrgent);
                cmd.Parameters.AddWithValue("@Shift", urgent.Shift);
                cmd.Parameters.AddWithValue("@Status", urgent.UrgentStatus);
                cmd.Parameters.AddWithValue("@Alimentation", urgent.Alimentation);
                cmd.Parameters.AddWithValue("@UserFinished", urgent.UserFinished);
                cmd.Parameters.AddWithValue("@FinishedDate", urgent.FinishedDate);

                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                    MessageBox.Show("Sorry It Was An Error While Saving Your Data Try Again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error While Processing Your Request\n"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Update Urgent Status When Urgent Manager User Update it

        public bool UpdateUrgent(string status,string user,string date,string unico)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "UPDATE Urgent SET UrgentStatus=@status,UserFinished=@user,FinishedDate=@date WHERE UrgentUnico=@unico";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@status",status);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@unico", unico);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    DbHelper.connection.Close();
                    return true;
                }
                else
                {
                    DbHelper.connection.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return false;
            }
        }

        // Update Urgent From Operator

            public bool UpdateUrgent(string status,string finishedDate,string unico)
        {
            try
            {
                DbHelper.connection.Open();
                string QUERY = "UPDATE Urgent SET UrgentStatus=@status,FinishedDate=@finishedDate WHERE UrgentUnico=@unico";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@finishedDate", finishedDate);
                cmd.Parameters.AddWithValue("@unico", unico);

                int result = cmd.ExecuteNonQuery();
                DbHelper.connection.Close();
                return result > 0 ? true : false;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return false;
            }
        }

        // Delete Urgent From Urgent Table

        public bool DeleteUrgent()
        {
            try
            {

                DbHelper.connection.Open();
                string QUERY = "DELETE FROM Urgent WHERE DATEDIFF(DD, CONVERT(date,DateUrgent,103) , GETDATE()) = 6 AND UrgentStatus = 'Finished'";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);

                int result = cmd.ExecuteNonQuery();
                if(result == 1)
                {
                    DbHelper.connection.Close();
                    return true;
                }
                else
                {
                    DbHelper.connection.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return false;
            }
        }

        // Fetch All The Data From Urgent Table

        public void fetchAllExpressRecords(Guna2DataGridView dg)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT W.Family,W.Unico,W.LeadCode,M.Machine,W.Adress as 'Location',W.Cable,W.WireLength as 'Length',W.MarL,W.SealL,W.TerL,W.MarR,W.SealR,W.TerR,W.LeadPrep as 'Lead Prep',U.UrgentStatus as 'Status',U.DateUrgent as 'Urgent Date' FROM Wire W,Machine M,Urgent U WHERE W.Unico=U.UrgentUnico AND M.Machine=W.MC AND U.UrgentStatus = 'Express' ORDER BY U.DateUrgent DESC,U.Shift,W.Groupe";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                dg.DataSource = dt.DefaultView;

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error While Processing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Fetch All The Data From Urgent Table Depend On The Machine

        public List<UrgentModel> fetchAllExpressRecords(string machine)
        {
            List<UrgentModel> list = new List<UrgentModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT W.Family,W.Unico,W.LeadCode as 'Lead Code',C.Color,W.WireLength as 'Length',W.Groupe,W.LeadPrep as 'Lead Prep',U.UrgentStatus as 'Status' FROM Wire W,Cable C,Urgent U WHERE W.Cable=C.Cable AND U.UrgentUnico = W.Unico AND U.UrgentStatus = 'Express' AND W.MC=@machine ORDER BY U.DateUrgent DESC,U.Shift,W.Groupe";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@machine", machine);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UrgentModel urgent = new UrgentModel();
                        urgent.Family = reader[0].ToString();
                        urgent.UrgentUnico = reader[1].ToString();
                        urgent.LeadCode = reader[2].ToString();
                        urgent.Color = reader[3].ToString();
                        urgent.Length = reader[4].ToString();
                        urgent.Group = reader[5].ToString();
                        urgent.LeadPrep = reader[6].ToString();

                        list.Add(urgent);
                    }

                    DbHelper.connection.Close();
                    return list;
                }


                DbHelper.connection.Close();
                return list;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return list;
            }
        }



        // Fetch Single Urgent Depend On Machine

        public UrgentModel fetchSingleExpressRecord(string machine,string unico)
        {
            UrgentModel urgent = new UrgentModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT U.UrgentUnico as 'Unico',W.LeadCode as 'Lead Code',M.Machine,W.Adress as 'Location',W.Cable,W.MarL,W.MarR,W.SealL,W.SealR,W.TerL,W.TerR,W.ToolL,W.ToolR,U.UrgentStatus as 'Status' FROM Wire W,Urgent U,Machine M WHERE U.UrgentUnico = W.Unico AND M.Machine=W.MC AND U.UrgentStatus ='Express' AND W.MC= @machine AND U.UrgentUnico=@unico";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@machine", machine);
                cmd.Parameters.AddWithValue("@unico", unico);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        urgent.UrgentUnico = reader[0].ToString();
                        urgent.LeadCode = reader[1].ToString();
                        urgent.Machine = reader[2].ToString();
                        urgent.Adress = reader[3].ToString();
                        urgent.Cable = reader[4].ToString();
                        urgent.MarL = reader[5].ToString();
                        urgent.MarR = reader[6].ToString();
                        urgent.SealL = reader[7].ToString();
                        urgent.SealR = reader[8].ToString();
                        urgent.TerL = reader[9].ToString();
                        urgent.TerR = reader[10].ToString();
                        urgent.ToolL = reader[11].ToString();
                        urgent.ToolR = reader[12].ToString();
                    }

                    DbHelper.connection.Close();
                    return urgent;
                }

                DbHelper.connection.Close();
                return urgent;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return urgent;
            }
        }

        // Fetch Urgents Count Per Machine

        public int actualUrgents(string machine)
        {
            int count = 0;
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT count(U.UrgentUnico), W.MC FROM Urgent U,Wire W WHERE W.Unico = U.UrgentUnico AND W.MC = @machine AND U.UrgentStatus='Express' GROUP BY  W.MC";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@machine", machine);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                    }

                    DbHelper.connection.Close();
                    return count;
                }

                DbHelper.connection.Close();
                return count;

            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return count;
            }
        }

        // Check If An Urgent Already Exist

        public bool isAlreadyExist(string unico)
        {
            try
            {
                string leadCode = getLeadCode(unico);
                if(leadCode != "")
                {
                    DbHelper.connection.Open();
                    string QUERY = "SELECT U.*,W.LeadCode FROM Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus='Express' AND W.LeadCode=@leadCode";
                    SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                    cmd.Parameters.AddWithValue("@leadCode", leadCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DbHelper.connection.Close();
                        return true;
                    }

                    DbHelper.connection.Close();
                    return false;
                }
                else
                {
                    DbHelper.connection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return false;
            }
        }

        // Get Urgents Machine

        public string getMachine(string unico)
        {
            string machine = "";
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT MC FROM Wire WHERE Unico=@unico";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@unico", unico);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        machine = reader[0].ToString();
                    }

                    DbHelper.connection.Close();
                    return machine;
                }


                DbHelper.connection.Close();
                return machine;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                MessageBox.Show(ex.Message);
                return machine;
            }
        }

        // Check If LeadCode Already Exist

        public string getLeadCode(string unico)
        {
            string leadCode = "";
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT LeadCode FROM Wire WHERE Unico=@unico";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@unico", unico);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                      leadCode =  reader[0].ToString();
                    }

                    DbHelper.connection.Close();
                    return leadCode;
                }

                DbHelper.connection.Close();
                return leadCode;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return leadCode;
            }
        }

        // Get Unico From Urgent

        public string getUnico(string leadCode)
        {
            string unico = "";
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT W.Unico,U.UrgentStatus FROM Wire W,Urgent U WHERE U.UrgentUnico=W.Unico AND W.LeadCode=@leadCode";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@leadCode", leadCode);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        unico = reader[0].ToString();
                    }

                    DbHelper.connection.Close();
                    return unico;
                }

                DbHelper.connection.Close();
                return unico;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return unico;
            }
        }

        // Fetch All Express Records For Urgent Manager
        public void UrgentManagerExpress(Guna2DataGridView dg)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT W.Unico,W.LeadCode as 'Lead Code',M.Machine,W.Adress as 'Location',W.Cable,W.WireLength as 'Length',W.MarL,W.SealL,W.TerL,W.MarR,W.SealR,W.TerR,W.LeadPrep as 'Lead Prep',U.UrgentStatus as 'Status' FROM Wire W,Machine M,Urgent U WHERE W.Unico=U.UrgentUnico AND M.Machine=W.MC AND U.UrgentStatus = 'Express' ORDER BY M.Machine";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                dg.DataSource = dt.DefaultView;

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error While Processing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Fetch All Express Records For Urgent Manager
        public void UrgentManagerExpress(Guna2DataGridView dg,string machine)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT W.Unico,W.LeadCode as 'Lead Code',M.Machine,W.Adress as 'Location',W.Cable,W.WireLength as 'Length',W.MarL,W.SealL,W.TerL,W.MarR,W.SealR,W.TerR,W.LeadPrep as 'Lead Prep',U.UrgentStatus as 'Status' FROM Wire W,Machine M,Urgent U WHERE W.Unico=U.UrgentUnico AND M.Machine=W.MC AND W.MC=@machine AND U.UrgentStatus = 'Express' ORDER BY Groupe";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@machine", machine);
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                dg.DataSource = dt.DefaultView;

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error While Processing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Get All Express Status Machines

        public ArrayList machines()
        {
            ArrayList arr = new ArrayList();
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT DISTINCT W.MC FROM Wire W,Urgent U WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus = 'Express'";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arr.Add(reader[0].ToString());
                    }

                    DbHelper.connection.Close();
                    return arr;
                }
                DbHelper.connection.Close();
                return arr;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return arr;
            }
        }
    }
}
