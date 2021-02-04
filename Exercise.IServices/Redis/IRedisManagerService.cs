using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.IServices.Redis
{
   public interface IRedisManagerService
    {
        string Get(string key);
        bool Set(string key, object t, int expiresSec = 0);
        List<T> Get<T>(string key);
        void Del(string key);
    }
}
