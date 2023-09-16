namespace FolderStructureDuplicator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Duplicateur de structure de dossiers =====\n\n");

            //Get the source folder
            Console.Write("Veuillez indiquer l'adresse du répertoire dont la structure est à dupliquer: ");
            string sourceFolder = Console.ReadLine();
            Console.WriteLine();

            //Get the target folder
            Console.Write("Veuillez indiquer l'adresse du répertoire dans lequel la structure sera répliquée: ");
            string destinationFolder = Console.ReadLine();
            Console.WriteLine();

            //Generates the structure
            string[] sourceSubFolders = Directory.GetDirectories(sourceFolder);

            //Trim the source path
            for (int i = 0; i < sourceSubFolders.Length; i++)
            {
                string[] temp = sourceSubFolders[i].Split('\\');
                sourceSubFolders[i] = temp[(temp.Length - 1)];
            }

            //Generates the duplication
            for (int i = 0; i < sourceSubFolders.Length; i++)
            {
                string newDirectory = destinationFolder + "\\" + sourceSubFolders[i];
                Directory.CreateDirectory(newDirectory);
            }

            //Final message
            Console.WriteLine("Opération terminé.");
            Console.WriteLine("Fin du programme, appuyez sur n'importe quelle touche ...");
            Console.ReadKey();
        }
    }
}