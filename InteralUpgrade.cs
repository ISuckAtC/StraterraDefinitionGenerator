public partial class Program
{
    public enum UpgradeType
    {
        STORAGE,
        SMITHY
    }

    public class InternalUpgrade
    {
        public int id;
        public UpgradeType type;
        public int upgradeTime;
        public int prerequisite;
        public int foodCost;
        public int woodCost;
        public int metalCost;
        public int orderCost;
    }

    public class StorageUpgrade : InternalUpgrade
    {
        public int foodMax;
        public int woodMax;
        public int metalMax;
        public int orderMax;
    }

    static void WriteInternalUpgrades(string[][] values)
    {
        List<InternalUpgrade> internalUpgrades = new List<InternalUpgrade>();

        for (int i = 0; i < 23; ++i)
        {
            InternalUpgrade upgrade = new InternalUpgrade();

            if (values[i][1] == ".") continue;

            switch (Enum.Parse<UpgradeType>(values[i][1]))
            {
                case UpgradeType.STORAGE:
                    upgrade = new StorageUpgrade();
                    break;
                case UpgradeType.SMITHY:
                    upgrade = new InternalUpgrade();
                    break;
                default:
                    throw new Exception("Wrong type");
            }

            upgrade.id = int.Parse(values[i][0]);
            upgrade.type = Enum.Parse<UpgradeType>(values[i][1]);
            upgrade.foodCost = int.Parse(values[i][2]);
            upgrade.woodCost = int.Parse(values[i][3]);
            upgrade.metalCost = int.Parse(values[i][4]);
            upgrade.orderCost = int.Parse(values[i][5]);
            upgrade.upgradeTime = int.Parse(values[i][6]);
            upgrade.prerequisite = int.Parse(values[i][7]);

            switch (upgrade.type)
            {
                case UpgradeType.STORAGE:
                {
                    StorageUpgrade storageUpgrade = (StorageUpgrade)upgrade;
                    storageUpgrade.foodMax = values[i][9] == "." ? 0 : int.Parse(values[i][9]);
                    storageUpgrade.woodMax = values[i][10] == "." ? 0 : int.Parse(values[i][10]);
                    storageUpgrade.metalMax = values[i][11] == "." ? 0 : int.Parse(values[i][11]);
                    storageUpgrade.orderMax = values[i][12] == "." ? 0 : int.Parse(values[i][12]);

                    upgrade = storageUpgrade;
                    break;
                }
            }

            internalUpgrades.Add(upgrade);
        }


        System.Text.StringBuilder csBuilder = new System.Text.StringBuilder();


        // C# (Unity Client)
        csBuilder.Append("InternalUpgrade?[] internalUpgrades = new InternalUpgrade?[256];\n");
        csBuilder.Append("System.Array.Fill(internalUpgrades, null);\n\n");
        for (int i = 0; i < internalUpgrades.Count; ++i)
        {
            InternalUpgrade internalUpgrade = internalUpgrades[i];
            
            string varName = internalUpgrade.type.ToString().ToLower() + internalUpgrade.id.ToString();

            switch (internalUpgrade.type)
            {
                case UpgradeType.STORAGE:
                {
                    csBuilder.Append("StorageUpgrade " + varName + " = new StorageUpgrade();\n");
                    csBuilder.Append(varName + ".foodMax = " + ((StorageUpgrade)internalUpgrade).foodMax + ";\n");
                    csBuilder.Append(varName + ".woodMax = " + ((StorageUpgrade)internalUpgrade).woodMax + ";\n");
                    csBuilder.Append(varName + ".metalMax = " + ((StorageUpgrade)internalUpgrade).metalMax + ";\n");
                    csBuilder.Append(varName + ".orderMax = " + ((StorageUpgrade)internalUpgrade).orderMax + ";\n");
                    break;
                }
            }
            csBuilder.Append(varName + ".id = " + internalUpgrade.id + ";\n");
            csBuilder.Append(varName + ".type = UpgradeTypes." + internalUpgrade.type.ToString() + ";\n");
            csBuilder.Append(varName + ".upgradeTime = " + internalUpgrade.upgradeTime + ";\n");
            csBuilder.Append(varName + ".prerequisite = " + internalUpgrade.prerequisite + ";\n");
            csBuilder.Append(varName + ".foodCost = " + internalUpgrade.foodCost + ";\n");
            csBuilder.Append(varName + ".woodCost = " + internalUpgrade.woodCost + ";\n");
            csBuilder.Append(varName + ".metalCost = " + internalUpgrade.metalCost + ";\n");
            csBuilder.Append(varName + ".orderCost = " + internalUpgrade.orderCost + ";\n");

            csBuilder.Append("internalUpgrades[" + internalUpgrade.id + "] = " + varName + ";\n\n");
        }

        File.WriteAllText("dontinclude/internalUpgradeOut.cs", csBuilder.ToString());

        csBuilder.Clear();

        // C++ (Server)
        for (int i = 0; i < internalUpgrades.Count; ++i)
        {
            InternalUpgrade internalUpgrade = internalUpgrades[i];
            
            string varName = internalUpgrade.type.ToString().ToLower() + internalUpgrade.id.ToString();

            switch (internalUpgrade.type)
            {
                case UpgradeType.STORAGE:
                {
                    csBuilder.Append("StorageUpgrade* " + varName + " = new StorageUpgrade();\n");
                    csBuilder.Append(varName + "->foodMax = " + ((StorageUpgrade)internalUpgrade).foodMax + ";\n");
                    csBuilder.Append(varName + "->woodMax = " + ((StorageUpgrade)internalUpgrade).woodMax + ";\n");
                    csBuilder.Append(varName + "->metalMax = " + ((StorageUpgrade)internalUpgrade).metalMax + ";\n");
                    csBuilder.Append(varName + "->orderMax = " + ((StorageUpgrade)internalUpgrade).orderMax + ";\n");
                    break;
                }
            }
            csBuilder.Append(varName + "->id = " + internalUpgrade.id + ";\n");
            csBuilder.Append(varName + "->type = " + internalUpgrade.type.ToString() + "UPGRADE;\n");
            csBuilder.Append(varName + "->upgradeTime = " + internalUpgrade.upgradeTime + ";\n");
            csBuilder.Append(varName + "->prerequisite = " + internalUpgrade.prerequisite + ";\n");
            csBuilder.Append(varName + "->foodCost = " + internalUpgrade.foodCost + ";\n");
            csBuilder.Append(varName + "->woodCost = " + internalUpgrade.woodCost + ";\n");
            csBuilder.Append(varName + "->metalCost = " + internalUpgrade.metalCost + ";\n");
            csBuilder.Append(varName + "->orderCost = " + internalUpgrade.orderCost + ";\n");

            csBuilder.Append("internalUpgradeDefinitions[" + internalUpgrade.id + "] = " + varName + ";\n\n");
        }

        File.WriteAllText("dontinclude/interalUpgradesOut.cpp", csBuilder.ToString());
    }
}