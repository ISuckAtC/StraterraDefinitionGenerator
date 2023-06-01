Unit?[] units = new Unit?[256];
System.Array.Fill(units, null);

Unit archer1 = new Unit();
archer1.id = 0;
archer1.name = "Archer";
archer1.level = 1;
archer1.maxLevel = 6;
archer1.preference = UnitType.INFANTRY;
archer1.unitType = UnitType.MISSILE;
archer1.speed = 2;
archer1.range = 10;
archer1.meleeAttack = 2;
archer1.rangeAttack = 7;
archer1.meleeDefence = 2;
archer1.rangeDefence = 1;
archer1.health = 10;
archer1.bonusDamage = new Dictionary<UnitType, int>();
archer1.counterBonus = 0;
archer1.hoverText = "";
archer1.trainingTime = 1;
archer1.spritePath = "Sprites/Army/Img_Archer_Lvl1_V2";
archer1.upgradeFoodCost = 0;
archer1.upgradeWoodCost = 0;
archer1.upgradeMetalCost = 0;
archer1.upgradeOrderCost = 0;
archer1.upgradeTime = 0;
archer1.foodCost = 40;
archer1.woodCost = 50;
archer1.metalCost = 5;
archer1.orderCost = 0;
units[0] = archer1;

Unit archer2 = new Unit();
archer2.id = 1;
archer2.name = "Archer";
archer2.level = 2;
archer2.maxLevel = 6;
archer2.preference = UnitType.INFANTRY;
archer2.unitType = UnitType.MISSILE;
archer2.speed = 2;
archer2.range = 10;
archer2.meleeAttack = 2;
archer2.rangeAttack = 7;
archer2.meleeDefence = 2;
archer2.rangeDefence = 1;
archer2.health = 10;
archer2.bonusDamage = new Dictionary<UnitType, int>();
archer2.counterBonus = 0;
archer2.hoverText = "";
archer2.trainingTime = 1;
archer2.spritePath = "Sprites/Army/Img_Archer_Lvl2_V2";
archer2.upgradeFoodCost = 100;
archer2.upgradeWoodCost = 100;
archer2.upgradeMetalCost = 100;
archer2.upgradeOrderCost = 0;
archer2.upgradeTime = 60;
archer2.foodCost = 40;
archer2.woodCost = 50;
archer2.metalCost = 5;
archer2.orderCost = 0;
units[1] = archer2;

Unit archer3 = new Unit();
archer3.id = 2;
archer3.name = "Archer";
archer3.level = 3;
archer3.maxLevel = 6;
archer3.preference = UnitType.INFANTRY;
archer3.unitType = UnitType.MISSILE;
archer3.speed = 2;
archer3.range = 10;
archer3.meleeAttack = 2;
archer3.rangeAttack = 7;
archer3.meleeDefence = 2;
archer3.rangeDefence = 1;
archer3.health = 10;
archer3.bonusDamage = new Dictionary<UnitType, int>();
archer3.counterBonus = 0;
archer3.hoverText = "";
archer3.trainingTime = 1;
archer3.spritePath = "Sprites/Army/Img_Archer_Lv3_V2";
archer3.upgradeFoodCost = 100;
archer3.upgradeWoodCost = 100;
archer3.upgradeMetalCost = 100;
archer3.upgradeOrderCost = 0;
archer3.upgradeTime = 60;
archer3.foodCost = 40;
archer3.woodCost = 50;
archer3.metalCost = 5;
archer3.orderCost = 0;
units[2] = archer3;

Unit archer4 = new Unit();
archer4.id = 3;
archer4.name = "Archer";
archer4.level = 4;
archer4.maxLevel = 6;
archer4.preference = UnitType.INFANTRY;
archer4.unitType = UnitType.MISSILE;
archer4.speed = 2;
archer4.range = 10;
archer4.meleeAttack = 2;
archer4.rangeAttack = 7;
archer4.meleeDefence = 2;
archer4.rangeDefence = 1;
archer4.health = 10;
archer4.bonusDamage = new Dictionary<UnitType, int>();
archer4.counterBonus = 0;
archer4.hoverText = "";
archer4.trainingTime = 1;
archer4.spritePath = "Sprites/Army/Img_Archer_Lvl4_V2";
archer4.upgradeFoodCost = 100;
archer4.upgradeWoodCost = 100;
archer4.upgradeMetalCost = 100;
archer4.upgradeOrderCost = 0;
archer4.upgradeTime = 60;
archer4.foodCost = 40;
archer4.woodCost = 50;
archer4.metalCost = 5;
archer4.orderCost = 0;
units[3] = archer4;

