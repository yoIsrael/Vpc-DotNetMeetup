using System;
using System.Collections.ObjectModel;
using VPCXamarinTraining.DTO;
using VPCXamarinTraining.ViewModels.Base;

namespace VPCXamarinTraining.ViewModels
{
    public class SoccerTeamsViewModel : ViewModelBase
    {
        #region Atributtes

        private ObservableCollection<SoccerTeamDTO> teamsList;

        private SoccerTeamDTO teamSelected;

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
                }
            }
        }

        #endregion

        #region Constructor

        public SoccerTeamsViewModel()
        {
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
        }

        #endregion

    }
}
