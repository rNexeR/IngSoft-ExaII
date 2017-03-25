namespace Logic.DataTypeDetector
{
    public interface ITypeDetector
    {
        bool Detect(string stringField);

        string Parse(string stringField);
    }
}