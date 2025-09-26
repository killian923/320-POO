using Drones;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Building> ville = new List<Building>(); 
            List<Factory> usine = new List<Factory>();
            List<Store> magasin = new List<Store>();



            Building building = new Building(700, 500, Color.DarkRed, 100, 50);

            Factory factory = new Factory(300, 250, Color.Gray, 100, 100);

            Store store = new Store(100, 150, Color.Green, 50, 50, new string[] { "Lundi: 8h - 18h", "Mardi: 8h - 18h", "Mercredi: 8h - 18h" });


            ville.Add(building);
            usine.Add(factory);
            magasin.Add(store);
            //fleet.Add(drone);
            for (int i = 0; i < 1; i++)

            {

                fleet.Add(new Drone($"Damien{i}", 50, 50));

            }


            try
            {
                // Démarrage
                Application.Run(new AirSpace(fleet, ville, usine, magasin));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}