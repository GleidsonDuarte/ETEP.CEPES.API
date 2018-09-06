using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Http;
using WEBAPI.REST.Models;

namespace WEBAPI.REST.Controllers
{
    public class CadastroController : ApiController
    {
        /** Método (verbo) para cadastrar o USUÁRIO. */
        [Route("api/CadastrarUsuario")]
        [HttpPost]
        public void CadastrarUsuario([FromBody] Usuario usuario)
        {
            /** Definição da STRING de conexão com o banco de dados. */
            SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoBancoProducao"].ConnectionString);
            
            /** Definição da STRING de comando para o banco de dados. */
            string query = "INSERT INTO [dbo].[USUARIOS] (NOME, EMAIL, SENHA, RA)" +
                           "VALUES (@nome, @email, @senha, @ra);";
            try
            {
                /** Cria um objeto do tipo SqlCommand e passa para o mesmo os dados do usuário a ser cadastrado. */
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@nome", usuario.Nome);
                comando.Parameters.AddWithValue("@email", usuario.Email);
                comando.Parameters.AddWithValue("@senha", usuario.Senha);
                comando.Parameters.AddWithValue("@ra", usuario.RA);

                /** Abre uma conexao com o banco de dados */
                conexao.Open();

                /** Executa o COMANDO para salvar as informações acima no banco de dados */
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                /** Lança uma exceção genérica caso apresente algum erro. */
                throw ex;
            }
            finally
            {
                /** Encerra a conexão com o banco de dados */
                conexao.Close();
            }
        }

        /** Método (verbo) para cadastrar USUÁRIo/ESTABELECIMENTO que o usuário ficará responsável por acompanhar. */
        [Route("api/CadastrarEstabelecimento")]
        [HttpPost]
        public void CadastrarEstabelecimento([FromBody] Estabelecimento estabelecimento)
        {
            /** Definição da STRING de conexão com o banco de dados. */
            SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoBancoProducao"].ConnectionString);

            /** Definição da STRING de comando para o banco de dados. */
            string query = "INSERT INTO [dbo].[ESTABELECIMENTOS] (NOME, BAIRRO, REGIAO)" +
                           "VALUES (@nome, @bairro, @regiao);";
            try
            {
                /** Cria um objeto do tipo SqlCommand e passa para o mesmo os dados do usuário a ser cadastrado. */
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@nome", estabelecimento.Nome);
                comando.Parameters.AddWithValue("@bairro", estabelecimento.Bairro);
                comando.Parameters.AddWithValue("@regiao", estabelecimento.Regiao);

                /** Abre uma conexao com o banco de dados */
                conexao.Open();

                /** Executa o COMANDO para salvar as informações acima no banco de dados */
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                /** Lança uma exceção genérica caso apresente algum erro. */
                throw ex;
            }
            finally
            {
                /** Encerra a conexão com o banco de dados */
                conexao.Close();
            }
        }

