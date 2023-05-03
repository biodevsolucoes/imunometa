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

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(x => x.Name.Equals("Removido")))
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
            SeedVacinas(modelBuilder);
            SeedNoticias(modelBuilder);
            SeedTipoPontuacao(modelBuilder);
            SeedPontosVacinacao(modelBuilder);
        }

        private void SeedVacinas(ModelBuilder modelBuilder)
        {
            var v1 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "BCG",
                Descricao = "A vacina BCG protege contra a tuberculose – doença contagiosa, provocada pela bactéria Mycobacterium tuberculosis. Foi criada em 1.921 por Léon Calmette e Alphonse Guérin, dando origem ao nome BCG.",
                CssClass = "bg-secondary"
            };
            var v2 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Hepatite A",
                Descricao = "É uma infecção causada pelo vírus A (HAV) da hepatite, também conhecida como “hepatite infecciosa”. Na maioria dos casos, a hepatite A é uma doença de caráter benigno, contudo o curso sintomático e a letalidade aumentam com a idade.",
                CssClass = "bg-info"
            };
            var v3 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Hepatite B",
                Descricao = "A hepatite B é uma doença que provoca mal-estar, febre, dor de cabeça, cansaço, dor no abdômen, náuseas e vômitos. Na sua forma mais grave, pode causar infecções e até tumores no fígado. A vacina que previne contra a hepatite B deve ser aplicada ainda nas primeiras horas após o nascimento, fornecendo uma proteção entre 80 e 100%. É aplicada com uma injeção e as doses de reforço estão presentes na vacina pentavalente, que também protege contra tétano, coqueluche, difteria e meningite, causada pela Haemophilus influenza tipo B.",
                CssClass = "bg-dark"
            };
            var v4 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Penta (DTP/Hib/Hep. B)",
                Descricao = "A vacina pentavalente é a combinação de cinco vacinas individuais em uma. O objetivo é proteger as pessoas contra múltiplas doenças ao mesmo tempo. Desde 2012, o Programa Nacional de Imunizações (PNI), do Ministério da Saúde, oferta a vacina pentavalente na rotina do Calendário Nacional de Vacinação.",
                CssClass = "bg-warning"
            };
            var v5 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Pneumocócica 10 valente",
                Descricao = "O Ministério da Saúde recomenda a vacinação de todas as crianças menores de cinco anos de acordo com o Calendário Nacional de Vacinação. A imunização com as doses recomendadas é fundamental para evitar o adoecimento, além de complicações e óbitos.",
                CssClass = "bg-danger"
            };
            var v6 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Vacina Inativada Poliomielite (VIP)",
                Descricao = "A vacina é indicada para prevenir contra a poliomielite causada por vírus dos tipos 1, 2 e 3.",
                CssClass = "bg-success"
            };
            var v7 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Vacina Oral Poliomielite (VOP)",
                Descricao = "A vacina é indicada para prevenir contra a poliomielite causada por vírus dos tipos 1, 2 e 3.",
                CssClass = "bg-light border"
            };
            var v8 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Vacina Rotavírus Humano (VRH)",
                Descricao = "AO imunizante que previne contra o rotavírus humano é a vacina VRH/VORH. A aplicação acontece com uma gotinha na boca dos bebês, a partir da sexta semana de vida, para proteger contra infecções provocadas pelo rotavírus, como a diarreia, uma das principais causas de problemas estomacais nas crianças.",
                CssClass = "bg-secondary"
            };
            var v9 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Meningocócica C (conjugada)",
                Descricao = "A vacina é composta pelo oligossacarídeo meningocócico C conjugado com a proteína CRM197 e não possui o micro-organismo causador da doença, o que a torna mais segura. É indicada para imunização ativa de crianças a partir de 2 meses de idade, adolescentes e adultos para a prevenção da doença invasiva causada por Neisseria meningitidis do sorogrupo C. Esta bactéria pode causar infecções graves, às vezes fatais, como a meningite e a sepse (infecção grave no sangue – infecção generalizada).",
                CssClass = "bg-secondary"
            };
            var v10 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Febre amarela",
                Descricao = "É uma doença de notificação compulsória imediata, ou seja, todo evento suspeito (tanto morte de primatas não humanos, quanto casos humanos com sintomatologia compatível) deve ser prontamente comunicado, em até 24 horas após a suspeita inicial, às autoridades locais competentes pela via mais rápida (telefone, fax, email, etc). Às autoridades estaduais de saúde cabe notificar os eventos de febre amarela suspeitos ao Ministério da Saúde. Atualmente, a febre amarela silvestre (FA) é uma doença endêmica no Brasil (região amazônica). ",
                CssClass = "bg-warning"
            };
            var v11 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Tríplice viral",
                Descricao = "No Sistema Único de Saúde (SUS), a vacina previne o sarampo, a caxumba e a rubéola. No Calendário Nacional de Vacinação, o imunizante está disponível para pessoas de 12 meses a 59 anos de idade, sendo recomendadas duas doses até 29 anos e uma dose de 30 a 59 anos, em pessoas não vacinadas. A vacinação é a forma mais eficaz de prevenção contra o sarampo e o objetivo é interromper a circulação do vírus e reduzir complicações e o número de óbitos pela doença.",
                CssClass = "bg-danger"
            };
            var v12 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Tetraviral",
                Descricao = "A vacina contra sarampo, caxumba, rubéola e varicela, também conhecida como tetra viral ou tetravalente viral é indicada para a vacinação de crianças com 15 meses de idade que já tenham recebido a primeira dose da vacina tríplice viral.",
                CssClass = "bg-danger"
            };
            var v13 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "DTP (tríplice bacteriana)",
                Descricao = "A vacina DTP (tríplice bacteriana), previne contra doenças como difteria, tétano e coqueluche, e é destinada a crianças entre 15 meses e quatro anos de idade como uma forma de reforço para as que já tenham se vacinado com a pentavalente.",
                CssClass = "bg-secondary"
            };
            var v14 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "Varicela",
                Descricao = "A vacina contra sarampo, caxumba, rubéola e varicela, também conhecida como tetra viral ou tetravalente viral é indicada para a vacinação de crianças com 15 meses de idade que já tenham recebido a primeira dose da vacina tríplice viral.",
                CssClass = "bg-secondary"
            };
            var v15 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "HPV quadrivalente",
                Descricao = "Segundo a Organização Mundial de Saúde (OMS), estima-se que haja de 9 a 10 milhões de infectados por esse vírus no Brasil e que a cada ano surjam 700 mil novos casos de infecção. O risco de desenvolvimento de cânceres associados ao HPV é cerca de quatro vezes maior entre pessoas vivendo com HIV/Aids e transplantados do que na população sem a doença ou transplante.",
                CssClass = "bg-dark text-white"
            };
            var v16 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "dT (dupla adulto)",
                Descricao = "Proteção contra o tétano acidental e a difteria.\r\nA difteriadifteriadifteriadifteriadifteria é causada por um bacilo, produtor de uma toxina\r\n(substância tóxica), que atinge as amídalas, a faringe, o nariz e a\r\npele, onde provoca placas branco-acinzentadas. É transmitida, por\r\nmeio de tosse ou espirro, de uma pessoa contaminada para outra.\r\nO tétanotétanotétanotétanotétano é uma infecção, causada por uma toxina (substância tóxica)\r\nproduzida pelo bacilo tetânico, que entra no organismo por meio de\r\nferimentos ou lesões na pele (tétano acidental) ou pelo coto do cordão\r\numbilical (tétano neonatal ou mal dos sete dias) e atinge o sistema\r\nnervoso central. Caracteriza-se por contrações e espasmos,\r\ndificuldade em engolir e rigidez no pescoço.",
                CssClass = "bg-primary"
            };
            var v17 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "dTpa (DTP adulto)",
                Descricao = "A vacina dTpa é uma associação de toxóide diftérico, toxóide tetânico e\r\ncomponentes purificados dos antígenos da Bordetella pertussis – toxina\r\npertussis, tendo o hidróxido e o fosfato de alumínio como adjuvante.",
                CssClass = "bg-info"
            };
            var v18 = new Vacina()
            {
                Id = Guid.NewGuid(),
                Nome = "dMenigocócica ACWY",
                Descricao = "Previne as meningites e as doenças meningocócicas causadas pela bactéria meningococo dos tipos A, C, W e Y. Meningite meningocócica é uma forma grave de meningite bacteriana, altamente contagiosa, causada pela bactéria Neisseria meningitidis, também conhecida como meningococo.",
                CssClass = "bg-warning"
            };

            modelBuilder.Entity<Vacina>().HasData(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18);
        }

        private void SeedPontosVacinacao(ModelBuilder modelBuilder)
        {
            var pv1 = new PontoVacinacao
            {
                Id = Guid.NewGuid(),
                Nome = "UBS 1 Lago Norte",
                Endereco = "QI 3",
                Longitude = -47.87385383699987,
                Latitude = -15.725453043781098,
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
                Longitude = -15.64796549335305,
                Latitude = -47.75527347168611,
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
                Longitude = -15.65127289695881,
                Latitude = -47.82815052000412,
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