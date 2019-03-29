using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonSpring
{
    public class JsonHelper
    {
        private string jsonFile = @"{'email':'jeehyeop@naver.com', 'firstname':'jeehyuep', 'lastname':'kwon'}";

        public Student JsonParser()
        {
            Student s = JsonConvert.DeserializeObject<Student>(jsonFile);
            return s;        
        }

        public void ReadJsonFile(string fileName) 
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                jsonFile = streamReader.ReadToEnd();
            }
        }


    }

    public class Student
    {
        public string email;
        public string firstName;
        public string lastName;
    }
}
