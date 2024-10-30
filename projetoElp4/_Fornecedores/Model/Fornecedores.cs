

namespace projetoElp4
{
    internal class Fornecedores : Pai
    {
        public string NomeFornecedor { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public Cidades aCidade { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Fornecedores() : base()
        {
            NomeFornecedor = string.Empty;
            Endereco = string.Empty;
            Bairro = string.Empty;
            Numero = string.Empty;
            Complemento = string.Empty;
            Cep = string.Empty;
            Telefone = string.Empty;
            Email = string.Empty;
            Cnpj = string.Empty;
            InscricaoEstadual = string.Empty;
            aCidade = new Cidades();
        }

        public Fornecedores(int codigo, string datCad, string datUltAlt, int coduso, string nomeFornecedor, string endereco, string bairro, string numero, string complemento, string cep, string telefone, string email, string cnpj, Cidades aCidade, string inscricaoEstadual) : base(codigo, datCad, datUltAlt, coduso)
        {
            this.NomeFornecedor = nomeFornecedor;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Cep = cep;
            this.Telefone = telefone;
            this.Email = email;
            this.Cnpj = cnpj;
            this.InscricaoEstadual = inscricaoEstadual;
            this.aCidade = aCidade;
        }
    }
}
