﻿using System.Collections.Generic;
using System.IO;
using AdoNetCore.AseClient.Internal;
using Newtonsoft.Json;
using NUnit.Framework;

namespace AdoNetCore.AseClient.Tests.Integration
{
    [TestFixture]
    public class InternalConnectionTests
    {
        private readonly Dictionary<string, string> _connectionStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("ConnectionStrings.json"));

        public InternalConnectionTests()
        {
            Logger.Enable();
        }

        [Test]
        public void Ping_ShouldWork()
        {
            using (var connection = ConnectionPoolManager.Reserve(ConnectionParameters.Parse(_connectionStrings["default"])))
            {
                Assert.IsTrue(connection.Ping());
            }
        }
    }
}
