using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPI.REST.Models
{
    public class Pesquisa
    {
        /// <summary>
        /// Adiciona um número para IDentificação da pesquisa salva no banco de dados
        /// </summary>
        public int IdPesquisa { get; set; }
        /// <summary>
        /// Arroz 5Kg Tipo 1 - Menor Preço 
        /// </summary>
        public decimal ArrozMe { get; set; }
        /// <summary>
        /// Arroz 5Kg Tipo 1 - Maior Preço 
        /// </summary>
        public decimal ArrozMa { get; set; }
        /// <summary>
        /// Feijão Carioca 1Kg - Menor Preço 
        /// </summary>
        public decimal FeijaoCariocaMe { get; set; }
        /// <summary>
        /// Feijão Carioca 1Kg - Maior Preço 
        /// </summary>
        public decimal FeijaoCariocaMa { get; set; }
        /// <summary>
        /// Feijão Preto 1Kg - Menor Preço 
        /// </summary>
        public decimal FeijaoPretoMe { get; set; }
        /// <summary>
        /// Feijão Preto 1Kg - Maior Preço 
        /// </summary>
        public decimal FeijaoPretoMa { get; set; }
        /// <summary>
        /// Açucar Refinado 1Kg - Menor Preço
        /// </summary>
        public decimal AcucarRefinadoMe { get; set; }
        /// <summary>
        /// Açucar Refinado 1Kg - Maior Preço
        /// </summary>
        public decimal AcucarRefinadoMa { get; set; }
        /// <summary>
        /// Sal 1Kg - Menor Preço
        /// </summary>
        public decimal SalMe { get; set; }
        /// <summary>
        /// Sal 1Kg - Maior Preço
        /// </summary>
        public decimal SalMa { get; set; }
        /// <summary>
        /// Café em Pó 500g - Menor Preço
        /// </summary>
        public decimal CafeMe { get; set; }
        /// <summary>
        /// Café em Pó 500g - Maior Preço
        /// </summary>
        public decimal CafeMa { get; set; }
        /// <summary>
        /// Farinha de Milhor (Fubá) Refinada 1Kg - Menor Preço
        /// </summary>
        public decimal FarinhaMilhoMe { get; set; }
        /// <summary>
        /// Farinha de Milhor (Fubá) Refinada 1Kg - Maior Preço
        /// </summary>
        public decimal FarinhaMilhoMa { get; set; }
        /// <summary>
        /// Farinha de Trigo 1Kg - Menor Preço
        /// </summary>
        public decimal FarinhaTrigoMe { get; set; }
        /// <summary>
        /// Farinha de Trigo 1Kg - Maior Preço
        /// </summary>
        public decimal FarinhaTrigoMa { get; set; }
        /// <summary>
        /// Farinha de Mandioca Torrada 500g - Menor Preço
        /// </summary>
        public decimal FarinhaMandiocaMe { get; set; }
        /// <summary>
        /// Farinha de Mandioca Torrada 500g - Maior Preço
        /// </summary>
        public decimal FarinhaMandiocaMa { get; set; }
        /// <summary>
        /// Batata lavada 1Kg
        /// </summary>
        public decimal Batata { get; set; }
        /// <summary>
        /// Cebola 1Kg
        /// </summary>
        public decimal Cebola { get; set; }
        /// <summary>
        /// Alho 1Kg
        /// </summary>
        public decimal Alho { get; set; }
        /// <summary>
        /// Ovos Brancos 12 - Menor Preço
        /// </summary>
        public decimal OvosBrancosMe { get; set; }
        /// <summary>
        /// Ovos Brancos 12 - Maior Preço
        /// </summary>
        public decimal OvosBrancosMa { get; set; }
        /// <summary>
        /// Margarina 500g - Menor Preço
        /// </summary>
        public decimal MargarinaMe { get; set; }
        /// <summary>
        /// Margarina 500g - Maior Preço
        /// </summary>
        public decimal MargarinaMa { get; set; }
        /// <summary>
        /// Molho de Tomate 340g - Menor Preço
        /// </summary>
        public decimal MolhoTomateMe { get; set; }
        /// <summary>
        /// Molho de Tomate 340g - Maior Preço
        /// </summary>
        public decimal MolhoTomateMa { get; set; }
        /// <summary>
        /// Extrato de Tomate 340-370g - Menor Preço
        /// </summary>
        public decimal ExtratoTomateMe { get; set; }
        /// <summary>
        /// Extrato de Tomate 340-370g - Maior Preço
        /// </summary>
        public decimal ExtratoTomateMa { get; set; }
        /// <summary>
        /// Óleo de Soja 900mL - Menor Preço
        /// </summary>
        public decimal OleoSojaMe { get; set; }
        /// <summary>
        /// Óleo de Soja 900mL - Maior Preço
        /// </summary>
        public decimal OleoSojaMa { get; set; }
        /// <summary>
        /// Leite em Pó 400g - Menor Preço
        /// </summary>
        public decimal LeitePoMe { get; set; }
        /// <summary>
        /// Leite em Pó 400g - Maior Preço
        /// </summary>
        public decimal LeitePoMa { get; set; }
        /// <summary>
        /// Macarrão com Ovos 500g - Menor Preço
        /// </summary>
        public decimal MacarraoMe { get; set; }
        /// <summary>
        /// Macarrão com Ovos 500g - Maior Preço
        /// </summary>
        public decimal MacarraoMa { get; set; }
        /// <summary>
        /// Sardinha em Conserva 125-130g - Menor Preço
        /// </summary>
        public decimal SardinhaLataMe { get; set; }
        /// <summary>
        /// Sardinha em Conserva 125-130g - Maior Preço
        /// </summary>
        public decimal SardinhaLataMa { get; set; }
        /// <summary>
        /// Biscoito Maizena 200g - Menor Preço
        /// </summary>
        public decimal BiscoitoMaizenaMe { get; set; }
        /// <summary>
        /// Biscoito Maizena 200g - Maior Preço
        /// </summary>
        public decimal BiscoitoMaizenaMa { get; set; }
        /// <summary>
        /// Acém sem Osso 1Kg
        /// </summary>
        public decimal Acem { get; set; }
        /// <summary>
        /// Picanha 1Kg
        /// </summary>
        public decimal Picanha { get; set; }
        /// <summary>
        /// Bisteca Suína 1Kg
        /// </summary>
        public decimal BistecaSuina { get; set; }
        /// <summary>
        /// Frango Resfriado decimaleiro 1Kg
        /// </summary>
        public decimal Frango { get; set; }
        /// <summary>
        /// Salsicha Avulsa 1Kg - Menor Preço
        /// </summary>
        public decimal SalsichaAvulsaMe { get; set; }
        /// <summary>
        /// Salsicha Avulsa 1Kg - Maior Preço
        /// </summary>
        public decimal SalsichaAvulsaMa { get; set; }
        /// <summary>
        /// Linguiça Toscana Fresca 1Kg - Menor Preço
        /// </summary>
        public decimal LinguicaToscanaMe { get; set; }
        /// <summary>
        /// Linguiça Toscana Fresca 1Kg - Maior Preço
        /// </summary>
        public decimal LinguicaToscanaMa { get; set; }
        /// <summary>
        /// Queijo Mozzarella Fatiado 1Kg - Menor Preço
        /// </summary>
        public decimal QueijoMozzarellaMe { get; set; }
        /// <summary>
        /// Queijo Mozzarella Fatiado 1Kg - Maior Preço
        /// </summary>
        public decimal QueijoMozzarellaMa { get; set; }
        /// <summary>
        /// Pão Francês 1Kg
        /// </summary>
        public decimal PaoFrances { get; set; }
        /// <summary>
        /// Refrigerante Coca-Cola 2L
        /// </summary>
        public decimal Refrigerante { get; set; }
        /// <summary>
        /// Suco em Pó Tang 30g
        /// </summary>
        public decimal SucoPo { get; set; }
        /// <summary>
        /// Achocolatado em Pó Nescau 400g
        /// </summary>
        public decimal AchocolatadoPo { get; set; }
        /// <summary>
        /// Leite Longa Vida 1L - Menor Preço
        /// </summary>
        public decimal LeiteLVMe { get; set; }
        /// <summary>
        /// Leite Longa Vida 1L - Maior Preço
        /// </summary>
        public decimal LeiteLVMa { get; set; }
        /// <summary>
        /// Leite Condensado 395g - Menor Preço
        /// </summary>
        public decimal LeiteCondensadoMe { get; set; }
        /// <summary>
        /// Leite Condensado 395g - Maior Preço
        /// </summary>
        public decimal LeiteCondensadoMa { get; set; }
        /// <summary>
        /// Creme de Leite 200g - Menor Preço
        /// </summary>
        public decimal CremeLeiteMe { get; set; }
        /// <summary>
        /// Creme de Leite 200g - Maior Preço
        /// </summary>
        public decimal CremeLeiteMa { get; set; }
        /// <summary>
        /// Maionese 500g - Menor Preço
        /// </summary>
        public decimal MaioneseMe { get; set; }
        /// <summary>
        /// Maionese 500g - Maior Preço
        /// </summary>
        public decimal MaioneseMa { get; set; }
        /// <summary>
        /// Caldo de Tempero 60-90g - Menor Preço
        /// </summary>
        public decimal CaldoTemperoMe { get; set; }
        /// <summary>
        /// Caldo de Tempero 60-90g - Maior Preço
        /// </summary>
        public decimal CaldoTemperoMa { get; set; }
        /// <summary>
        /// Sabão em Pó 1Kg - Menor Preço
        /// </summary>
        public decimal SabaoPoMe { get; set; }
        /// <summary>
        /// Sabão em Pó 1Kg - Maior Preço
        /// </summary>
        public decimal SabaoPoMa { get; set; }
        /// <summary>
        /// Sabão em Barra 5 Unidade 1Kg - Menor Preço
        /// </summary>
        public decimal SabaoBarraMe { get; set; }
        /// <summary>
        /// Sabão em Barra 5 Unidade 1Kg - Maior Preço
        /// </summary>
        public decimal SabaoBarraMa { get; set; }
        /// <summary>
        /// Água Sanitária 1L - Menor Preço
        /// </summary>
        public decimal AguaSanitariaMe { get; set; }
        /// <summary>
        /// Água Sanitária 1L - Maior Preço
        /// </summary>
        public decimal AguaSanitariaMa { get; set; }
        /// <summary>
        /// Detergente Líquido 500mL - Menor Preço
        /// </summary>
        public decimal DetergenteLiquidoMe { get; set; }
        /// <summary>
        /// Detergente Líquido 500mL - Maior Preço
        /// </summary>
        public decimal DetergenteLiquidoMa { get; set; }
        /// <summary>
        /// Amaciante 2L - Menor Preço
        /// </summary>
        public decimal AmacianteMe { get; set; }
        /// <summary>
        /// Amaciante 2L - Maior Preço
        /// </summary>
        public decimal AmacianteMa { get; set; }
        /// <summary>
        /// Papel Higiênico Folha Simples - Menor Preço
        /// </summary>
        public decimal PapelHigienicoSimplesMe { get; set; }
        /// <summary>
        /// Papel Higiênico Folha Simples - Maior Preço
        /// </summary>
        public decimal PapelHigienicoSimplesMa { get; set; }
        /// <summary>
        /// Papel Higiênico Folha Dupla - Menor Preço
        /// </summary>
        public decimal PapelHigienicoDuploMe { get; set; }
        /// <summary>
        /// Papel Higiênico Folha Dupla - Maior Preço
        /// </summary>
        public decimal PapelHigienicoDuploMa { get; set; }
        /// <summary>
        /// Creme Dental 90g - Menor Preço
        /// </summary>
        public decimal CremeDentalMe { get; set; }
        /// <summary>
        /// Creme Dental 90g - Maior Preço
        /// </summary>
        public decimal CremeDentalMa { get; set; }
        /// <summary>
        /// Sabonete 90-100g - Menor Preço
        /// </summary>
        public decimal SaboneteMe { get; set; }
        /// <summary>
        /// Sabonete 90-100g - Maior Preço
        /// </summary>
        public decimal SaboneteMa { get; set; }
        /// <summary>
        /// Shampoo 350-450mL - Menor Preço
        /// </summary>
        public decimal ShampooMe { get; set; }
        /// <summary>
        /// Shampoo 350-450mL - Maior Preço
        /// </summary>
        public decimal ShampooMa { get; set; }
        /// <summary>
        /// Condicionador 350-450mL - Menor Preço
        /// </summary>
        public decimal CondicionadorMe { get; set; }
        /// <summary>
        /// Condicionador 350-450mL - Maior Preço
        /// </summary>
        public decimal CondicionadorMa { get; set; }
        /// <summary>
        /// Cerveja Brahma 350mL - 12 Latas
        /// </summary>
        public decimal CervejaBrahma { get; set; }
        /// <summary>
        /// Cerveja Skol 350mL - 12 Latas
        /// </summary>
        public decimal CervejaSkol { get; set; }
        /// <summary>
        /// Cerveja Itaipava 350mL - 12 Latas
        /// </summary>
        public decimal CervejaItaipava { get; set; }
        /// <summary>
        /// Cerveja Bavária 350mL - 12 Latas
        /// </summary>
        public decimal CervejaBavaria { get; set; }
    }
}