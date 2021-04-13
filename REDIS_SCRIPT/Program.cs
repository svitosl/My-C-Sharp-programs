using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace REDIS_SCRIPT
{
    public class RedisRecord
    {
        public RedisRecord() { }
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase db = redis.GetDatabase();
            var server = redis.GetServer("127.0.0.1", 6379);
            server.Keys(pattern: "group:list*");

            var fromServer = server.Keys(pattern: "group:list*");
            int n = fromServer.Count();                         //колличество записей в базе Redis

            List<RedisRecord> listRecords = new List<RedisRecord>();

            foreach (var key in server.Keys(pattern: "group:list*"))
            {
                RedisRecord rec = new RedisRecord();

                rec.ID = Convert.ToInt32(key.ToString().Split(':')[2]);
                rec.Name = db.StringGet(key);
                listRecords.Add(rec);
            }
            var sortList = from u in listRecords orderby u.ID select u; //выбираем каждый объект listRecords как u, упорядочиваем объекты по возрастанию u.id и выбираем объект u 

            string name = "Kuzmin";
            int pos = -1; // мой номер в списке группы
            int ns = 2; // шаг равен 2

            var sl = sortList.ToList<RedisRecord>();

            Console.WriteLine("////////////Исходный список группы//////////////////////");
            foreach (RedisRecord record in sl)
            {
                Console.WriteLine(record.ID.ToString() + " " + record.Name);
            }

            foreach (RedisRecord record in sl) 
            {
                if (record.Name == name)
                { pos = record.ID; //определили мой номер в списке группы
                    break;
                }
            }

            Console.WriteLine("////////////Список группы выше меня//////////////////////");
            for (int i = pos - 1 - ns; i >= 0; i = i - ns)
            {
                RedisRecord record = sl[i]; 
                Console.WriteLine(record.ID.ToString() + " " + record.Name);
            }

            Console.WriteLine("////////////Список группы ниже меня//////////////////////");
            for (int i = pos - 1 + ns; i >= 0; i = i + ns)
            {
                if (i > sl.Count()) break;
                RedisRecord record = sl[i];
                Console.WriteLine(record.ID.ToString() + " " + record.Name);
            }

            Console.ReadKey();
        }
    }
}
