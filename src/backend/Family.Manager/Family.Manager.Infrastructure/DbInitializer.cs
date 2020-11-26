using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.Configurations;
using System;
using System.Collections.Generic;

namespace Family.Manager.Infrastructure
{
    public static class DbInitializer
    {
        public static void Initialize(FamilyContext familyContext)
        {
            familyContext.Database.EnsureCreated();

            var families = new List<Domain.Entities.Family>
            {
                new Domain.Entities.Family("Família Souza", "Rua do Arroz, 123, Pq Novo Mundo, Americana", "1936217471", "19998877890", "Católica", "Santa Clara", string.Empty, 3),
                new Domain.Entities.Family("Família Alves", "Rua do Feijão, 456, Pq Novo Mundo, Americana", "1936217472", "19998877891", "Católica", "Nossa Senhora Aparecida", "Necessário 2 cestas básicas", 8),
                new Domain.Entities.Family("Família Rodrigues", "Rua do Macarrão, 789, Pq Novo Mundo, Americana", "1936217473", "19998877892", "Católica", "Par. São Francisco de Assis", string.Empty, 5),
                new Domain.Entities.Family("Família Pedroso", "Rua do Botão, 987, Pq Novo Mundo, Americana", "1936217474", "19998877893", "Católica", "N. Senhora de Fátima", "Necessário 3 cestas básicas", 11),
                new Domain.Entities.Family("Família Teste", "Rua do Trigo, 111, Pq Novo Mundo, Americana", "1936217475", "19998877894", "-", "-", "Necessário 5 cestas básicas", 15),
                new Domain.Entities.Family("Família Pereira", "Rua da Farinha, 222, Pq Novo Mundo, Americana", "1936217476", "19998877895", "Evangélica", "Comunidade da Fé Church", string.Empty, 4),
                new Domain.Entities.Family("Família Trab", "Rua Pirassununga, 333, Pq Novo Mundo, Americana", "1936217477", "19998877896", "Evangélica", "Comunidade da Fé Church", string.Empty, 5),
                new Domain.Entities.Family("Família Bento", "Rua Guarulhos, 444, Pq Novo Mundo, Americana", "1936217478", string.Empty, "Evangélica", "Comunidade da Fé Church", string.Empty, 6),
                new Domain.Entities.Family("Família Garcia", "Rua Rio Claro, 555, Pq Novo Mundo, Americana", "1936217479", string.Empty, "-", "Possui filhos gêmeos", "Necessário 4 cestas básicas", 4),
                new Domain.Entities.Family("Família Cabral", "Rua Rio Negro, 666, Pq Novo Mundo, Americana", string.Empty, "19998877897", "-", "-", "Necessário 4 cestas básicas", 7)
            };

            var kinships = new List<Kinship>
            {
                new Kinship("Pai", "José de Souza", families[0].Id),
                new Kinship("Avó", "Lucia", families[0].Id),
                new Kinship("Mãe", "Zeza Alves", families[1].Id),
                new Kinship("Mãe", "Renata Rodrigues", families[2].Id),
                new Kinship("Pai", "Mario Pedroso Júnior", families[3].Id),
                new Kinship("Pai", "Vinícius Teste", families[4].Id),
                new Kinship("Mãe", "Maria Pereira de Albuquerque", families[5].Id),
                new Kinship("Mãe", "Mãe Trab", families[6].Id),
                new Kinship("Avó", "Aparecida Bento", families[7].Id),
                new Kinship("Tio", "Yoda Kappa", families[8].Id),
                new Kinship("Mãe", "Ana Garcia", families[9].Id),
                new Kinship("Pai", "Dorval", families[9].Id),
                new Kinship("Pai", "Roberto Cabral", families[9].Id)
            };

            families[0].AddKinships(new List<Kinship> { kinships[0], kinships[1] });
            families[1].AddKinships(new List<Kinship> { kinships[2] });
            families[2].AddKinships(new List<Kinship> { kinships[3] });
            families[3].AddKinships(new List<Kinship> { kinships[4] });
            families[4].AddKinships(new List<Kinship> { kinships[5] });
            families[5].AddKinships(new List<Kinship> { kinships[6] });
            families[6].AddKinships(new List<Kinship> { kinships[7] });
            families[7].AddKinships(new List<Kinship> { kinships[8] });
            families[8].AddKinships(new List<Kinship> { kinships[9] });
            families[9].AddKinships(new List<Kinship> { kinships[10], kinships[11] });

            var kids = new List<Kid>
            {
                new Kid("Vinicius de Souza Avansini", new DateTime(2015, 6, 22), string.Empty, families[0].Id),
                new Kid("Leonardo Alves", new DateTime(2014, 1, 7), string.Empty, families[1].Id),
                new Kid("Julia Rodrigues", new DateTime(2000, 5, 20), string.Empty, families[2].Id),
                new Kid("Guilherme Rodrigues", new DateTime(2011, 6, 21), string.Empty, families[2].Id),
                new Kid("Tatiane Pedroso", new DateTime(2015, 2, 24), string.Empty, families[3].Id),
                new Kid("Mario do Teste", new DateTime(2013, 12, 20), string.Empty, families[4].Id),
                new Kid("Lucas Pereira", new DateTime(2018, 4, 1), "Necessário chupeta", families[5].Id),
                new Kid("Yoda Trab", new DateTime(2020, 3, 5), "Necessário fralda", families[6].Id),
                new Kid("Chico Bento", new DateTime(2019, 10, 10), "Necessário fralda", families[7].Id),
                new Kid("Felipe Garcia", new DateTime(2020, 6, 12), "Necessário fralda", families[8].Id),
                new Kid("Vitor Garcia", new DateTime(2020, 6, 12), "Necessário fralda", families[8].Id),
                new Kid("Murilo Cabral", new DateTime(2017, 9, 7), "Necessário fralda", families[9].Id)
            };

            kids[0].UpdateReligionInformation(new KidReligionInformation(kids[0], isBaptized: true));
            kids[1].UpdateReligionInformation(new KidReligionInformation(kids[1], isBaptized: true));
            kids[2].UpdateReligionInformation(new KidReligionInformation(kids[2], isBaptized: true, doneCatechesis: true, doneConfirmationSacrament: true));
            kids[3].UpdateReligionInformation(new KidReligionInformation(kids[3], isBaptized: true, doingPerse: true));
            kids[4].UpdateReligionInformation(new KidReligionInformation(kids[4]));
            kids[5].UpdateReligionInformation(new KidReligionInformation(kids[5]));
            kids[6].UpdateReligionInformation(new KidReligionInformation(kids[6]));
            kids[7].UpdateReligionInformation(new KidReligionInformation(kids[7]));
            kids[8].UpdateReligionInformation(new KidReligionInformation(kids[8]));
            kids[9].UpdateReligionInformation(new KidReligionInformation(kids[9]));
            kids[10].UpdateReligionInformation(new KidReligionInformation(kids[10]));
            kids[11].UpdateReligionInformation(new KidReligionInformation(kids[11]));

            familyContext.Families.AddRange(families);
            familyContext.Kids.AddRange(kids);
            familyContext.SaveChanges();
        }
    }
}
