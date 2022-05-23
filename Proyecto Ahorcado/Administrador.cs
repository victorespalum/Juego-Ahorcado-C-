using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ahorcado
{
    class Administrador
    {
        String usuario;
        String password;
        bool activeSesion;

        public Administrador()
        {
            this.usuario = null;
            this.password = null;
            this.activeSesion = false;
        }

        public Administrador(String usuario, String password)
        {
            this.usuario = usuario;
            this.password = password;
        }

        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getUsuario()
        {
            return this.usuario;
        }

        public String getPassword()
        {
            return this.password;
        }

        public bool upchecking(String user, String pwd)
        {
            bool upCheckingSuccess = false;

            if (this.usuario.Equals(user))
                if (this.password.Equals(pwd))
                    upCheckingSuccess = true;

            return upCheckingSuccess;
        }

        public void setSesionActive(bool active)
        {
            this.activeSesion = active;
        }

        public bool isSesionActive()
        {
            return this.activeSesion;
        }
    }
}
