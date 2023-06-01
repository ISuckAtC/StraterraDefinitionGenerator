public partial class Program
{
    public enum MapBuildingType
    {
        VILLAGE,
        FARM,
        WOOD,
        MINE,
        HOUSE,
        CASTLE
    };

    public struct MapBuilding
    {
        public int id;
        public MapBuildingType type;
        public int buildingTime;
        public string name;
        public int health;
        public byte level;
        public byte maxLevel;
        public int foodCost;
        public int woodCost;
        public int metalCost;
        public int orderCost;
        public int baseProduction;
    }

    static void WriteMapBuildings(string[][] values)
    {
        List<MapBuilding> mapBuildings = new List<MapBuilding>();

        for (int i = 0; i < 23; ++i)
        {
            MapBuilding mapBuilding = new MapBuilding();

            mapBuilding.id = int.Parse(values[i][0]);
            if (values[i][1] == ".") continue;
            mapBuilding.type = Enum.Parse<MapBuildingType>(values[i][1]);
            mapBuilding.foodCost = int.Parse(values[i][2]);
            mapBuilding.woodCost = int.Parse(values[i][3]);
            mapBuilding.metalCost = int.Parse(values[i][4]);
            mapBuilding.orderCost = int.Parse(values[i][5]);
            mapBuilding.buildingTime = int.Parse(values[i][6]);
            mapBuilding.level = byte.Parse(values[i][7]);
            mapBuilding.maxLevel = byte.Parse(values[i][8]);
            mapBuilding.name = values[i][9];
            mapBuilding.health = int.Parse(values[i][10]);
            mapBuilding.baseProduction = int.Parse(values[i][10]);


            mapBuildings.Add(mapBuilding);
        }


        System.Text.StringBuilder csBuilder = new System.Text.StringBuilder();


        // C# (Unity Client)
        csBuilder.Append("MapBuilding?[] mapBuildings = new MapBuilding?[256];\n");
        csBuilder.Append("System.Array.Fill(mapBuildings, null);\n\n");
        for (int i = 0; i < mapBuildings.Count; ++i)
        {
            MapBuilding mapBuilding = mapBuildings[i];

            string varName = mapBuilding.type.ToString().ToLower() + mapBuilding.level.ToString();
            csBuilder.Append("MapBuilding " + varName + " = new MapBuilding();\n");

            csBuilder.Append(varName + ".id = " + mapBuilding.id + ";\n");
            csBuilder.Append(varName + ".type = TownBuildingType." + mapBuilding.type.ToString() + ";\n");
            csBuilder.Append(varName + ".buildingTime = " + mapBuilding.buildingTime + ";\n");
            csBuilder.Append(varName + ".name = \"" + mapBuilding.name + "\";\n");
            csBuilder.Append(varName + ".health = " + mapBuilding.health + ";\n");
            csBuilder.Append(varName + ".foodCost = " + mapBuilding.foodCost + ";\n");
            csBuilder.Append(varName + ".woodCost = " + mapBuilding.woodCost + ";\n");
            csBuilder.Append(varName + ".metalCost = " + mapBuilding.metalCost + ";\n");
            csBuilder.Append(varName + ".orderCost = " + mapBuilding.orderCost + ";\n");
            csBuilder.Append(varName + ".baseProduction = " + mapBuilding.baseProduction + ";\n");
            csBuilder.Append(varName + ".level = " + mapBuilding.level + ";\n");
            csBuilder.Append(varName + ".maxLevel = " + mapBuilding.maxLevel + ";\n");

            csBuilder.Append("mapBuildings[" + mapBuilding.id + "] = " + varName + ";\n\n");
        }

        File.WriteAllText("dontinclude/mapBuildingsOut.cs", csBuilder.ToString());

        csBuilder.Clear();

        // C++ (Server)
        for (int i = 0; i < mapBuildings.Count; ++i)
        {
            MapBuilding mapBuilding = mapBuildings[i];

            string varName = mapBuilding.type.ToString().ToLower() + mapBuilding.level.ToString();
            csBuilder.Append("MapBuilding " + varName + "{};\n");

            csBuilder.Append(varName + ".id = " + mapBuilding.id + ";\n");
            csBuilder.Append(varName + ".type = " + mapBuilding.type.ToString() + ";\n");
            csBuilder.Append(varName + ".buildingTime = " + mapBuilding.buildingTime + ";\n");
            csBuilder.Append(varName + ".name = \"" + mapBuilding.name + "\";\n");
            csBuilder.Append(varName + ".health = " + mapBuilding.health + ";\n");
            csBuilder.Append(varName + ".foodCost = " + mapBuilding.foodCost + ";\n");
            csBuilder.Append(varName + ".woodCost = " + mapBuilding.woodCost + ";\n");
            csBuilder.Append(varName + ".metalCost = " + mapBuilding.metalCost + ";\n");
            csBuilder.Append(varName + ".orderCost = " + mapBuilding.orderCost + ";\n");
            csBuilder.Append(varName + ".baseProduction = " + mapBuilding.baseProduction + ";\n");
            csBuilder.Append(varName + ".level = " + mapBuilding.level + ";\n");
            csBuilder.Append(varName + ".maxLevel = " + mapBuilding.maxLevel + ";\n");

            csBuilder.Append("mapBuildings[" + mapBuilding.id + "] = " + varName + ";\n\n");
        }

        File.WriteAllText("dontinclude/mapBuildingsOut.cpp", csBuilder.ToString());
    }
}