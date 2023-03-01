using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2_HelenaMadrenysPlanas
{
    class Alumne
    {
        //Atributs
        private string nom, cognom, email, foto;

        //Constructor
        public Alumne(string _nom, string _cognom, string _email, string _foto)
        {
            nom = _nom;
            cognom = _cognom;
            email = _email;
            foto = _foto;
        }

        //Gets i Sets
        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
            }
        }

        public string Cognom
        {
            get { return cognom; }
            set
            {
                cognom = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public string Foto
        {
            get { return foto; }
            set
            {
                foto = value;
            }
        }
    }
}
