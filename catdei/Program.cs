using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;

public class Bot
{
    private static readonly string BotToken = "7099629430:AAE9nsg7Wd3DIkCzYUzLbfoxMNg2-IF-RwE";
    private static readonly long ChatId = -1001610516293;
    private static readonly string[] MondayFolder = Directory.GetFiles("Monday");
    private static readonly string[] FridayFolder = Directory.GetFiles("Friday");
    private static readonly string[] RandomFolder = Directory.GetFiles("Random");
    private static readonly Random random = new Random();
    private static DateTime lastRandomSent = DateTime.Now;

    public static void Main(string[] args)
    {
        var botClient = new TelegramBotClient(BotToken);

        botClient.OnMessage += BotOnMessage;
        botClient.StartReceiving();

        Console.WriteLine("Бот запущен.");

        while (true)
        {
            CheckDayAndSendImage(botClient);
            CheckRandomImageCooldownAndSend(botClient);
            Thread.Sleep(1000);
        }
    }

    private static void BotOnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
    {
        if (e.Message.Text == "/start")
        {
            botClient.SendTextMessageAsync(ChatId, "Привет! Я бот для отправки картинок.");
        }
    }

    private static void CheckDayAndSendImage(TelegramBotClient botClient)
    {
        var dayOfWeek = DateTime.Now.DayOfWeek;
        string[] folder;

        switch (dayOfWeek)
        {
            case DayOfWeek.Monday:
                folder = MondayFolder;
                break;
            case DayOfWeek.Friday:
                folder = FridayFolder;
                break;
            default:
                return;
        }

        var image = GetRandomImage(folder);
        botClient.SendPhotoAsync(ChatId, image);
    }

    private static void CheckRandomImageCooldownAndSend(TelegramBotClient botClient)
    {
        if ((DateTime.Now - lastRandomSent).TotalHours >= 4)
        {
            var image = GetRandomImage(RandomFolder);
            botClient.SendPhotoAsync(ChatId, image);
            lastRandomSent = DateTime.Now;
        }
    }

    private static string GetRandomImage(string[] folder)
    {
        return folder[random.Next(folder.Length)];
    }
}


// private static readonly string BotToken = "7099629430:AAE9nsg7Wd3DIkCzYUzLbfoxMNg2-IF-RwE";
// private static readonly long ChatId = -1001610516293;