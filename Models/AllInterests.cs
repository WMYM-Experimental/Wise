using System.Collections.ObjectModel;

namespace Wise.Models
{
    public class AllInterests
    {
        public ObservableCollection<Interest> Interests { get; set; } = new ObservableCollection<Interest>();

        public AllInterests()
        {
            LoadInterests();
        }

        public void LoadInterests()
        {
            Interests.Clear();

            string appDataPath = FileSystem.AppDataDirectory;

            IEnumerable<Interest> interests = Directory.EnumerateFiles(
                appDataPath,
                "*.notes.txt"
                ).Select(
                filename => new Interest(){
                    Name = File.ReadAllText(filename),
                })
                .OrderBy(i => i.Name);

            foreach (Interest i in interests)
            {
                Interests.Add(i);
            }
        }
    }
}
