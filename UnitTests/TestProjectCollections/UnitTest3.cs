using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using PhoneBook;

namespace TestProjectCollections
{
    public class UnitTest3
    {
        private PhoneDirectory _phoneDirectory = new PhoneDirectory();

        [Fact]
        public void PutNumber_In2StringsNameAndNumber_OutExpectPhoneDirectoryToContainEntry()
        {
            //Arrange

            //Act
            _phoneDirectory.PutNumber("Adam", "25839584");
            //Assert
            Assert.True(_phoneDirectory.Find("Adam"));
            Assert.Equal("25839584", _phoneDirectory.GetNumber("Adam"));
        }

        [Fact]
        public void PutNumber_InPhoneEntry_OutExpectPhoneDirectoryToContainEntry()
        {
            //Arrange
            PhoneEntry entry = new PhoneEntry("Bobby", "29254828");
            //Act
            _phoneDirectory.PutNumber(entry);
            //Assert
            Assert.True(_phoneDirectory.Find("Bobby"));
            Assert.Equal("29254828", _phoneDirectory.GetNumber("Bobby"));
        }

        [Fact]
        public void Find_InNothing_OutExpectToGetAnEntry()
        {
            //Arrange
            PhoneEntry entry = new PhoneEntry("Charlie", "29252527");
            _phoneDirectory.PutNumber(entry);
            //Act
            bool EntryExists = _phoneDirectory.Find("Charlie");
            //Assert
            Assert.True(EntryExists);
        }

        [Fact]
        public void GetNumber_InNameAsString_OutNumberAsString()
        {
            //Arrange
            _phoneDirectory.PutNumber(new PhoneEntry("Delty", "2684952"));
            string expected = "2684952";
            //Act
            string actual = _phoneDirectory.GetNumber("Delty");
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDict_InNothing_OutSortedDictionaryObject()
        {
            //Arrange
            SortedDictionary<string, string> expected = new SortedDictionary<string, string> ();
            //Act
            var actual = _phoneDirectory.GetDict();
            //Assert
            Assert.IsType<SortedDictionary<string, string>>(actual);
        }
    }
}

