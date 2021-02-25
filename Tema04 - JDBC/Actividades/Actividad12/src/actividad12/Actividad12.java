/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package actividad12;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Actividad12 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws SQLException, ClassNotFoundException {
        ResultSet resultado;
        
        //Conexión a base de datos
        Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        String connectionUrl
                = "jdbc:sqlserver://DESKTOP-S65ABNK\\BD_MONTECASTELO:1433;"
                + "databaseName=JDBC;"
                + "user=sa;"
                + "password=montecastelo;";
        Connection connection = DriverManager.getConnection(connectionUrl);
        System.out.println("Conexion realizada con éxito");
        
        //Realizamos la consulta        
        String consulta1 = "SELECT Nombre, Telefono FROM Alumnos WHERE ID = ?";
        try {
            connection.setAutoCommit(false);
            PreparedStatement consultaPreparada = connection.prepareStatement(consulta1);

            consultaPreparada.setInt(1, 2);

            resultado = consultaPreparada.executeQuery();            
            connection.commit();
            
            while (resultado.next()) {
                System.out.println("Nombre: " + resultado.getString(1) );
                System.out.println("Teléfono: " + resultado.getString(2) );
            }
            
            connection.setAutoCommit(true);

        } catch (Exception e) {
            connection.rollback();
            System.out.println("Ha habido un error. Se ha realizado un rollback");
        }

    }

}
