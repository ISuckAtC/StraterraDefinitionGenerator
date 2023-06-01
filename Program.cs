global using System;
global using System.Net.Http;

string apiKey = "AIzaSyBWUsAqcWvcdNyi-WnGCaj_WswpF832exc";



HttpClient client = new HttpClient();

var response = await client.GetAsync("https://sheets.googleapis.com/v4/spreadsheets/16BbMSgm6UyzQhtFXTUMxHHDnvdjGvdfq0CaI7_lNWi4/values/Units!A2:AA41?key=" + apiKey);

string sResponse = await response.Content.ReadAsStringAsync();


SheetResponse sheet = System.Text.Json.JsonSerializer.Deserialize<SheetResponse>(sResponse);

var values = sheet.values;

List<Unit> units = new List<Unit>();

for (int i = 0; i < 40; ++i)
{
    Unit unit = new Unit();

    unit.id = int.Parse(values[i][0]);
    unit.name = values[i][1];
    if (unit.name == String.Empty) continue;
    unit.level = byte.Parse(values[i][2]);
    unit.maxLevel = byte.Parse(values[i][3]);
    unit.preference = Enum.Parse<UnitType>(values[i][4]);
    unit.unitType = Enum.Parse<UnitType>(values[i][5]);
    unit.speed = byte.Parse(values[i][6]);
    unit.range = byte.Parse(values[i][7]);
    unit.meleeAttack = byte.Parse(values[i][8]);
    unit.rangeAttack = byte.Parse(values[i][9]);
    unit.meleeDefence = byte.Parse(values[i][10]);
    unit.rangeDefence = byte.Parse(values[i][11]);
    unit.health = byte.Parse(values[i][12]);
    unit.bonusDamage = new Dictionary<UnitType, int>();
    if (values[i][13] != String.Empty)
    {
        string[] bonusDamages = values[i][13].Split(';');
        for (int k = 0; k < bonusDamages.Length; ++k)
        {
            int colonIndex = bonusDamages[k].IndexOf(':');
            string target = bonusDamages[k].Substring(0, colonIndex);
            string damage = bonusDamages[k].Substring(colonIndex + 1);

            unit.bonusDamage.Add(Enum.Parse<UnitType>(target), int.Parse(damage));
        }
    }
    unit.counterBonus = byte.Parse(values[i][14]);
    unit.hoverText = values[i][15];
    unit.trainingTime = int.Parse(values[i][16]);
    unit.spritePath = values[i][17];
    unit.upgradeFoodCost = int.Parse(values[i][18]);
    unit.upgradeWoodCost = int.Parse(values[i][19]);
    unit.upgradeMetalCost = int.Parse(values[i][20]);
    unit.upgradeOrderCost = int.Parse(values[i][21]);
    unit.upgradeTime = int.Parse(values[i][22]);
    unit.foodCost = int.Parse(values[i][23]);
    unit.woodCost = int.Parse(values[i][24]);
    unit.metalCost = int.Parse(values[i][25]);
    unit.orderCost = int.Parse(values[i][26]);

    units.Add(unit);
}


System.Text.StringBuilder csBuilder = new System.Text.StringBuilder();


// C# (Unity Client)
csBuilder.Append("Unit?[] units = new Unit?[256];\n");
csBuilder.Append("System.Array.Fill(units, null);\n\n");
for (int i = 0; i < units.Count; ++i)
{
    Unit unit = units[i];

    string varName = unit.name.ToLower() + unit.level.ToString();

    csBuilder.Append("Unit " + varName + " = new Unit();\n");
    csBuilder.Append(varName + ".id = " + unit.id + ";\n");
    csBuilder.Append(varName + ".name = \"" + unit.name + "\";\n");
    csBuilder.Append(varName + ".level = " + unit.level + ";\n");
    csBuilder.Append(varName + ".maxLevel = " + unit.maxLevel + ";\n");
    csBuilder.Append(varName + ".preference = UnitType." + unit.preference.ToString() + ";\n");
    csBuilder.Append(varName + ".unitType = UnitType." + unit.unitType.ToString() + ";\n");
    csBuilder.Append(varName + ".speed = " + unit.speed + ";\n");
    csBuilder.Append(varName + ".range = " + unit.range + ";\n");
    csBuilder.Append(varName + ".meleeAttack = " + unit.meleeAttack + ";\n");
    csBuilder.Append(varName + ".rangeAttack = " + unit.rangeAttack + ";\n");
    csBuilder.Append(varName + ".meleeDefence = " + unit.meleeDefence + ";\n");
    csBuilder.Append(varName + ".rangeDefence = " + unit.rangeDefence + ";\n");
    csBuilder.Append(varName + ".health = " + unit.health + ";\n");

    csBuilder.Append(varName + ".bonusDamage = new Dictionary<UnitType, int>();\n");
    for (int k = 0; k < unit.bonusDamage.Count; ++k)
    {
        UnitType target = unit.bonusDamage.Keys.ElementAt(k);
        int damage = unit.bonusDamage.Values.ElementAt(k);
        csBuilder.Append(varName + ".bonusDamage.Add(UnitType." + target.ToString() + ", " + damage.ToString() + ");\n");
    }

    csBuilder.Append(varName + ".counterBonus = " + unit.counterBonus + ";\n");
    csBuilder.Append(varName + ".hoverText = \"" + unit.hoverText + "\";\n");
    csBuilder.Append(varName + ".trainingTime = " + unit.trainingTime + ";\n");
    csBuilder.Append(varName + ".spritePath = \"" + unit.spritePath + "\";\n");
    csBuilder.Append(varName + ".upgradeFoodCost = " + unit.upgradeFoodCost + ";\n");
    csBuilder.Append(varName + ".upgradeWoodCost = " + unit.upgradeWoodCost + ";\n");
    csBuilder.Append(varName + ".upgradeMetalCost = " + unit.upgradeMetalCost + ";\n");
    csBuilder.Append(varName + ".upgradeOrderCost = " + unit.upgradeOrderCost + ";\n");
    csBuilder.Append(varName + ".upgradeTime = " + unit.upgradeTime + ";\n");
    csBuilder.Append(varName + ".foodCost = " + unit.foodCost + ";\n");
    csBuilder.Append(varName + ".woodCost = " + unit.woodCost + ";\n");
    csBuilder.Append(varName + ".metalCost = " + unit.metalCost + ";\n");
    csBuilder.Append(varName + ".orderCost = " + unit.orderCost + ";\n");
    
    csBuilder.Append("units[" + unit.id + "] = " + varName + ";\n\n");
}

