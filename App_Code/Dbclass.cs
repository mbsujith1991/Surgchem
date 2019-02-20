using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

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
        try
        {            
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }        
    }
    public void insertqry()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(strCommand, con);
            cmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }        
    }

    public int executeQuery(string qry)
    {
        SqlConnection sCon = new SqlConnection(sqlcon);
        try
        {
            SqlCommand cmd = new SqlCommand(qry, sCon);
            sCon.Open();
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            sCon.Close();
        }
        
    }
    public DataSet selectqry()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {
            SqlCommand cmd = new SqlCommand(strCommand, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
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
        }
        catch (Exception ex)
        {
            pwd = ex.Message.ToString();
        }
        finally
        {
            con.Close();
        }
        return pwd;
    }
    public DataTable selecttable()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {
            SqlCommand cmd = new SqlCommand(strCommand, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public SqlDataReader dataread()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(strCommand, con);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //con.Close();
            return dr;
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public SqlDataReader dataread_subcat()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(strCommand, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }
    public string executescalar()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(strCommand, con);
            string value = cmd.ExecuteScalar().ToString();
            return value;
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }
    public string executescalar_args(string query)
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            string value = cmd.ExecuteScalar().ToString();
            return value;
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }
    public string sclarVal()
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(strCommand, con);
            string value = cmd.ExecuteScalar().ToString();            
            return value;
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
        finally
        {
            con.Close();
        }
    }
    public SqlDataReader getDataReader(string Qry)
    {
        SqlConnection con = new SqlConnection(sqlcon);
        try
        {            
            SqlCommand cmd = new SqlCommand(Qry, con);
            con.Open();
            SqlDataReader sqldr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sqldr;            
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
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

    public List<ListItem> PopulatePager(int recordCount, int currentPage, int maxRows)
    {
        double dblPageCount = (double)((decimal)recordCount / maxRows);
        int pageCount = (int)Math.Ceiling(dblPageCount);
        List<ListItem> pages = new List<ListItem>();
        if (pageCount > 0)
        {
            int showMax = 10;
            int startPage;
            int endPage;
            if (pageCount <= showMax)
            {
                startPage = 1;
                endPage = pageCount;
            }
            else
            {
                startPage = currentPage;
                endPage = currentPage + showMax - 1;
            }

            pages.Add(new ListItem("First", "1", currentPage > 1));

            for (int i = startPage; i <= endPage; i++)
            {
                pages.Add(new ListItem(i.ToString(), i.ToString(), i != currentPage));
            }

            pages.Add(new ListItem("Last", pageCount.ToString(), currentPage < pageCount));
        }
        return pages;
    }
}