using System;
using System.Collections.ObjectModel;
using System.Linq;
using VPCXamarinTraining.DTO;
using VPCXamarinTraining.ViewModels.Base;
using Xamarin.Forms;

namespace VPCXamarinTraining.ViewModels
{
    public class SoccerTeamsViewModel : ViewModelBase
    {
        #region Atributtes

        private ObservableCollection<SoccerTeamDTO> teamsList;

        private SoccerTeamDTO teamSelected;

        private INavigation _navigation;

        #endregion

        #region Properties

        public ObservableCollection<SoccerTeamDTO> TeamsList
        {
            get { return teamsList; }
            set
            {
                teamsList = value;
                OnPropertyChanged();
            }
        }

        public SoccerTeamDTO TeamSelected
        {
            get { return teamSelected; }
            set
            {
                if (teamSelected != value)
                {
                    teamSelected = value;
                    OnPropertyChanged();
                    _navigation.PushAsync(new Pages.TeamSelected(teamSelected));
                }
            }
        }

        #endregion

        #region Constructor

        public SoccerTeamsViewModel(INavigation Navigation)
        {
            _navigation = Navigation;
            TeamsList = new ObservableCollection<SoccerTeamDTO>();

            LoadTeams();
        }

        #endregion

        #region Private Methods

        private void LoadTeams()
        {
            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "Atlético Nacional",
                Detail = "Rey de Copas",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Escudo_de_Atl%C3%A9tico_Nacional.svg/150px-Escudo_de_Atl%C3%A9tico_Nacional.svg.png",
                Description = @"Cuenta el señor Carlos Serna, escritor antioqueño, que en 1947 Alberto Villegas Lopera, un ex presidente de la Liga Antioqueña de fútbol, lideró la fundación de una sociedad comercial destinada a estimular los deportes y establecer el fútbol y el baloncesto profesional en Antioquia. La sociedad inició labores con $50.000 aportados por 500 socios en acciones de $100 pesos cada una, pagaderas en un primer contado de $20 pesos al momento de ingresar a la sociedad y los $80 restantes en un máximo de 12 cuotas mensuales. Así pues, el viernes 7 de marzo de 1947 se comenzó a gestar el nacimiento de la nueva Institución bajo el nombre de Club Atlético Municipal de Medellín, pero por escritura pública la nueva sociedad se constituyó el 30 de abril de 1947 en la notaría primera de Medellín. En 1950 se cambió el nombre por Atlético Nacional y desde allí siempre ha sido el mismo. El origen nacionalista, cuenta Serna en su libro sobre el elenco Verdolaga, viene de la fusión de dos equipos como Unión e Indulana que participaban con ruido en los torneos de la Liga de Fútbol de Antioquia de ese entonces, pero realmente el 30 de abril de 1947 está establecida como la fecha en que se comenzó esta linda historia. 
                Era un sueño ambicioso.Se trataba de convertir al Atlético Nacional en un equipo que hiciera honor a su nombre,
                integrado únicamente por jugadores colombianos.Un cuadro criollo protagonista del torneo colombiano y que poco a poco pudiera avanzar en el afianzamiento de un estilo propio que nos abriera amplios horizontes en el futuro.Hoy,
                casi setenta años más tarde de su aparición,
                con el nombre de Atlético Municipal,
                vemos con satisfacción que buena parte de los objetivos se han cumplido.Setenta años a lo largo de los cuales el equipo verde y blanco de Antioquia se ha consolidado como el verdadero símbolo del fútbol colombiano.Siete décadas llenas de logros y satisfacciones.Catorce estrellas en el torneo de la Dimayor.La primera en el 54 cuando apenas se consolidaba el fútbol nuestro,
                superada la etapa del Dorado.Y el logro continental de la Copa Libertadores en 1989 como el trofeo más grande de una insuperable historia que además cuenta con la mayor cantidad de adeptos en el país por la popularidad de los colores y la representatividad de las conquistas."
            });

            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "Independiente Medellín",
                Detail = "El Poderoso",
                ImageUrl = "https://pbs.twimg.com/profile_images/813380675793457152/pejf01uB.jpg",
                Description = @"El Deportivo Independiente Medellín, más conocido como el DIM o simplemente Medellín, es un club de fútbol colombiano fundado bajo el nombre de «Medellín Football Club» 14 de noviembre de 1913 por Alberto Uribe Piedrahíta. Perteneciente a la ciudad de Medellín, capital del departamento de Antioquia. Actualmente juega en la Categoría Primera A del Fútbol Profesional Colombiano. Disputa los partidos como local en el Estadio Atanasio Girardot.
                                Durante el amateurismo, el club fue siete veces campeón nacional. A su vez, logró ocho veces el campeonato de la Liga Antioqueña de Primera División, consolidándose de esta forma como el club más veces campeón de este ámbito.
                                Desde el inicio del profesionalismo en 1948, el Independiente Medellín ha obtenido seis veces el campeonato colombiano (1955, 1957, Finalización 2002, Apertura 2004, Finalización 2009, y Apertura 2016), y en una ocasión la Copa Colombia (1981). Ha faltado en cinco temporadas de la Categoría Primera A: En 1952, 1953, 1958, 1971 y 1972."
            });

            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "Millonarios",
                Detail = "El Embajador",
                ImageUrl = "http://s3.amazonaws.com/WidgetResultadosWin/images/teams/9401.png",
                Description = @"El Azul & Blanco Millonarios Fútbol Club S. A. mejor conocido como Millonarios,6 es un club de fútbol de la ciudad de Bogotá, capital de Colombia. Es uno de los clubes más laureados y emblemáticos de Colombia, por lo tanto, es considerado uno de los clubes más grandes del país.7 Los orígenes del equipo se remontan hasta la década del 20, pero fue empezado a llamar como Los Millonarios en el año de 1939 cuando su nombre era Club Municipal de Deportes; oficialmente fue fundado el 18 de junio de 1946 bajo el nombre de Club Deportivo Los Millonarios y, posteriormente, como Millonarios Fútbol Club el 20 de abril de 2011 cuando fue reconstituido como Sociedad Anónima. Participa en la máxima categoría de la División Mayor del Fútbol Colombiano, la Categoría Primera A o Liga Águila, desde su fundación en 1948 siendo uno de los tres únicos equipos que ha participado en todos sus torneos, junto a Independiente Santa Fe y a Atlético Nacional.
                                Es el segundo equipo más laureado del fútbol colombiano con 17 títulos en total entre campeonatos nacionales e internacionales.8 En su palmarés adornan 14 campeonatos del torneo local de la liga Colombiana, y se registra 2 títulos de la Copa Colombia. También, logró coronarse como campeón continental en la última edición de la Copa Merconorte en el año 2001, además de algunos otros torneos amistosos internacionales.
                                Es regido por la Federación Colombiana de Fútbol y la DIMAYOR a nivel nacional, y por la Confederación Sudamericana de Fútbol (CONMEBOL) y la Federación Internacional de Fútbol Asociación (FIFA) a escala internacional.
                                A partir del inicio del campeonato colombiano en 1948 logró la mayor cantidad de los títulos locales que se disputaron y conformó un equipo denominado el Ballet Azul, que era considerado de gran importancia a nivel mundial durante la primera parte de la década de los años 1950, cuando consiguió muchos triunfos internacionales, entre los que destacan el Campeonato de las Bodas de Oro del Real Madrid y la Pequeña Copa del Mundo de Clubes de 1953, que le dieron los calificativos del equipo 'Embajador'."
            });

            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "Envigado",
                Detail = "La Cantera",
                ImageUrl = "http://as00.epimg.net/img/comunes/fotos/fichas/equipos/large/3841.png",
                Description = @"El club nace en el municipio de Envigado al sur del Área Metropolitana de Medellín, sin embargo, su debut en el fútbol profesional se dio en el año 1991 con la creación del Torneo de ascenso. En esa primera temporada, Envigado F. C. superó al Alianza Llanos, Atlético Huila y El Cóndor de Bogotá para lograr el cupo en la Primera División. Por aquel entonces, en el equipo naranja militaban jugadores como Hugo Tuberquia, Sergio Guzmán, Samuel Cárdenas, Édgar Carvajal, entre otros, bajo la dirección técnica de Hugo Castaño.
                                En la campaña 2005-I consiguió por tercera vez clasificarse a los cuadrangulares semifinales de la Primera A.
                                Posteriormente, el 12 de noviembre de 2006 en desarrollo del Finalización, descendió nuevamente a la Primera B, luego de perder con el Cúcuta Deportivo 1-0, concluyendo una participación de 15 años consecutivos en la primera división.3 Regresando de esta forma al lugar en el cual se inició al fútbol profesional."
            });

            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "America",
                Detail = "La Mechita",
                ImageUrl = "http://as01.epimg.net/img/comunes/fotos/fichas/equipos/large/3952.png",
                Description = @"La Sociedad Anónima Deportiva América S.A., conocida como América de Cali o simplemente América, es un club de fútbol colombiano de la ciudad de Santiago de Cali; es considerado uno de los clubes más grandes de Colombia y más importantes de Sudamérica.7 Fue fundado el domingo 13 de febrero de 1927. Disputa sus partidos en el Estadio Olímpico Pascual Guerrero, el color que identifica al club desde sus inicios es el rojo escarlata.
                                Con 13 títulos, es el tercer equipo con más campeonatos oficiales de la Liga Colombiana ganados; también logró ser campeón de la Categoría Primera B en 2016. A nivel internacional tiene cuatro subcampeonatos de la Copa Libertadores de América en los años 1985, 1986, 1987 y 1996. También, logró coronarse como campeón continental en la Copa Merconorte del año 1999; en total suma 15 títulos oficiales entre nacionales e internacionales, además de varios torneos amistosos."
            });

            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "Deportivo Pasto",
                Detail = "Los Volcánicos",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6b/Deportivo_Pasto_logo.png",
                Description = @"El Deportivo Pasto es un club de fútbol de la ciudad de Pasto, Nariño. Fue fundado el 12 de octubre de 1949.1 3 Actualmente juega en la Categoría Primera A del fútbol profesional colombiano y disputa los encuentros como local en el Estadio Departamental Libertad con capacidad para 28.400 espectadores.
                                Ascendió por primera vez a la máxima categoría en 1998. Históricamente, el Deportivo Pasto fue el primer equipo que llegado del ascenso salió campeón del torneo nacional 2006 y el primero en llegar a una final 2002. En total, el equipo tiene en su haber un título de Categoría Primera A, dos subcampeonatos, 12 presencias en fases finales y dos subcampeonatos de Copa Colombia como máximos logros nacionales y la clasificación a la Copa Sudamericana 2003, la Copa Libertadores 2007 y la Copa Sudamericana 2013 como éxitos internacionales."
            });

            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "Santa Fe",
                Detail = "Los Cardenales",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Escudo_de_Independiente_Santa_Fe.svg/1200px-Escudo_de_Independiente_Santa_Fe.svg.png",
                Description = @"El Club Independiente Santa Fe S. A., conocido como Independiente Santa Fe , o simplemente Santa Fe, es un club de fútbol de la ciudad de Bogotá, capital de Colombia. El club de los Cardenales, o el Expreso Rojo, como es conocido popularmente y considerado uno de los clubes más grandes de Colombia y el mundo durante el año 2016.11 se identifica por ser el primer campeón del fútbol profesional colombiano en la temporada de 1948. 
                                Es el tercer equipo más exitoso del fútbol colombiano con 16 títulos de primera división en competiciones oficiales, entre nacionales e internacionales. Fue el primer club colombiano en ganar la Copa Sudamericana en 2015 y el primer club colombiano en ganar un trofeo oficial fuera de América, la Copa Suruga Bank en 2016. Ha ganado nueve veces el campeonato de la Categoría Primera A, la más reciente en el Finalización 2016; dos Copas Colombia, en 1989 y 2009; además siendo el más veces campeón de la Superliga de Colombia, en 2013, 2015 y 2017, también posee dos títulos internacionales: la Copa Sudamericana 2015 y la Copa Suruga Bank 2016."
            });

            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "Junior",
                Detail = "El Tiburón",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Escudo_del_Junior_de_Barranquilla.svg/140px-Escudo_del_Junior_de_Barranquilla.svg.png",
                Description = @"El Club Atlético Junior, también conocido como Junior de Barranquilla, Atlético Junior o simplemente Junior, es un club de fútbol de la ciudad de Barranquilla, Colombia. Fue fundado el 7 de agosto de 1924 convirtiéndose en el tercer club más antiguo del país.12 A nivel deportivo se ha consagrado campeón de la Primera división del fútbol profesional colombiano en siete ocasiones (1977, 1980, 1993, 1995, 2004-II, 2010-I, 2011-II).13 Además, ganó la Copa Colombia 2015, que reúne a los equipos pertenecientes a las categorías profesionales del fútbol colombiano.
                                A nivel internacional, cuenta con (19) participaciones oficiales en torneos internacionales organizados por la Conmebol. Junior es el quinto club del Fútbol Profesional Colombiano con más participaciones internacionales oficiales, siendo el mejor de la Región Caribe del país ubicado en ese rubro.15 Además, ha sido el único en representar en calidad de selección nacional a Colombia en un Campeonato Sudamericano (actual Copa América) obteniendo la Copa Mariscal Sucre destinada a la mejor selección entre los equipos Bolivarianos."
            });

            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "Cali",
                Detail = "Azucareros",
                ImageUrl = "http://as00.epimg.net/img/comunes/fotos/fichas/equipos/large/4201.png",
                Description = @"El Deportivo Cali es un club deportivo de la ciudad de Santiago de Cali, en el Departamento del Valle del Cauca. Fundado el 23 de noviembre de 1912 como (Cali Football Club) que después de pasar por dos re-estructuraciones desde su fundación por cuestiones económicas, en el año de 1959 se constituye como asociación y es reconocida oficialmente en 1962 lo que en la actualidad es la Asociación Deportivo Cali, hoy en día tiene 104 años. El Deportivo Cali es más conocido como un club de fútbol, aunque compite en otras disciplinas como el baloncesto,14 el tenis, la natación y futsal.
                                En sus inicios como equipo amateur conquistó los títulos departamentales en los años 1927, 1928, 1929, 1930, 1931, 1934, 1935, y 1936. En su rama de fútbol profesional, ha obtenido los títulos en 1965, 1967, 1969, 1970, 1974, 1996, 1998, 2005 y 2015 de la Categoría Primera A siendo de esta forma el cuarto club más ganador, además de esto, posee el título de la Copa Colombia, trofeo que obtuvo en el 2010 y el título de Superliga de Colombia del año 2014, lo que lo convierte en el quinto club más ganador de la División Mayor del Fútbol Colombiano con 11 títulos oficiales."
            });

            TeamsList.Add(new SoccerTeamDTO
            {
                id = Guid.NewGuid(),
                Name = "Once Caldas",
                Detail = "El Blanco Blanco",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Once_Caldas_logo-svg.svg/1200px-Once_Caldas_logo-svg.svg.png",
                Description = @"El Once Caldas, es un club de fútbol de Colombia, tiene su sede en la ciudad de Manizales, departamento de Caldas, fue refundado el 15 de enero de 1961 sobre la historia del Deportes Caldas, equipo que había jugado los cuatro primeros campeonatos de la Categoría Primera A entre 1948 y 1952. Actualmente juega en la Categoría Primera A de Colombia.
                                El color que identifica al club es el blanco, el cual utiliza en su uniforme desde 1961. El equipo ejerce de local en el Estadio Palogrande de Manizales, que tiene una capacidad de 28 678 espectadores.
                                El Once Caldas ha sido campeón cuatro veces del fútbol profesional colombiano, en 1950, en el Apertura de 2003, en el Apertura de 2009 y en el Finalización de 2010. En 2004 se coronó campeón de la Copa Libertadores de América derrotando en la final al que era el vigente campeón Boca Juniors de Argentina convirtiéndose en el segundo equipo colombiano en conseguir este título."
            });

            TeamsList = new ObservableCollection<SoccerTeamDTO>(TeamsList.OrderBy(x => x.Name));
        }

        #endregion

    }
}
