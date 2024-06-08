using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CPPclasses;


namespace MetadataGenerator
{
    public class RegionList
    {
        public string Name { get; set; } = "undefined";
        public List<FlatSurface> FlatSurfaces { get; set; } = new();
        public List<SingleVanishingPoint_simplified> SingleVanishingPoints { get; set; } = new();
        public List<DoubleVanishingPoint> DoubleVanishingPoints { get; set; } = new();

        public void SerializeThis()
        {
            using FileStream createStream = File.Create(Name+".json");
            JsonSerializer.SerializeAsync(createStream, this);
        }
    }
}
