using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TubesKPL
{
    internal class KendaraanConfig
    {
        public ACuciKendaraan aCuciConfig;
        public const string filepath = @"kendaraan_config.json";
        public ACuciKendaraan ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filepath);
            aCuciConfig = JsonSerializer.Deserialize<ACuciKendaraan>(configJsonData);
            return aCuciConfig;
        }
        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };

            String jsonString = JsonSerializer.Serialize(aCuciConfig);
            File.WriteAllText(filepath, jsonString);
        }
        private void SetDefault()
        {
            aCuciConfig = new ACuciKendaraan("Mobil Default", "Mobil");
        }

        public KendaraanConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }
    }
}
