using Tdd;

namespace TddTest
{
    public class LogTest
    {
        [Fact]
        public void Return_substring_after_separator()
        {
            var log = "[INFO]: File Deleted.";
            Assert.Equal("File Deleted.", log.SubstringAfter(": ")); 
        }
        [Fact]
        public void Return_substring_after_separator_II()
        {
            var log = "[INFO]";
            Assert.Equal("INFO]", log.SubstringAfter("["));
        }

        [Fact]
        public void Return_substring_between_two_strings()
        {
            var log = "[INFO]: File Deleted.";
            Assert.Equal("INFO", log.SubstringBetween("[", "]")); // => returns "INFO"
        }

        [Fact]
        public void Return_message()
        {
            var log = "[ERROR]: Missing ; on line 20.";
            Assert.Equal("Missing ; on line 20.", log.Message());
        }

        [Fact]
        public void Return_log_level()
        {
            var log = "[ERROR]: Missing ; on line 20.";
            Assert.Equal("ERROR", log.LogLevel());
        }


    }
}
