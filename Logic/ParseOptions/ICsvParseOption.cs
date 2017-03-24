using System.Collections.Generic;

namespace Logic.ParseOptions
{
    public interface ICsvParseOption
    {
        string CreateRow();
        string CloseRow();
        string CreateField { get; set; }
        string AddFields(ICollection<string> fieldsString);
    }
}