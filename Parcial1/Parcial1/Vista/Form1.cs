using Parcial1.DAO;
using Parcial1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClsEmpleadoD clsD = new ClsEmpleadoD();
            clsD.DeleteUser(Convert.ToInt32(TxtEmpleado.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            void carga()
            {

                ClsEmpleadoD clsDUser = new ClsEmpleadoD();
                List<Tbl_empleado> lista = clsDUser.cargardatosUserLis();

                foreach (var iteracion in lista)
                {

                    DtgEmpleados.Rows.Add(iteracion.Id_empleado, iteracion.Empl_nombre, iteracion.Empl_apellido, iteracion.Empl_DUI
                        , iteracion.Empl_direccion, iteracion.Empl_tel, iteracion.Empl_email, iteracion.Empl_cargo);

                }

            }
        }
    }
}
