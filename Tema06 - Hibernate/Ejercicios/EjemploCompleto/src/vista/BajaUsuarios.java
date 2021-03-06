/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package vista;

import controlador.Operaciones;
import javax.swing.DefaultListModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import modelo.Usuarios;

/**
 *
 * @author Juanro49
 */
public class BajaUsuarios extends javax.swing.JFrame
{
    DefaultTableModel m;
    DefaultListModel dlm=new DefaultListModel();
    Operaciones oper=new Operaciones();

    /**
     * Creates new form BajaUsuarios
     */
    public BajaUsuarios()
    {
        initComponents();
        PrepararTabla();
        LLenarTabla();
    }

    private void PrepararTabla()
    {
        String titulos[]=new String[5];
        m=new DefaultTableModel(null,titulos);
        tabla.setModel(m);
    }
    
    private void LLenarTabla()
    {
        String titulos[]={"Usuario","Nombre","Dirección","Teléfono","E-Mail"};
        m=new DefaultTableModel(null,titulos);
        dlm=oper.mostrarUsuarios();
        String fila[]= new String[5];
        
        for (int i=0;i<dlm.size();i++)
        { 
            Usuarios aux=(Usuarios)dlm.get(i);
            fila[0]=aux.getUsuario();
            fila[1]=aux.getNombre()+" "+aux.getApellidos();
            fila[2]=aux.getCalle()+" "+aux.getNumero()+"  CP: "+aux.getCp()+" "+aux.getProvincia();
            fila[3]=aux.getTelefono();
            fila[4]=aux.getEmail();
            m.addRow(fila);
        }     
        tabla.setModel(m);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents()
    {

        jLabel1 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        tabla = new javax.swing.JTable();
        btnVolver = new javax.swing.JButton();
        btnBaja = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("sansserif", 1, 14)); // NOI18N
        jLabel1.setText("Baja de usuarios:");

        tabla.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][]
            {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String []
            {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane1.setViewportView(tabla);

        btnVolver.setText("Volver");
        btnVolver.addActionListener(new java.awt.event.ActionListener()
        {
            public void actionPerformed(java.awt.event.ActionEvent evt)
            {
                btnVolverActionPerformed(evt);
            }
        });

        btnBaja.setText("Dar de baja");
        btnBaja.addActionListener(new java.awt.event.ActionListener()
        {
            public void actionPerformed(java.awt.event.ActionEvent evt)
            {
                btnBajaActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                .addContainerGap())
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(0, 113, Short.MAX_VALUE)
                .addComponent(btnBaja)
                .addGap(102, 102, 102)
                .addComponent(btnVolver)
                .addGap(32, 32, 32))
            .addGroup(layout.createSequentialGroup()
                .addGap(123, 123, 123)
                .addComponent(jLabel1)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(17, 17, 17)
                .addComponent(jLabel1)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 206, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnVolver)
                    .addComponent(btnBaja))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnVolverActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnVolverActionPerformed
    {//GEN-HEADEREND:event_btnVolverActionPerformed
        this.dispose();
    }//GEN-LAST:event_btnVolverActionPerformed

    private void btnBajaActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnBajaActionPerformed
    {//GEN-HEADEREND:event_btnBajaActionPerformed
        int filsel;
        String dni;
        int resp;
        
        try
        {
            filsel = tabla.getSelectedRow();
            
            if (filsel==-1){
                JOptionPane.showMessageDialog(null, "Debes seleccionar Usuario a borrar.");
            }else{
                resp=JOptionPane.showConfirmDialog(null, "Desea eliminar el usuario seleccionado?","Eliminar",JOptionPane.YES_NO_OPTION);
                if(resp==JOptionPane.YES_OPTION){
                        
                        int selectedRow=filsel;
                        String clave =(String)m.getValueAt(selectedRow,0);
                        //ejecutar método que da de baja, le pasamos la clave del objeto a dar de baja
                        oper.bajaUsuarios(clave);
                        LLenarTabla();
                }
            }
       } catch (Exception e)
         {
           JOptionPane.showMessageDialog(null,e+ "Error al eliminar el usuario.");
         } 

    }//GEN-LAST:event_btnBajaActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[])
    {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try
        {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels())
            {
                if ("Nimbus".equals(info.getName()))
                {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        }
        catch (ClassNotFoundException ex)
        {
            java.util.logging.Logger.getLogger(BajaUsuarios.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        catch (InstantiationException ex)
        {
            java.util.logging.Logger.getLogger(BajaUsuarios.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        catch (IllegalAccessException ex)
        {
            java.util.logging.Logger.getLogger(BajaUsuarios.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        catch (javax.swing.UnsupportedLookAndFeelException ex)
        {
            java.util.logging.Logger.getLogger(BajaUsuarios.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable()
        {
            public void run()
            {
                new BajaUsuarios().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBaja;
    private javax.swing.JButton btnVolver;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable tabla;
    // End of variables declaration//GEN-END:variables
}
