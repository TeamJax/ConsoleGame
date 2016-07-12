using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Entities;
using TeamJaxConsoleGame.Lib.Enumerations;
using TeamJaxConsoleGame.Lib.Scenes;

namespace TeamJaxConsoleGame.Lib.Factory.GameSceneFactory
{
    public class TravelSceneFactory : GameSceneFactory
    {
        public override GameScene CreateScene(Hero hero, Location location)
        {
            Dictionary<string, GameSceneType> menuOptions = new Dictionary<string, GameSceneType>()
            {
                { GameSceneType.Invenotry.ToString(), GameSceneType.Invenotry  },
                { GameSceneType.Town.ToString(), GameSceneType.Town  },
                { GameSceneType.Forest.ToString(), GameSceneType.Forest  },
                { GameSceneType.Shop.ToString(), GameSceneType.Shop  }
            };

            var locationsValues = Enum.GetValues(typeof(Locations));
            //LINQU
            var filteredLocationsValues = locationsValues.OfType<Locations>().ToList().Where(x => x != location.LocationType);//.ToList().Where().AsQueryable().
            var travelOptions = new Dictionary<string, Locations>();

            foreach (var filteredLocation in filteredLocationsValues)
            {
                travelOptions.Add(filteredLocation.ToString(), filteredLocation);
            }

            return new TravelScene(location, hero, GameSceneType.Travel, menuOptions, travelOptions);
        }
    }
}
