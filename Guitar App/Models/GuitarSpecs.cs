using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class GuitarSpecs
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int NumberOfStrings {  get; set; }

        public GuitarSpecs(Builder builder, string model, Type type, Wood backwood, Wood topWood, int numberOfStrings)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backwood;
            TopWood = topWood;
            NumberOfStrings = numberOfStrings;
        }
    }
}
