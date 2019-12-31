﻿using System;
using System.Collections.Generic;
using System.Numerics;
using Newtonsoft.Json.Utilities;
using NUnit.Framework;
using UnityEngine;

namespace Newtonsoft.Json.Tests.Aot
{
    [TestFixture]
    public class EnsureTypes
    {
        [SetUp]
        public void TestInitialize()
        {
            AotHelper.EnsureList<bool>(); // used in JsonSerializerTest.DeserializeBooleans
            AotHelper.EnsureList<bool?>(); // used in JsonSerializerTest.DeserializeNullableBooleans
            AotHelper.EnsureList<int>(); // used in ContractResolverTests.ListInterfaceDefaultCreator
            AotHelper.EnsureList<int?>(); // used in JsonSerializerCollectionsTests.DeserializeIEnumerableFromConstructor
            AotHelper.EnsureList<long>(); // used in JsonSerializerTest.ReadTooLargeInteger
            AotHelper.EnsureList<float>(); // used in JsonSerializerTest.ReadStringFloatingPointSymbols
            AotHelper.EnsureList<double>(); // used in JsonSerializerTest.ReadStringFloatingPointSymbols
            AotHelper.EnsureList<double?>(); // used in JsonSerializerTest.DeserializeNullableArray
            AotHelper.EnsureList<decimal>(); // used in JsonSerializerTest.CommentTestClassTest
            AotHelper.EnsureList<BigInteger>(); // used in JsonSerializerTest.ReadTooLargeInteger
            AotHelper.EnsureList<Guid>(); // used in BsonReaderTests
            AotHelper.EnsureList<DateTime>(); // used in DeserializeDateFormatString
            AotHelper.EnsureList<DateTimeOffset?>(); // used in JsonSerializerTest.ReadForTypeHackFixDateTimeOffset
            AotHelper.EnsureList<KeyValuePair<string, IList<string>>?>(); // used in JsonSerializerCollectionsTests.DeserializeNullableKeyValuePairArray
            AotHelper.EnsureList<KeyValuePair<string, IList<string>>>(); // used in JsonSerializerCollectionsTests.DeserializeKeyValuePairArray
            AotHelper.EnsureList<KeyValuePair<string, int>>(); // used in KeyValuePairConverterTests
            AotHelper.EnsureList<KeyValuePair<string, string>>(); // used in Issue1322
            AotHelper.EnsureDictionary<string, decimal>(); // used in JsonSerializerTest.DeserializeDecimalDictionaryExact
            AotHelper.EnsureDictionary<string, int>(); // used in JsonSerializerCollectionsTests.SerializeCustomReadOnlyDictionary
            AotHelper.EnsureDictionary<string, object>(); // used in combination with JsonExtensionDataAttribute, for example in SerializeExtensionData.CustomerInvoice
        }
    }
}
