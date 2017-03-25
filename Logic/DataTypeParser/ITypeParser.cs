namespace Logic.DataTypeDetector
{
    public interface ITypeParser
    {
        dynamic Parse(string stringField);
    }
}