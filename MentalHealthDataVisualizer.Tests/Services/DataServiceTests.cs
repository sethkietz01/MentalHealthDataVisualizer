using Xunit;
using MentalHealthDataVisualizer.Models;
using System.Collections.Generic;

namespace MentalHealthDataVisualizer.Tests
{
    public class DataServiceTests
    {
        // Test when data is sum when data is valid
        [Fact]
        public void GetDemographicSummaries_ShouldSumTalliesCorrectly()
        {
            // Arrange
            var service = new DataService();
            var fakeData = new List<AmiPrevalence>
            {
                new AmiPrevalence { demographic = "Male", tally = 100 },
                new AmiPrevalence { demographic = "Female", tally = 50 },
                new AmiPrevalence { demographic = "Female", tally = 20 }
            };

            // Act
            var result = service.GetDemographicSummaries(fakeData);

            // Assert
            var maleResult = result.Find(r => r.Demographic == "Male");
            var femaleResult = result.Find(r => r.Demographic == "Female");

            Assert.Equal(100, maleResult.TotalTally);
            Assert.Equal(70, femaleResult.TotalTally);
        }

        // Test when data is empty
        [Fact]
        public void GetDemographicSummaries_ShouldReturnEmptyList_WhenInputIsEmpty()
        {
            // Arrange
            var service = new DataService();
            var emptyData = new List<AmiPrevalence>();

            // Act
            var result = service.GetDemographicSummaries(emptyData);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void GetAgeCategorySummaries_ShouldExcludeEmptyAgeCategories()
        {
            // Arrange
            var service = new DataService();
            var mixedData = new List<AmiPrevalence>
            {
                new AmiPrevalence { age_category = "18-25", tally = 50 },
                new AmiPrevalence { age_category = "", tally = 999 }, // Should be ignored
                new AmiPrevalence { age_category = null, tally = 888 } // Should be ignored
            };

            // Act
            var result = service.GetAgeCategorySummaries(mixedData);

            // Assert
            Assert.Single(result); // Only one valid category should exist
            Assert.Equal("18-25", result[0].AgeCategory);
            Assert.Equal(50, result[0].TotalTally);
        }
    }
}