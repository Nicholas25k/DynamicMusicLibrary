using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLibraryProcessing
{
    public class InputFileParser
    {
        public static void SubmittedLibraryCSVParser()
        {
            var newDatabaseEntryObject = new DatabasePopulationObject();
            newDatabaseEntryObject.DatabaseEntries = new List<List<string>>();

            //TODO: Replace this hardcoded path with a more dynamic solution
            //TODO: Figure out a solution for reading directly from Excel files
            string filePath = "../UserLibraryProcessing/symphonic_band_library_csv.csv";
            var FileContents = File.ReadLines(filePath);

            var unseperatedCategories = FileContents.First();

            //Categories in the user provided database
            newDatabaseEntryObject.DatabaseCategoriesList = unseperatedCategories.Split(',');

            //TODO: Move this step into file cleaning?
            foreach (string i in FileContents.Skip(1))
            {
                string[] parsedEntry = i.Split(',');

                for (int j = 0; j < parsedEntry.Length; j++)
                {
                    if (parsedEntry[j].Length == 0)
                    {
                        parsedEntry[j] = "N/A";
                    }
                }

                List<string> parsedEntryList = new List<string> (parsedEntry);

                newDatabaseEntryObject.DatabaseEntries.Add(parsedEntryList);

            }

            
        }

        public class DatabasePopulationObject
        {
            //Object used for storing population information for a new database
            public string[]? DatabaseCategoriesList { get; set; }
            public List<List<string>>? DatabaseEntries { get; set; }
        }


    }
}
