namespace Logic.DataTypeDetector
{
    public interface ITypeDetector
    {
        bool Detect(string stringField);

        dynamic Parse(string stringField);
    }
}