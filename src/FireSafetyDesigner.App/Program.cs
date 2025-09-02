using FireSafetyDesigner.Core;

Class1 core = new Class1();
Console.WriteLine(core.GetMessage());

// Instantiate the SimulationEngine
SimulationEngine engine = new SimulationEngine();

// Create a sample building layout
var fireResistantMaterial = new Material { Name = "Fire-Resistant Drywall", FireResistanceRating = 2.0 };
var standardMaterial = new Material { Name = "Standard Drywall", FireResistanceRating = 0.5 };

var room1 = new Room { Name = "Living Room", Area = 30.5, WallMaterial = fireResistantMaterial };
var room2 = new Room { Name = "Kitchen", Area = 15.0, WallMaterial = standardMaterial };
var room3 = new Room { Name = "Bedroom", Area = 20.0, WallMaterial = fireResistantMaterial };

var buildingLayout = new BuildingLayout
{
    Name = "Sample Building",
    Rooms = new List<Room> { room1, room2, room3 }
};

// Perform analysis
string analysisResult = engine.PerformAnalysis(buildingLayout);

Console.WriteLine(analysisResult);
