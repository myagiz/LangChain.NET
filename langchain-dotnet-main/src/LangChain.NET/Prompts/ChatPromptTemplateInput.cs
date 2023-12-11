using LangChain.NET.Prompts.Base;

namespace LangChain.NET.Prompts;

public class ChatPromptTemplateInput : IBasePromptTemplateInput
{
    public List<BaseMessagePromptTemplate> PromptMessages { get; set; }

    public bool ValidateTemplate { get; set; } = true;
    public List<string> InputVariables { get; set; } = new();
    public Dictionary<string, object> PartialVariables { get; set; } = new();
}