Unit archer5 = new Unit();
archer5.id = 4;
archer5.name = "Archer";
archer5.level = 5;
archer5.maxLevel = 6;
archer5.preference = UnitType.INFANTRY;
archer5.unitType = UnitType.MISSILE;
archer5.speed = 2;
archer5.range = 10;
archer5.meleeAttack = 2;
archer5.rangeAttack = 7;
archer5.meleeDefence = 2;
archer5.rangeDefence = 1;
archer5.health = 10;
archer5.bonusDamage = new Dictionary<UnitType, int>();
archer5.counterBonus = 0;
archer5.hoverText = "";
archer5.trainingTime = 1;
archer5.spritePath = "Sprites/Army/Img_Archer_Lvl5_V2";
archer5.upgradeFoodCost = 100;
archer5.upgradeWoodCost = 100;
archer5.upgradeMetalCost = 100;
archer5.upgradeOrderCost = 0;
archer5.upgradeTime = 60;
archer5.foodCost = 40;
archer5.woodCost = 50;
archer5.metalCost = 5;
archer5.orderCost = 0;
units[4] = archer5;

Unit archer6 = new Unit();
archer6.id = 5;
archer6.name = "Archer";
archer6.level = 6;
archer6.maxLevel = 6;
archer6.preference = UnitType.INFANTRY;
archer6.unitType = UnitType.MISSILE;
archer6.speed = 2;
archer6.range = 10;
archer6.meleeAttack = 2;
archer6.rangeAttack = 7;
archer6.meleeDefence = 2;
archer6.rangeDefence = 1;
archer6.health = 10;
archer6.bonusDamage = new Dictionary<UnitType, int>();
archer6.counterBonus = 0;
archer6.hoverText = "";
archer6.trainingTime = 1;
archer6.spritePath = "Sprites/Army/Img_Archer_Lvl6_V2";
archer6.upgradeFoodCost = 100;
archer6.upgradeWoodCost = 100;
archer6.upgradeMetalCost = 100;
archer6.upgradeOrderCost = 0;
archer6.upgradeTime = 60;
archer6.foodCost = 40;
archer6.woodCost = 50;
archer6.metalCost = 5;
archer6.orderCost = 0;
units[5] = archer6;

Unit cavalry1 = new Unit();
cavalry1.id = 10;
cavalry1.name = "Cavalry";
cavalry1.level = 1;
cavalry1.maxLevel = 6;
cavalry1.preference = UnitType.MISSILE;
cavalry1.unitType = UnitType.CAVALRY;
cavalry1.speed = 6;
cavalry1.range = 0;
cavalry1.meleeAttack = 14;
cavalry1.rangeAttack = 0;
cavalry1.meleeDefence = 4;
cavalry1.rangeDefence = 3;
cavalry1.health = 50;
cavalry1.bonusDamage = new Dictionary<UnitType, int>();
cavalry1.counterBonus = 0;
cavalry1.hoverText = "";
cavalry1.trainingTime = 60;
cavalry1.spritePath = "Sprites/Army/Img_cavalry_Lvl1_1";
cavalry1.upgradeFoodCost = 100;
cavalry1.upgradeWoodCost = 100;
cavalry1.upgradeMetalCost = 100;
cavalry1.upgradeOrderCost = 0;
cavalry1.upgradeTime = 60;
cavalry1.foodCost = 200;
cavalry1.woodCost = 50;
cavalry1.metalCost = 0;
cavalry1.orderCost = 0;
units[10] = cavalry1;

