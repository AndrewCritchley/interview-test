using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace FileImporter.Tests
{
    [NUnit.Framework.TestFixture]
    public class FileImporterFixture
    {
        [Test]
        public void It_Should_Create_The_User()
        {
            // Arrange
            var repository = new ShoppaTecRepository();
            var fileImporter = new FileImporter(repository);

            var fileImportLine = new FileImportLine()
            {
                EmailAddress = "bran@storyteller.com",
                Organisation = "Shoppify"
            };

            var expected = new User()
            {
                EmailAddress = "bran@storyteller.com"
            };

            // Act
            fileImporter.Import(fileImportLine);

            // Assert
            repository.GetUsers().Should().HaveCount(1);
            repository.GetUsers().Single().Should().BeEquivalentTo(expected);
        }

        public void It_Should_Create_The_Organisation()
        {

        }

        public void It_Should_Associate_The_User_To_The_Organisation()
        {

        }

        public void It_Should_Not_Add_Duplicate_Email_Addresses()
        {

        }

        public void It_Should_Not_Add_Duplicate_Associations()
        {

        }
    }
}
