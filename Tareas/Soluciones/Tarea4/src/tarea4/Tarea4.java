/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tarea4;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.*;
import java.util.Scanner;

public class Tarea4 {

    /**
     * Menu principal
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        // TODO code application logic here
        boolean bucle = true;
        
        while(bucle){
            System.out.println("////******* Menu principal *******\\\\");
            
            System.out.println("1 - Ejercicio 1");
            System.out.println("2 - Ejercicio 2");
            System.out.println("3 - EXIT");
            Scanner in = new Scanner(System.in);
            int respuesta = in.nextInt();
            
            switch(respuesta){
                case 1: Ejercicio_1();
                case 2: Ejercicio_2();
                case 3: bucle = false;
                default: System.out.println("No se reconoce el valor introducido");
            }
        }
    }
    
    /**
     * Ejercicio 1 de la tarea 4 
     */
    public static void Ejercicio_1()throws ClassNotFoundException, SQLException{
        Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        String cadena = "jdbc:sqlserver://DESKTOP-8C2TRPA:1433;databaseName=JDBC;integratedSecurity=true;UID=estev;PWD=2252";

        Connection conn = DriverManager.getConnection(cadena);
        System.out.println("Conectado");
        boolean bucle = true;
        
        while(bucle){
            System.out.println("Que opcion quiere ejecutar:");
            System.out.println("1 - Obtenga las ciudades de todas las oficinas de Galicia");
            System.out.println("2 - Permita insertar registros en la tabla EMP utilizando consultas parametrizadas");
            System.out.println("3 - Permita reducir un 10% el importe de todos los pedidos");
            System.out.println("4 - Permita borrar todos los registros de la tabla SALGRADE");
            System.out.println("5 - EXIT");

            Scanner in = new Scanner(System.in);
            int respuesta = in.nextInt();

            switch(respuesta){
                case 1: ObtenerCiudades(conn);
                case 2: InsertarEMP(conn);
                case 3: ReducirPedidos(conn);
                case 4: DeleteSalgade(conn);
                case 5: bucle = false;
                default: System.out.println("No se reconoce el valor introducido");
            }
        }
    }
    public static void ObtenerCiudades(Connection conn) throws SQLException{
        // select ciudad from oficinas where region='Galicia'
        String cadenaSQL = "select ciudad from oficinas where region=?";
        
        PreparedStatement pstmt = (PreparedStatement) conn.prepareStatement(cadenaSQL);
        pstmt.setString(1, "Galicia");
        
        ResultSet rs = pstmt.executeQuery();
        while(rs.next()){
            System .out.println(rs.getString("ciudad"));
        }
    }
    public static void InsertarEMP(Connection conn) throws SQLException{
        // insert into EMP values(7890,'Nicolas','Infomati',7788,'1995-09-01',2000,1400,10)
        String cadenaSQL = "insert into EMP values(?,?,?,?,?,?,?,?)";
        PreparedStatement pstmt = (PreparedStatement) conn.prepareStatement(cadenaSQL);
        pstmt.setInt(1, 7890);
        pstmt.setString(2, "Nicolas");
        pstmt.setString(3, "Infomati");
        pstmt.setInt(4, 7788);
        pstmt.setString(5, "1995-09-01");
        pstmt.setInt(6, 2000);
        pstmt.setInt(7, 1400);
        pstmt.setInt(8, 10);
        int i = pstmt.executeUpdate();
        System.out.println("Se han introducido " + Integer.toString(i) + " filas en la tabla EMP");
    }
    public static void ReducirPedidos(Connection conn) throws SQLException{
        // asdfasdf
        String cadenaSQL = "update pedidos set importe = importe*0.9";
        PreparedStatement pstmt = (PreparedStatement) conn.prepareStatement(cadenaSQL);
        int i = pstmt.executeUpdate();
        System.out.println("Se han actualizado " + Integer.toString(i) + " filas en la tabla Pedidos");
    }
    public static void DeleteSalgade(Connection conn) throws SQLException{
        //truncate table SALGRADE
        String cadenaSQL = "truncate table SALGRADE";
        PreparedStatement pstmt = (PreparedStatement) conn.prepareStatement(cadenaSQL);
        int i = pstmt.executeUpdate();
        System.out.println("Se han eliminado " + Integer.toString(i) + " filas en la tabla SALGRADE");
    }
    
    /**
     * Ejercicio 2 de la tarea 4 
     */
    public static void Ejercicio_2() throws ClassNotFoundException, SQLException{
        Class.forName("com.mysql.jdbc.Driver");
        String cadena = "jdbc:mysql://localhost/jdbc";

        Connection conn = DriverManager.getConnection(cadena, "ciclo","ciclo");
        System.out.println("Conectado");
        boolean bucle = true;
        
        while(bucle){
            System.out.println("Que opcion quiere ejecutar:");
            System.out.println("1 - Ejeccutar TRANSACCION");
            System.out.println("2 - EXIT");

            Scanner in = new Scanner(System.in);
            int respuesta = in.nextInt();

            switch(respuesta){
                case 1: Transaccion(conn);
                case 2: bucle = false;
                default: System.out.println("No se reconoce el valor introducido");
            }
        }
    }
    public static void Transaccion(Connection conn) throws SQLException{
        
        try{
            conn.setAutoCommit(false);
            /*1*/
            System.out.println("Insertar un registro en la tabla BONUS");
            String cadenaSQL1 = "insert into bonus values('Nicolas','Informati',2000, 25)";
            PreparedStatement pstmt1 = (PreparedStatement) conn.prepareStatement(cadenaSQL1);
            int i1 = pstmt1.executeUpdate();
            System.out.println("Se han introducido " + Integer.toString(i1) + " filas en la tabla bonus");
            
            /*2*/
            System.out.println("Borra todos aquellos empleados mayores de 40 años");
            String cadenaSQL2 = "delete from empleados where edad>40";
            PreparedStatement pstmt2 = (PreparedStatement) conn.prepareStatement(cadenaSQL2);
            int i2 = pstmt2.executeUpdate();
            System.out.println("Se han eliminado " + Integer.toString(i2) + " filas en la tabla empleados");
            
            /*3*/
            System.out.println("Actualiza las cantidades de todos los pedidos cuyo importe sea menor a 3€");
            String cadenaSQL3 = "update pedidos set importe=5 where importe<3";
            PreparedStatement pstmt3 = (PreparedStatement) conn.prepareStatement(cadenaSQL3);
            int i3 = pstmt3.executeUpdate();
            System.out.println("Se han actualizado " + Integer.toString(i3) + " filas en la tabla Pedidos");
            
            /*4*/
            System.out.println("Muestra las localizaciones de todos los departamentos");
            String cadenaSQL4 = "select LOC from dept";
            PreparedStatement pstmt4 = (PreparedStatement) conn.prepareStatement(cadenaSQL4);
            ResultSet rs4 = pstmt4.executeQuery();
            while(rs4.next()){
                System .out.println(rs4.getString("LOC"));
            }
            
            conn.commit();
            conn.setAutoCommit(true);
        }catch(SQLException e){
            try{
                conn.rollback();
                System.out.println(e.getMessage());
            }catch(SQLException ex){
                ex.printStackTrace();
            }
        }
    }
}
