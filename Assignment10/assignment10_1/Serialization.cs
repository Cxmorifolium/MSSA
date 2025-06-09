using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace assignment10_1
{
    public class Serialization
    {
        // JSON Serialization
        public void SerializeToJson(List<Student> students, string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText(filePath, json);
                Console.WriteLine($"Students serialized to JSON: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"JSON Serialization Error: {ex.Message}");
            }
        }

        public List<Student> DeserializeFromJson(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    var students = JsonConvert.DeserializeObject<List<Student>>(json);
                    Console.WriteLine($"Students deserialized from JSON: {filePath}");
                    return students ?? new List<Student>();
                }
                else
                {
                    Console.WriteLine("JSON file not found.");
                    return new List<Student>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"JSON Deserialization Error: {ex.Message}");
                return new List<Student>();
            }
        }

        // XML Serialization
        public void SerializeToXml(List<Student> students, string filePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(fs, students);
                }
                Console.WriteLine($"Students serialized to XML: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"XML Serialization Error: {ex.Message}");
            }
        }

        public List<Student> DeserializeFromXml(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        var students = (List<Student>)serializer.Deserialize(fs);
                        Console.WriteLine($"Students deserialized from XML: {filePath}");
                        return students ?? new List<Student>();
                    }
                }
                else
                {
                    Console.WriteLine("XML file not found.");
                    return new List<Student>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"XML Deserialization Error: {ex.Message}");
                return new List<Student>();
            }
        }
    }
}