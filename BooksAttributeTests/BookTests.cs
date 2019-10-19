using BooksLibraryProject1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BooksAttributeTests
{
    [TestClass]
    public class BookTest1
    {
        [TestMethod]
       
        [ExpectedException(typeof(ArgumentException))]
        public void test_Title()
        {
            Book obj = new Book("Ne", "newAuthor", 94, "0123456789123");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void test_PageNumber()
        {
            Book obj = new Book("NewBook", "newAuthor", 64, "0123456789123");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void test_Isbn()
        {
            Book obj = new Book("NewBook", "newAuthor", 11, "012345678912");
        }
    }
    }

