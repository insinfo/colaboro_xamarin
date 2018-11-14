using Colaboro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboro.Services
{
    public class BairroDataStore
    {
        public List<Bairro> bairros;

        public BairroDataStore()
        {
            bairros = new List<Bairro>() {
                new Bairro(){nome="Alphaville"},
                new Bairro(){nome="Âncora"},
                 new Bairro(){nome="Atlântica"},
                 new Bairro(){nome="Balneário das Garças"},
                 new Bairro(){nome="Balneário Remanso"},
                 new Bairro(){nome="Boca da Barra"},
                 new Bairro(){nome="Bosque Beira Rio"},
                 new Bairro(){nome="Bosque da Areia"},
                 new Bairro(){nome="Bosque da Praia"},
                 new Bairro(){nome="Cantagalo"},
                 new Bairro(){nome="Cantinho do Mar"},
                 new Bairro(){nome="Casa Grande"},
                 new Bairro(){nome="Centro"},
                 new Bairro(){nome="Chácara Mariléa"},
                 new Bairro(){nome="Cidade Beira Mar"},
                 new Bairro(){nome="Cidade Praiana"},
                 new Bairro(){nome="Colinas"},
                 new Bairro(){nome="Condomínio Porto Seguro"},
                 new Bairro(){nome="Costazul"},
                 new Bairro(){nome="Enseada das Gaivotas"},
                 new Bairro(){nome="Extensão do Bosque"},
                 new Bairro(){nome="Extensão Novo Rio das Ostras"},
                 new Bairro(){nome="Extensão Serramar"},
                 new Bairro(){nome="Fazenda Palmeiras"},
                 new Bairro(){nome="Floresta das Gaivotas"},
                 new Bairro(){nome="Gelson Apicelo"},
                 new Bairro(){nome="Jardim Bela Vista"},
                 new Bairro(){nome="Jardim Campomar"},
                 new Bairro(){nome="Jardim Mariléa"},
                 new Bairro(){nome="Jardim Miramar"},
                 new Bairro(){nome="Jardim Patrícia"},
                 new Bairro(){nome="Liberdade"},
                 new Bairro(){nome="Mar do Norte"},
                 new Bairro(){nome="Mar Y Lago"},
                 new Bairro(){nome="Maria Turri"},
                 new Bairro(){nome="Nova Aliança"},
                 new Bairro(){nome="Nova Cidade"},
                 new Bairro(){nome="Nova Esperança"},
                 new Bairro(){nome="Novo Rio das Ostras"},
                 new Bairro(){nome="Operário"},
                 new Bairro(){nome="Ouro Verde"},
                 new Bairro(){nome="Palmital"},
                 new Bairro(){nome="Parque São Jorge"},
                 new Bairro(){nome="Parque Zabulão"},
                 new Bairro(){nome="Peroba"},
                 new Bairro(){nome="Praia Mar"},
                 new Bairro(){nome="Recanto"},
                 new Bairro(){nome="Recreio"},
                 new Bairro(){nome="Reduto da Paz"},
                 new Bairro(){nome="Residencial Camping do Bosque"},
                 new Bairro(){nome="Residencial Rio das Ostras"},
                 new Bairro(){nome="Rocha Leão"},
                 new Bairro(){nome="São Cristóvão"},
                 new Bairro(){nome="Serramar"},
                 new Bairro(){nome="Sobradinho Cerveja"},
                 new Bairro(){nome="Terra Firme"},
                 new Bairro(){nome="Terras do Contorno"},
                 new Bairro(){nome="Verdes Mares"},
                 new Bairro(){nome="Vila Real"},
                 new Bairro(){nome="Village Rio das Ostras"},
                 new Bairro(){nome="Village Sol e Mar"},
                 new Bairro(){nome="Viverde I"},
                 new Bairro(){nome="Zona Zen"},

            };
        }

        public List<Bairro> GetItems()
        {
            return bairros;
        }
    }
}
