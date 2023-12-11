
using LangChain.NET.LLMS.HuggingFace;

var huggingFace = new HuggingFace();

var hfResult = await huggingFace.Call("Where is the capital of Germany ?");

Console.WriteLine(hfResult);