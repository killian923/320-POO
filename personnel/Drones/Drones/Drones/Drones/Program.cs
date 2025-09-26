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

            //Drone drone = new Drone("Damien", 50, 100);

            Building building = new Building(700, 500, Color.DarkRed, 100, 50);

            Factory factory = new Factory(300, 250, Color.Gray, 100, 100);


            ville.Add(building);
            usine.Add(factory);
            //fleet.Add(drone);
            for (int i = 0; i < 10; i++)

            {

                fleet.Add(new Drone($"Damien{i}", 50, 50));

            }


            try
            {
                // Démarrage
                Application.Run(new AirSpace(fleet, ville, usine));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}