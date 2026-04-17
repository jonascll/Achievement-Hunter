public class Achievement
{
    private string _achievementName;
    public string AchievementName
    {
        get { return _achievementName; }
    }
    private string _achievementDescription;
    public string AchievementDescription
    {
        get { return _achievementDescription; }
    }


    public Achievement(string achievementName, string achievementDescription)
    {
        this._achievementName = achievementName;
        this._achievementDescription = achievementDescription;
    }
}