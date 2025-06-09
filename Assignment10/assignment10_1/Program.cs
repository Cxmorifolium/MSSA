using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(100, "Lewis Carroll", 4.0, 100, new DateTime(2025, 1, 1));

        // XML SERIALIZATION
        Console.WriteLine("XML SERIALIZATION");
        XmlSerializeDeserialize(student);
        Console.WriteLine();

        // JSON SERIALIZATION
        Console.WriteLine("JSON SERIALIZATION");
        JsonSerializeDeserialize(student);

        Console.ReadKey();
    }

    // XML Serialization and Deserialization
    static void XmlSerializeDeserialize(Student student)
    {
        try
        {
            // Serialize to XML
            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            using (FileStream stream = new FileStream("student.xml", FileMode.Create))
            {
                serializer.Serialize(stream, student);
            }
            Console.WriteLine("XML serialization completed. File: student.xml");

            // Deserialize from XML
            using (FileStream stream = new FileStream("student.xml", FileMode.Open))
            {
                Student deserializedStudent = (Student)serializer.Deserialize(stream);
                Console.WriteLine("XML deserialization result:");
                Console.WriteLine(deserializedStudent);
            }

            // Display XML content
            string xmlContent = File.ReadAllText("student.xml");
            Console.WriteLine("XML Content:");
            Console.WriteLine(xmlContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"XML serialization error: {ex.Message}");
        }
    }

    // JSON Serialization and Deserialization
    static void JsonSerializeDeserialize(Student student)
    {
        try
        {
            // Serialize to JSON
            string jsonString = JsonSerializer.Serialize(student, new JsonSerializerOptions 
            { 
                WriteIndented = true 
            });
            File.WriteAllText("student.json", jsonString);
            Console.WriteLine("JSON serialization completed. File: student.json");

            // Display JSON content
            Console.WriteLine("JSON Content:");
            Console.WriteLine(jsonString);

            // Deserialize from JSON
            string jsonFromFile = File.ReadAllText("student.json");
            Student deserializedStudent = JsonSerializer.Deserialize<Student>(jsonFromFile);
            Console.WriteLine("JSON deserialization result:");
            Console.WriteLine(deserializedStudent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"JSON serialization error: {ex.Message}");
        }
    }
}