File.WriteAllText("dontinclude/out.cs", csBuilder.ToString());

csBuilder.Clear();

// C++ (Server)
for (int i = 0; i < units.Count; ++i)
{
    Unit unit = units[i];

    string varName = unit.name.ToLower() + unit.level.ToString();

    csBuilder.Append("Unit " + varName + "{};\n");
    csBuilder.Append(varName + ".id = " + unit.id + ";\n");
    csBuilder.Append(varName + ".name = \"" + unit.name + "\";\n");
    csBuilder.Append(varName + ".level = " + unit.level + ";\n");
    csBuilder.Append(varName + ".maxLevel = " + unit.maxLevel + ";\n");
    csBuilder.Append(varName + ".preference = " + unit.preference.ToString() + ";\n");
    csBuilder.Append(varName + ".unitType = " + unit.unitType.ToString() + ";\n");
    csBuilder.Append(varName + ".speed = " + unit.speed + ";\n");
    csBuilder.Append(varName + ".range = " + unit.range + ";\n");
    csBuilder.Append(varName + ".meleeAttack = " + unit.meleeAttack + ";\n");
    csBuilder.Append(varName + ".rangeAttack = " + unit.rangeAttack + ";\n");
    csBuilder.Append(varName + ".meleeDefence = " + unit.meleeDefence + ";\n");
    csBuilder.Append(varName + ".rangeDefence = " + unit.rangeDefence + ";\n");
    csBuilder.Append(varName + ".health = " + unit.health + ";\n");

    csBuilder.Append(varName + ".bonusDamageCount = " + unit.bonusDamage.Count + ";\n");
    for (int k = 0; k < unit.bonusDamage.Count; ++k)
    {
        UnitType target = unit.bonusDamage.Keys.ElementAt(k);
        int damage = unit.bonusDamage.Values.ElementAt(k);
        csBuilder.Append(varName + ".bonusDamageTargets.push_back(" + target.ToString() + ");\n");
        csBuilder.Append(varName + ".bonusDamageValues.push_back(" + damage + ");\n");
    }

    csBuilder.Append(varName + ".counterBonus = " + unit.counterBonus + ";\n");
    //csBuilder.Append(varName + ".hoverText = \"" + unit.hoverText + "\";\n");
    csBuilder.Append(varName + ".trainingTime = " + unit.trainingTime + ";\n");
    //csBuilder.Append(varName + ".spritePath = \"" + unit.spritePath + "\";\n");
    csBuilder.Append(varName + ".upgradeFoodCost = " + unit.upgradeFoodCost + ";\n");
    csBuilder.Append(varName + ".upgradeWoodCost = " + unit.upgradeWoodCost + ";\n");
    csBuilder.Append(varName + ".upgradeMetalCost = " + unit.upgradeMetalCost + ";\n");
    csBuilder.Append(varName + ".upgradeOrderCost = " + unit.upgradeOrderCost + ";\n");
    csBuilder.Append(varName + ".upgradeTime = " + unit.upgradeTime + ";\n");
    csBuilder.Append(varName + ".foodCost = " + unit.foodCost + ";\n");
    csBuilder.Append(varName + ".woodCost = " + unit.woodCost + ";\n");
    csBuilder.Append(varName + ".metalCost = " + unit.metalCost + ";\n");
    csBuilder.Append(varName + ".orderCost = " + unit.orderCost + ";\n");
    
    csBuilder.Append("unitDefinitions[" + unit.id + "] = " + varName + ";\n\n");
}

File.WriteAllText("dontinclude/out.cpp", csBuilder.ToString());


[System.Serializable]
public struct SheetResponse
{
    public string range {get; set;}
    public string majorDimension {get; set;}
    public string[][] values {get; set;}
}

public enum UnitType
{
    TYPELESS,
    INFANTRY,
    MISSILE,
    CAVALRY
}

public struct Unit
{
    public int id;
    public int trainingTime;
    public string name;
    public UnitType unitType;
    public UnitType preference;
    public byte level;
    public byte maxLevel;
    public byte speed;
    public byte range;
    public byte meleeAttack;
    public byte rangeAttack;
    public byte meleeDefence;
    public byte rangeDefence;
    public byte health;
    public Dictionary<UnitType, int> bonusDamage;
    public byte counterBonus;
    public int foodCost;
    public int woodCost;
    public int metalCost;
    public int orderCost;
    public int upgradeFoodCost;
    public int upgradeWoodCost;
    public int upgradeMetalCost;
    public int upgradeOrderCost;
    public int upgradeTime;
    public string spritePath;
    public string hoverText;
}