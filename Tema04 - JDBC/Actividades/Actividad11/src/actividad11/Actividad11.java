/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package actividad11;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Actividad11 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws SQLException, ClassNotFoundException {

        ResultSet resultado;
        int filasAfectadas;

        Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");

        String connectionUrl
                = "jdbc:sqlserver://DESKTOP-S65ABNK\\BD_MONTECASTELO:1433;"
                + "databaseName=JDBC;"
                + "user=sa;"
                + "password=montecastelo;";

        Connection connection = DriverManager.getConnection(connectionUrl);

        String consulta1 = "INSERT INTO Empleados VALUES (?,?,?,?,?)";

        System.out.println("Conexion realizada con éxito");

        //Consulta1
        try {
            connection.setAutoCommit(false);
            PreparedStatement consultaPreparada = connection.prepareStatement(consulta1);

            consultaPreparada.setInt(1, 6);
            consultaPreparada.setString(2, "Pedro");
            consultaPreparada.setString(3, "Revienta");
            consultaPreparada.setInt(4, 33);
            consultaPreparada.setString(5, "01/01/2000");

            filasAfectadas = consultaPreparada.executeUpdate();
            
            connection.commit();
            connection.setAutoCommit(true);

        } catch (Exception e) {
            connection.rollback();
            System.out.println("Ha habido un error. Se ha realizado un rollback");
        }

    }

}
