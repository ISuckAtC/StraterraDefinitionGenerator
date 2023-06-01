public partial class Program
{
    public enum TownBuildingType
    {
        TOWNHALL,
        BARRACKS,
        SMITHY,
        ACADEMY,
        TEMPLE,
        WORKSHOP,
        WAREHOUSE,
        WALL,
        MARKETPLACE
    };

    public struct TownBuilding
    {
        public int id;
        public TownBuildingType type;
        public int buildingTime;
        public string name;
        public int health;
        public byte level;
        public byte maxLevel;
        public int foodCost;
        public int woodCost;
        public int metalCost;
        public int orderCost;
    }

    static void WriteTownBuildings(string[][] values)
    {
        List<TownBuilding> townBuildings = new List<TownBuilding>();

        for (int i = 0; i < 30; ++i)
        {
            TownBuilding townBuilding = new TownBuilding();

            townBuilding.id = int.Parse(values[i][0]);
            if (values[i][1] == ".") continue;
            townBuilding.type = Enum.Parse<TownBuildingType>(values[i][1]);
            townBuilding.buildingTime = int.Parse(values[i][2]);
            townBuilding.name = values[i][3];
            townBuilding.health = int.Parse(values[i][4]);
            townBuilding.level = byte.Parse(values[i][5]);
            townBuilding.maxLevel = byte.Parse(values[i][6]);
            townBuilding.foodCost = int.Parse(values[i][7]);
            townBuilding.woodCost = int.Parse(values[i][8]);
            townBuilding.metalCost = int.Parse(values[i][9]);
            townBuilding.orderCost = int.Parse(values[i][10]);


            townBuildings.Add(townBuilding);
        }


        System.Text.StringBuilder csBuilder = new System.Text.StringBuilder();


        // C# (Unity Client)
        csBuilder.Append("TownBuilding?[] townBuildings = new TownBuilding?[256];\n");
        csBuilder.Append("System.Array.Fill(townBuildings, null);\n\n");
        for (int i = 0; i < townBuildings.Count; ++i)
        {
            TownBuilding townBuilding = townBuildings[i];

            string varName = townBuilding.type.ToString().ToLower() + townBuilding.level.ToString();
            csBuilder.Append("TownBuilding " + varName + " = new TownBuilding();\n");

            csBuilder.Append(varName + ".id = " + townBuilding.id + ";\n");
            csBuilder.Append(varName + ".type = TownBuildingType." + townBuilding.type.ToString() + ";\n");
            csBuilder.Append(varName + ".buildingTime = " + townBuilding.buildingTime + ";\n");
            csBuilder.Append(varName + ".name = " + townBuilding.name + ";\n");
            csBuilder.Append(varName + ".health = \"" + townBuilding.health + "\";\n");
            csBuilder.Append(varName + ".foodCost = " + townBuilding.foodCost + ";\n");
            csBuilder.Append(varName + ".woodCost = " + townBuilding.woodCost + ";\n");
            csBuilder.Append(varName + ".metalCost = " + townBuilding.metalCost + ";\n");
            csBuilder.Append(varName + ".orderCost = " + townBuilding.orderCost + ";\n");
            csBuilder.Append(varName + ".level = " + townBuilding.level + ";\n");
            csBuilder.Append(varName + ".maxLevel = " + townBuilding.maxLevel + ";\n");

            csBuilder.Append("townBuildings[" + townBuilding.id + "] = " + varName + ";\n\n");
        }

        File.WriteAllText("dontinclude/townBuildingsOut.cs", csBuilder.ToString());

        csBuilder.Clear();

        // C++ (Server)
        for (int i = 0; i < townBuildings.Count; ++i)
        {
            TownBuilding townBuilding = townBuildings[i];

            string varName = townBuilding.type.ToString().ToLower() + townBuilding.level.ToString();
            csBuilder.Append("TownBuilding " + varName + "{};\n");

            csBuilder.Append(varName + ".id = " + townBuilding.id + ";\n");
            csBuilder.Append(varName + ".type = " + townBuilding.type.ToString() + ";\n");
            csBuilder.Append(varName + ".buildingTime = " + townBuilding.buildingTime + ";\n");
            csBuilder.Append(varName + ".name = \"" + townBuilding.name + "\";\n");
            csBuilder.Append(varName + ".health = " + townBuilding.health + ";\n");
            csBuilder.Append(varName + ".foodCost = " + townBuilding.foodCost + ";\n");
            csBuilder.Append(varName + ".woodCost = " + townBuilding.woodCost + ";\n");
            csBuilder.Append(varName + ".metalCost = " + townBuilding.metalCost + ";\n");
            csBuilder.Append(varName + ".orderCost = " + townBuilding.orderCost + ";\n");
            csBuilder.Append(varName + ".level = " + townBuilding.level + ";\n");
            csBuilder.Append(varName + ".maxLevel = " + townBuilding.maxLevel + ";\n");

            csBuilder.Append("townBuildingDefinitions[" + townBuilding.id + "] = " + varName + ";\n\n");
        }

        File.WriteAllText("dontinclude/townBuildingsOut.cpp", csBuilder.ToString());
    }
}