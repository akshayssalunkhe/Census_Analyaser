using CensusAnalyserProblem;
using NUnit.Framework;

namespace CensusAnalyserTest
{
    public class CensusAnalyserTestCases
    {
        //GIVING FILE PATH
        static string STATE_CENSUS_DATA_PATH = "C:/Users/de/source/repos/CensusAnalyserProblem/CensusAnalyserTest/resource/StateCensusData.csv";

        //GIVING WRONG FILE PATH
        static string STATE_CENSUS_DATA_WRONG_PATH = "src/test/resources/StateCensusDa.csv";

        //GIVING WRONG FILE EXTENSION
        static string FILE_WITH_WRONG_EXTENSION = "C:/Users/de/source/repos/CensusAnalyserProblem/CensusAnalyserTest/resource/StateCensusWithWrongExtension.txt";

        //GIVING WRONG FILE DELIMITER
        static string FILE_WITH_INCORRECT_DELIMITER = "src/test/resources/StateCensusDataIncorrectDelimiter.csv";

        //GIVING WRONG FILE HEADER
        static string FILE_WITH_WRONG_HEADER = "C:/Users/de/source/repos/CensusAnalyserProblem/CensusAnalyserTest/resource/StateCensusDataWithWrongHeader.csv";

        //CREATING OBJECT
        CensusAnalyser censusAnalyser = new CensusAnalyser();

        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void givenStatesCensusCSVFile_WhenNumberOfRecordsMatches_ShouldReturnTrue()
        {

            int numberOfRecord = censusAnalyser.loadStateCSVData(STATE_CENSUS_DATA_PATH);
            Assert.AreEqual(29, numberOfRecord);




        }
    }
}