Unit cavalry2 = new Unit();
cavalry2.id = 11;
cavalry2.name = "Cavalry";
cavalry2.level = 2;
cavalry2.maxLevel = 6;
cavalry2.preference = UnitType.MISSILE;
cavalry2.unitType = UnitType.CAVALRY;
cavalry2.speed = 6;
cavalry2.range = 0;
cavalry2.meleeAttack = 14;
cavalry2.rangeAttack = 0;
cavalry2.meleeDefence = 4;
cavalry2.rangeDefence = 3;
cavalry2.health = 50;
cavalry2.bonusDamage = new Dictionary<UnitType, int>();
cavalry2.counterBonus = 0;
cavalry2.hoverText = "";
cavalry2.trainingTime = 60;
cavalry2.spritePath = "Sprites/Army/Img_cavalry_Lvl2_V2";
cavalry2.upgradeFoodCost = 100;
cavalry2.upgradeWoodCost = 100;
cavalry2.upgradeMetalCost = 100;
cavalry2.upgradeOrderCost = 0;
cavalry2.upgradeTime = 60;
cavalry2.foodCost = 200;
cavalry2.woodCost = 50;
cavalry2.metalCost = 0;
cavalry2.orderCost = 0;
units[11] = cavalry2;

Unit cavalry3 = new Unit();
cavalry3.id = 12;
cavalry3.name = "Cavalry";
cavalry3.level = 3;
cavalry3.maxLevel = 6;
cavalry3.preference = UnitType.MISSILE;
cavalry3.unitType = UnitType.CAVALRY;
cavalry3.speed = 6;
cavalry3.range = 0;
cavalry3.meleeAttack = 14;
cavalry3.rangeAttack = 0;
cavalry3.meleeDefence = 4;
cavalry3.rangeDefence = 3;
cavalry3.health = 50;
cavalry3.bonusDamage = new Dictionary<UnitType, int>();
cavalry3.counterBonus = 0;
cavalry3.hoverText = "";
cavalry3.trainingTime = 60;
cavalry3.spritePath = "Sprites/Army/Img_cavalry_Lvl3_V2";
cavalry3.upgradeFoodCost = 100;
cavalry3.upgradeWoodCost = 100;
cavalry3.upgradeMetalCost = 100;
cavalry3.upgradeOrderCost = 0;
cavalry3.upgradeTime = 60;
cavalry3.foodCost = 200;
cavalry3.woodCost = 50;
cavalry3.metalCost = 0;
cavalry3.orderCost = 0;
units[12] = cavalry3;

Unit cavalry4 = new Unit();
cavalry4.id = 13;
cavalry4.name = "Cavalry";
cavalry4.level = 4;
cavalry4.maxLevel = 6;
cavalry4.preference = UnitType.MISSILE;
cavalry4.unitType = UnitType.CAVALRY;
cavalry4.speed = 6;
cavalry4.range = 0;
cavalry4.meleeAttack = 14;
cavalry4.rangeAttack = 0;
cavalry4.meleeDefence = 4;
cavalry4.rangeDefence = 3;
cavalry4.health = 50;
cavalry4.bonusDamage = new Dictionary<UnitType, int>();
cavalry4.counterBonus = 0;
cavalry4.hoverText = "";
cavalry4.trainingTime = 60;
cavalry4.spritePath = "Sprites/Army/Img_cavalry_Lvl4_V2";
cavalry4.upgradeFoodCost = 100;
cavalry4.upgradeWoodCost = 100;
cavalry4.upgradeMetalCost = 100;
cavalry4.upgradeOrderCost = 0;
cavalry4.upgradeTime = 60;
cavalry4.foodCost = 200;
cavalry4.woodCost = 50;
cavalry4.metalCost = 0;
cavalry4.orderCost = 0;
units[13] = cavalry4;

Unit cavalry5 = new Unit();
cavalry5.id = 14;
cavalry5.name = "Cavalry";
cavalry5.level = 5;
cavalry5.maxLevel = 6;
cavalry5.preference = UnitType.MISSILE;
cavalry5.unitType = UnitType.CAVALRY;
cavalry5.speed = 6;
cavalry5.range = 0;
cavalry5.meleeAttack = 14;
cavalry5.rangeAttack = 0;
cavalry5.meleeDefence = 4;
cavalry5.rangeDefence = 3;
cavalry5.health = 50;
cavalry5.bonusDamage = new Dictionary<UnitType, int>();
cavalry5.counterBonus = 0;
cavalry5.hoverText = "";
cavalry5.trainingTime = 60;
cavalry5.spritePath = "Sprites/Army/Img_cavalry_Lvl5_V2";
cavalry5.upgradeFoodCost = 100;
cavalry5.upgradeWoodCost = 100;
cavalry5.upgradeMetalCost = 100;
cavalry5.upgradeOrderCost = 0;
cavalry5.upgradeTime = 60;
cavalry5.foodCost = 200;
cavalry5.woodCost = 50;
cavalry5.metalCost = 0;
cavalry5.orderCost = 0;
units[14] = cavalry5;

