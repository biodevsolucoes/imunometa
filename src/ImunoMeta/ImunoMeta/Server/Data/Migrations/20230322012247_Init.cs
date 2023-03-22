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
                    Data = table.Column<string>(type: "varchar(100)", nullable: false)
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
                    Data = table.Column<string>(type: "varchar(max)", nullable: false)
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
                    { new Guid("47d2d1b8-73f8-4bcb-bd3e-dd25ef6efe8c"), "Palestra em unidade de saúde de Sobradinho busca tornar o atendimento a vítimas mais empático e aprofundar temas sensíveis, como traumas e agressões sexuais", "Atendimento ainda mais empático. Esse foi um dos objetivos da palestra Violência sexual e compreensão das reações das vítimas realizada nessa segunda-feira (20), no Hospital Regional de Sobradinho (HRS). A iniciativa visa capacitar a rede que atua no acolhimento de casos de violência, incluindo profissionais da saúde e servidores da rede-adjunta, como educação, órgãos da justiça e conselhos tutelares.", "Hospital capacita servidores para acolher pessoas em situação de violência", "https://www.saude.df.gov.br/image/journal/article?img_id=3019264" },
                    { new Guid("6dc65d4d-b60a-42ab-900c-cb8def69bf87"), "Secretaria nomeia novos profissionais e abre leitos de UTI e de enfermaria pediátrica, além de capacitar equipes para atender ao público infantil", "A chegada do outono e do inverno nos meses de março a junho ocasiona a propagação de vírus que causam doenças respiratórias, majoritariamente, entre as crianças – em especial naquelas de até dois anos de idade, cujo sistema imunológico não é tão fortalecido.", "Saúde reforça serviços de atendimento às crianças", "https://www.saude.df.gov.br/image/journal/article?img_id=3019298" },
                    { new Guid("852e84ca-29a7-4cb4-9edc-c0bcdd61ed88"), "Nesta etapa, poderão receber o imunizante profissionais de saúde, trabalhadores do sistema prisional, pessoas com deficiência e população privada de liberdade", "A Secretaria de Saúde do Distrito Federal inicia nesta quarta-feira (22) a imunização de profissionais de saúde, trabalhadores prisionais, população privada de liberdade e pessoas com deficiência permanente com a versão bivalente da vacina contra a covid-19. O imunizante estará disponível em mais de 90 locais com atendimento das 8h às 17h.", "DF inicia vacinação bivalente contra a covid-19 para novos grupos", "https://www.saude.df.gov.br/image/journal/article?img_id=3019334" }
                });

            migrationBuilder.InsertData(
                table: "PontoVacinacao",
                columns: new[] { "Id", "Cidade", "Endereco", "Latitude", "Longitude", "Nome", "UF", "UsuarioId", "UsuarioId1" },
                values: new object[,]
                {
                    { new Guid("203f501f-a908-4e64-a767-42827ea6e331"), "Brasília", "SGAN 905", 0.0, 0.0, "UBS 1 Asa Norte", "DF", null, null },
                    { new Guid("2d6a0f01-db8a-4e63-b0ef-91cc114041c2"), "Sobradinho", "Rodovia DF 420, Complexo de Saúde, Setor de Mansões, ao lado da UPA Sobradinho", 0.0, 0.0, "UBS 1 Sobradinho II", "DF", null, null },
                    { new Guid("38c4f56e-5a6b-4441-9286-9a599bbe9b08"), "Sobradinho", "Condomínio Mini-Chácaras, QMS 16 Rua 14 Casa 01 – Sobradinho II", 0.0, 0.0, "UBS 5 Sobradinho II", "DF", null, null },
                    { new Guid("39c8f952-19a8-4fbf-aa66-d1a3e7be5811"), "Sobradinho", "DF 150 Km 12 Quadra 10 Casa 14 ", 0.0, 0.0, "UBS 1 Fercal", "DF", null, null },
                    { new Guid("53ee40c5-6de2-4ecf-80d4-85f52b61bc1c"), "Sobradinho", "Condomínio Vale das Acácias, Quadra 12, Lote 01, Sobradinho II", 0.0, 0.0, "UBS 6 Sobradinho II", "DF", null, null },
                    { new Guid("62bfdebe-e068-4934-828a-26b58da7aad4"), "Brasília", "QI 3", 0.0, 0.0, "UBS 1 Lago Norte", "DF", null, null },
                    { new Guid("732f6bb8-3e94-433d-9d8b-7bc1531126bd"), "Brasília", "Vila Varjão Quadra 5 Conjunto A Lote 17", 0.0, 0.0, "UBS 1 Varjão", "DF", null, null },
                    { new Guid("7fc90716-4950-48a7-8aa7-b8f2cc62d867"), "Brasília", "QS 514/515 – W3 Sul ", 0.0, 0.0, "Policlínica 514 Sul", "DF", null, null },
                    { new Guid("8f84ff82-90e8-4f2d-bb23-8f9b3e39b315"), "Brasília", "EQN 114/115", 0.0, 0.0, "UBS 2 Asa Norte", "DF", null, null },
                    { new Guid("95b0f18e-76d2-4907-b080-085b60e6d4b3"), "Sobradinho", "Área Especial – Novo Setor de Mansões Nova Colina", 0.0, 0.0, "UBS 3 Sobradinho – Nova Colina", "DF", null, null },
                    { new Guid("ab2347ed-4271-42be-90a2-4a36e937e9a4"), "Brasília", "Rua Piau – Acampamento Pacheco", 0.0, 0.0, "UBS 3 Vila Planalto", "DF", null, null },
                    { new Guid("aef1d9b1-d345-4f52-a8c8-1a671a930cc5"), "Sobradinho", "Quadra 5, Área Especial A, nº 1. Vila Buritizinho", 0.0, 0.0, "UBS 7 Sobradinho II – Vila Buritizinho", "DF", null, null },
                    { new Guid("b519a054-2aac-40e2-a71d-29f5e48e9b67"), "Brasília", "SHIS QI 21 – Área Especial/23 – AE LT E – Lago Sul", 0.0, 0.0, "Policlínica do Lago Sul", "DF", null, null },
                    { new Guid("b9559937-e734-4c81-a5b4-3e4c62f8ad8b"), "Brasília", "Setor Escolar Lote 04 - Cruzeiro Velho", 0.0, 0.0, "UBS 2 Cruzeiro", "DF", null, null },
                    { new Guid("c1e4e375-f41c-4e18-a18c-c95144862b42"), "Brasília", "SHCES 601 - Lote 01 - Cruzeiro Novo", 0.0, 0.0, "UBS 1 Cruzeiro", "DF", null, null },
                    { new Guid("c5a1a8ec-f359-494e-ba0b-ec950275ffd9"), "Sobradinho", "Área Especial 01, Lote 01, Associação de Moradores, Vila BASEVI", 0.0, 0.0, "UBS 5 Sobradinho - Basevi", "DF", null, null },
                    { new Guid("c73febf8-82c3-44db-ac31-e69b50ade191"), "Sobradinho", "Quadra 3 Área Especial Conjuntos D/E", 0.0, 0.0, "UBS 2 Sobradinho", "DF", null, null },
                    { new Guid("e4006b8d-4b1a-46e1-a76f-bc99d4985b66"), "Sobradinho", "Quadra 14 Área Especial 22/23", 0.0, 0.0, "UBS 1 Sobradinho", "DF", null, null },
                    { new Guid("f28b07a4-a198-4227-875c-58f1f50c722f"), "Sobradinho", "Condomínio Vale dos Pinheiros, Quadra 45 A, Conjunto A, Lote 56, Sobradinho II", 0.0, 0.0, "UBS 3 Sobradinho II", "DF", null, null },
                    { new Guid("f46a0d5c-ccf0-412c-8568-fe3c61b6b936"), "Sobradinho", "DF 001 KM 120 Rua 08 Chácara 187 Lago Oeste, Sobradinho", 0.0, 0.0, "UBS 6 Sobradinho - Lago Oeste", "DF", null, null }
                });

            migrationBuilder.InsertData(
                table: "TipoPontuacao",
                columns: new[] { "Id", "Descricao", "Valor" },
                values: new object[,]
                {
                    { new Guid("0c266f32-23b5-4e06-9167-02cd44b36290"), "Denuncia", (short)50 },
                    { new Guid("7ed1c701-8c6b-4cc5-b618-1c30bd4a0f60"), "Vacinas", (short)10 },
                    { new Guid("c21eba19-20e8-402a-9b5b-c380753701c7"), "Compartilhar", (short)25 }
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
