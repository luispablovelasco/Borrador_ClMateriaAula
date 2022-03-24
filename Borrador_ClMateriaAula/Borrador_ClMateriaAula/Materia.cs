using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador_ClMateriaAula
{
    class Materia : Materia_Aula
    {
        private int capacidad = 40;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }


        private string docente;

        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }

        private int matricula;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        /*
        private string grupo;

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        */

        private int uv;

        public int Uv
        {
            get { return uv; }
            set { uv = value; }
        }

        private string hinicio;

        public string Hinicio
        {
            get { return hinicio; }
            set { hinicio = value; }
        }

        private string hfinal;

        public string Hfianal
        {
            get { return hfinal; }
            set { hfinal = value; }
        }


    }
}
