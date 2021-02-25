/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package actividad6;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Actividad6 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws SQLException, ClassNotFoundException {
        
        ResultSet resultado;
        
        Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        
        String consulta1 = "INSERT INTO Empleados VALUES (5,'Marcos','Perez',40, 01/01/2025)";
        String consulta2 = "SELECT * FROM Empleados";
        
        String connectionUrl
                = "jdbc:sqlserver://DESKTOP-S65ABNK\\BD_MONTECASTELO:1433;"
                + "databaseName=JDBC;"
                + "user=sa;"
                + "password=montecastelo;";      

        Connection connection = DriverManager.getConnection(connectionUrl);
        
        System.out.println("Conexion realizada con éxito");
        
        Statement stmt = connection.createStatement();
        
        //stmt.executeUpdate(consulta1);
        
        resultado = stmt.executeQuery(consulta2);
        
        stmt.close();
        connection.close();
        
    }

}
