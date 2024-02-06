

namespace InterviewQuestions
{
    internal static class Question1
    {
        internal static void PrintFiles()
        {
            var folder = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            folder = Path.GetFullPath(Path.Combine(folder, @"..\..\..\QuestionData\Question1Data"));

            int fileCount = Directory.EnumerateFiles(folder).Count();

            List<string> textfiles = Directory.EnumerateFiles(folder, "*.txt").ToList();

            for(int i = 0; i < fileCount; i++)
            {
                Console.WriteLine(textfiles[i]);
            }
        }
        
    }
}
