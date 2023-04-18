using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ImunoMeta.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    UrlFoto = table.Column<string>(type: "varchar(100)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "varchar(100)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "varchar(100)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(100)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(100)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "varchar(100)", nullable: true),
                    Algorithm = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Noticia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(250)", nullable: false),
                    Resumo = table.Column<string>(type: "varchar(1000)", nullable: false),
                    Texto = table.Column<string>(type: "varchar(max)", nullable: false),
                    UrlImagemCapa = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "TipoPontuacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Valor = table.Column<short>(type: "smallint", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPontuacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trofeu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    ImagemUrl = table.Column<string>(type: "varchar(500)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trofeu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "varchar(100)", nullable: false),
                    ClaimType = table.Column<string>(type: "varchar(100)", nullable: true),
                    ClaimValue = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "varchar(100)", nullable: false),
                    ClaimType = table.Column<string>(type: "varchar(100)", nullable: true),
                    ClaimValue = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "varchar(100)", nullable: true),
                    UserId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(100)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(100)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioContatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    UsuarioContatoId1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_AspNetUsers_UsuarioContatoId1",
                        column: x => x.UsuarioContatoId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contato_AspNetUsers_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Denuncia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UrlDenunciada = table.Column<string>(type: "varchar(500)", nullable: true),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Denuncia_AspNetUsers_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mensagem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    Texto = table.Column<string>(type: "varchar(1000)", nullable: false),
                    UsuarioDestinoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioDestinoId1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mensagem_AspNetUsers_UsuarioDestinoId1",
                        column: x => x.UsuarioDestinoId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Mensagem_AspNetUsers_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PontoVacinacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(250)", nullable: false),
                    UsuarioId1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontoVacinacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PontoVacinacao_AspNetUsers_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vacina",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacina_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pontuacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoPontuacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontuacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pontuacao_AspNetUsers_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pontuacao_TipoPontuacao_TipoPontuacaoId",
                        column: x => x.TipoPontuacaoId,
                        principalTable: "TipoPontuacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioTrofeu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrofeuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId1 = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioTrofeu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioTrofeu_AspNetUsers_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioTrofeu_Trofeu_TrofeuId",
                        column: x => x.TrofeuId,
                        principalTable: "Trofeu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioVacina",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VacinaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId1 = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataCadastroUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Removido = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioVacina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioVacina_AspNetUsers_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioVacina_Vacina_VacinaId",
                        column: x => x.VacinaId,
                        principalTable: "Vacina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_UsuarioContatoId1",
                table: "Contato",
                column: "UsuarioContatoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_UsuarioId1",
                table: "Contato",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Denuncia_UsuarioId1",
                table: "Denuncia",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagem_UsuarioDestinoId1",
                table: "Mensagem",
                column: "UsuarioDestinoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagem_UsuarioId1",
                table: "Mensagem",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PontoVacinacao_UsuarioId1",
                table: "PontoVacinacao",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pontuacao_TipoPontuacaoId",
                table: "Pontuacao",
                column: "TipoPontuacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pontuacao_UsuarioId1",
                table: "Pontuacao",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioTrofeu_TrofeuId",
                table: "UsuarioTrofeu",
                column: "TrofeuId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioTrofeu_UsuarioId1",
                table: "UsuarioTrofeu",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioVacina_UsuarioId1",
                table: "UsuarioVacina",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioVacina_VacinaId",
                table: "UsuarioVacina",
                column: "VacinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacina_UsuarioId",
                table: "Vacina",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Denuncia");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "Mensagem");

            migrationBuilder.DropTable(
                name: "Noticia");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "PontoVacinacao");

            migrationBuilder.DropTable(
                name: "Pontuacao");

            migrationBuilder.DropTable(
                name: "UsuarioTrofeu");

            migrationBuilder.DropTable(
                name: "UsuarioVacina");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TipoPontuacao");

            migrationBuilder.DropTable(
                name: "Trofeu");

            migrationBuilder.DropTable(
                name: "Vacina");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