Unit cavalry6 = new Unit();
cavalry6.id = 15;
cavalry6.name = "Cavalry";
cavalry6.level = 6;
cavalry6.maxLevel = 6;
cavalry6.preference = UnitType.MISSILE;
cavalry6.unitType = UnitType.CAVALRY;
cavalry6.speed = 6;
cavalry6.range = 0;
cavalry6.meleeAttack = 14;
cavalry6.rangeAttack = 0;
cavalry6.meleeDefence = 4;
cavalry6.rangeDefence = 3;
cavalry6.health = 50;
cavalry6.bonusDamage = new Dictionary<UnitType, int>();
cavalry6.counterBonus = 0;
cavalry6.hoverText = "";
cavalry6.trainingTime = 60;
cavalry6.spritePath = "Sprites/Army/Img_cavalry_Lvl6_V2";
cavalry6.upgradeFoodCost = 100;
cavalry6.upgradeWoodCost = 100;
cavalry6.upgradeMetalCost = 100;
cavalry6.upgradeOrderCost = 0;
cavalry6.upgradeTime = 60;
cavalry6.foodCost = 200;
cavalry6.woodCost = 50;
cavalry6.metalCost = 0;
cavalry6.orderCost = 0;
units[15] = cavalry6;

Unit swordsman1 = new Unit();
swordsman1.id = 20;
swordsman1.name = "Swordsman";
swordsman1.level = 1;
swordsman1.maxLevel = 6;
swordsman1.preference = UnitType.INFANTRY;
swordsman1.unitType = UnitType.INFANTRY;
swordsman1.speed = 2;
swordsman1.range = 0;
swordsman1.meleeAttack = 8;
swordsman1.rangeAttack = 0;
swordsman1.meleeDefence = 5;
swordsman1.rangeDefence = 4;
swordsman1.health = 15;
swordsman1.bonusDamage = new Dictionary<UnitType, int>();
swordsman1.counterBonus = 0;
swordsman1.hoverText = "";
swordsman1.trainingTime = 5;
swordsman1.spritePath = "Sprites/Army/Img_Swordsman_Lvl1_V2";
swordsman1.upgradeFoodCost = 100;
swordsman1.upgradeWoodCost = 100;
swordsman1.upgradeMetalCost = 100;
swordsman1.upgradeOrderCost = 0;
swordsman1.upgradeTime = 60;
swordsman1.foodCost = 50;
swordsman1.woodCost = 0;
swordsman1.metalCost = 10;
swordsman1.orderCost = 0;
units[20] = swordsman1;

Unit swordsman2 = new Unit();
swordsman2.id = 21;
swordsman2.name = "Swordsman";
swordsman2.level = 2;
swordsman2.maxLevel = 6;
swordsman2.preference = UnitType.INFANTRY;
swordsman2.unitType = UnitType.INFANTRY;
swordsman2.speed = 2;
swordsman2.range = 0;
swordsman2.meleeAttack = 8;
swordsman2.rangeAttack = 0;
swordsman2.meleeDefence = 5;
swordsman2.rangeDefence = 4;
swordsman2.health = 15;
swordsman2.bonusDamage = new Dictionary<UnitType, int>();
swordsman2.counterBonus = 0;
swordsman2.hoverText = "";
swordsman2.trainingTime = 5;
swordsman2.spritePath = "Sprites/Army/Img_Swordsman_Lvl2_V2";
swordsman2.upgradeFoodCost = 100;
swordsman2.upgradeWoodCost = 100;
swordsman2.upgradeMetalCost = 100;
swordsman2.upgradeOrderCost = 0;
swordsman2.upgradeTime = 60;
swordsman2.foodCost = 50;
swordsman2.woodCost = 0;
swordsman2.metalCost = 10;
swordsman2.orderCost = 0;
units[21] = swordsman2;

