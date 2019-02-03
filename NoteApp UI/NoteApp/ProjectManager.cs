using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class ProjectManager
    {
        private static string _PathFile = @"";

        public static void SaveToFile (Project se, string filename)
        {
            _PathFile = filename;
            JsonSerializer serializer = new JsonSerializer();
            ///<summary>
            ///открытие потока для записи файла с указанем пути
            ///</summary>
            using (StreamWriter sw = new StreamWriter(filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                ///<summary>
                ///вызов сериализации и передача объекта, который хотим сериализовать
                ///</summary>
                serializer.Serialize(writer, se);
            }
        }
        public static Project LoadFromFile(string filename)
        {
            _PathFile = filename;
            Project deNote = null;
            ///<summary>
            ///если файл отсутствует, создать его и вернуть новый
            ///</summary>
            if (!FileStyleUriParser.Exists(filename))
            {
                deNote = new Project();
                SaveToFile(deNote, filename);
                return deNote;
            }
            ///<summary>
            ///создать экземпляр сериализатора
            ///</summary>
            JsonSerializer serializer = new JsonSerializer();
            ///<summary>
            ///открыть поток для чтения из файда с указанием пути
            ///</summary>
            using (StreamRader sr = new StreamReader(filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                ///<summary>
                ///вызов десериализации и явно преобразуем результат в целевой тип данных
                ///</summary>
                deNote = (Project)serializer.Deserialize<Project>(reader);
            }
            return deNote;
        }
    }
}
