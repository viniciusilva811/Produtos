using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Produtos.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricaco { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricaco)
            : base(nome, preco)
        {
            DataFabricaco = dataFabricaco;
        }

        public override string Etiqueta()
        {
            return Nome
                + " (usado) $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de fabricacao: "
                + DataFabricaco.ToString("DIA/MES/ANO")
                + ")";
        }
    }
}
