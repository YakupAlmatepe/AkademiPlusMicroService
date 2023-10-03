﻿using StackExchange.Redis;

namespace AkademiPlusMicroservice.Basket.Services
{
    public class RedisService
    {
        private readonly string _host;
        private readonly string _port;
        private ConnectionMultiplexer _multiplexer;

        public RedisService(string host, string port)
        {
            _host = host;
            _port = port;
        }
        public void Connect() => _multiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");

        public IDatabase GetDb(int db = 1) => _multiplexer.GetDatabase(db);

    }
}
