using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Produtos.Entidades
{
    class ProdutoImportado : Produto
    {
        public double CustoAlfandega { get; set; }

        public ProdutoImportado() 
        {
        }

        public ProdutoImportado(string nome, double preco, double custoAlfandega)
            : base(nome, preco)
        {
            CustoAlfandega = custoAlfandega;
        }

        public double PrecoTotal() 
        {
            return Preco + CustoAlfandega;
        }

        public override string Etiqueta() 
        {
            return Nome
                + " $ "
                + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " ( Custo da alfandega : $ "
                + CustoAlfandega.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }


}
}
