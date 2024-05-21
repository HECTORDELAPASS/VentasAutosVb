using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VentaAutos
{

    public partial class ActualizarVendAgencEdp
    {
        private DataTable dt;
        private string query;
        private SqlCommand cmd;

        public ActualizarVendAgencEdp()
        {
            InitializeComponent();
        }

        private void ActualizarVendAgencEdp_Load(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = true;
            int id = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;

            if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 1)
            {
                query = "select nombre from vendedor where id = " + id;
                dt = VentaAutos.Connection.SelectQuery(query);

                txtNombre.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 2)
            {
                query = "select nombre from agencia where id = " + id;
                dt = VentaAutos.Connection.SelectQuery(query);

                txtNombre.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 3)
            {
                query = "select nombreestado from estado where id = " + id;
                dt = VentaAutos.Connection.SelectQuery(query);

                txtNombre.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 4)
            {
                query = "select nombre from carroceria where id =" + id;
                dt = VentaAutos.Connection.SelectQuery(query);

                txtNombre.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 5)
            {
                query = "select nombre from modelo where id =" + id;
                dt = VentaAutos.Connection.SelectQuery(query);

                txtNombre.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 6)
            {
                query = "select nombre from variante where id =" + id;
                dt = VentaAutos.Connection.SelectQuery(query);

                txtNombre.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 7)
            {
                query = "select nombre from trasmicion where id =" + id;
                dt = VentaAutos.Connection.SelectQuery(query);

                txtNombre.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 8)
            {
                query = "select nombre from interior where id =" + id;
                dt = VentaAutos.Connection.SelectQuery(query);

                txtNombre.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 9)
            {
                query = "select nombre from colores where id =" + id;
                dt = VentaAutos.Connection.SelectQuery(query);

                txtNombre.Text = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string horaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

            if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 1)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idvendedor", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "spactualizarvendedor");

                    query = "select fechamodifica from vendedor where id =" + VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    dt = VentaAutos.Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                        VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al Actualizar: " + ex.Message);
                }
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 2)
            {

                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "spactualizaragencia");

                    query = "select fechamodifica from agencia where id =" + VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    dt = VentaAutos.Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                        VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al Actualizar: " + ex.Message);
                }
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 3)
            {

                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idEstado", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "spActualizarEstado");

                    query = "select fechamodifica from estado where id =" + VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    dt = VentaAutos.Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                        VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al Actualizar: " + ex.Message);
                }
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 4)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idcarroceria", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "SpActualizarCarroceria");

                    query = "select fechamodifica from carroceria where id =" + VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    dt = VentaAutos.Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                        VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al Actualizar: " + ex.Message);
                }
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 5)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idmodelo", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "SpActualizarModelo");

                    query = "select fechamodifica from modelo where id =" + VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    dt = VentaAutos.Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                        VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al Actualizar: " + ex.Message);
                }
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 6)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idvariante", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "SpActualizarVariante");

                    query = "select fechamodifica from variante where id =" + VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    dt = VentaAutos.Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                        VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al Actualizar: " + ex.Message);
                }
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 7)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idTransmision", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "SpActualizarTransmision");

                    query = "select fechamodifica from trasmicion where id =" + VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    dt = VentaAutos.Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                        VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al Actualizar: " + ex.Message);
                }
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 8)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idInterior", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "SpActualizarInterior");

                    query = "select fechamodifica from interior where id =" + VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    dt = VentaAutos.Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                        VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al Actualizar: " + ex.Message);
                }
            }

            else if (VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.eleccion == 9)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Add("@idcolor", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = VentaAutos.My.MyProject.Forms.InicioSeccion.idusuario;
                    cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text;

                    VentaAutos.Connection.ExecuteStoreProcedure(cmd, "SpActualizarColores");

                    query = "select fechamodifica from colores where id =" + VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.EliminarActualizar;
                    dt = VentaAutos.Connection.SelectQuery(query);
                    string comprobacion = Conversions.ToString(dt.AsEnumerable().ElementAtOrDefault(0)[0]);

                    if ((horaHoy ?? "") == (comprobacion ?? ""))
                    {
                        Interaction.MsgBox("Actualizacion realizada correctamente");
                        VentaAutos.My.MyProject.Forms.VendedorAgenciaEstados.filtro();
                        Close();
                    }
                    else
                    {
                        Interaction.MsgBox("Error al actulizar " + Constants.vbCrLf + "Revisa los campos");
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Error al Actualizar: " + ex.Message);
                }

            }


        }
    }
}