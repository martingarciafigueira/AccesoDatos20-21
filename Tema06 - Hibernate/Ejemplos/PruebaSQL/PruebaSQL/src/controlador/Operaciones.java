/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package controlador;
import modelo.*;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.classic.Session;

/**
 *
 * @author MESACOCINA
 */
public class Operaciones {
    
    
    public void InsertarOActualizarProducto(Producto p){
        SessionFactory factoria = HibernateUtil.getSessionFactory();
        Session sesion = factoria.getCurrentSession();
        Transaction tx = null;
        
        sesion.saveOrUpdate(p);
    }
    
}
