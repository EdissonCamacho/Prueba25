﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using appE2Colsis.Datos;

namespace appE2Colsis.Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clLogin objLogin = new clLogin();
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text=="admin" &&txtPswd.Text=="admin2021")
            {
                pSettings.Visible = true;
                mtdCargarDatosDB();
            }
            else
            {
                objLogin.documento = txtUser.Text;
                objLogin.password = txtPswd.Text;
                objLogin.mtdLogin();
                if (objLogin.nombre=="" && objLogin.apellido=="" && objLogin.idRol==0)
                {
                    MessageBox.Show("El usuario No existe", "Usuario No Existe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    frmMenuPrincipal objFrmMenuP = new frmMenuPrincipal(objLogin.idRol, objLogin.nombre, objLogin.apellido);
                    objFrmMenuP.Show();
                    this.Hide();
                }



            }


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pSettings.Visible = false;
            grpSetting.Visible = false;
        }

        private void pSettings_Click(object sender, EventArgs e)
        {
            grpSetting.Visible = true;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if(mtdValidarDatosDB() == true)
            {
                mtdActualizarDatosDB();
                pSettings.Visible = false;
                grpSetting.Visible = false;
            }
            else
            {
                MessageBox.Show("Hay campos vacios");
            }
        }
        private Boolean mtdValidarDatosDB()
        {
            Boolean validarCampos = false;
            if(txtServerDB.Text != "" && txtUserDB.Text != "" && txtPortDB.Text != "" &&
               txtDataBaseDB.Text != "" && txtPasswordDB.Text != "")
            {
                validarCampos = true;
            }
            return validarCampos;
        }
        private void mtdCargarDatosDB()
        {
            txtServerDB.Text = ConfigurationManager.AppSettings["server"];
            txtDataBaseDB.Text = ConfigurationManager.AppSettings["database"];
            txtPortDB.Text = ConfigurationManager.AppSettings["port"];
            txtUserDB.Text = ConfigurationManager.AppSettings["user"];
            txtPasswordDB.Text = ConfigurationManager.AppSettings["password"];
        }
        private void mtdActualizarDatosDB()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "server")
                        { node.Attributes[1].Value = txtServerDB.Text; }
                        else if(node.Attributes[0].Value == "user")
                        { node.Attributes[1].Value = txtUserDB.Text; }
                        else if (node.Attributes[0].Value == "port")
                        { node.Attributes[1].Value = txtPortDB.Text; }
                        else if (node.Attributes[0].Value == "database")
                        { node.Attributes[1].Value = txtDataBaseDB.Text; }
                        else if (node.Attributes[0].Value == "password")
                        { node.Attributes[1].Value = txtPasswordDB.Text; }
                    }
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("DataBase actualizada correctamente");
        }

       
    }
}
