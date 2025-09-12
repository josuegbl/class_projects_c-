namespace apiRest_EF.Services;
using System.Data.SqlTypes;
using System.Reflection.PortableExecutable;
using apiRest.Models;
using Microsoft.Data.SqlClient;

public class AdoNetTest
{
    public AdoNetTest()
    {
        string connectionString = "Serve=(localdb)\\MSSQLLocalDB;database=Test;Interated Security=true";

        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();

        sqlConnectionStringBuilder.IntegratedSecurity = true;
        sqlConnectionStringBuilder.InitialCatalog = "Test";
        sqlConnectionStringBuilder.DataSource = "Serve=(localdb)\\MSSQLLocalDB";

        sqlConnectionStringBuilder.ToString();

        using SqlConnection connection = new SqlConnection(connectionString);

        string commandQuery = "SELECT * "
                            + "FROM Users";

        using SqlCommand command = new SqlCommand(commandQuery, connection);

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows == true)
        {
            while(reader.Read())
            {
                var userId = reader["id"];
                var name = reader["name"];
                var userAge = reader["age"];
            }
        }

        connection.Close();
    }

    public void insertUser()
    {
        string insertQuery = "INSERT INTO Users "
                           + " Values(1, 'Nombre1', 20)";
        
        using SqlCommand inserCommand = new SqlCommand(insertQuery);
        // esto es lo mismo en los dos. El de abajo es el correcto       
        //----------------------------------------------

        string insertQueryParams = "INSERT INTO Users "
                           + " Values(@id, @name, @age)";

        using SqlCommand inserCommandParams = new SqlCommand(insertQueryParams);


        //-----------

        //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter()

        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();

        SqlCommand insertCOmmandAuto = sqlCommandBuilder.GetInsertCommand(true);

        insertCOmmandAuto.Parameters["@id"].Value = 1;
        insertCOmmandAuto.Parameters["@name"].Value = "Nombre1";
        insertCOmmandAuto.Parameters["@age"].Value = 20;


        //-----------

        SqlParameter id = new SqlParameter("id", 1);
        inserCommandParams.Parameters.Add(id);

        SqlParameter namep = new SqlParameter("name", "Nombre");
        inserCommandParams.Parameters.Add(namep);

        SqlParameter age = new SqlParameter("age", 20);
        inserCommandParams.Parameters.Add(age);

        int rowsAffected = inserCommand.ExecuteNonQuery();

        //-----------------------------------------------

        using SqlDataReader readerInsert = inserCommand.ExecuteReader();

        if (readerInsert.HasRows == true)
        {
            while (readerInsert.Read())
            {
                var userId = readerInsert["id"];
                var name = readerInsert["name"];
                var userAge = readerInsert["age"];
            }
        }
    }

    public void updateUser()
    {
        string updateQuery = "UPDATE Users "
                           + " SET name=@nameUpdated"
                           + "WHERE id=@idToUpdate";

        using (SqlCommand updateCommand = new SqlCommand(updateQuery))
        {
            updateCommand.Parameters.Add(
                new SqlParameter("@nameUpdated", "Nombre1Updated"));
            updateCommand.Parameters.Add(
                new SqlParameter("@idToUpdate", "1"));
        }

        // EXECUTE QUERY AND READER
    }

    public void deleteUser()
    {
        string deleteQuery = "DELETE FROM Users "
                           + "WHERE id=@idToUpdate";

        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery))
        {
            deleteCommand.Parameters.Add(
                new SqlParameter("@idToDelete", "1"));
        }

        // EXECUTE QUERY AND READER
    }

    public void selectUser()
    {
        string commandQuery = "SELECT * "
                            + "FROM Users";

        using SqlCommand command = new SqlCommand(commandQuery);

        using SqlDataReader reader = command.ExecuteReader();

        
        if (reader.HasRows == true)
        {
            while (reader.Read())
            {
                int userId = reader.GetFieldValue<int>(reader.GetOrdinal("id"));
                string name = reader.GetFieldValue<string>(reader.GetOrdinal("name"));
                int age = reader.GetFieldValue<int>(reader.GetOrdinal("age"));
            }
        }

    }


}
