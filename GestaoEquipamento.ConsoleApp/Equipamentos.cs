using System;


namespace GestaoEquipamento.ConsoleApp
{
    class Equipamentos
    {
        private string nomeEquipamento;
        private double precoEquipamento;
        private string numeroSerie;
        private string fabricanteEquipamentos;
        private DateTime datasFabricacaoEquipamento;
        private int idEquipamentos;

        public Equipamentos(string nomeEquipamento, double precoEquipamento, string numeroSerie, string fabricanteEquipamentos, DateTime datasFabricacaoEquipamento, int idEquipamentos)
        {
            this.nomeEquipamento = nomeEquipamento;
            this.precoEquipamento = precoEquipamento;
            this.numeroSerie = numeroSerie;
            this.fabricanteEquipamentos = fabricanteEquipamentos;
            this.datasFabricacaoEquipamento = datasFabricacaoEquipamento;
            this.idEquipamentos = idEquipamentos;
        }

        public Equipamentos()
        {
        }
        
        public string Nome 
        {
            get { return nomeEquipamento; }
            set {  nomeEquipamento = value; }

        }

        public double Preco
        {
            get { return precoEquipamento; }
            set { precoEquipamento = value; }

        }
        public string NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }

        }

        public string Fabricante
        {
            get { return fabricanteEquipamentos; }
            set { fabricanteEquipamentos = value; }

        }

        public DateTime Data
        {
            get { return datasFabricacaoEquipamento; }
            set { datasFabricacaoEquipamento = value; }

        }

        public int Id
        {
            get { return idEquipamentos; }
            set { idEquipamentos = value; }
        }
    }
}
