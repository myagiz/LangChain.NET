using LangChain.NET.Schema;

namespace LangChain.NET.Prompts.Base;

public abstract class BaseStringPromptTemplate : BasePromptTemplate
{
    public override async Task<BasePromptValue> FormatPromptValue(InputValues values)
    {
        var formattedPrompt = await Format(values);
        
        return new StringPromptValue()
        {
            Value = formattedPrompt
        };
    }

    protected BaseStringPromptTemplate(IBasePromptTemplateInput input) : base(input)
    {
    }
}