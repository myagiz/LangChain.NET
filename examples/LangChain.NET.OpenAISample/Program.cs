
using LangChain.NET.LLMS.OpenAi;

var model = new OpenAi();

var result = await model.Call("Where is the capital of Turkey ?");

Console.WriteLine(result);

