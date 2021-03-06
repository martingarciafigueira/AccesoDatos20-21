package boletin4;

import java.sql.*;

public class Ejercicio4 {

    public static void main(String[] args) {
        Connection conexion = null;
        try {
            // Cargar el driver
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");

            // Se obtiene una conexión con la base de datos.
            String connectionUrl
                = "jdbc:sqlserver://DESKTOP-S65ABNK\\BD_MONTECASTELO:1433;"
                + "databaseName=JDBC;"
                + "user=sa;"
                + "password=montecastelo;";                   
            conexion = DriverManager.getConnection(connectionUrl);

            //Indicamos que el ResultSet será desplazable y modificable
            Statement s = conexion.createStatement(ResultSet.TYPE_SCROLL_SENSITIVE, ResultSet.CONCUR_UPDATABLE);

            ResultSet rs = s.executeQuery("select * from alumnos");

            //Recorrer el ResultSet desde el final hasta el principio
            rs.afterLast();
            while (rs.previous()) {
                System.out.println(rs.getInt(1) + " " + rs.getString(2) + " " + rs.getString(3));
            }

            // modificar el campo nombre (2) del registro 2 del ResultSet
            // el cambio también se produce en la base de datos
            rs.absolute(2);
            rs.updateString(2, "Zinedine Zidane");
            rs.updateRow();

            //Recorrer el ResultSet para comprobar la modificación.
            //Para recorrer el ResultSet desde el principio hasta el final nos debemos situar
            //de nuevo al principio
            rs.beforeFirst();
            while (rs.next()) {
                System.out.println(rs.getInt(1) + " " + rs.getString(2) + " " + rs.getString(3));
            }
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        } catch (ClassNotFoundException e) {
            System.out.println(e.getMessage());
        } finally {
            try {
                if (conexion != null) {
                    conexion.close();
                }
            } catch (SQLException ex) {
                System.out.println(ex.getMessage());
            }
        }
    }
}
