using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using Microsoft.VisualBasic;
using System.Net.Http;
using System.Text.Json;

namespace Achievement_Hunter.Classes;

public class Game : BaseObject
{

    public string name { get; set; }

    public string steamAppId { get; set; }


    private List<Achievement> achievements = new List<Achievement>();
    public List<Achievement> Achievements
    {
        get { return achievements; }
    }



    public Game(string name, string steamAppId)
    {
        this.name = name;
        this.steamAppId = steamAppId;


    }

    public async Task InitializeAsync()
    {

        string url = $"https://api.steampowered.com/ISteamUserStats/GetSchemaForGame/v2/?key={apiKey}&appid={appId}";

        using HttpClient client = new HttpClient();
        var response = await client.GetStringAsync(url);

        // Parse the JSON response
        using JsonDocument doc = JsonDocument.Parse(response);
        var achievementsJson = doc.RootElement
            .GetProperty("game")
            .GetProperty("availableGameStats")
            .GetProperty("achievements");

        achievements.Clear();

        foreach (var item in achievementsJson.EnumerateArray())
        {
            achievements.Add(new Achievement(item.GetProperty("displayName").GetString(), item.GetProperty("description").GetString()));
        }

    }


}