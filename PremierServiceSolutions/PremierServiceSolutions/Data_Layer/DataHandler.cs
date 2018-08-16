using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using PremierServiceSolutions.Business_Layer;
using System.Data;
using System.Data.Sql;

namespace PremierServiceSolutions.Data_Layer
{
    class DataHandler
    {
        public static string conString = @"workstation id=PremierServicedb.mssql.somee.com;packet size=4096;user id=solafidei_SQLLogin_1;pwd=ny98xprdqh;data source=PremierServicedb.mssql.somee.com;persist security info=False;initial catalog=PremierServicedb";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        bool check;
        List<string> name = new List<string>();
        List<string> model = new List<string>();
        List<string> treeNode = new List<string>();
        Crypto crypto = new Crypto();
        string department;

        public void Connect()
        {
            using (con = new SqlConnection(conString))
            {
                MessageBox.Show(con.State.ToString());
            }
        }
        public void Disconnect()
        {
            con.Close();
            MessageBox.Show(con.State.ToString());
        }

        public void Delete(string table, string field, string permField)
        {
            string sqlDelete = "DELETE FROM " + table + "WHERE " + field + " = " + permField;
            try
            {
                SqlCommand cmdDelete = new SqlCommand(sqlDelete, con);

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
        }

        public bool InsertClient(string firstName, string lastName, int telNumber,
            string address, string adhocNote, string businessName, string clientType,
            string contractType, string followup, string report, string status,string clientIdentifier)
        {
            using (con = new SqlConnection(conString))
            {
                bool check;
                using (cmd = new SqlCommand("sp_InsertClient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@telNumber", telNumber);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@adhocNote", adhocNote);
                    cmd.Parameters.AddWithValue("@businessName", businessName);
                    cmd.Parameters.AddWithValue("@clientType", clientType);
                    cmd.Parameters.AddWithValue("@contractType", contractType);
                    cmd.Parameters.AddWithValue("@followup", followup);
                    cmd.Parameters.AddWithValue("@report", report);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@clientIdentifier", clientIdentifier);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                    }
                    else
                    {
                        return check = false;
                    }
                    con.Close();
                   // MessageBox.Show("inserted client from data");
                    return check;
                }
            }
        }

        public bool InsertCall(DateTime receiveTime, DateTime endTime, string name, string surname, string reason,
            string clientType, string customerName, string customerSurname, string businessName)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_InsertCall", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@receiveTime", receiveTime);
                    cmd.Parameters.AddWithValue("@endTime", endTime);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@reason", reason);
                    cmd.Parameters.AddWithValue("@clientType", clientType);
                    cmd.Parameters.AddWithValue("@customerName", customerName);
                    cmd.Parameters.AddWithValue("@customerSurname", customerSurname);
                    cmd.Parameters.AddWithValue("@businessName", businessName);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                    }
                    else
                    {
                        return check = false;
                    }
                  //  MessageBox.Show("inserted call data check");
                }
            }
            return check;
        }

        public bool InsertContract(string contractType, string serviceName, string serviceLevel
            , string serviceAvailable, string equipmentName, string equipmentModel, string contractIdentifier)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_InsertContract", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@contractType", contractType);
                    cmd.Parameters.AddWithValue("@serviceName", serviceName);
                    cmd.Parameters.AddWithValue("@serviceAvailable", serviceAvailable);
                    cmd.Parameters.AddWithValue("@serviceLevel", serviceLevel);
                    cmd.Parameters.AddWithValue("@equipmentName", equipmentName);
                    cmd.Parameters.AddWithValue("@equipmentModel", equipmentModel);
                    cmd.Parameters.AddWithValue("@contractIdentifier", contractIdentifier);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                      //  MessageBox.Show("contract inserted from data");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool InsertEmployeeType(string employeeSkill, string employeeType) //not used yet
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_InsertEmployeeType", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@employeeSkill", employeeSkill);
                    cmd.Parameters.AddWithValue("@employeeType", employeeType);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                       // MessageBox.Show("inserted employee types from data");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool InsertService(string serviceName, string serviceLevel)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_InsertService", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@serviceName", serviceName);
                    cmd.Parameters.AddWithValue("@serviceLevel", serviceLevel);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                      //  MessageBox.Show("inserted service from data");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool InsertEmployee(string name, string surname, string address, int telNum, //not used yet
            string employeeType, string jobDescription)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_IEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@telNum", telNum);
                    cmd.Parameters.AddWithValue("@employeeType", employeeType);
                    cmd.Parameters.AddWithValue("@jobDescription", jobDescription);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 1)
                    {
                        check = true;
                      //  MessageBox.Show("employee inserted");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool InsertWorkRequest(string workRequirement, string workDuration,
            string name, string surname)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_InsertWorkRequest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@WorkRequirement", workRequirement);
                    cmd.Parameters.AddWithValue("@workDuration", workDuration);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool UpdateClient(int telNumber, string address, string adhocNote, string clientType,
            string contractType, string followup, string report, string status, string clientIdentifier)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_UpdateClient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.AddWithValue("@firstName", firstName);
                   // cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@telNumber", telNumber);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@adhocNote", adhocNote);
                  //  cmd.Parameters.AddWithValue("@businessName", businessName);
                    cmd.Parameters.AddWithValue("@clientType", clientType);
                    cmd.Parameters.AddWithValue("@contractType", contractType);
                    cmd.Parameters.AddWithValue("@followup", followup);
                    cmd.Parameters.AddWithValue("@report", report);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@clientIdentifier", clientIdentifier);

                    con.Open();
                    int checking = cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                      //  MessageBox.Show("updated client from data");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool UpdateContract(string contractType, string serviceAvailable, string serviceName,string contractIdentifier, string equipmentName, string equipmentModel)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_UpdateContract", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@contractType", contractType);
                    cmd.Parameters.AddWithValue("@serviceAvailable", serviceAvailable);
                    cmd.Parameters.AddWithValue("@serviceName", serviceName);
                    cmd.Parameters.AddWithValue("@contractIdentifier", contractIdentifier);
                    cmd.Parameters.AddWithValue("@equipmentName", equipmentName);
                    cmd.Parameters.AddWithValue("@equipmentModel", equipmentModel);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                      //  MessageBox.Show("contract updated from data");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool UpdateEmployee(string name, string surname, string address, // not used yet
            int telNum, string employeeType, string jobDescription)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_UpdateEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@telNum", telNum);
                    cmd.Parameters.AddWithValue("@employeeType", employeeType);
                    cmd.Parameters.AddWithValue("@jobDescription", jobDescription);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 1)
                    {
                        check = true;
                       // MessageBox.Show("employee updated");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool UpdateService(string serviceName, string serviceLevel)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_UpdateService", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@serviceName", serviceName);
                    cmd.Parameters.AddWithValue("@serviceLevel", serviceLevel);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                      //  MessageBox.Show("service updated");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool UpdateWorkRequest(int workID, string workRequirement, string workDuration, //not used yet
            string name, string surname)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_UpdateWorkRequest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@workID", workID);
                    cmd.Parameters.AddWithValue("@workRequirement", workRequirement);
                    cmd.Parameters.AddWithValue("@workDuration", workDuration);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 1)
                    {
                        check = true;
                      //  MessageBox.Show("workrequest updated");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public List<string> FindClient(string clientType, string clientIdentifier)
        {
            List<string> client = new List<string>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_FindClient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@clientIdentifier", clientIdentifier);
                    cmd.Parameters.AddWithValue("@clientType", clientType);

                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    // cmd.ExecuteNonQuery();
                    ds = new DataSet();
                    adapter.Fill(ds);

                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        foreach (var field in item.ItemArray)
                        {
                            client.Add(field.ToString());
                        }
                    }
                    return client;
                }
            }
        }

        public List<string> FindClientWithContract(string clientType, string clientIdentifier)
        {
            List<string> client = new List<string>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_FindClientWithContract", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@clientIdentifier", clientIdentifier);
                    cmd.Parameters.AddWithValue("@clientType", clientType);

                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    
                    ds = new DataSet();
                    adapter.Fill(ds);

                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        foreach (var field in item.ItemArray)
                        {
                            client.Add(field.ToString());
                        }
                    }
                    return client;
                }
            }
        }

        public bool ReassignWorkRequest(string workRequest, string name, string surname)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_ReassignWorkRequest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@workRequirement", workRequest);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                      //  MessageBox.Show("work request reassigned");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public bool CloseWorkRequest(int workID)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_DeleteWorkRequest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@workID", workID);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        check = true;
                        MessageBox.Show("delete from data");
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        public List<ClientDetail> FindFollowup(string clientType)
        {
            List<ClientDetail> followup = new List<ClientDetail>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_FindFollowup",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clientType", clientType);
                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        followup.Add(new ClientDetail(item["ClientIdentifier"].ToString(), item["ClientFollowup"].ToString(), item["ClientStatus"].ToString()));
                    }
                }
            }
            return followup;
        }

        public List<string> FindReport()
        {
            List<string> report = new List<string>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_FindReport", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        foreach (var field in item.ItemArray)
                        {
                            report.Add(field.ToString());
                        }
                    }
                }
            }
            return report;
        }

        public List<string> ViewContract()
        {
            List<string> report = new List<string>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_ViewContractType", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        foreach (var field in item.ItemArray)
                        {
                            report.Add(field.ToString());
                        }
                    }
                }
            }
            return report;
        }

        public List<string> FindAgreement(string firstName, string lastName, string businessName, string clientType)
        {
            List<string> agreement = new List<string>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_FindAgreement", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@businessName", businessName);
                    cmd.Parameters.AddWithValue("@clientType", clientType);

                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    // cmd.ExecuteNonQuery();
                    ds = new DataSet();
                    adapter.Fill(ds);

                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        foreach (var field in item.ItemArray)
                        {
                            agreement.Add(field.ToString());
                        }
                    }
                    return agreement;
                }
            }
        }

        public string Login(string username, string password)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_Login",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            if (crypto.Decrypt(item["Password"].ToString()) == crypto.Decrypt(password))
                            {
                                department = item["department"].ToString();
                                check = true;
                            }
                        }
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return department;
        }

        private DataTable GetEquipmentType()
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_ViewEquipmentType",con))
                {
                    using (adapter = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        private DataTable GetEquipment(int parentID)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_ViewEquipment", con))
                {
                    using (adapter = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@parentID", parentID);
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                    }
                }
                PopulateTreeView(dt);
                return dt;
            }
        }

        private void PopulateTreeView(DataTable dtParent)
        {

            foreach (DataRow dr in dtParent.Rows)
            {
                treeNode.Add(dr["EquipmentType"].ToString());
                
                PopulateTreeViewChild(Convert.ToInt32(dr["EquipmentTypeID"].ToString()), treeNode);
            }
        }
        private void PopulateTreeViewChild(int parentId, List<string> ParentNode)
        {
            DataTable dtParent = new DataTable();
            dtParent = GetEquipmentType();

            foreach (DataRow dr in dtParent.Rows)
            {
                if (ParentNode == null)
                {
                    name.Add(dr["EquipmentName"].ToString());
                }
                else
                {
                    name.Add(dr["EquipmentName"].ToString());
                    if (name == null)
                    {
                        model.Add(dr["EquipmentModel"].ToString());
                    }
                    else
                    {
                        model.Add(dr["EquipmentModel"].ToString());
                    }
                    //model = ParentNode.Nodes.Add(dr["EquipmentName"].ToString());
                }
            }
        }

        public List<Equipment> ViewEquipmentWithType()
        {
            List<Equipment> equipment = new List<Equipment>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_ViewEquipmentWithType",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    
                    ds = new DataSet();
                    adapter.Fill(ds);

                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        equipment.Add(new Equipment(item["EquipmentType"].ToString(),item["EquipmentName"].ToString(),item["EquipmentModel"].ToString()));
                    }
                }
            }
            return equipment;
        }

        public List<string> FindAgreementWithContract(string contractIdentifier)
        {
            List<string> agreement = new List<string>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_ViewContractTypeWithView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@contractID", contractIdentifier);

                    con.Open();
                    adapter = new SqlDataAdapter(cmd);

                    ds = new DataSet();
                    adapter.Fill(ds);

                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        foreach (var field in item.ItemArray)
                        {
                            agreement.Add(field.ToString());
                        }
                    }
                    return agreement;
                }
            }
        }

        public ClientDetail.eClientStatus GetClientStatus(string clientIdentifier)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_GetClientStatus",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clientIdentifier", clientIdentifier);
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return (ClientDetail.eClientStatus)int.Parse(ds.Tables[0].Rows[0]["status"].ToString());

                    }
                    return new ClientDetail.eClientStatus();
                }
            }
        }

        public DataTable GetReport(string clientType, string clientIdentifier)
        {
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_ClientReport",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clientIdentifier", clientIdentifier);
                    cmd.Parameters.AddWithValue("@clientType", clientType);
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);

                    return ds.Tables[0];
                }
            }
        }

        public List<string> ViewServiceLevel()
        {
            List<string> report = new List<string>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_ViewServiceLevel", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        foreach (var field in item.ItemArray)
                        {
                            report.Add(field.ToString());
                        }
                    }
                }
            }
            return report;
        }

        public List<WorkRequest> ViewWorkRequest()
        {
            List<WorkRequest> workrequest = new List<WorkRequest>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_ViewWorkRequest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {

                        workrequest.Add(new WorkRequest(int.Parse(item["WorkID"].ToString()),item["WorkRequirement"].ToString(),item["WorkDuration"].ToString()));

                    }
                }
            }
            return workrequest;
        }

        public List<WorkRequest> ViewUnassignedRequest()
        {
            List<WorkRequest> workrequest = new List<WorkRequest>();
            using (con = new SqlConnection(conString))
            {
                using (cmd = new SqlCommand("sp_UnassignedWork", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        workrequest.Add(new WorkRequest(item["WorkRequirement"].ToString(), item["WorkDuration"].ToString()));
                    }
                }
            }
            return workrequest;
        }
    }
}
