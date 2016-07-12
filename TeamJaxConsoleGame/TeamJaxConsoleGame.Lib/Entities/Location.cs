namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;
    using Factory.LocationEntitiesFactory;
    using Enumerations;
    /// <summary>
    /// The different locations in the game where the player can travel around
    /// </summary>
    public class Location : GameObject
    {
        private GameFactory locationFactory;
        
        public Location(string name, string description, GameFactory locationFactory, Locations locationType)
        {
            this.LocationDescription = description;
            this.Name = name;
            this.LocationFacotry = locationFactory;
            this.LocationObjects = new List<IGameObject>();
            this.LocationType = locationType;
        }
        
        public string LocationDescription { get; set; }
        
        public IList<IGameObject> LocationObjects { get; set; }

        public Locations LocationType { get; set; }

        public GameFactory LocationFacotry
        {
            get
            {
                return this.locationFactory;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(value.ToString(), "Location facotry can not be null");
                }

                this.locationFactory = value;
            }
        }
        
        public override string GiveDescription()
        {
            var descriptionToReturn = new StringBuilder();
            descriptionToReturn.AppendLine(string.Format("Current location is {0}. {1}", this.Name, this.LocationDescription));

            descriptionToReturn.AppendLine(string.Format("There are currently {0} objects of interest here.", this.LocationObjects.Count));

            foreach (var item in this.LocationObjects)
            {
                descriptionToReturn.AppendLine(item.GiveDescription());
            }

            return descriptionToReturn.ToString();
        }
    }
}
