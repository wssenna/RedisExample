using ServiceStack.Redis;
using System;

namespace RedisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var Usuario1 = new Usuario
            {
                Nome = "Mirele",
                Cpf = "123456"
            };

            var Usuario2 = new Usuario
            {
                Nome = "Bruna",
                Cpf = "5461231"
            };

            using (var redisClient = new RedisClient("localhost:6379"))
            {
                redisClient.Set<Usuario>(Usuario1.Id.ToString(), Usuario1);

                redisClient.Set<Usuario>(Usuario2.Id.ToString(), Usuario2);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
