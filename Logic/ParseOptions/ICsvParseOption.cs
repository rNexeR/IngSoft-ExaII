using System.Collections.Generic;

namespace Logic.ParseOptions
{
    public interface ICsvParseOption
    {
        void AddRow();
        void CloseRow();
        void AddField(string fieldValue, string fieldName);
    }
}