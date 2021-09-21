﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Modelos
{
    public class ClienteInformation
    {
        private int _codigo;
        public int Codigo
        {
            get {return _codigo;}
            set {_codigo = value;}
        }

        private string _nome;
        public string Nome
        {
            get {return _nome;}
            set {_nome = value;}
        }

        private string _email;
        public string Email
        {
            get {return _email;}
            set {_email = value;}
        }

        private string _telefone;
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        private string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private string _uf;
        public string UF
        {
            get { return _uf; }
            set { _uf = value; }
        }
    }
}
