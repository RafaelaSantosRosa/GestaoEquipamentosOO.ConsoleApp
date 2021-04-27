using System;


namespace GestaoEquipamento.ConsoleApp
{
    class Chamados
    {
        private string titulo;
        private string descricao;
        private int idChamado;
        private DateTime dataAbertura;

        public Chamados(string titulo, string descricao, int idChamado, DateTime dataAbertura)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.idChamado = idChamado;
            this.dataAbertura = dataAbertura;
        }
        public Chamados()
        {
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int Id
        {
            get { return idChamado; }
            set { idChamado = value; }
        }

        public DateTime DataAbertura
        {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }
    }
}