        /** Método (verbo) para cadastrar os produtos de uma pesquisa. */
        [Route("api/CadastrarPesquisa")]
        [HttpPost]
        public void CadastrarPesquisa([FromBody] Pesquisa produto)
        {
            /** Definição da STRING de conexão com o banco de dados. */
            SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoBancoProducao"].ConnectionString);
            
            /** Definição da STRING de comando para o banco de dados. */
            string query = "INSERT INTO [dbo].[PRODUTOS] (ARROZ_MENOR," +
                                                         "ARROZ_MAIOR," +
                                                         "FEIJAO_CARIOCA_MENOR," +
                                                         "FEIJAO_CARIOCA_MAIOR," +
                                                         "FEIJAO_PRETO_MENOR," +
                                                         "FEIJAO_PRETO_MAIOR," +
                                                         "ACUCAR_MENOR," +
                                                         "ACUCAR_MAIOR," +
                                                         "SAL_MENOR," +
                                                         "SAL_MAIOR," +
                                                         "CAFE_MENOR," +
                                                         "CAFE_MAIOR," +
                                                         "FARINHA_MILHO_MENOR," +
                                                         "FARINHA_MILHO_MAIOR," +
                                                         "FARINHA_TRIGO_MENOR," +
                                                         "FARINHA_TRIGO_MAIOR," +
                                                         "FARINHA_MANDIOCA_MENOR," +
                                                         "FARINHA_MANDIOCA_MAIOR," +
                                                         "BATATA," +
                                                         "CEBOLA," +
                                                         "ALHO," +
                                                         "OVOS_BRANCOS_MENOR," +
                                                         "OVOS_BRANCOS_MAIOR," +
                                                         "MARGARINA_MENOR," +
                                                         "MARGARINA_MAIOR," +
                                                         "MOLHO_TOMATE_MENOR," +
                                                         "MOLHO_TOMATE_MAIOR," +
                                                         "EXTRATO_TOMATE_MENOR," +
                                                         "EXTRATO_TOMATE_MAIOR," +
                                                         "OLEO_SOJA_MENOR," +
                                                         "OLEO_SOJA_MAIOR," +
                                                         "LEITE_PO_MENOR," +
                                                         "LEITE_PO_MAIOR," +
                                                         "MACARRAO_MENOR," +
                                                         "MACARRA_MAIOR," +
                                                         "SARDINHA_LATA_MENOR," +
                                                         "SARDINHA_LATA_MAIOR," +
                                                         "BISCOITO_MAIZENA_MENOR," +
                                                         "BISCOITO_MAIZENA_MAIOR," +
                                                         "ACEM," +
                                                         "PICANHA," +
                                                         "BISTECA_SUINA," +
                                                         "FRANGO," +
                                                         "SALSICHA_AVULSA_MENOR," +
                                                         "SALSICHA_AVULSA_MAIOR," +
                                                         "LINGUICA_TOSCANA_MENOR," +
                                                         "LINGUICA_TOSCANA_MAIOR," +
                                                         "QUEIJO_MOZZARELA_MENOR," +
                                                         "QUEIJO_MOZZARELA_MAIOR," +
                                                         "PAO_FRANCES," +
                                                         "REFRIGERANTE," +
                                                         "SUCO_PO," +
                                                         "ACHOCOLATADO_PO," +
                                                         "LEITE_LV_MENOR," +
                                                         "LEITE_LV_MAIOR," +
                                                         "LEITE_CONDENSADO_MENOR," +
                                                         "LEITE_CONDENSADO_MAIOR," +
                                                         "CREME_LEITE_MENOR," +
                                                         "CREME_LEITE_MAIOR," +
                                                         "MAIONESE_MENOR," +
                                                         "MAIONESE_MAIOR," +
                                                         "CALDO_TEMPERADO_MENOR," +
                                                         "CALDO_TEMPERADO_MAIOR," +
                                                         "SABAO_PO_MENOR," +
                                                         "SABAO_PO_MAIOR," +
                                                         "SABAO_BARRA_MENOR," +
                                                         "SABAO_BARRA_MAIOR," +
                                                         "AGUA_SANITARIA_MENOR," +
                                                         "AGUA_SANITARIA_MAIOR," +
                                                         "DETERGENTE_LIQUIDO_MENOR," +
                                                         "DETERGENTE_LIQUIDO_MAIOR," +
                                                         "AMACIANTE_MENOR," +
                                                         "AMACIANTE_MAIOR," +
                                                         "PAPEL_HIGIENICO_SIMPLES_MENOR," +
                                                         "PAPEL_HIGIENICO_SIMPLES_MAIOR," +
                                                         "PAPEL_HIGIENICO_DUPLO_MENOR," +
                                                         "PAPEL_HIGIENICO_DUPLO_MAIOR," +
                                                         "CREME_DENTAL_MENOR," +
                                                         "CREME_DENTAL_MAIOR," +
                                                         "SABONETE_MENOR," +
                                                         "SABONETE_MAIOR," +
                                                         "SHAMPOO_MENOR," +
                                                         "SHAMPOO_MAIOR," +
                                                         "CONDICIONADOR_MENOR," +
                                                         "CONDICIONADOR_MAIOR," +
                                                         "CERVEJA_BRAHMA," +
                                                         "CERVEJA_SKOL," +
                                                         "CERVEJA_ITAIPAVA," +
                                                         "CERVEJA_BAVARIA)" +
                           "VALUES (@arrozMenor," +
                                   "@arrozMaior," +
                                   "@feijaoCariocaMenor," +
                                   "@feijaoCariocaMaior," +
                                   "@feijaoPretoMenor," +
                                   "@feijaoPretoMaior," +
                                   "@acucarMenor," +
                                   "@acucarMaior," +
                                   "@salMenor," +
                                   "@salMaior," +
                                   "@cafeMenor," +
                                   "@cafeMaior," +
                                   "@farinhaMilhoMenor," +
                                   "@farinhaMilhoMaior," +
                                   "@farinhaTrigoMenor," +
                                   "@farinhaTrigoMaior," +
                                   "@farinhaMandiocaMenor," +
                                   "@farinhaMandiocaMaior," +
                                   "@batata," +
                                   "@cebola," +
                                   "@alho," +
                                   "@ovosBrancosMenor," +
                                   "@ovosBrancosMaior," +
                                   "@margarinaMenor," +
                                   "@margarinaMaior," +
                                   "@molhoTomateMenor," +
                                   "@molhoTomateMaior," +
                                   "@extratoTomateMenor," +
                                   "@extratoTomateMaior," +
                                   "@oleoSojaMenor," +
                                   "@oleoSojaMaior," +
                                   "@leitePoMenor," +
                                   "@leitePoMaior," +
                                   "@macarraoMenor," +
                                   "@macarraoMaior," +
                                   "@sardinhaLataMenor," +
                                   "@sardinhaLataMaior," +
                                   "@biscoitoMaizenaMenor," +
                                   "@biscoitoMaizenaMaior," +
                                   "@acem," +
                                   "@picanha," +
                                   "@bistecaSuina," +
                                   "@frango," +
                                   "@salsichaAvulsaMenor," +
                                   "@salsichaAvulsaMaior," +
                                   "@linguicaToscanaMenor," +
                                   "@linguicaToscanaMaior," +
                                   "@queijoMozzarelaMenor," +
                                   "@queijoMozzarelaMaior," +
                                   "@paoFrances," +
                                   "@refrigerante," +
                                   "@sucoPo," +
                                   "@achocolatadoPo," +
                                   "@leiteLVMenor," +
                                   "@leiteLVMaior," +
                                   "@leiteCondensadoMenor," +
                                   "@leiteCondensadoMaior," +
                                   "@cremeLeiteMenor," +
                                   "@cremeLeiteMaior," +
                                   "@maioneseMenor," +
                                   "@maioneseMaior," +
                                   "@caldoTemperadoMenor," +
                                   "@caldoTemperadoMaior," +
                                   "@sabaoPoMenor," +
                                   "@sabaoPoMaior," +
                                   "@sabaoBarraMenor," +
                                   "@sabaoBarraMaior," +
                                   "@aguaSanitariaMenor," +
                                   "@aguaSanitariaMaior," +
                                   "@detergenteLiquidoMenor," +
                                   "@detergenteLiquidoMaior," +
                                   "@amacianteMenor," +
                                   "@amacianteMaior," +
                                   "@papelHigienicoSimplesMenor," +
                                   "@papelHigienicoSimplesMaior," +
                                   "@papelHigienicoDuploMenor," +
                                   "@papelHigienicoDuploMaior," +
                                   "@cremeDentalMenor," +
                                   "@cremeDentalMaior," +
                                   "@saboneteMenor," +
                                   "@saboneteMaior," +
                                   "@shampooMenor," +
                                   "@shampooMaior," +
                                   "@condicionadorMenor," +
                                   "@condicionadorMaior," +
                                   "@cervejaBrahma," +
                                   "@cervejaSkol," +
                                   "@cervejaItaipava," +
                                   "@cervejaBavaria)";
            try
            {
                /** Cria um objeto do tipo SqlCommand e passa para o mesmo os valores dos produtos da pesquisa realizada. */
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@arrozMenor", produto.ArrozMe);
                comando.Parameters.AddWithValue("@arrozMaior", produto.ArrozMa);
                comando.Parameters.AddWithValue("@feijaoCariocaMenor", produto.FeijaoCariocaMe);
                comando.Parameters.AddWithValue("@feijaoCariocaMaior", produto.FeijaoCariocaMa);
                comando.Parameters.AddWithValue("@feijaoPretoMenor", produto.FeijaoPretoMe);
                comando.Parameters.AddWithValue("@feijaoPretoMaior", produto.FeijaoPretoMa);
                comando.Parameters.AddWithValue("@acucarMenor", produto.AcucarRefinadoMe);
                comando.Parameters.AddWithValue("@acucarMaior", produto.AcucarRefinadoMa);
                comando.Parameters.AddWithValue("@salMenor", produto.SalMe);
                comando.Parameters.AddWithValue("@salMaior", produto.SalMa);
                comando.Parameters.AddWithValue("@cafeMenor", produto.CafeMe);
                comando.Parameters.AddWithValue("@cafeMaior", produto.CafeMa);
                comando.Parameters.AddWithValue("@farinhaMilhoMenor", produto.FarinhaMilhoMe);
                comando.Parameters.AddWithValue("@farinhaMilhoMaior", produto.FarinhaMilhoMa);
                comando.Parameters.AddWithValue("@farinhaTrigoMenor", produto.FarinhaTrigoMe);
                comando.Parameters.AddWithValue("@farinhaTrigoMaior", produto.FarinhaTrigoMa);
                comando.Parameters.AddWithValue("@farinhaMandiocaMenor", produto.FarinhaMandiocaMe);
                comando.Parameters.AddWithValue("@farinhaMandiocaMaior", produto.FarinhaMandiocaMa);
                comando.Parameters.AddWithValue("@batata", produto.Batata);
                comando.Parameters.AddWithValue("@cebola", produto.Cebola);
                comando.Parameters.AddWithValue("@alho", produto.Alho);
                comando.Parameters.AddWithValue("@ovosBrancosMenor", produto.OvosBrancosMe);
                comando.Parameters.AddWithValue("@ovosBrancosMaior", produto.OvosBrancosMa);
                comando.Parameters.AddWithValue("@margarinaMenor", produto.MargarinaMe);
                comando.Parameters.AddWithValue("@margarinaMaior", produto.MargarinaMa);
                comando.Parameters.AddWithValue("@molhoTomateMenor", produto.MolhoTomateMe);
                comando.Parameters.AddWithValue("@molhoTomateMaior", produto.MolhoTomateMa);
                comando.Parameters.AddWithValue("@extratoTomateMenor", produto.ExtratoTomateMe);
                comando.Parameters.AddWithValue("@extratoTomateMaior", produto.ExtratoTomateMa);
                comando.Parameters.AddWithValue("@oleoSojaMenor", produto.OleoSojaMe);
                comando.Parameters.AddWithValue("@oleoSojaMaior", produto.OleoSojaMa);
                comando.Parameters.AddWithValue("@leitePoMenor", produto.LeitePoMe);
                comando.Parameters.AddWithValue("@leitePoMaior", produto.LeitePoMa);
                comando.Parameters.AddWithValue("@macarraoMenor", produto.MacarraoMe);
                comando.Parameters.AddWithValue("@macarraoMaior", produto.MacarraoMa);
                comando.Parameters.AddWithValue("@sardinhaLataMenor", produto.SardinhaLataMe);
                comando.Parameters.AddWithValue("@sardinhaLataMaior", produto.SardinhaLataMa);
                comando.Parameters.AddWithValue("@biscoitoMaizenaMenor", produto.BiscoitoMaizenaMe);
                comando.Parameters.AddWithValue("@biscoitoMaizenaMaior", produto.BiscoitoMaizenaMa);
                comando.Parameters.AddWithValue("@acem", produto.Acem);
                comando.Parameters.AddWithValue("@picanha", produto.Picanha);
                comando.Parameters.AddWithValue("@bistecaSuina", produto.BistecaSuina);
                comando.Parameters.AddWithValue("@frango", produto.Frango);
                comando.Parameters.AddWithValue("@salsichaAvulsaMenor", produto.SalsichaAvulsaMe);
                comando.Parameters.AddWithValue("@salsichaAvulsaMaior", produto.SalsichaAvulsaMa);
                comando.Parameters.AddWithValue("@linguicaToscanaMenor", produto.LinguicaToscanaMe);
                comando.Parameters.AddWithValue("@linguicaToscanaMaior", produto.LinguicaToscanaMa);
                comando.Parameters.AddWithValue("@queijoMozzarelaMenor", produto.QueijoMozzarellaMe);
                comando.Parameters.AddWithValue("@queijoMozzarelaMaior", produto.QueijoMozzarellaMa);
                comando.Parameters.AddWithValue("@paoFrances", produto.PaoFrances);
                comando.Parameters.AddWithValue("@refrigerante", produto.Refrigerante);
                comando.Parameters.AddWithValue("@sucoPo", produto.SucoPo);
                comando.Parameters.AddWithValue("@achocolatadoPo", produto.AchocolatadoPo);
                comando.Parameters.AddWithValue("@leiteLVMenor", produto.LeiteLVMe);
                comando.Parameters.AddWithValue("@leiteLVMaior", produto.LeiteLVMa);
                comando.Parameters.AddWithValue("@leiteCondensadoMenor", produto.LeiteCondensadoMe);
                comando.Parameters.AddWithValue("@leiteCondensadoMaior", produto.LeiteCondensadoMa);
                comando.Parameters.AddWithValue("@cremeLeiteMenor", produto.CremeLeiteMe);
                comando.Parameters.AddWithValue("@cremeLeiteMaior", produto.CremeLeiteMa);
                comando.Parameters.AddWithValue("@maioneseMenor", produto.MaioneseMe);
                comando.Parameters.AddWithValue("@maioneseMaior", produto.MaioneseMa);
                comando.Parameters.AddWithValue("@caldoTemperadoMenor", produto.CaldoTemperoMe);
                comando.Parameters.AddWithValue("@caldoTemperadoMaior", produto.CaldoTemperoMa);
                comando.Parameters.AddWithValue("@sabaoPoMenor", produto.SabaoPoMe);
                comando.Parameters.AddWithValue("@sabaoPoMaior", produto.SabaoPoMa);
                comando.Parameters.AddWithValue("@sabaoBarraMenor", produto.SabaoBarraMe);
                comando.Parameters.AddWithValue("@sabaoBarraMaior", produto.SabaoBarraMa);
                comando.Parameters.AddWithValue("@aguaSanitariaMenor", produto.AguaSanitariaMe);
                comando.Parameters.AddWithValue("@aguaSanitariaMaior", produto.AguaSanitariaMa);
                comando.Parameters.AddWithValue("@detergenteLiquidoMenor", produto.DetergenteLiquidoMe);
                comando.Parameters.AddWithValue("@detergenteLiquidoMaior", produto.DetergenteLiquidoMa);
                comando.Parameters.AddWithValue("@amacianteMenor", produto.AmacianteMe);
                comando.Parameters.AddWithValue("@amacianteMaior", produto.AmacianteMa);
                comando.Parameters.AddWithValue("@papelHigienicoSimplesMenor", produto.PapelHigienicoSimplesMe);
                comando.Parameters.AddWithValue("@papelHigienicoSimplesMaior", produto.PapelHigienicoSimplesMa);
                comando.Parameters.AddWithValue("@papelHigienicoDuploMenor", produto.PapelHigienicoDuploMe);
                comando.Parameters.AddWithValue("@papelHigienicoDuploMaior", produto.PapelHigienicoDuploMa);
                comando.Parameters.AddWithValue("@cremeDentalMenor", produto.CremeDentalMe);
                comando.Parameters.AddWithValue("@cremeDentalMaior", produto.CremeDentalMa);
                comando.Parameters.AddWithValue("@saboneteMenor", produto.SaboneteMe);
                comando.Parameters.AddWithValue("@saboneteMaior", produto.SaboneteMa);
                comando.Parameters.AddWithValue("@shampooMenor", produto.ShampooMe);
                comando.Parameters.AddWithValue("@shampooMaior", produto.ShampooMa);
                comando.Parameters.AddWithValue("@condicionadorMenor", produto.CondicionadorMe);
                comando.Parameters.AddWithValue("@condicionadorMaior", produto.CondicionadorMa);
                comando.Parameters.AddWithValue("@cervejaBrahma", produto.CervejaBrahma);
                comando.Parameters.AddWithValue("@cervejaSkol", produto.CervejaSkol);
                comando.Parameters.AddWithValue("@cervejaItaipava", produto.CervejaItaipava);
                comando.Parameters.AddWithValue("@cervejaBavaria", produto.CervejaBavaria);

                /** Abre uma conexao com o banco de dados */
                conexao.Open();

                /** Executa o COMANDO para salvar as informações acima no banco de dados */
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                /** Lança uma exceção genérica caso apresente algum erro. */
                throw ex;
            }
            finally
            {
                /** Encerra a conexão com o banco de dados */
                conexao.Close();
            }
        }
    }
}