## About

MySQL provides connectivity for client applications developed in .NET compatible programming languages with MySQL Connector/NET through a series of packages.

MySql.Data is the core package of Connector/NET. It is compatible with .NET Framework 4.6+ and .NET 6.0+ and provides classic MySQL protocol and MySQL X DevAPI capabilities.

More information at [MySQL Connector/NET documentation](https://dev.mysql.com/doc/connector-net/en/).

## How to use

```
    MySql.Data.MySqlClient.MySqlConnection myConnection;
    string myConnectionString;
    //set the correct values for your server, user, password and database name
    myConnectionString = "server=127.0.0.1;uid=root;pwd=12345;database=test";

    try
    {
      myConnection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
      //open a connection
      myConnection.Open();

      // create a MySQL command and set the SQL statement with parameters
      MySqlCommand myCommand = new MySqlCommand();
      myCommand.Connection = myConnection;
      myCommand.CommandText = @"SELECT * FROM clients WHERE client_id = @clientId;";
      myCommand.Parameters.AddWithValue("@clientId", clientId);

      // execute the command and read the results
      using var myReader = myCommand.ExecuteReader()
      {
        while (myReader.Read())
        {
          var id = myReader.GetInt32("client_id");
          var name = myReader.GetString("client_name");
          // ...
        }
      }
      myConnection.Close();
    }
    catch (MySql.Data.MySqlClient.MySqlException ex)
    {
      MessageBox.Show(ex.Message);
    }
```

## Related Packages

* Entity Framework Core: [MySql.EntityFrameworkCore](https://www.nuget.org/packages/MySql.EntityFrameworkCore/)
* Entity Framework: [MySql.Data.EntityFramework](https://www.nuget.org/packages/MySql.Data.EntityFramework)
* Web: [MySql.Web](https://www.nuget.org/packages/MySql.Web)
* OpenTelemetry: [MySql.Data.OpenTelemetry](https://www.nuget.org/packages/MySql.Data.OpenTelemetry)

## Contributing

There are a few ways to contribute to the Connector/NET code. Please refer to the [contributing guidelines](https://github.com/mysql/mysql-connector-net/blob/8.x/CONTRIBUTING.md) for additional information.

### Additional Resources

* [MySQL](http://www.mysql.com/)
* [MySQL Connector/NET GitHub](https://github.com/mysql/mysql-connector-net)
* [MySQL Connector/NET API](https://dev.mysql.com/doc/dev/connector-net/latest/)
* [MySQL Connector/NET Discussion Forum](https://forums.mysql.com/list.php?38)
* [MySQL Public Bug Tracker](https://bugs.mysql.com)
* [`#connectors` channel in MySQL Community Slack](https://mysqlcommunity.slack.com/messages/connectors) ([Sign-up](https://lefred.be/mysql-community-on-slack/) required when not using an Oracle account)
* For more information about this and other MySQL products, please visit [MySQL Contact & Questions](http://www.mysql.com/about/contact/).
