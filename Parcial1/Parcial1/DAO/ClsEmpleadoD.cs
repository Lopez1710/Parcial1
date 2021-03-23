using Parcial1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1.DAO
{
    class ClsEmpleadoD
    {
        public List<Tbl_empleado> cargardatosUserLis()
        {
            List<Tbl_empleado> lista;
            using (EMPLEADOEntities db = new EMPLEADOEntities())
            {
                lista = db.Tbl_empleado.ToList();

            }

            return lista;
        }
        public void DeleteUser(int ID)
        {
            try
            {
                using (EMPLEADOEntities db = new EMPLEADOEntities())
                {

                    int eliminar = Convert.ToInt32(ID);
                    Tbl_empleado EMPLEADO = db.Tbl_empleado.Where(x => x.Id_empleado == eliminar).Select(x => x).FirstOrDefault();

                    //
                    //userList = db.UserList.Find(eliminar);
                    db.Tbl_empleado.Remove(EMPLEADO);
                    db.SaveChanges();

                    MessageBox.Show("Se ha Eliminado al Usuario con Id = " + ID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);

            }
        }
    }
}
