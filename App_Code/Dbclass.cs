using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Dbclass
/// </summary>
public class Dbclass
{
    string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();
    string _command, _username, _email,_logid;

    public string strCommand
    {
        get { return _command; }
        set { _command = value; }
    }

    public string Username
    {
        get { return _username; }
        set { _username = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
   
	public Dbclass()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void insert_stmnt(string qry)
    {
        SqlConnection con = new SqlConnection(sqlcon);
        con.Open();
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void insertqry()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        con.Open();
        SqlCommand cmd = new SqlCommand(strCommand, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public int executeQuery(string qry)
    {
        SqlConnection sCon = new SqlConnection(sqlcon);
        SqlCommand cmd = new SqlCommand(qry, sCon);
        sCon.Open();
        int i = cmd.ExecuteNonQuery();
        sCon.Close();
        return i;
    }
    public DataSet selectqry()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        SqlCommand cmd = new SqlCommand(strCommand, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        return ds;
    }

    public string getPwd()
    {
        string pwd;
        SqlConnection con = new SqlConnection(sqlcon);
        SqlCommand cmd = new SqlCommand("Select Password from LoginTb where EmailID='" + Username + "'", con);
        try
        {
            con.Open();
            pwd = cmd.ExecuteScalar().ToString();
            con.Close();
        }
        catch (Exception ex)
        {
            pwd = ex.Message.ToString();
        }
        return pwd;

    }
    public DataTable selecttable()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        SqlCommand cmd = new SqlCommand(strCommand, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        con.Close();
        return dt;
    }

    public SqlDataReader dataread()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        con.Open();
        SqlCommand cmd = new SqlCommand(strCommand,con);
        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        con.Close();
        return dr;
    }

    public SqlDataReader dataread_subcat()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        con.Open();
        SqlCommand cmd = new SqlCommand(strCommand, con);
        SqlDataReader dr = cmd.ExecuteReader();
        con.Close();
        return dr;
    }
    public string executescalar()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        con.Open();
        SqlCommand cmd = new SqlCommand(strCommand, con);
        string value = cmd.ExecuteScalar().ToString();
        con.Close();
        return value;

    }
    public string executescalar_args(string query)
    {
        SqlConnection con = new SqlConnection(sqlcon);
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        string value = cmd.ExecuteScalar().ToString();
        con.Close();
        return value;

    }
    public string sclarVal()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(strCommand, con);
            string value = cmd.ExecuteScalar().ToString();
            con.Close();
            return value;
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();

        }

    }
    public SqlDataReader getDataReader(string Qry)
    {
        try
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand(Qry, con);
            con.Open();
            SqlDataReader sqldr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sqldr;
            
        }
        catch
        {
            throw;
        }
    }

    public static DataTable GetData(string qry)
    {
        DataTable dt = new DataTable();
        string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(sqlcon))
            {
                using (SqlDataAdapter adp = new SqlDataAdapter(qry, sqlConnection))
                {
                    sqlConnection.Open();
                    adp.Fill(dt);
                    sqlConnection.Close();
                }
            }
            return dt;
        }
        catch
        {
            return null;
        }

    }
}