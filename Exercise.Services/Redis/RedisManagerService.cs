using Exercise.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Exercise.IServices.Redis;
namespace Exercise.Services.Redis
{
    public class RedisManagerService: IRedisManagerService
    {
        public string Get(string key)
        {
            return RedisHelper.Get(key);
        }
        public List<T> Get<T>(string key)
        {
            var key_list = RedisHelper.Get(key);
            if (!string.IsNullOrWhiteSpace(key_list))
                return JsonConvert.DeserializeObject<List<T>>(RedisHelper.Get(key));
            else
                return null;
        }

        public bool Set(string key, object value, int expiresSec = 0)
        {
            return RedisHelper.Set(key, value, expiresSec);
        }

        public void Del(string key)
        {
            RedisHelper.Del(key);
        }
    }
}
