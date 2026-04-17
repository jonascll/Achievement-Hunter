using System.Threading.Tasks;

namespace Achievement_Hunter.Classes;

public static class SupportedGamesManager
{
    public enum SupportedGame
    {
        Minecraft,
        Binding_Of_Isaac,
        Enter_The_Gungeon
    }

    static public async Task<Game> CreateGame(SupportedGame supportedGame)
    {
        /*Game game;
        switch (supportedGame)
        {
            case SupportedGame.Minecraft:
                game = new Game("Minecraft", "https://minecraft.fandom.com/wiki/Achievement");
                await game.InitializeAsync();
                return game;

            case SupportedGame.Binding_Of_Isaac:
                game = new Game("Binding of Isaac", "https://bindingofisaacrebirth.fandom.com/wiki/Achievements");
                await game.InitializeAsync();
                return game;

            case SupportedGame.Enter_The_Gungeon:
                game = new Game("Enter the gungeon", "https://enterthegungeon.fandom.com/wiki/Achievements");
                await game.InitializeAsync();
                return game;

        }*/
        return null;

    }
}