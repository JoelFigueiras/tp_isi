using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace project_isi
{
    internal class Program
    {
        // ^[A-Z][a-z]* ([A-Z]|[0-9])([a-z]|[0-9]).* (expressao regular para marcas de carros)
        // ([1]|[2])[0-9]{3} (expressão regular para ano dos carros)
        // [0-9]* (preço carro)
        // [0-9]* (km's carro)
        //[A-Z](([a-z]|[A-Z])+) (combustivel)
        // [A-Z]([a-z]+) (tipo de caixa velocidades)
        //[A-Z]([a-z]+) (numero propietario)
        //@"^[A-Z][a-z]* ([A-Z]|[0-9])([a-z]|[0-9]).*,([1]|[2])[0-9]{3},[0-9]*,[0-9]*,[A-Z](([a-z]|[A-Z])+),[A-Z]([a-z]+),[A-Z]([a-z]+))$";
        static void Main(string[] args)
        {

            string ficheiro = @"..\..\csv_files\car_details.csv";
            string destinojson = @"..\..\json_files\car_details.json";            
            string destinoxml = @"..\..\xml_files\car_details.xml";
            string er = @"[^,]+,([1]|[2])[0-9]{3},[0-9]*,[0-9]*,[A-Za-z,]+,[^\n]+";
            string csvString = null;
            List<Veiculo> listaVeiculos = new List<Veiculo>();
            string jsonString;


            foreach (string line in File.ReadLines(ficheiro))
            {
                csvString = line;
                Regex g = new Regex(er);
                Match m = g.Match(csvString);

                if (m.Success)
                {

                    string[] campos = m.Value.Split(',');
                    string nome = campos[0];
                    int ano = Convert.ToInt32(campos[1]);
                    int preco = Convert.ToInt32(campos[2]);
                    int km = Convert.ToInt32(campos[3]);
                    string fuel = campos[4];
                    string transmissao = campos[6];
                    string n_dono = campos[7];
                    string tipo_dono = campos[5];
                    Veiculo veiculo = new Veiculo(nome, ano, preco, km, fuel, transmissao, n_dono, tipo_dono);

                    listaVeiculos.Add(veiculo);

                }
                else
                {


                    Console.WriteLine($"{line}");
                }


            }
         
            jsonString = System.Text.Json.JsonSerializer.Serialize(listaVeiculos);
            jsonString = "{\"Carro\": " + jsonString + "}";


            if (!File.Exists(destinojson))
            {
                File.WriteAllText(destinojson, jsonString);
            }
            else
            {
                File.WriteAllText(destinojson, jsonString);
            }
            XNode node = JsonConvert.DeserializeXNode(jsonString, "Carros");
            XmlDocument doc = new XmlDocument();
            File.WriteAllText(destinoxml, node.ToString());

        }
    }
}
