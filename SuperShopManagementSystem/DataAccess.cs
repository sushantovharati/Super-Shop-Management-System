using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

public class DataAccess
{
    private readonly string cs;

    public DataAccess()
    {
        cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    }

    public DataTable ExecuteQueryTable(string sql, OracleParameter[] parameters = null)
    {
        DataTable dt = new DataTable();

        using (OracleConnection con = new OracleConnection(cs))
        {
            using (OracleCommand cmd = new OracleCommand(sql, con))
            {
                cmd.BindByName = true;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
        }

        return dt;
    }

    // INSERT / UPDATE / DELETE
    public int ExecuteDMLQuery(string sql, OracleParameter[] param = null)
    {
        using (OracleConnection con = new OracleConnection(cs))
        {
            using (OracleCommand cmd = new OracleCommand(sql, con))
            {
                cmd.BindByName = true;

                if (param != null)
                    cmd.Parameters.AddRange(param);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }


}
