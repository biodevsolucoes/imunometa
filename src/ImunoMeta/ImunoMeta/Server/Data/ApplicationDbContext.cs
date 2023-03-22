using Duende.IdentityServer.EntityFramework.Options;
using ImunoMeta.Shared.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace ImunoMeta.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<Usuario>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            foreach (var property in modelBuilder.Model.GetEntityTypes()
                                                     .SelectMany(t => t.GetProperties())
                                                     .Where(p => p.ClrType == typeof(string))
                 )
            {
                property.SetColumnType("varchar(100)");
            }

            foreach(var property in modelBuilder.Model.GetEntityTypes().SelectMany(t=>t.GetProperties()).Where(x=>x.Name.Equals("Removido")))
            {
                property.SetColumnType("bit");
                property.SetDefaultValueSql("0");
            }

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                                                        .SelectMany(t => t.GetProperties())
                                                        .Where(p => p.ClrType == typeof(DateTime) || p.ClrType == typeof(DateTime?))
                   )
            {
                property.SetColumnType("datetime2");

                if (property.Name == "DataCadastro")
                    property.SetDefaultValueSql("getdate()");
                else if (property.Name == "DataCadastroUTC")
                    property.SetDefaultValueSql("getutcdate()");
            }

            Seed(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            SeedNoticias(modelBuilder);
            SeedTipoPontuacao(modelBuilder);
            SeedPontosVacinacao(modelBuilder);
        }

        private void SeedPontosVacinacao(ModelBuilder modelBuilder)
        {
            var pv1 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 1 Lago Norte",
                Endereco = "QI 3",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Brasília",
                UF = "DF"
            };
            var pv2 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 1 Varjão",
                Endereco = "Vila Varjão Quadra 5 Conjunto A Lote 17",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Brasília",
                UF = "DF"
            };
            var pv3 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 1 Asa Norte",
                Endereco = "SGAN 905",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Brasília",
                UF = "DF"
            };
            var pv4 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 2 Asa Norte",
                Endereco = "EQN 114/115",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Brasília",
                UF = "DF"
            };
            var pv5 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 3 Vila Planalto",
                Endereco = "Rua Piau – Acampamento Pacheco",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Brasília",
                UF = "DF"
            };
            var pv6 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "Policlínica 514 Sul",
                Endereco = "QS 514/515 – W3 Sul ",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Brasília",
                UF = "DF"
            };
            var pv7 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 1 Cruzeiro",
                Endereco = "SHCES 601 - Lote 01 - Cruzeiro Novo",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Brasília",
                UF = "DF"
            };
            var pv8 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 2 Cruzeiro",
                Endereco = "Setor Escolar Lote 04 - Cruzeiro Velho",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Brasília",
                UF = "DF"
            };
            var pv9 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "Policlínica do Lago Sul",
                Endereco = "SHIS QI 21 – Área Especial/23 – AE LT E – Lago Sul",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Brasília",
                UF = "DF"
            };
            var pv10 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 1 Sobradinho",
                Endereco = "Quadra 14 Área Especial 22/23",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv11 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 2 Sobradinho",
                Endereco = "Quadra 3 Área Especial Conjuntos D/E",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv12 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 3 Sobradinho – Nova Colina",
                Endereco = "Área Especial – Novo Setor de Mansões Nova Colina",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv13 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 5 Sobradinho - Basevi",
                Endereco = "Área Especial 01, Lote 01, Associação de Moradores, Vila BASEVI",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv14 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 6 Sobradinho - Lago Oeste",
                Endereco = "DF 001 KM 120 Rua 08 Chácara 187 Lago Oeste, Sobradinho",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv15 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 1 Sobradinho II",
                Endereco = "Rodovia DF 420, Complexo de Saúde, Setor de Mansões, ao lado da UPA Sobradinho",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv16 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 3 Sobradinho II",
                Endereco = "Condomínio Vale dos Pinheiros, Quadra 45 A, Conjunto A, Lote 56, Sobradinho II",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv17 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 5 Sobradinho II",
                Endereco = "Condomínio Mini-Chácaras, QMS 16 Rua 14 Casa 01 – Sobradinho II",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv18 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 6 Sobradinho II",
                Endereco = "Condomínio Vale das Acácias, Quadra 12, Lote 01, Sobradinho II",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv19 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 7 Sobradinho II – Vila Buritizinho",
                Endereco = "Quadra 5, Área Especial A, nº 1. Vila Buritizinho",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };
            var pv20 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 1 Fercal",
                Endereco = "DF 150 Km 12 Quadra 10 Casa 14 ",
                Longitude = 0,
                Latitude = 0,
                Cidade = "Sobradinho",
                UF = "DF"
            };

            modelBuilder.Entity<PontoVacinacao>().HasData(pv1, pv2, pv3, pv4, pv5, pv6, pv7, pv8, pv9, pv10, pv11, pv12, pv13, pv14, pv15, pv16, pv17, pv18, pv19, pv20);
        }

        private void SeedTipoPontuacao(ModelBuilder modelBuilder)
        {
            var tp1 = new TipoPontuacao
            {
                Id = Guid.NewGuid(),
                Descricao = "Denuncia",
                Valor = 50
            };
            var tp2 = new TipoPontuacao
            {
                Id = Guid.NewGuid(),
                Descricao = "Compartilhar",
                Valor = 25
            };
            var tp3 = new TipoPontuacao
            {
                Id = Guid.NewGuid(),
                Descricao = "Vacinas",
                Valor = 10
            };

            modelBuilder.Entity<TipoPontuacao>().HasData(tp1, tp2, tp3);
        }

        private void SeedNoticias(ModelBuilder modelBuilder)
        {
            var noticia1 = new Noticia()
            {
                Id = Guid.NewGuid(),
                Titulo = "DF inicia vacinação bivalente contra a covid-19 para novos grupos",
                Resumo = "Nesta etapa, poderão receber o imunizante profissionais de saúde, trabalhadores do sistema prisional, pessoas com deficiência e população privada de liberdade",
                Texto = "A Secretaria de Saúde do Distrito Federal inicia nesta quarta-feira (22) a imunização de profissionais de saúde, trabalhadores prisionais, população privada de liberdade e pessoas com deficiência permanente com a versão bivalente da vacina contra a covid-19. O imunizante estará disponível em mais de 90 locais com atendimento das 8h às 17h.",
                UrlImagemCapa = "https://www.saude.df.gov.br/image/journal/article?img_id=3019334"

            };

            var noticia2 = new Noticia()
            {
                Id = Guid.NewGuid(),
                Titulo = "Saúde reforça serviços de atendimento às crianças",
                Resumo = "Secretaria nomeia novos profissionais e abre leitos de UTI e de enfermaria pediátrica, além de capacitar equipes para atender ao público infantil",
                Texto = "A chegada do outono e do inverno nos meses de março a junho ocasiona a propagação de vírus que causam doenças respiratórias, majoritariamente, entre as crianças – em especial naquelas de até dois anos de idade, cujo sistema imunológico não é tão fortalecido.",
                UrlImagemCapa = "https://www.saude.df.gov.br/image/journal/article?img_id=3019298"
            };

            var noticia3 = new Noticia()
            {
                Id = Guid.NewGuid(),
                Titulo = "Hospital capacita servidores para acolher pessoas em situação de violência",
                Resumo = "Palestra em unidade de saúde de Sobradinho busca tornar o atendimento a vítimas mais empático e aprofundar temas sensíveis, como traumas e agressões sexuais",
                Texto = "Atendimento ainda mais empático. Esse foi um dos objetivos da palestra Violência sexual e compreensão das reações das vítimas realizada nessa segunda-feira (20), no Hospital Regional de Sobradinho (HRS). A iniciativa visa capacitar a rede que atua no acolhimento de casos de violência, incluindo profissionais da saúde e servidores da rede-adjunta, como educação, órgãos da justiça e conselhos tutelares.",
                UrlImagemCapa = "https://www.saude.df.gov.br/image/journal/article?img_id=3019264"
            };

            modelBuilder.Entity<Noticia>().HasData(noticia1, noticia2, noticia3);
        }

        public DbSet<Contato> Contato { get; set; }
        public DbSet<Denuncia> Denuncia { get; set; }
        public DbSet<Mensagem> Mensagem { get; set; }
        public DbSet<Noticia> Noticia { get; set; }
        public DbSet<PontoVacinacao> PontoVacinacao { get; set; }
        public DbSet<Pontuacao> Pontuacao { get; set; }
        public DbSet<TipoPontuacao> TipoPontuacao { get; set; }
        public DbSet<Trofeu> Trofeu { get; set; }
        public DbSet<UsuarioTrofeu> UsuarioTrofeu { get; set; }
        public DbSet<UsuarioVacina> UsuarioVacina { get; set; }
        public DbSet<Vacina> Vacina { get; set; }
    }
}