using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{

    public partial class InicioSeccion
    {
        // Public autoriza As Integer = 0
        public bool pantallabienvenida;
        private string query;
        public string idusuario, nombreusuario;
        private SqlCommand cmd;

        public InicioSeccion()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            query = "select convert(nvarchar(50),hashbytes('SHA1','" + txtcontra.Text + @"'),2) from usuario
                where username = '" + txtusuario.Text + "'";

            DataTable dt;
            try
            {
                dt = VentaAutos.Connection.SelectQuery(query);
                var contrausuario = dt.Rows[0][0];

                query = "select id, nombre,password from usuario where username ='" + txtusuario.Text + "' and estatus = 1";
                dt = VentaAutos.Connection.SelectQuery(query);
                var contrabase = dt.Rows[0][2];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(contrabase, contrausuario, false)))
                {
                    idusuario = Conversions.ToString(dt.Rows[0][0]);
                    nombreusuario = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[1]);
                    pantallabienvenida = true;
                    VentaAutos.My.MyProject.Forms.Carga.Show();
                }

                else
                {
                    Interaction.MsgBox("Contra incorrecta");
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Usuario No existe");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InicioSeccion_Load(object sender, EventArgs e)
        {
            picno.Visible = false;
            txtcontra.UseSystemPasswordChar = true;
            VentaAutos.Connection.VisibleoNo(panelactualizar, false);

            txtcontra2.UseSystemPasswordChar = true;
            picno2.Visible = false;

            txtcontra3.UseSystemPasswordChar = true;
            picno3.Visible = false;
        }

        private void picsi_Click(object sender, EventArgs e)
        {
            picno.Visible = true;
            picsi.Visible = false;
            txtcontra.UseSystemPasswordChar = false;
        }

        private void btnbuscar2_Click(object sender, EventArgs e)
        {
            query = "select convert(nvarchar(50),hashbytes('SHA1','" + txtcontra2.Text + @"'),2) from usuario
                where username = '" + txtusuario2.Text + "'";

            DataTable dt;
            try
            {
                dt = VentaAutos.Connection.SelectQuery(query);
                var contrausuario = dt.Rows[0][0];

                query = "select id, nombre,password from usuario where username ='" + txtusuario2.Text + "' and estatus = 1";
                dt = VentaAutos.Connection.SelectQuery(query);
                var contrabase = dt.Rows[0][2];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(contrabase, contrausuario, false)))
                {
                    VentaAutos.Connection.VisibleoNo(panelactualizar, true);
                    VentaAutos.Connection.VisibleoNo(panelbuscar, false);

                    txtusernameactualizar2.Text = txtusuario2.Text;
                    txtnombreactualizar2.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[1]);
                    txtcontractualizar2.Text = txtcontra2.Text;
                    idusuario = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
                }

                else
                {
                    Interaction.MsgBox("Contra incorrecta");
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Usuario No existe");
            }
        }

        private void txtnombreactualizar2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombreactualizar2.Text) | string.IsNullOrEmpty(txtcontractualizar2.Text) | string.IsNullOrEmpty(txtusernameactualizar2.Text))
            {

                Interaction.MsgBox("Faltan campor por rellenar");
                return;

            }

            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de modificar los datos del usuario" + Constants.vbCrLf + "Deseas Continuar ?" + Constants.vbCrLf, MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();

                    cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombreactualizar2.Text;
                    cmd.Parameters.Add("@usarname", SqlDbType.VarChar).Value = txtusernameactualizar2.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtcontractualizar2.Text;
                    cmd.Parameters.Add("@passwordUsuario", SqlDbType.VarChar).Value = txtcontra2.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "SpActualizarUsuario");

                    Interaction.MsgBox("Usuario Actualizado Correctamente");
                    VentaAutos.Connection.VisibleoNo(panelactualizar, false);
                    VentaAutos.Connection.VisibleoNo(panelbuscar, true);
                }

                catch (Exception ex)
                {
                    Interaction.MsgBox("Error " + ex.Message);
                }
            }
        }

        private void picno2_Click(object sender, EventArgs e)
        {
            picsi2.Visible = true;
            picno2.Visible = false;
            txtcontra2.UseSystemPasswordChar = true;
        }

        private void picsi2_Click(object sender, EventArgs e)
        {
            picno2.Visible = true;
            picsi2.Visible = false;
            txtcontra2.UseSystemPasswordChar = false;
        }

        private void picno3_Click(object sender, EventArgs e)
        {
            picsi3.Visible = true;
            picno3.Visible = false;
            txtcontra3.UseSystemPasswordChar = true;
        }

        private void picsi3_Click(object sender, EventArgs e)
        {
            picno3.Visible = true;
            picsi3.Visible = false;
            txtcontra3.UseSystemPasswordChar = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            query = "select convert(nvarchar(50),hashbytes('SHA1','" + txtcontra3.Text + @"'),2) from usuario
                where username = '" + txtusuario3.Text + "'";

            DataTable dt;
            try
            {
                dt = VentaAutos.Connection.SelectQuery(query);
                var contrausuario = dt.Rows[0][0];

                query = "select id, nombre,password from usuario where username ='" + txtusuario3.Text + "' and estatus = 1";
                dt = VentaAutos.Connection.SelectQuery(query);
                var contrabase = dt.Rows[0][2];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(contrabase, contrausuario, false)))
                {
                    idusuario = Conversions.ToString(dt.Rows[0][0]);
                    nombreusuario = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[1]);
                }

                else
                {
                    Interaction.MsgBox("Contra incorrecta");
                    return;
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Usuario No existe");
                return;
            }

            MsgBoxResult respuesta;
            respuesta = Interaction.MsgBox("Estas a punto de borrar el usuario: " + nombreusuario.ToString() + Constants.vbCrLf + "Deseas Continuar ?" + Constants.vbCrLf, MsgBoxStyle.YesNo);

            if (respuesta == MsgBoxResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand();

                    cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "SpborrarUsuario");

                    Interaction.MsgBox("Usuario Eliminado");

                    txtcontra3.Clear();
                    txtusuario3.Clear();
                }

                catch (Exception ex)
                {
                    Interaction.MsgBox("Error " + ex.Message);
                }
            }
        }

        private void picno_Click(object sender, EventArgs e)
        {
            picsi.Visible = true;
            picno.Visible = false;
            txtcontra.UseSystemPasswordChar = true;
        }
    }
}