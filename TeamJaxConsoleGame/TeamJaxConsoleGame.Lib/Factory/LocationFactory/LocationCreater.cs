namespace TeamJaxConsoleGame.Lib.Factory.LocationFactory
{
    using LocationEntitiesFactory;
    using Resources;
    using TeamJaxConsoleGame.Lib.Entities;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class LocationCreater
    {
        public Location CreateLocation(Locations selectedLocations)
        {
            switch (selectedLocations)
            {
                case Locations.Northrend:
                    return new Location(Locations.Northrend.ToString(), LocationResources.NorthrendDescription, new NorthrendFactory(), Locations.Northrend);
                case Locations.Kalimdor:
                    return new Location(Locations.Kalimdor.ToString(),  LocationResources.KalimdorDescription, new KalimdorFactory(), Locations.Kalimdor);
                case Locations.Pandaria:
                    return new Location(Locations.Pandaria.ToString(),  LocationResources.PandariaDescription, new PandariaFactory(), Locations.Pandaria);
                case Locations.EasternKingdoms:
                    return new Location(Locations.EasternKingdoms.ToString(),  LocationResources.EasternKingdomsDescription, new EasternKingdomsFactory(), Locations.EasternKingdoms);
                default:
                    return null;
            }

        }

    }
}
