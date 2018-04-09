using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio4
{
    enum TipoDeAnuncio
    {
        LOCACAO,
        VENDA
    }

    // Classe anuncio
    class Anuncio
    {
        public TipoDeAnuncio tipo { get; set; }
        public Decimal preco { get; set; }
        public string anunciante { get; set; }
        public string telefone { get; set; }

        public virtual string descricaoAnuncio()
        {
            return "Um anuncio qualquer";
        }

        protected string textoInicial()
        {
            switch (tipo)
            {
                case TipoDeAnuncio.LOCACAO:
                    return "Aluga-se ";
                case TipoDeAnuncio.VENDA:
                    return "Vende-se ";
            }
            return "";
        }

        protected string textoFinal()
        {
            return $"Preço: {preco} - Contato: {anunciante} - {telefone}";
        }

    }

    // Classe anuncio de imóvel
    class AnuncioImovel : Anuncio
    {
        public string endereco { get; set; }
        public int numeroQuartos { get; set; }

        protected string textoImovel()
        {
            return $"localizada na rua {endereco} com {numeroQuartos} quartos ";
        }
    }

    // Classe casa
    class Casa : AnuncioImovel
    {
        public Decimal areaQuintal { get; set; }

        public override string descricaoAnuncio()
        {
            return textoInicial() + "casa " + textoImovel() + $"com {areaQuintal} metros quadrados de quintal. " + textoFinal();
        }

    }

    // Classe apartamento
    class Apartamento : AnuncioImovel
    {
        public int andar { get; set; }

        public override string descricaoAnuncio()
        {
            return textoInicial() + "apartamento " + textoImovel() + $"no {andar} andar. " + textoFinal();
        }
    }


    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            List<Anuncio> anuncios = new List<Anuncio>();

            Casa anuncioCasa = new Casa();
            anuncioCasa.anunciante = "José";
            anuncioCasa.telefone = "(41) 99999-9934";
            anuncioCasa.tipo = TipoDeAnuncio.LOCACAO;
            anuncioCasa.preco = 1500.00m;
            anuncioCasa.endereco = "Martin Afonso, 158 - Curitiba";
            anuncioCasa.numeroQuartos = 4;
            anuncioCasa.areaQuintal = 30.0m;

            anuncios.Add(anuncioCasa);

            Apartamento anuncioApartamento = new Apartamento();
            anuncioApartamento.tipo = TipoDeAnuncio.VENDA;
            anuncioApartamento.anunciante = "Maria";
            anuncioApartamento.telefone = "(41) 99999-9934";
            anuncioApartamento.preco = 350000.00m;
            anuncioApartamento.endereco = "Martin Afonso, 600 - Curitiba";
            anuncioApartamento.numeroQuartos = 4;
            anuncioApartamento.andar = 5;
            anuncios.Add(anuncioApartamento);

            foreach (Anuncio a in anuncios)
            {
                Console.WriteLine(a.descricaoAnuncio());
                Console.WriteLine();
            }
        }
    }
}
