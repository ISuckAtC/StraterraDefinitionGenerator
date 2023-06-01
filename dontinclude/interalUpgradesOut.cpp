StorageUpgrade* storage0 = new StorageUpgrade();
storage0->foodMax = 1024;
storage0->woodMax = 1024;
storage0->metalMax = 1024;
storage0->orderMax = 1024;
storage0->id = 0;
storage0->type = STORAGEUPGRADE;
storage0->upgradeTime = 0;
storage0->prerequisite = -1;
storage0->foodCost = 0;
storage0->woodCost = 0;
storage0->metalCost = 0;
storage0->orderCost = 0;
internalUpgradeDefinitions[0] = storage0;

StorageUpgrade* storage1 = new StorageUpgrade();
storage1->foodMax = 4096;
storage1->woodMax = 0;
storage1->metalMax = 0;
storage1->orderMax = 0;
storage1->id = 1;
storage1->type = STORAGEUPGRADE;
storage1->upgradeTime = 60;
storage1->prerequisite = 0;
storage1->foodCost = 100;
storage1->woodCost = 100;
storage1->metalCost = 100;
storage1->orderCost = 0;
internalUpgradeDefinitions[1] = storage1;

StorageUpgrade* storage2 = new StorageUpgrade();
storage2->foodMax = 16384;
storage2->woodMax = 0;
storage2->metalMax = 0;
storage2->orderMax = 0;
storage2->id = 2;
storage2->type = STORAGEUPGRADE;
storage2->upgradeTime = 120;
storage2->prerequisite = 1;
storage2->foodCost = 1000;
storage2->woodCost = 1000;
storage2->metalCost = 1000;
storage2->orderCost = 0;
internalUpgradeDefinitions[2] = storage2;

StorageUpgrade* storage3 = new StorageUpgrade();
storage3->foodMax = 65536;
storage3->woodMax = 0;
storage3->metalMax = 0;
storage3->orderMax = 0;
storage3->id = 3;
storage3->type = STORAGEUPGRADE;
storage3->upgradeTime = 240;
storage3->prerequisite = 2;
storage3->foodCost = 3000;
storage3->woodCost = 3000;
storage3->metalCost = 3000;
storage3->orderCost = 0;
internalUpgradeDefinitions[3] = storage3;

StorageUpgrade* storage11 = new StorageUpgrade();
storage11->foodMax = 0;
storage11->woodMax = 4096;
storage11->metalMax = 0;
storage11->orderMax = 0;
storage11->id = 11;
storage11->type = STORAGEUPGRADE;
storage11->upgradeTime = 60;
storage11->prerequisite = 0;
storage11->foodCost = 100;
storage11->woodCost = 100;
storage11->metalCost = 100;
storage11->orderCost = 0;
internalUpgradeDefinitions[11] = storage11;

StorageUpgrade* storage12 = new StorageUpgrade();
storage12->foodMax = 0;
storage12->woodMax = 16384;
storage12->metalMax = 0;
storage12->orderMax = 0;
storage12->id = 12;
storage12->type = STORAGEUPGRADE;
storage12->upgradeTime = 120;
storage12->prerequisite = 11;
storage12->foodCost = 1000;
storage12->woodCost = 1000;
storage12->metalCost = 1000;
storage12->orderCost = 0;
internalUpgradeDefinitions[12] = storage12;

StorageUpgrade* storage13 = new StorageUpgrade();
storage13->foodMax = 0;
storage13->woodMax = 65536;
storage13->metalMax = 0;
storage13->orderMax = 0;
storage13->id = 13;
storage13->type = STORAGEUPGRADE;
storage13->upgradeTime = 240;
storage13->prerequisite = 12;
storage13->foodCost = 3000;
storage13->woodCost = 3000;
storage13->metalCost = 3000;
storage13->orderCost = 0;
internalUpgradeDefinitions[13] = storage13;

StorageUpgrade* storage21 = new StorageUpgrade();
storage21->foodMax = 0;
storage21->woodMax = 0;
storage21->metalMax = 4096;
storage21->orderMax = 0;
storage21->id = 21;
storage21->type = STORAGEUPGRADE;
storage21->upgradeTime = 60;
storage21->prerequisite = 0;
storage21->foodCost = 100;
storage21->woodCost = 100;
storage21->metalCost = 100;
storage21->orderCost = 0;
internalUpgradeDefinitions[21] = storage21;

StorageUpgrade* storage22 = new StorageUpgrade();
storage22->foodMax = 0;
storage22->woodMax = 0;
storage22->metalMax = 16384;
storage22->orderMax = 0;
storage22->id = 22;
storage22->type = STORAGEUPGRADE;
storage22->upgradeTime = 120;
storage22->prerequisite = 21;
storage22->foodCost = 1000;
storage22->woodCost = 1000;
storage22->metalCost = 1000;
storage22->orderCost = 0;
internalUpgradeDefinitions[22] = storage22;

