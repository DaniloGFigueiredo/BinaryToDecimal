using BinaryToDecimal.Domain;
using BinaryToDecimal.Service;
using BinaryToDecimal.Test.UnitTests.TestSeeds;
using FluentAssertions;
using Moq;
using Xunit;

namespace BinaryToDecimal.Test.UnitTests
{
    public sealed class BinaryToDecimalServiceTests
    {
        [Theory]
        [ClassData(typeof(BinaryToDecimalServiceSeed))]
        public void Given_a_valid_binary_sequences_when_using_transfrom_binary_to_decimal_should_return_correct_converted_decimal_values(BinaryToDecimalServiceSeedData binaryToDecimalServiceSeedData)
        {
            //arrange
            var binarySequence = binaryToDecimalServiceSeedData.Input;
            var service = new BinaryToDecimalService();
            //act
            var result = service.TransformBinaryToDecimal(binarySequence);
            //assert
            result.Should().Be(binaryToDecimalServiceSeedData.Result);
        }

        [Fact]
        public void Given_an_invalid_binary_sequences_when_using_transfrom_binary_to_decimal_should_return_a_warning_message()
        {
            //arrange
            var invalidBinarySequence = "1011n1";
            var expectedMessage = "O sistema apenas aceita valores binarios '1' ou '0'";
            var service = new BinaryToDecimalService();
            //act
            var result = service.TransformBinaryToDecimal(invalidBinarySequence);
            //assert
            result.Should().Be(expectedMessage);
        }
    }
}

