/*using Domain.Interfaces.Telegram;

namespace Domain.Implementations.Telegram;

public class Telegram : ITelegram
{
    private readonly TelegramBotClient bot;

    public TelegramBot(string token)
    {
        bot = new TelegramBotClient(token);
    }

    public void Start()
    {
        bot.OnMessage += Bot_OnMessage;
        bot.StartReceiving();
    }

    private async void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
    {
        var message = e.Message;
        if (message == null || message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
            return;

        await bot.SendTextMessageAsync(message.Chat.Id, $"Вы написали: {message.Text}");
    }
}