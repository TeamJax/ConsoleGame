﻿namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Factory;
    using Interfaces;

    public class Location : GameObject
    {
        private GameFactory locationFactory;

        public Location(string name, string description, GameFactory locationFactory)
        {
            this.LocationDescription = description;
            this.Name = name;
            this.LocationFacotry = locationFactory;
            this.LocationObjects = new List<IGameObject>();
        }

        private string LocationDescription { get; set; }
        
        public IList<IGameObject> LocationObjects { get; set; }

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
        
        public override string GiveDescriptionDescribe()
        {
            var descriptionToReturn = new StringBuilder();
            descriptionToReturn.AppendLine(string.Format("Current location is {0}. {1}", this.Name, this.LocationDescription));

            descriptionToReturn.AppendLine(string.Format("There are currently {0} objects of interest here.", this.LocationObjects.Count));

            foreach (var item in this.LocationObjects)
            {
                descriptionToReturn.AppendLine(item.GiveDescriptionDescribe());
            }

            return descriptionToReturn.ToString();
        }
    }
}
