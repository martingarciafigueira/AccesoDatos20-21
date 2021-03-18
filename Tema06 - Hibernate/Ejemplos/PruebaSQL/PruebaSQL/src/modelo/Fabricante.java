package modelo;
// Generated 18-mar-2021 19:21:19 by Hibernate Tools 3.6.0


import java.util.HashSet;
import java.util.Set;

/**
 * Fabricante generated by hbm2java
 */
public class Fabricante  implements java.io.Serializable {


     private int codigo;
     private String nombre;
     private Set productos = new HashSet(0);

    public Fabricante() {
    }

    public Fabricante(int codigo, String nombre) {
        this.codigo = codigo;
        this.nombre = nombre;
    }
    public Fabricante(int codigo, String nombre, Set productos) {
       this.codigo = codigo;
       this.nombre = nombre;
       this.productos = productos;
    }
   
    public int getCodigo() {
        return this.codigo;
    }
    
    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }
    public String getNombre() {
        return this.nombre;
    }
    
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    public Set getProductos() {
        return this.productos;
    }
    
    public void setProductos(Set productos) {
        this.productos = productos;
    }




}

