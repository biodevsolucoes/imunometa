using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ImunoMeta.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class Vacina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Noticia",
                keyColumn: "Id",
                keyValue: new Guid("1bf99edf-a37e-4665-9194-3c1dd51ee531"));

            migrationBuilder.DeleteData(
                table: "Noticia",
                keyColumn: "Id",
                keyValue: new Guid("6c2a6bb4-0439-4795-afa6-57fe8de1fb1e"));

            migrationBuilder.DeleteData(
                table: "Noticia",
                keyColumn: "Id",
                keyValue: new Guid("f77a0058-fd20-48df-b85f-ac875da252fe"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("2dcc459a-67ed-4e4b-b85f-d43baa060cbe"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("5cb64c4c-d31f-4713-9e0d-d4b6973ac9db"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("6e1a720e-c8c1-4f59-965f-f54fa1e64b03"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("779305b6-3537-4aa3-8bf1-ed9e72c8e982"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("848c5c1b-35c8-48c2-bc5e-093b2a45112b"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("8596da97-bfe3-4957-b38d-bf61657bb7d1"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("8ce37bb4-e0d9-4d5f-bc24-c2c53adba423"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("9637a93b-5bf7-4f3c-8a30-fbda392ad6bb"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("a39f72e6-adff-4ba8-a81a-b67fe686e25a"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("a8ed3cb5-9acf-48e2-ba3a-130b702a896b"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("abd252da-d7b2-468a-9890-f9e1210ed263"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("b097ea92-ac65-425d-b6fa-0940e907dbdb"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("b0e84dca-dbac-4c10-aae1-06b3ada858ed"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("d39c1020-b256-40db-bbb5-0cdc4454f7b7"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("d5ef630b-6c15-4607-a206-2181296d30cc"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("d86ff3f2-5053-48e7-b849-ddc4d7e7bbea"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("d9e163c5-0ab4-4ea0-958d-37df15287253"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("df89252b-fceb-4040-ae9f-b54ac033645a"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("eaee9b78-96e2-4683-a46b-0dc95325db8b"));

            migrationBuilder.DeleteData(
                table: "PontoVacinacao",
                keyColumn: "Id",
                keyValue: new Guid("fe44f672-00db-484c-922d-d7a51b457129"));

            migrationBuilder.DeleteData(
                table: "TipoPontuacao",
                keyColumn: "Id",
                keyValue: new Guid("2fec7f33-2126-4d97-b8af-072ea89fb60e"));

            migrationBuilder.DeleteData(
                table: "TipoPontuacao",
                keyColumn: "Id",
                keyValue: new Guid("8c3ea3b9-0b97-4bce-8e40-ba060e00c877"));

            migrationBuilder.DeleteData(
                table: "TipoPontuacao",
                keyColumn: "Id",
                keyValue: new Guid("ed2a1a55-b8e5-4390-8815-4e2e332c2d8c"));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Vacina",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AddColumn<string>(
                name: "CssClass",
                table: "Vacina",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Vacina",
                type: "varchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "PersistedGrants",
                type: "varchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "Keys",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "DeviceCodes",
                type: "varchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CssClass",
                table: "Vacina");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Vacina");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Vacina",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "PersistedGrants",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "Keys",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "DeviceCodes",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.InsertData(
                table: "Noticia",
                columns: new[] { "Id", "Resumo", "Texto", "Titulo", "UrlImagemCapa" },
                values: new object[,]
                {
                    { new Guid("1bf99edf-a37e-4665-9194-3c1dd51ee531"), "Palestra em unidade de saúde de Sobradinho busca tornar o atendimento a vítimas mais empático e aprofundar temas sensíveis, como traumas e agressões sexuais", "Atendimento ainda mais empático. Esse foi um dos objetivos da palestra Violência sexual e compreensão das reações das vítimas realizada nessa segunda-feira (20), no Hospital Regional de Sobradinho (HRS). A iniciativa visa capacitar a rede que atua no acolhimento de casos de violência, incluindo profissionais da saúde e servidores da rede-adjunta, como educação, órgãos da justiça e conselhos tutelares.", "Hospital capacita servidores para acolher pessoas em situação de violência", "https://www.saude.df.gov.br/image/journal/article?img_id=3019264" },
                    { new Guid("6c2a6bb4-0439-4795-afa6-57fe8de1fb1e"), "Secretaria nomeia novos profissionais e abre leitos de UTI e de enfermaria pediátrica, além de capacitar equipes para atender ao público infantil", "A chegada do outono e do inverno nos meses de março a junho ocasiona a propagação de vírus que causam doenças respiratórias, majoritariamente, entre as crianças – em especial naquelas de até dois anos de idade, cujo sistema imunológico não é tão fortalecido.", "Saúde reforça serviços de atendimento às crianças", "https://www.saude.df.gov.br/image/journal/article?img_id=3019298" },
                    { new Guid("f77a0058-fd20-48df-b85f-ac875da252fe"), "Nesta etapa, poderão receber o imunizante profissionais de saúde, trabalhadores do sistema prisional, pessoas com deficiência e população privada de liberdade", "A Secretaria de Saúde do Distrito Federal inicia nesta quarta-feira (22) a imunização de profissionais de saúde, trabalhadores prisionais, população privada de liberdade e pessoas com deficiência permanente com a versão bivalente da vacina contra a covid-19. O imunizante estará disponível em mais de 90 locais com atendimento das 8h às 17h.", "DF inicia vacinação bivalente contra a covid-19 para novos grupos", "https://www.saude.df.gov.br/image/journal/article?img_id=3019334" }
                });

            migrationBuilder.InsertData(
                table: "PontoVacinacao",
                columns: new[] { "Id", "Cidade", "Endereco", "Latitude", "Longitude", "Nome", "UF", "UsuarioId", "UsuarioId1" },
                values: new object[,]
                {
                    { new Guid("2dcc459a-67ed-4e4b-b85f-d43baa060cbe"), "Brasília", "Rua Piau – Acampamento Pacheco", 0.0, 0.0, "UBS 3 Vila Planalto", "DF", null, null },
                    { new Guid("5cb64c4c-d31f-4713-9e0d-d4b6973ac9db"), "Brasília", "SHIS QI 21 – Área Especial/23 – AE LT E – Lago Sul", 0.0, 0.0, "Policlínica do Lago Sul", "DF", null, null },
                    { new Guid("6e1a720e-c8c1-4f59-965f-f54fa1e64b03"), "Sobradinho", "Quadra 14 Área Especial 22/23", 0.0, 0.0, "UBS 1 Sobradinho", "DF", null, null },
                    { new Guid("779305b6-3537-4aa3-8bf1-ed9e72c8e982"), "Brasília", "Vila Varjão Quadra 5 Conjunto A Lote 17", 0.0, 0.0, "UBS 1 Varjão", "DF", null, null },
                    { new Guid("848c5c1b-35c8-48c2-bc5e-093b2a45112b"), "Brasília", "EQN 114/115", 0.0, 0.0, "UBS 2 Asa Norte", "DF", null, null },
                    { new Guid("8596da97-bfe3-4957-b38d-bf61657bb7d1"), "Sobradinho", "Condomínio Mini-Chácaras, QMS 16 Rua 14 Casa 01 – Sobradinho II", 0.0, 0.0, "UBS 5 Sobradinho II", "DF", null, null },
                    { new Guid("8ce37bb4-e0d9-4d5f-bc24-c2c53adba423"), "Brasília", "QI 3", -15.725453043781098, -47.873853836999871, "UBS 1 Lago Norte", "DF", null, null },
                    { new Guid("9637a93b-5bf7-4f3c-8a30-fbda392ad6bb"), "Brasília", "SHCES 601 - Lote 01 - Cruzeiro Novo", 0.0, 0.0, "UBS 1 Cruzeiro", "DF", null, null },
                    { new Guid("a39f72e6-adff-4ba8-a81a-b67fe686e25a"), "Brasília", "Setor Escolar Lote 04 - Cruzeiro Velho", 0.0, 0.0, "UBS 2 Cruzeiro", "DF", null, null },
                    { new Guid("a8ed3cb5-9acf-48e2-ba3a-130b702a896b"), "Sobradinho", "DF 001 KM 120 Rua 08 Chácara 187 Lago Oeste, Sobradinho", 0.0, 0.0, "UBS 6 Sobradinho - Lago Oeste", "DF", null, null },
                    { new Guid("abd252da-d7b2-468a-9890-f9e1210ed263"), "Brasília", "QS 514/515 – W3 Sul ", 0.0, 0.0, "Policlínica 514 Sul", "DF", null, null },
                    { new Guid("b097ea92-ac65-425d-b6fa-0940e907dbdb"), "Sobradinho", "Quadra 3 Área Especial Conjuntos D/E", 0.0, 0.0, "UBS 2 Sobradinho", "DF", null, null },
                    { new Guid("b0e84dca-dbac-4c10-aae1-06b3ada858ed"), "Sobradinho", "Condomínio Vale das Acácias, Quadra 12, Lote 01, Sobradinho II", 0.0, 0.0, "UBS 6 Sobradinho II", "DF", null, null },
                    { new Guid("d39c1020-b256-40db-bbb5-0cdc4454f7b7"), "Sobradinho", "Área Especial 01, Lote 01, Associação de Moradores, Vila BASEVI", 0.0, 0.0, "UBS 5 Sobradinho - Basevi", "DF", null, null },
                    { new Guid("d5ef630b-6c15-4607-a206-2181296d30cc"), "Sobradinho", "Condomínio Vale dos Pinheiros, Quadra 45 A, Conjunto A, Lote 56, Sobradinho II", 0.0, 0.0, "UBS 3 Sobradinho II", "DF", null, null },
                    { new Guid("d86ff3f2-5053-48e7-b849-ddc4d7e7bbea"), "Sobradinho", "Área Especial – Novo Setor de Mansões Nova Colina", -47.75527347168611, -15.64796549335305, "UBS 3 Sobradinho – Nova Colina", "DF", null, null },
                    { new Guid("d9e163c5-0ab4-4ea0-958d-37df15287253"), "Sobradinho", "Rodovia DF 420, Complexo de Saúde, Setor de Mansões, ao lado da UPA Sobradinho", 0.0, 0.0, "UBS 1 Sobradinho II", "DF", null, null },
                    { new Guid("df89252b-fceb-4040-ae9f-b54ac033645a"), "Sobradinho", "DF 150 Km 12 Quadra 10 Casa 14 ", 0.0, 0.0, "UBS 1 Fercal", "DF", null, null },
                    { new Guid("eaee9b78-96e2-4683-a46b-0dc95325db8b"), "Brasília", "SGAN 905", 0.0, 0.0, "UBS 1 Asa Norte", "DF", null, null },
                    { new Guid("fe44f672-00db-484c-922d-d7a51b457129"), "Sobradinho", "Quadra 5, Área Especial A, nº 1. Vila Buritizinho", -47.828150520004122, -15.65127289695881, "UBS 7 Sobradinho II – Vila Buritizinho", "DF", null, null }
                });

            migrationBuilder.InsertData(
                table: "TipoPontuacao",
                columns: new[] { "Id", "Descricao", "Valor" },
                values: new object[,]
                {
                    { new Guid("2fec7f33-2126-4d97-b8af-072ea89fb60e"), "Denuncia", (short)50 },
                    { new Guid("8c3ea3b9-0b97-4bce-8e40-ba060e00c877"), "Compartilhar", (short)25 },
                    { new Guid("ed2a1a55-b8e5-4390-8815-4e2e332c2d8c"), "Vacinas", (short)10 }
                });
        }
    }
}
