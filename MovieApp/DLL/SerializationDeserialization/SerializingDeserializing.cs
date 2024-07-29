using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieClasses.Models;
using Newtonsoft.Json;

namespace MovieClasses.SerializationDeserialization
{
    public class SerializingDeserializing
    {
        public static void Serialize(List<Movie> movies)
        {
            File.WriteAllText("Movies.json", JsonConvert.SerializeObject(movies));

        }

        public static List<Movie> Deserialize()
        {
            List<Movie> list = new List<Movie>();
            string filename = "Movies.json";
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                list = JsonConvert.DeserializeObject<List<Movie>>(json);
            }
            return list;
        }
    }
}
