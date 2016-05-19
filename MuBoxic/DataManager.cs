using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuBoxic
{
    class DataManager
    {
        private List<Artist> _cache = new List<Artist>();

        private static DataManager defaultItem;

        public static DataManager GetDefaultItem()
        {
            if (defaultItem == null)
            {
                defaultItem = new DataManager();
            }

            return defaultItem;
        }

        private DataManager()
        {

        }

        public void Add(Artist artist)
        {
            _cache.Add(artist);
        }

        public List<Artist> GetAllBy(string key, object value)
        {
            return _cache.Where(p =>
            {
                object obtainedValue = p.GetType().GetProperty(key);
                if (value == null && obtainedValue == null)
                {
                    return true;
                }
                return obtainedValue != null && obtainedValue == value;
            }).ToList();
        }

        public void DeleteAll(string key, object value, int count)
        {
            foreach(var item in GetAllBy(key, value))
            {
                _cache.Remove(item);
            }
        }

        public bool Delete(string key, object value, int count)
        {
            foreach(var item in GetAllBy(key, value))
            {
                if (count <= 0)
                {
                    break;
                }
                _cache.Remove(item);
            }

            return count == 0;
        }

        public bool Delete(string key, object value)
        {
            try
            {
                return _cache.Remove(GetAllBy(key, value)[0]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }

            return false;
        }
    }
}
