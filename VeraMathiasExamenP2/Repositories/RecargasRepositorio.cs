using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using VeraMathiasExamenP2.Models;

namespace VeraMathiasExamenP2.Repositories
{
    public class RecargasRepositorio
    {
        public string _filename = Path.Combine(FileSystem.AppDataDirectory, "MathiasVera.txt");
        public VeraMathiasRecarga DevuelveInfoRecarga()
        {
            return new VeraMathiasRecarga()
            {
                Id = 1,
                Numero=0979386716,
                Nombre="Mathias"
            };
        }

        public void GuardarEnArchivo(VeraMathiasRecarga veraMathiasRecarga)
        {
            string json = JsonConvert.SerializeObject(veraMathiasRecarga);
            File.WriteAllText(_filename, json);
        }

        public VeraMathiasRecarga ObtenerInformacionRecarga()
        {
            VeraMathiasRecarga veraMathiasRecarga = new VeraMathiasRecarga();
            if (File.Exists(_filename))
            {
                string data = File.ReadAllText(_filename);
                veraMathiasRecarga = JsonConvert.DeserializeObject<VeraMathiasRecarga>(data);
            }
            return veraMathiasRecarga;
        }
    }
}
