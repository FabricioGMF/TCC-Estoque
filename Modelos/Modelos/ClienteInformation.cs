using System;

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

        private string _cpfcnpj;
        public string CPFCNPJ
        {
            get { return _cpfcnpj; }
            set { _cpfcnpj = value; }
        }

        private string _rg;
        public string RG
        {
            get { return _rg; }
            set { _rg = value; }
        }

        private string _logradouro;
        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        private string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
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

        private string _cep;
        public string CEP
        {
            get { return _cep; }
            set { _cep = value; }
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

        private string _telefone2;
        public string Telefone2
        {
            get { return _telefone2; }
            set { _telefone2 = value; }
        }

        private DateTime _datacadastro;
        public DateTime DataCadastro
        {
            get { return _datacadastro; }
            set { _datacadastro = value; }
        }
    }
}
