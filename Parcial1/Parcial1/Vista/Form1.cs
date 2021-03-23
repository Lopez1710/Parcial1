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
        void clear()
        {
            TxtEmpleado.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDUI.Clear();
            TxtDireccion.Clear();
            TxtTel.Clear();
            TxtEmail.Clear();
            TxtCargp.Clear();

        }
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClsEmpleadoD clsD = new ClsEmpleadoD();
            clsD.DeleteUser(Convert.ToInt32(TxtEmpleado.Text));

            clear();
            carga();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carga();
            clear();
        }

        private void DtgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = DtgEmpleados.CurrentRow.Cells[0].Value.ToString();
            String Nombre = DtgEmpleados.CurrentRow.Cells[1].Value.ToString();
            String Apellido = DtgEmpleados.CurrentRow.Cells[2].Value.ToString();
            String DUI = DtgEmpleados.CurrentRow.Cells[3].Value.ToString();
            String Direccion = DtgEmpleados.CurrentRow.Cells[4].Value.ToString();
            String Tel = DtgEmpleados.CurrentRow.Cells[5].Value.ToString();
            String Email = DtgEmpleados.CurrentRow.Cells[6].Value.ToString();
            String Cargo = DtgEmpleados.CurrentRow.Cells[7].Value.ToString();

            TxtEmpleado.Text = Id;
            TxtNombre.Text = Nombre;
            TxtApellido.Text = Apellido;
            TxtDUI.Text = DUI;
            TxtDireccion.Text = Direccion;
            TxtTel.Text = Tel;
            TxtEmail.Text = Email;
            TxtCargp.Text = Cargo;

        }
    }
}
