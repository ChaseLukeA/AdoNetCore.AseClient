﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AdoNetCore.AseClient.Enum;
using AdoNetCore.AseClient.Interface;
using AdoNetCore.AseClient.Token;

namespace AdoNetCore.AseClient.Internal
{
    public class TokenParser : ITokenParser
    {
        public IToken[] Parse(Stream stream, Encoding enc)
        {
            return ParseInternal(stream, enc).ToArray();
        }

        private IEnumerable<IToken> ParseInternal(Stream stream, Encoding enc)
        {
            IToken previous = null;
            while (stream.Position < stream.Length)
            {
                var tokenType = (TokenType)stream.ReadByte();

                if (Readers.ContainsKey(tokenType))
                {
                    var t = Readers[tokenType](stream, enc, previous);
                    previous = t;
                    yield return t;
                }
                else
                {
                    Console.WriteLine($"Hit unknown token type {tokenType}");
                    var t = new CatchAllToken(tokenType);
                    t.Read(stream, enc, previous);
                    previous = t;
                    yield return t;
                    //throw new InvalidOperationException($"Unexpected token type {tokenType}");
                }
            }
        }

        private static readonly Dictionary<TokenType, Func<Stream, Encoding, IToken, IToken>> Readers = new Dictionary<TokenType, Func<Stream, Encoding, IToken, IToken>>
        {
            {TokenType.TDS_ENVCHANGE, EnvironmentChangeToken.Create},
            {TokenType.TDS_EED, EedToken.Create },
            {TokenType.TDS_LOGINACK, LoginAckToken.Create }
        };
    }
}
