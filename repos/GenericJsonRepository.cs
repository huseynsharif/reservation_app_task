using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace ReservationSystem.repos
{
    internal abstract class GenericJsonRepository<T>
    {

        public abstract string FilePath { get; set; }
        public abstract int GetLastId();

        public void Add(T item)
        {
            List<T> datas;
            if (File.Exists(FilePath))
            {
                datas = GetAll();
            }
            else
            {
                datas = new List<T>();
            }
            datas.Add(item);

            WriteToJson(datas);

        }

        public void WriteToJson(List<T> datas)
        {
            string updatedJson = JsonConvert.SerializeObject(datas, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, updatedJson);
        }

        public List<T> GetAll()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            else
            {
                return new List<T>();
            }
        }

    }
}
