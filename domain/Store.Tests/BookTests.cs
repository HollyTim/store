using System;
using Xunit;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithBlankString_ReturnFalse()
        {
            bool actual = Book.IsIsbn("    ");
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalideIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_Returntrue()
        {
            bool actual = Book.IsIsbn("IsBn 123-121-234 0");
            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn13_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 123-456-789 0123");
            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_Returntrue()
        {
            bool actual = Book.IsIsbn("xxxxIsBn 123-121-234 0yyyy");
            Assert.False(actual);
        }
    }
}
