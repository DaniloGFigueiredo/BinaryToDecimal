using System;
using Xunit;

namespace BinaryToDecimal.Test.UnitTests.TestSeeds
{
    public sealed class BinaryToDecimalServiceSeedData
    {
        public string Input { get; }
        public string Result { get; }

        public BinaryToDecimalServiceSeedData(string input, string result)
        {
            Input = input;
            Result = result;
        }
    }

    public sealed class BinaryToDecimalServiceSeed : TheoryData<BinaryToDecimalServiceSeedData>
    {
        public BinaryToDecimalServiceSeed()
        {

            Add(new BinaryToDecimalServiceSeedData("101","5"));
            Add(new BinaryToDecimalServiceSeedData("101010","42"));
            Add(new BinaryToDecimalServiceSeedData("101010101011", "2731"));
        }
    }
}

