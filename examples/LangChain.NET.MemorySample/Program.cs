﻿using LangChain.NET.Memory;

var inMemoryHistory = new ChatMessageHistory();

inMemoryHistory.AddUserMessage("hi!");

inMemoryHistory.AddAiMessage("whats up?");

foreach (var message in inMemoryHistory.Messages)
{
    Console.WriteLine(message.GetType().Name + ":" + message.Text);
}

