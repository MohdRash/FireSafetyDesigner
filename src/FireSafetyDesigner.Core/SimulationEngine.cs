namespace FireSafetyDesigner.Core
{
    public class SimulationEngine
    {
        public string PerformAnalysis(BuildingLayout layout)
        {
            // Advanced simulation logic will go here
            // For now, a placeholder based on the new structure
            return $"Analysis performed on building with {layout.Rooms.Count} rooms. Result: Safe.";
        }
    }

    public class BuildingLayout
    {
        public string? Name { get; set; }
        public List<Room>? Rooms { get; set; }

        public BuildingLayout()
        {
            Rooms = new List<Room>();
        }
    }

    public class Room
    {
        public string? Name { get; set; }
        public double Area { get; set; }
        public Material? WallMaterial { get; set; }
        // Add more properties as needed, e.g., doors, windows, contents
    }

    public class Material
    {
        public string? Name { get; set; }
        public double FireResistanceRating { get; set; } // e.g., in hours
        // Add more properties as needed, e.g., smoke production, heat release rate
    }
}