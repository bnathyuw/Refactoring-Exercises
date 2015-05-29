using System.IO;
using System.Linq;

namespace RefactoringExercises.SimplifyObjectCreation
{
    public class PupilDetailsReader
    {
        public int ParseDetails(string name, Pupil pupil)
        {
            var lines = File.ReadLines(string.Format("SimplifyObjectCreation/{0}.txt", name.Replace(" ", "")));

            var values = lines.Select(line => line.Split(':')).ToDictionary(bits => bits[0].Trim(), bits => bits[1].Trim());

            pupil.Name = values["Name"];
            pupil.Nickname = values["Nickname"];
            pupil.BestFriend = values["Best friend"];

            return int.Parse(values["Pupil number"]);
        }
    }
}