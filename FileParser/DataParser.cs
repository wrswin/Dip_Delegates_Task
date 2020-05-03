using System.Collections.Generic;

namespace FileParser {
    public class DataParser {
        

        /// <summary>
        /// Strips any whitespace before and after a data value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripWhiteSpace(List<List<string>> data) {
            var result = new List<List<string>>();

            foreach(var line in data) {
                var resultColumns = new List<string>();

                foreach(var column in line) {
                    resultColumns.Add(column.Trim());
                }

                result.Add(resultColumns);
            }

            return result;
        }

        /// <summary>
        /// Strips quotes from beginning and end of each data value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripQuotes(List<List<string>> data) {
            var result = new List<List<string>>();

            foreach(var line in data) {
                var resultColumns = new List<string>();

                foreach(var column in line) {
                    resultColumns.Add(column.Trim('"'));
                }

                result.Add(resultColumns);
            }

            return result;
        }

    }
}