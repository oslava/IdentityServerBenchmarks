using BenchmarkDotNet.Attributes;
using IdentityServer4.Models;
using IdentityServer4.Stores.Serialization;

namespace IdentityServerBenchmarks
{
    public class SerializerTests
    {
        private readonly PersistentGrantSerializer _serializer = new PersistentGrantSerializer();

        private string json = "{\"Audiences\":[\"http://localhost.dev.ru:1111/resources\",\"api.auth\"],\"Issuer\":\"http://localhost.dev.ru:1111\",\"CreationTime\":\"2018-11-21T05:57:39Z\",\"Lifetime\":3600,\"Type\":\"access_token\",\"ClientId\":\"Security.SampleHybrid\",\"AccessTokenType\":1,\"Claims\":[{\"Type\":\"client_id\",\"Value\":\"Security.SampleHybrid\",\"ValueType\":\"http://www.w3.org/2001/XMLSchema#string\"},{\"Type\":\"scope\",\"Value\":\"openid\",\"ValueType\":\"http://www.w3.org/2001/XMLSchema#string\"},{\"Type\":\"scope\",\"Value\":\"profile\",\"ValueType\":\"http://www.w3.org/2001/XMLSchema#string\"},{\"Type\":\"scope\",\"Value\":\"auth.sid\",\"ValueType\":\"http://www.w3.org/2001/XMLSchema#string\"},{\"Type\":\"sub\",\"Value\":\"3de81a2e-de0c-4680-8075-5872ab88ee96\",\"ValueType\":\"http://www.w3.org/2001/XMLSchema#string\"},{\"Type\":\"auth_time\",\"Value\":\"1542331446\",\"ValueType\":\"http://www.w3.org/2001/XMLSchema#integer\"},{\"Type\":\"idp\",\"Value\":\"portal\",\"ValueType\":\"http://www.w3.org/2001/XMLSchema#string\"},{\"Type\":\"amr\",\"Value\":\"pwd\",\"ValueType\":\"http://www.w3.org/2001/XMLSchema#string\"},{\"Type\":\"auth_sid\",\"Value\":\"2XXX\",\"ValueType\":\"http://www.w3.org/2001/XMLSchema#string\"}],\"Version\":4}";

        [Benchmark]
        public void DeserializeInstance()
        {
            var serializer = new PersistentGrantSerializer();
            var s = serializer.Deserialize<Token>(json);
        }

        [Benchmark]
        public void CreateInstance()
        {
            var serializer = new PersistentGrantSerializer();
        }

        [Benchmark]
        public void DeserializeSingleton()
        {
            var s = _serializer.Deserialize<Token>(json);
        }
    }
}