Unit swordsman3 = new Unit();
swordsman3.id = 22;
swordsman3.name = "Swordsman";
swordsman3.level = 3;
swordsman3.maxLevel = 6;
swordsman3.preference = UnitType.INFANTRY;
swordsman3.unitType = UnitType.INFANTRY;
swordsman3.speed = 2;
swordsman3.range = 0;
swordsman3.meleeAttack = 8;
swordsman3.rangeAttack = 0;
swordsman3.meleeDefence = 5;
swordsman3.rangeDefence = 4;
swordsman3.health = 15;
swordsman3.bonusDamage = new Dictionary<UnitType, int>();
swordsman3.counterBonus = 0;
swordsman3.hoverText = "";
swordsman3.trainingTime = 5;
swordsman3.spritePath = "Sprites/Army/Img_Swordsman_Lvl3_V2";
swordsman3.upgradeFoodCost = 100;
swordsman3.upgradeWoodCost = 100;
swordsman3.upgradeMetalCost = 100;
swordsman3.upgradeOrderCost = 0;
swordsman3.upgradeTime = 60;
swordsman3.foodCost = 50;
swordsman3.woodCost = 0;
swordsman3.metalCost = 10;
swordsman3.orderCost = 0;
units[22] = swordsman3;

Unit swordsman4 = new Unit();
swordsman4.id = 23;
swordsman4.name = "Swordsman";
swordsman4.level = 4;
swordsman4.maxLevel = 6;
swordsman4.preference = UnitType.INFANTRY;
swordsman4.unitType = UnitType.INFANTRY;
swordsman4.speed = 2;
swordsman4.range = 0;
swordsman4.meleeAttack = 8;
swordsman4.rangeAttack = 0;
swordsman4.meleeDefence = 5;
swordsman4.rangeDefence = 4;
swordsman4.health = 15;
swordsman4.bonusDamage = new Dictionary<UnitType, int>();
swordsman4.counterBonus = 0;
swordsman4.hoverText = "";
swordsman4.trainingTime = 5;
swordsman4.spritePath = "Sprites/Army/Img_Swordsman_Lvl4_V2";
swordsman4.upgradeFoodCost = 100;
swordsman4.upgradeWoodCost = 100;
swordsman4.upgradeMetalCost = 100;
swordsman4.upgradeOrderCost = 0;
swordsman4.upgradeTime = 60;
swordsman4.foodCost = 50;
swordsman4.woodCost = 0;
swordsman4.metalCost = 10;
swordsman4.orderCost = 0;
units[23] = swordsman4;

Unit swordsman5 = new Unit();
swordsman5.id = 24;
swordsman5.name = "Swordsman";
swordsman5.level = 5;
swordsman5.maxLevel = 6;
swordsman5.preference = UnitType.INFANTRY;
swordsman5.unitType = UnitType.INFANTRY;
swordsman5.speed = 2;
swordsman5.range = 0;
swordsman5.meleeAttack = 8;
swordsman5.rangeAttack = 0;
swordsman5.meleeDefence = 5;
swordsman5.rangeDefence = 4;
swordsman5.health = 15;
swordsman5.bonusDamage = new Dictionary<UnitType, int>();
swordsman5.counterBonus = 0;
swordsman5.hoverText = "";
swordsman5.trainingTime = 5;
swordsman5.spritePath = "Sprites/Army/Img_Swordsman_Lvl5_V2";
swordsman5.upgradeFoodCost = 100;
swordsman5.upgradeWoodCost = 100;
swordsman5.upgradeMetalCost = 100;
swordsman5.upgradeOrderCost = 0;
swordsman5.upgradeTime = 60;
swordsman5.foodCost = 50;
swordsman5.woodCost = 0;
swordsman5.metalCost = 10;
swordsman5.orderCost = 0;
units[24] = swordsman5;

