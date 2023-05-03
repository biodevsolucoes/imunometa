using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ImunoMeta.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class VacinaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Noticia",
                keyColumn: "Id",
                keyValue: new Guid("451f57c1-762d-4de0-8163-253bff491b06"));

            migrationBuilder.DeleteData(
                table: "Noticia",
                keyColumn: "Id",
                keyValue: new Guid("d02c4eb3-d71f-4975-9ec0-c3bcfccc4711"));

            migrationBuilder.DeleteData(
                table: "Noticia",
                keyColumn: "Id",
                keyValue: new Guid("d1320621-7d2e-4b85-a48b-7044ac4ee8a5"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("0b5165ae-3db2-493b-a4d4-e2ff86cfcf96"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("12d2612b-a6fd-4e60-88ff-895c84fdd7bb"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("212aa4d9-5b25-4ed8-8815-1e010e646eee"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("2ab60576-c248-48dc-a1f4-63bc76859e8b"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("328b6faa-d763-484b-b6b6-b93111acb77e"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("33d91ed2-44cb-4ec6-bc21-059fdeab45bc"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("395a4bd7-a97e-4c25-a815-c7fae9c2b1ba"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("40cfc63f-d882-42f1-92c0-fcfac0c41dda"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("633ed756-0077-4e89-b0e2-af1e32f4a21e"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("75391d30-93e3-4644-829a-452e8f1252eb"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("9351ec15-db86-43c0-834e-91fdf066920e"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("9957c911-e29b-4aa0-ba86-126d2eb36dc7"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("aab3ac2b-4939-4bb5-b511-bfd1c85c139b"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("b038da73-fa1c-4f20-995b-3e8e96395274"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("c9d947d0-c953-4b54-9b36-da2f852b7237"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("ce0891fc-51af-4a01-bcfb-de563e908af1"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("d286c7d3-1c26-4d3e-9e4e-92b4bc3d6963"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("e9fcdb2c-f870-41e8-8564-648845376aca"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("f0b63d2d-d84b-4d2c-a9e4-172d8684d241"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("fde638f2-47a9-4c7a-b465-930347c23c34"));

            migrationBuilder.DeleteData(
                table: "TipoPontuacao",
                keyColumn: "Id",
                keyValue: new Guid("293209f9-4ef8-4670-8fba-91183dcce9ff"));

            migrationBuilder.DeleteData(
                table: "TipoPontuacao",
                keyColumn: "Id",
                keyValue: new Guid("5f6c35fb-8d60-4107-8071-ee7c08ea4a12"));

            migrationBuilder.DeleteData(
                table: "TipoPontuacao",
                keyColumn: "Id",
                keyValue: new Guid("61b5897f-469b-476c-90e9-c854cc544636"));

            migrationBuilder.InsertData(
                table: "Noticia",
                columns: new[] { "Id", "Resumo", "Texto", "Titulo", "UrlImagemCapa" },
                values: new object[,]
                {
                    { new Guid("0fb75976-7321-4578-b779-752f4b65f507"), "Nesta etapa, poderão receber o imunizante profissionais de saúde, trabalhadores do sistema prisional, pessoas com deficiência e população privada de liberdade", "A Secretaria de Saúde do Distrito Federal inicia nesta quarta-feira (22) a imunização de profissionais de saúde, trabalhadores prisionais, população privada de liberdade e pessoas com deficiência permanente com a versão bivalente da vacina contra a covid-19. O imunizante estará disponível em mais de 90 locais com atendimento das 8h às 17h.", "DF inicia vacinação bivalente contra a covid-19 para novos grupos", "https://www.saude.df.gov.br/image/journal/article?img_id=3019334" },
                    { new Guid("53a83cad-7ff0-4e3e-a0cc-163dae4cce6c"), "Secretaria nomeia novos profissionais e abre leitos de UTI e de enfermaria pediátrica, além de capacitar equipes para atender ao público infantil", "A chegada do outono e do inverno nos meses de março a junho ocasiona a propagação de vírus que causam doenças respiratórias, majoritariamente, entre as crianças – em especial naquelas de até dois anos de idade, cujo sistema imunológico não é tão fortalecido.", "Saúde reforça serviços de atendimento às crianças", "https://www.saude.df.gov.br/image/journal/article?img_id=3019298" },
                    { new Guid("c30a49a8-4c66-4b95-b63e-0c24e5b00fcb"), "Palestra em unidade de saúde de Sobradinho busca tornar o atendimento a vítimas mais empático e aprofundar temas sensíveis, como traumas e agressões sexuais", "Atendimento ainda mais empático. Esse foi um dos objetivos da palestra Violência sexual e compreensão das reações das vítimas realizada nessa segunda-feira (20), no Hospital Regional de Sobradinho (HRS). A iniciativa visa capacitar a rede que atua no acolhimento de casos de violência, incluindo profissionais da saúde e servidores da rede-adjunta, como educação, órgãos da justiça e conselhos tutelares.", "Hospital capacita servidores para acolher pessoas em situação de violência", "https://www.saude.df.gov.br/image/journal/article?img_id=3019264" }
                });

            migrationBuilder.InsertData(
                table: "PontoVacinacao",
                columns: new[] { "Id", "Cidade", "Endereco", "Latitude", "Longitude", "Nome", "UF", "UsuarioId", "UsuarioId1" },
                values: new object[,]
                {
                    { new Guid("011de263-2ea3-41f2-bbb9-62dfe88d1560"), "Sobradinho", "Quadra 3 Área Especial Conjuntos D/E", 0.0, 0.0, "UBS 2 Sobradinho", "DF", null, null },
                    { new Guid("057d4c17-c940-4e49-b4f7-f1b030f043a7"), "Brasília", "QI 3", -15.725453043781098, -47.873853836999871, "UBS 1 Lago Norte", "DF", null, null },
                    { new Guid("32fa6133-07b6-4808-9b20-3c9eda200eb7"), "Brasília", "Setor Escolar Lote 04 - Cruzeiro Velho", 0.0, 0.0, "UBS 2 Cruzeiro", "DF", null, null },
                    { new Guid("345660eb-3f29-4f6a-a730-97e42b8dc8e1"), "Sobradinho", "Condomínio Mini-Chácaras, QMS 16 Rua 14 Casa 01 – Sobradinho II", 0.0, 0.0, "UBS 5 Sobradinho II", "DF", null, null },
                    { new Guid("3565a0a8-dddd-4d3e-9e81-fceaf0813aef"), "Brasília", "QS 514/515 – W3 Sul ", 0.0, 0.0, "Policlínica 514 Sul", "DF", null, null },
                    { new Guid("4aa86664-5972-42f1-8491-2f18c58b6baf"), "Sobradinho", "Quadra 5, Área Especial A, nº 1. Vila Buritizinho", -47.828150520004122, -15.65127289695881, "UBS 7 Sobradinho II – Vila Buritizinho", "DF", null, null },
                    { new Guid("5c48e0b1-063a-446e-8a10-cc72a09b2cd4"), "Sobradinho", "Condomínio Vale dos Pinheiros, Quadra 45 A, Conjunto A, Lote 56, Sobradinho II", 0.0, 0.0, "UBS 3 Sobradinho II", "DF", null, null },
                    { new Guid("6d5be054-beee-41f5-8990-d8bb341c84e5"), "Brasília", "EQN 114/115", 0.0, 0.0, "UBS 2 Asa Norte", "DF", null, null },
                    { new Guid("73013701-dc2b-4508-9f4c-e8339d7ebdf4"), "Sobradinho", "Quadra 14 Área Especial 22/23", 0.0, 0.0, "UBS 1 Sobradinho", "DF", null, null },
                    { new Guid("76bc2488-a2e1-4f40-b59f-2ab7bcd1fffe"), "Sobradinho", "Rodovia DF 420, Complexo de Saúde, Setor de Mansões, ao lado da UPA Sobradinho", 0.0, 0.0, "UBS 1 Sobradinho II", "DF", null, null },
                    { new Guid("7ff1b674-b849-4eb3-a3cf-97fcaee6930a"), "Brasília", "SHCES 601 - Lote 01 - Cruzeiro Novo", 0.0, 0.0, "UBS 1 Cruzeiro", "DF", null, null },
                    { new Guid("804abaa7-5b45-4fe6-b1a9-878079f75d59"), "Brasília", "Vila Varjão Quadra 5 Conjunto A Lote 17", 0.0, 0.0, "UBS 1 Varjão", "DF", null, null },
                    { new Guid("8be7b68c-aa00-458c-bc26-efb6b9b920b0"), "Brasília", "SGAN 905", 0.0, 0.0, "UBS 1 Asa Norte", "DF", null, null },
                    { new Guid("939bd4f4-08d1-4ee8-a227-9d30b96ad2e5"), "Brasília", "SHIS QI 21 – Área Especial/23 – AE LT E – Lago Sul", 0.0, 0.0, "Policlínica do Lago Sul", "DF", null, null },
                    { new Guid("ab0d7f3e-8091-4169-b720-daee6e130c23"), "Sobradinho", "Condomínio Vale das Acácias, Quadra 12, Lote 01, Sobradinho II", 0.0, 0.0, "UBS 6 Sobradinho II", "DF", null, null },
                    { new Guid("c74a0d3b-31bd-4375-a268-fece8b1ce935"), "Sobradinho", "DF 001 KM 120 Rua 08 Chácara 187 Lago Oeste, Sobradinho", 0.0, 0.0, "UBS 6 Sobradinho - Lago Oeste", "DF", null, null },
                    { new Guid("daaa47cf-5cc2-466b-92a2-0618ff52b594"), "Sobradinho", "Área Especial – Novo Setor de Mansões Nova Colina", -47.75527347168611, -15.64796549335305, "UBS 3 Sobradinho – Nova Colina", "DF", null, null },
                    { new Guid("ed5fca6d-a6b8-4a10-a311-898d507d9715"), "Brasília", "Rua Piau – Acampamento Pacheco", 0.0, 0.0, "UBS 3 Vila Planalto", "DF", null, null },
                    { new Guid("f35080ac-2d01-4658-b658-bcafbcb0020c"), "Sobradinho", "DF 150 Km 12 Quadra 10 Casa 14 ", 0.0, 0.0, "UBS 1 Fercal", "DF", null, null },
                    { new Guid("fc901dfc-55d2-4346-87e5-adafc8d82303"), "Sobradinho", "Área Especial 01, Lote 01, Associação de Moradores, Vila BASEVI", 0.0, 0.0, "UBS 5 Sobradinho - Basevi", "DF", null, null }
                });

            migrationBuilder.InsertData(
                table: "TipoPontuacao",
                columns: new[] { "Id", "Descricao", "Valor" },
                values: new object[,]
                {
                    { new Guid("33ba1010-adc4-4d57-822d-627acf7a9e08"), "Vacinas", (short)10 },
                    { new Guid("894f442d-07fc-4c36-99c7-3f74dfdd7db8"), "Compartilhar", (short)25 },
                    { new Guid("e508ba2e-d41f-44ef-a0b4-9783a17bfd6a"), "Denuncia", (short)50 }
                });

            migrationBuilder.InsertData(
                table: "Vacina",
                columns: new[] { "Id", "CssClass", "Descricao", "Nome", "UsuarioId" },
                values: new object[,]
                {
                    { new Guid("0f688e05-d401-42ac-a925-13eb218d70cb"), "bg-warning", "Previne as meningites e as doenças meningocócicas causadas pela bactéria meningococo dos tipos A, C, W e Y. Meningite meningocócica é uma forma grave de meningite bacteriana, altamente contagiosa, causada pela bactéria Neisseria meningitidis, também conhecida como meningococo.", "dMenigocócica ACWY", null },
                    { new Guid("1248fa30-5042-4049-8e72-fad3e152b7cf"), "bg-dark", "A hepatite B é uma doença que provoca mal-estar, febre, dor de cabeça, cansaço, dor no abdômen, náuseas e vômitos. Na sua forma mais grave, pode causar infecções e até tumores no fígado. A vacina que previne contra a hepatite B deve ser aplicada ainda nas primeiras horas após o nascimento, fornecendo uma proteção entre 80 e 100%. É aplicada com uma injeção e as doses de reforço estão presentes na vacina pentavalente, que também protege contra tétano, coqueluche, difteria e meningite, causada pela Haemophilus influenza tipo B.", "Hepatite B", null },
                    { new Guid("270eb4ea-f727-40bf-9add-c1d914da5889"), "bg-secondary", "A vacina é composta pelo oligossacarídeo meningocócico C conjugado com a proteína CRM197 e não possui o micro-organismo causador da doença, o que a torna mais segura. É indicada para imunização ativa de crianças a partir de 2 meses de idade, adolescentes e adultos para a prevenção da doença invasiva causada por Neisseria meningitidis do sorogrupo C. Esta bactéria pode causar infecções graves, às vezes fatais, como a meningite e a sepse (infecção grave no sangue – infecção generalizada).", "Meningocócica C (conjugada)", null },
                    { new Guid("316d7af5-be61-4790-829a-60bbcdc1ed09"), "bg-warning", "É uma doença de notificação compulsória imediata, ou seja, todo evento suspeito (tanto morte de primatas não humanos, quanto casos humanos com sintomatologia compatível) deve ser prontamente comunicado, em até 24 horas após a suspeita inicial, às autoridades locais competentes pela via mais rápida (telefone, fax, email, etc). Às autoridades estaduais de saúde cabe notificar os eventos de febre amarela suspeitos ao Ministério da Saúde. Atualmente, a febre amarela silvestre (FA) é uma doença endêmica no Brasil (região amazônica). ", "Febre amarela", null },
                    { new Guid("605d534a-7a92-4eac-b02f-e47b50fb1126"), "bg-secondary", "A vacina BCG protege contra a tuberculose – doença contagiosa, provocada pela bactéria Mycobacterium tuberculosis. Foi criada em 1.921 por Léon Calmette e Alphonse Guérin, dando origem ao nome BCG.", "BCG", null },
                    { new Guid("609bb9e1-c085-49f6-9d9c-61b32fe031d3"), "bg-success", "A vacina é indicada para prevenir contra a poliomielite causada por vírus dos tipos 1, 2 e 3.", "Vacina Inativada Poliomielite (VIP)", null },
                    { new Guid("82192a6b-8f8a-404e-b38a-52b2b7e9b17d"), "bg-info", "É uma infecção causada pelo vírus A (HAV) da hepatite, também conhecida como “hepatite infecciosa”. Na maioria dos casos, a hepatite A é uma doença de caráter benigno, contudo o curso sintomático e a letalidade aumentam com a idade.", "Hepatite A", null },
                    { new Guid("98866d5d-6aed-4419-b83b-47edde60d095"), "bg-warning", "A vacina pentavalente é a combinação de cinco vacinas individuais em uma. O objetivo é proteger as pessoas contra múltiplas doenças ao mesmo tempo. Desde 2012, o Programa Nacional de Imunizações (PNI), do Ministério da Saúde, oferta a vacina pentavalente na rotina do Calendário Nacional de Vacinação.", "Penta (DTP/Hib/Hep. B)", null },
                    { new Guid("9beeb99b-99dc-4460-9e4d-08864199b4df"), "bg-primary", "Proteção contra o tétano acidental e a difteria.\r\nA difteriadifteriadifteriadifteriadifteria é causada por um bacilo, produtor de uma toxina\r\n(substância tóxica), que atinge as amídalas, a faringe, o nariz e a\r\npele, onde provoca placas branco-acinzentadas. É transmitida, por\r\nmeio de tosse ou espirro, de uma pessoa contaminada para outra.\r\nO tétanotétanotétanotétanotétano é uma infecção, causada por uma toxina (substância tóxica)\r\nproduzida pelo bacilo tetânico, que entra no organismo por meio de\r\nferimentos ou lesões na pele (tétano acidental) ou pelo coto do cordão\r\numbilical (tétano neonatal ou mal dos sete dias) e atinge o sistema\r\nnervoso central. Caracteriza-se por contrações e espasmos,\r\ndificuldade em engolir e rigidez no pescoço.", "dT (dupla adulto)", null },
                    { new Guid("a97d6bcc-a7d9-4dd9-b479-60b8e9e92f95"), "bg-secondary", "A vacina DTP (tríplice bacteriana), previne contra doenças como difteria, tétano e coqueluche, e é destinada a crianças entre 15 meses e quatro anos de idade como uma forma de reforço para as que já tenham se vacinado com a pentavalente.", "DTP (tríplice bacteriana)", null },
                    { new Guid("aaaf3e44-fee6-4ce0-8a50-e05ad0728d8d"), "bg-secondary", "A vacina contra sarampo, caxumba, rubéola e varicela, também conhecida como tetra viral ou tetravalente viral é indicada para a vacinação de crianças com 15 meses de idade que já tenham recebido a primeira dose da vacina tríplice viral.", "Varicela", null },
                    { new Guid("b95ef933-8714-49b2-bd50-696e4c439fab"), "bg-light border", "A vacina é indicada para prevenir contra a poliomielite causada por vírus dos tipos 1, 2 e 3.", "Vacina Oral Poliomielite (VOP)", null },
                    { new Guid("c50a9723-8e62-45af-9d29-9fbcbd94d6e9"), "bg-danger", "No Sistema Único de Saúde (SUS), a vacina previne o sarampo, a caxumba e a rubéola. No Calendário Nacional de Vacinação, o imunizante está disponível para pessoas de 12 meses a 59 anos de idade, sendo recomendadas duas doses até 29 anos e uma dose de 30 a 59 anos, em pessoas não vacinadas. A vacinação é a forma mais eficaz de prevenção contra o sarampo e o objetivo é interromper a circulação do vírus e reduzir complicações e o número de óbitos pela doença.", "Tríplice viral", null },
                    { new Guid("da2ca772-6611-40d6-8a72-d73894293bfa"), "bg-secondary", "AO imunizante que previne contra o rotavírus humano é a vacina VRH/VORH. A aplicação acontece com uma gotinha na boca dos bebês, a partir da sexta semana de vida, para proteger contra infecções provocadas pelo rotavírus, como a diarreia, uma das principais causas de problemas estomacais nas crianças.", "Vacina Rotavírus Humano (VRH)", null },
                    { new Guid("f125c4a0-b01d-4cc7-8f46-b5682a1be921"), "bg-danger", "A vacina contra sarampo, caxumba, rubéola e varicela, também conhecida como tetra viral ou tetravalente viral é indicada para a vacinação de crianças com 15 meses de idade que já tenham recebido a primeira dose da vacina tríplice viral.", "Tetraviral", null },
                    { new Guid("f8ffd6bd-3a53-4e26-a05c-a1e4c9cac739"), "bg-info", "A vacina dTpa é uma associação de toxóide diftérico, toxóide tetânico e\r\ncomponentes purificados dos antígenos da Bordetella pertussis – toxina\r\npertussis, tendo o hidróxido e o fosfato de alumínio como adjuvante.", "dTpa (DTP adulto)", null },
                    { new Guid("fc3696ab-288f-4796-8760-e65b9b6cefaf"), "bg-danger", "O Ministério da Saúde recomenda a vacinação de todas as crianças menores de cinco anos de acordo com o Calendário Nacional de Vacinação. A imunização com as doses recomendadas é fundamental para evitar o adoecimento, além de complicações e óbitos.", "Pneumocócica 10 valente", null },
                    { new Guid("fcb93b24-3eee-40e4-b586-b350616f2afe"), "bg-dark text-white", "Segundo a Organização Mundial de Saúde (OMS), estima-se que haja de 9 a 10 milhões de infectados por esse vírus no Brasil e que a cada ano surjam 700 mil novos casos de infecção. O risco de desenvolvimento de cânceres associados ao HPV é cerca de quatro vezes maior entre pessoas vivendo com HIV/Aids e transplantados do que na população sem a doença ou transplante.", "HPV quadrivalente", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Noticia",
                keyColumn: "Id",
                keyValue: new Guid("0fb75976-7321-4578-b779-752f4b65f507"));

            migrationBuilder.DeleteData(
                table: "Noticia",
                keyColumn: "Id",
                keyValue: new Guid("53a83cad-7ff0-4e3e-a0cc-163dae4cce6c"));

            migrationBuilder.DeleteData(
                table: "Noticia",
                keyColumn: "Id",
                keyValue: new Guid("c30a49a8-4c66-4b95-b63e-0c24e5b00fcb"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("011de263-2ea3-41f2-bbb9-62dfe88d1560"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("057d4c17-c940-4e49-b4f7-f1b030f043a7"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("32fa6133-07b6-4808-9b20-3c9eda200eb7"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("345660eb-3f29-4f6a-a730-97e42b8dc8e1"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("3565a0a8-dddd-4d3e-9e81-fceaf0813aef"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("4aa86664-5972-42f1-8491-2f18c58b6baf"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("5c48e0b1-063a-446e-8a10-cc72a09b2cd4"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("6d5be054-beee-41f5-8990-d8bb341c84e5"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("73013701-dc2b-4508-9f4c-e8339d7ebdf4"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("76bc2488-a2e1-4f40-b59f-2ab7bcd1fffe"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("7ff1b674-b849-4eb3-a3cf-97fcaee6930a"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("804abaa7-5b45-4fe6-b1a9-878079f75d59"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("8be7b68c-aa00-458c-bc26-efb6b9b920b0"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("939bd4f4-08d1-4ee8-a227-9d30b96ad2e5"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("ab0d7f3e-8091-4169-b720-daee6e130c23"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("c74a0d3b-31bd-4375-a268-fece8b1ce935"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("daaa47cf-5cc2-466b-92a2-0618ff52b594"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("ed5fca6d-a6b8-4a10-a311-898d507d9715"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("f35080ac-2d01-4658-b658-bcafbcb0020c"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("fc901dfc-55d2-4346-87e5-adafc8d82303"));

            migrationBuilder.DeleteData(
                table: "TipoPontuacao",
                keyColumn: "Id",
                keyValue: new Guid("33ba1010-adc4-4d57-822d-627acf7a9e08"));

            migrationBuilder.DeleteData(
                table: "TipoPontuacao",
                keyColumn: "Id",
                keyValue: new Guid("894f442d-07fc-4c36-99c7-3f74dfdd7db8"));

            migrationBuilder.DeleteData(
                table: "TipoPontuacao",
                keyColumn: "Id",
                keyValue: new Guid("e508ba2e-d41f-44ef-a0b4-9783a17bfd6a"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("0f688e05-d401-42ac-a925-13eb218d70cb"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("1248fa30-5042-4049-8e72-fad3e152b7cf"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("270eb4ea-f727-40bf-9add-c1d914da5889"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("316d7af5-be61-4790-829a-60bbcdc1ed09"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("605d534a-7a92-4eac-b02f-e47b50fb1126"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("609bb9e1-c085-49f6-9d9c-61b32fe031d3"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("82192a6b-8f8a-404e-b38a-52b2b7e9b17d"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("98866d5d-6aed-4419-b83b-47edde60d095"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("9beeb99b-99dc-4460-9e4d-08864199b4df"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("a97d6bcc-a7d9-4dd9-b479-60b8e9e92f95"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("aaaf3e44-fee6-4ce0-8a50-e05ad0728d8d"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("b95ef933-8714-49b2-bd50-696e4c439fab"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("c50a9723-8e62-45af-9d29-9fbcbd94d6e9"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("da2ca772-6611-40d6-8a72-d73894293bfa"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("f125c4a0-b01d-4cc7-8f46-b5682a1be921"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("f8ffd6bd-3a53-4e26-a05c-a1e4c9cac739"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("fc3696ab-288f-4796-8760-e65b9b6cefaf"));

            migrationBuilder.DeleteData(
                table: "Vacina",
                keyColumn: "Id",
                keyValue: new Guid("fcb93b24-3eee-40e4-b586-b350616f2afe"));

            migrationBuilder.InsertData(
                table: "Noticia",
                columns: new[] { "Id", "Resumo", "Texto", "Titulo", "UrlImagemCapa" },
                values: new object[,]
                {
                    { new Guid("451f57c1-762d-4de0-8163-253bff491b06"), "Palestra em unidade de saúde de Sobradinho busca tornar o atendimento a vítimas mais empático e aprofundar temas sensíveis, como traumas e agressões sexuais", "Atendimento ainda mais empático. Esse foi um dos objetivos da palestra Violência sexual e compreensão das reações das vítimas realizada nessa segunda-feira (20), no Hospital Regional de Sobradinho (HRS). A iniciativa visa capacitar a rede que atua no acolhimento de casos de violência, incluindo profissionais da saúde e servidores da rede-adjunta, como educação, órgãos da justiça e conselhos tutelares.", "Hospital capacita servidores para acolher pessoas em situação de violência", "https://www.saude.df.gov.br/image/journal/article?img_id=3019264" },
                    { new Guid("d02c4eb3-d71f-4975-9ec0-c3bcfccc4711"), "Nesta etapa, poderão receber o imunizante profissionais de saúde, trabalhadores do sistema prisional, pessoas com deficiência e população privada de liberdade", "A Secretaria de Saúde do Distrito Federal inicia nesta quarta-feira (22) a imunização de profissionais de saúde, trabalhadores prisionais, população privada de liberdade e pessoas com deficiência permanente com a versão bivalente da vacina contra a covid-19. O imunizante estará disponível em mais de 90 locais com atendimento das 8h às 17h.", "DF inicia vacinação bivalente contra a covid-19 para novos grupos", "https://www.saude.df.gov.br/image/journal/article?img_id=3019334" },
                    { new Guid("d1320621-7d2e-4b85-a48b-7044ac4ee8a5"), "Secretaria nomeia novos profissionais e abre leitos de UTI e de enfermaria pediátrica, além de capacitar equipes para atender ao público infantil", "A chegada do outono e do inverno nos meses de março a junho ocasiona a propagação de vírus que causam doenças respiratórias, majoritariamente, entre as crianças – em especial naquelas de até dois anos de idade, cujo sistema imunológico não é tão fortalecido.", "Saúde reforça serviços de atendimento às crianças", "https://www.saude.df.gov.br/image/journal/article?img_id=3019298" }
                });

            migrationBuilder.InsertData(
                table: "PontoVacinacao",
                columns: new[] { "Id", "Cidade", "Endereco", "Latitude", "Longitude", "Nome", "UF", "UsuarioId", "UsuarioId1" },
                values: new object[,]
                {
                    { new Guid("0b5165ae-3db2-493b-a4d4-e2ff86cfcf96"), "Sobradinho", "Condomínio Mini-Chácaras, QMS 16 Rua 14 Casa 01 – Sobradinho II", 0.0, 0.0, "UBS 5 Sobradinho II", "DF", null, null },
                    { new Guid("12d2612b-a6fd-4e60-88ff-895c84fdd7bb"), "Sobradinho", "Condomínio Vale dos Pinheiros, Quadra 45 A, Conjunto A, Lote 56, Sobradinho II", 0.0, 0.0, "UBS 3 Sobradinho II", "DF", null, null },
                    { new Guid("212aa4d9-5b25-4ed8-8815-1e010e646eee"), "Sobradinho", "Área Especial 01, Lote 01, Associação de Moradores, Vila BASEVI", 0.0, 0.0, "UBS 5 Sobradinho - Basevi", "DF", null, null },
                    { new Guid("2ab60576-c248-48dc-a1f4-63bc76859e8b"), "Brasília", "Vila Varjão Quadra 5 Conjunto A Lote 17", 0.0, 0.0, "UBS 1 Varjão", "DF", null, null },
                    { new Guid("328b6faa-d763-484b-b6b6-b93111acb77e"), "Sobradinho", "DF 001 KM 120 Rua 08 Chácara 187 Lago Oeste, Sobradinho", 0.0, 0.0, "UBS 6 Sobradinho - Lago Oeste", "DF", null, null },
                    { new Guid("33d91ed2-44cb-4ec6-bc21-059fdeab45bc"), "Sobradinho", "Quadra 5, Área Especial A, nº 1. Vila Buritizinho", -47.828150520004122, -15.65127289695881, "UBS 7 Sobradinho II – Vila Buritizinho", "DF", null, null },
                    { new Guid("395a4bd7-a97e-4c25-a815-c7fae9c2b1ba"), "Sobradinho", "Área Especial – Novo Setor de Mansões Nova Colina", -47.75527347168611, -15.64796549335305, "UBS 3 Sobradinho – Nova Colina", "DF", null, null },
                    { new Guid("40cfc63f-d882-42f1-92c0-fcfac0c41dda"), "Brasília", "EQN 114/115", 0.0, 0.0, "UBS 2 Asa Norte", "DF", null, null },
                    { new Guid("633ed756-0077-4e89-b0e2-af1e32f4a21e"), "Sobradinho", "Rodovia DF 420, Complexo de Saúde, Setor de Mansões, ao lado da UPA Sobradinho", 0.0, 0.0, "UBS 1 Sobradinho II", "DF", null, null },
                    { new Guid("75391d30-93e3-4644-829a-452e8f1252eb"), "Brasília", "SGAN 905", 0.0, 0.0, "UBS 1 Asa Norte", "DF", null, null },
                    { new Guid("9351ec15-db86-43c0-834e-91fdf066920e"), "Brasília", "SHIS QI 21 – Área Especial/23 – AE LT E – Lago Sul", 0.0, 0.0, "Policlínica do Lago Sul", "DF", null, null },
                    { new Guid("9957c911-e29b-4aa0-ba86-126d2eb36dc7"), "Brasília", "QS 514/515 – W3 Sul ", 0.0, 0.0, "Policlínica 514 Sul", "DF", null, null },
                    { new Guid("aab3ac2b-4939-4bb5-b511-bfd1c85c139b"), "Brasília", "QI 3", -15.725453043781098, -47.873853836999871, "UBS 1 Lago Norte", "DF", null, null },
                    { new Guid("b038da73-fa1c-4f20-995b-3e8e96395274"), "Brasília", "SHCES 601 - Lote 01 - Cruzeiro Novo", 0.0, 0.0, "UBS 1 Cruzeiro", "DF", null, null },
                    { new Guid("c9d947d0-c953-4b54-9b36-da2f852b7237"), "Sobradinho", "Condomínio Vale das Acácias, Quadra 12, Lote 01, Sobradinho II", 0.0, 0.0, "UBS 6 Sobradinho II", "DF", null, null },
                    { new Guid("ce0891fc-51af-4a01-bcfb-de563e908af1"), "Brasília", "Rua Piau – Acampamento Pacheco", 0.0, 0.0, "UBS 3 Vila Planalto", "DF", null, null },
                    { new Guid("d286c7d3-1c26-4d3e-9e4e-92b4bc3d6963"), "Sobradinho", "DF 150 Km 12 Quadra 10 Casa 14 ", 0.0, 0.0, "UBS 1 Fercal", "DF", null, null },
                    { new Guid("e9fcdb2c-f870-41e8-8564-648845376aca"), "Sobradinho", "Quadra 3 Área Especial Conjuntos D/E", 0.0, 0.0, "UBS 2 Sobradinho", "DF", null, null },
                    { new Guid("f0b63d2d-d84b-4d2c-a9e4-172d8684d241"), "Brasília", "Setor Escolar Lote 04 - Cruzeiro Velho", 0.0, 0.0, "UBS 2 Cruzeiro", "DF", null, null },
                    { new Guid("fde638f2-47a9-4c7a-b465-930347c23c34"), "Sobradinho", "Quadra 14 Área Especial 22/23", 0.0, 0.0, "UBS 1 Sobradinho", "DF", null, null }
                });

            migrationBuilder.InsertData(
                table: "TipoPontuacao",
                columns: new[] { "Id", "Descricao", "Valor" },
                values: new object[,]
                {
                    { new Guid("293209f9-4ef8-4670-8fba-91183dcce9ff"), "Vacinas", (short)10 },
                    { new Guid("5f6c35fb-8d60-4107-8071-ee7c08ea4a12"), "Compartilhar", (short)25 },
                    { new Guid("61b5897f-469b-476c-90e9-c854cc544636"), "Denuncia", (short)50 }
                });
        }
    }
}
