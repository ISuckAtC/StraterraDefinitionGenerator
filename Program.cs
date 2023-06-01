global using System;
global using System.Net.Http;

string apiKey = "AIzaSyBWUsAqcWvcdNyi-WnGCaj_WswpF832exc";

string baseAddress = "https://sheets.googleapis.com/v4/spreadsheets/16BbMSgm6UyzQhtFXTUMxHHDnvdjGvdfq0CaI7_lNWi4/values/";


HttpClient client = new HttpClient();

var response = await client.GetAsync(baseAddress + "Units!A2:AA41?key=" + apiKey);

string sResponse = await response.Content.ReadAsStringAsync();

SheetResponse sheet = System.Text.Json.JsonSerializer.Deserialize<SheetResponse>(sResponse);

Console.WriteLine(sheet.range + " | " + sheet.majorDimension + " | " + sheet.values[2][2] + " | " + sheet.values.Length + " | " + sheet.values[0].Length);

var values = sheet.values;

WriteUnits(values);

response = await client.GetAsync(baseAddress + "InternalUpgrades!A2:Z61?key=" + apiKey);

sResponse = await response.Content.ReadAsStringAsync();

sheet = System.Text.Json.JsonSerializer.Deserialize<SheetResponse>(sResponse);

Console.WriteLine(sheet.range + " | " + sheet.majorDimension + " | " + sheet.values[2][2] + " | " + sheet.values.Length + " | " + sheet.values[0].Length);

values = sheet.values;

WriteInternalUpgrades(values);

[System.Serializable]
public struct SheetResponse
{
    public string range {get; set;}
    public string majorDimension {get; set;}
    public string[][] values {get; set;}
}