Unit swordsman6 = new Unit();
swordsman6.id = 25;
swordsman6.name = "Swordsman";
swordsman6.level = 6;
swordsman6.maxLevel = 6;
swordsman6.preference = UnitType.INFANTRY;
swordsman6.unitType = UnitType.INFANTRY;
swordsman6.speed = 2;
swordsman6.range = 0;
swordsman6.meleeAttack = 8;
swordsman6.rangeAttack = 0;
swordsman6.meleeDefence = 5;
swordsman6.rangeDefence = 4;
swordsman6.health = 15;
swordsman6.bonusDamage = new Dictionary<UnitType, int>();
swordsman6.counterBonus = 0;
swordsman6.hoverText = "";
swordsman6.trainingTime = 5;
swordsman6.spritePath = "Sprites/Army/Img_Swordsman_Lvl6_V2";
swordsman6.upgradeFoodCost = 100;
swordsman6.upgradeWoodCost = 100;
swordsman6.upgradeMetalCost = 100;
swordsman6.upgradeOrderCost = 0;
swordsman6.upgradeTime = 60;
swordsman6.foodCost = 50;
swordsman6.woodCost = 0;
swordsman6.metalCost = 10;
swordsman6.orderCost = 0;
units[25] = swordsman6;

Unit spearman1 = new Unit();
spearman1.id = 30;
spearman1.name = "Spearman";
spearman1.level = 1;
spearman1.maxLevel = 6;
spearman1.preference = UnitType.CAVALRY;
spearman1.unitType = UnitType.INFANTRY;
spearman1.speed = 3;
spearman1.range = 0;
spearman1.meleeAttack = 7;
spearman1.rangeAttack = 0;
spearman1.meleeDefence = 3;
spearman1.rangeDefence = 2;
spearman1.health = 12;
spearman1.bonusDamage = new Dictionary<UnitType, int>();
spearman1.bonusDamage.Add(UnitType.CAVALRY, 10);
spearman1.counterBonus = 0;
spearman1.hoverText = "";
spearman1.trainingTime = 3;
spearman1.spritePath = "Sprites/Army/Img_Spearman_Lvl1_V2";
spearman1.upgradeFoodCost = 100;
spearman1.upgradeWoodCost = 100;
spearman1.upgradeMetalCost = 100;
spearman1.upgradeOrderCost = 0;
spearman1.upgradeTime = 60;
spearman1.foodCost = 30;
spearman1.woodCost = 20;
spearman1.metalCost = 0;
spearman1.orderCost = 0;
units[30] = spearman1;

Unit spearman2 = new Unit();
spearman2.id = 31;
spearman2.name = "Spearman";
spearman2.level = 2;
spearman2.maxLevel = 6;
spearman2.preference = UnitType.CAVALRY;
spearman2.unitType = UnitType.INFANTRY;
spearman2.speed = 3;
spearman2.range = 0;
spearman2.meleeAttack = 7;
spearman2.rangeAttack = 0;
spearman2.meleeDefence = 3;
spearman2.rangeDefence = 2;
spearman2.health = 12;
spearman2.bonusDamage = new Dictionary<UnitType, int>();
spearman2.bonusDamage.Add(UnitType.CAVALRY, 10);
spearman2.counterBonus = 0;
spearman2.hoverText = "";
spearman2.trainingTime = 3;
spearman2.spritePath = "Sprites/Army/Img_Spearman_Lvl2_V2";
spearman2.upgradeFoodCost = 100;
spearman2.upgradeWoodCost = 100;
spearman2.upgradeMetalCost = 100;
spearman2.upgradeOrderCost = 0;
spearman2.upgradeTime = 60;
spearman2.foodCost = 30;
spearman2.woodCost = 20;
spearman2.metalCost = 0;
spearman2.orderCost = 0;
units[31] = spearman2;

Unit spearman3 = new Unit();
spearman3.id = 32;
spearman3.name = "Spearman";
spearman3.level = 3;
spearman3.maxLevel = 6;
spearman3.preference = UnitType.CAVALRY;
spearman3.unitType = UnitType.INFANTRY;
spearman3.speed = 3;
spearman3.range = 0;
spearman3.meleeAttack = 7;
spearman3.rangeAttack = 0;
spearman3.meleeDefence = 3;
spearman3.rangeDefence = 2;
spearman3.health = 12;
spearman3.bonusDamage = new Dictionary<UnitType, int>();
spearman3.bonusDamage.Add(UnitType.CAVALRY, 10);
spearman3.counterBonus = 0;
spearman3.hoverText = "";
spearman3.trainingTime = 3;
spearman3.spritePath = "Sprites/Army/Img_Spearman_Lvl3_V2";
spearman3.upgradeFoodCost = 100;
spearman3.upgradeWoodCost = 100;
spearman3.upgradeMetalCost = 100;
spearman3.upgradeOrderCost = 0;
spearman3.upgradeTime = 60;
spearman3.foodCost = 30;
spearman3.woodCost = 20;
spearman3.metalCost = 0;
spearman3.orderCost = 0;
units[32] = spearman3;

