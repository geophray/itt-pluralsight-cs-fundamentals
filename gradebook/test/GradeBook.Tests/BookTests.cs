using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void OnlyAddsGradesFromZeroToOneHundred()
        {
        //Given
        var book = new InMemoryBook("Grade Test");
        book.AddGrade(101.0);
        book.AddGrade(-1.0);
        //When
        var results = book.GetStatistics();
        //Then
        Assert.Equal(double.MinValue, results.High);
        Assert.Equal(double.MaxValue, results.Low);
        }
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }
    }
}
