namespace RefactoringExercises.SimplifyObjectCreation
{
    public class PupilFinder
    {
        private readonly PupilDetailsReader _pupilDetailsReader = new PupilDetailsReader();
        private readonly ResultsReader _resultsReader = new ResultsReader();

        public Pupil Find(string name)
        {
            var pupil = new Pupil();

            var pupilNumber = _pupilDetailsReader.ParseDetails(name, pupil);

            _resultsReader.ParseResults(pupilNumber, pupil);

            return pupil;
        }
    }
}