Unit spearman4 = new Unit();
spearman4.id = 33;
spearman4.name = "Spearman";
spearman4.level = 4;
spearman4.maxLevel = 6;
spearman4.preference = UnitType.CAVALRY;
spearman4.unitType = UnitType.INFANTRY;
spearman4.speed = 3;
spearman4.range = 0;
spearman4.meleeAttack = 7;
spearman4.rangeAttack = 0;
spearman4.meleeDefence = 3;
spearman4.rangeDefence = 2;
spearman4.health = 12;
spearman4.bonusDamage = new Dictionary<UnitType, int>();
spearman4.bonusDamage.Add(UnitType.CAVALRY, 10);
spearman4.counterBonus = 0;
spearman4.hoverText = "";
spearman4.trainingTime = 3;
spearman4.spritePath = "Sprites/Army/Img_Spearman_Lvl4_V2";
spearman4.upgradeFoodCost = 100;
spearman4.upgradeWoodCost = 100;
spearman4.upgradeMetalCost = 100;
spearman4.upgradeOrderCost = 0;
spearman4.upgradeTime = 60;
spearman4.foodCost = 30;
spearman4.woodCost = 20;
spearman4.metalCost = 0;
spearman4.orderCost = 0;
units[33] = spearman4;

Unit spearman5 = new Unit();
spearman5.id = 34;
spearman5.name = "Spearman";
spearman5.level = 5;
spearman5.maxLevel = 6;
spearman5.preference = UnitType.CAVALRY;
spearman5.unitType = UnitType.INFANTRY;
spearman5.speed = 3;
spearman5.range = 0;
spearman5.meleeAttack = 7;
spearman5.rangeAttack = 0;
spearman5.meleeDefence = 3;
spearman5.rangeDefence = 2;
spearman5.health = 12;
spearman5.bonusDamage = new Dictionary<UnitType, int>();
spearman5.bonusDamage.Add(UnitType.CAVALRY, 10);
spearman5.counterBonus = 0;
spearman5.hoverText = "";
spearman5.trainingTime = 3;
spearman5.spritePath = "Sprites/Army/Img_Spearman_Lvl5_V2";
spearman5.upgradeFoodCost = 100;
spearman5.upgradeWoodCost = 100;
spearman5.upgradeMetalCost = 100;
spearman5.upgradeOrderCost = 0;
spearman5.upgradeTime = 60;
spearman5.foodCost = 30;
spearman5.woodCost = 20;
spearman5.metalCost = 0;
spearman5.orderCost = 0;
units[34] = spearman5;

Unit spearman6 = new Unit();
spearman6.id = 35;
spearman6.name = "Spearman";
spearman6.level = 6;
spearman6.maxLevel = 6;
spearman6.preference = UnitType.CAVALRY;
spearman6.unitType = UnitType.INFANTRY;
spearman6.speed = 3;
spearman6.range = 0;
spearman6.meleeAttack = 7;
spearman6.rangeAttack = 0;
spearman6.meleeDefence = 3;
spearman6.rangeDefence = 2;
spearman6.health = 12;
spearman6.bonusDamage = new Dictionary<UnitType, int>();
spearman6.bonusDamage.Add(UnitType.CAVALRY, 10);
spearman6.counterBonus = 0;
spearman6.hoverText = "";
spearman6.trainingTime = 3;
spearman6.spritePath = "Sprites/Army/Img_Spearman_Lvl6_V2";
spearman6.upgradeFoodCost = 100;
spearman6.upgradeWoodCost = 100;
spearman6.upgradeMetalCost = 100;
spearman6.upgradeOrderCost = 0;
spearman6.upgradeTime = 60;
spearman6.foodCost = 30;
spearman6.woodCost = 20;
spearman6.metalCost = 0;
spearman6.orderCost = 0;
units[35] = spearman6;
