using System.Xml;

namespace RefactoringExercises.SimplifyObjectCreation
{
    public class ResultsReader
    {
        public void ParseResults(int pupilNumber, Pupil pupil)
        {
            var results = new XmlDocument();
            results.Load("SimplifyObjectCreation/PupilResults.xml");

            pupil.MathsResult = results.SelectSingleNode(string.Format("/pupils/pupil[@number='{0}']/results/result[subject/.='Maths']/grade/text()", pupilNumber)).Value;
            pupil.EnglishResult = results.SelectSingleNode(string.Format("/pupils/pupil[@number='{0}']/results/result[subject/.='English']/grade/text()", pupilNumber)).Value;
            pupil.RunningResult = results.SelectSingleNode(string.Format("/pupils/pupil[@number='{0}']/results/result[subject/.='Running']/grade/text()", pupilNumber)).Value;
        }
    }
}