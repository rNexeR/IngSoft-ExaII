namespace Logic.DataTypeDetector
{
    public class IntTypeDetector : ITypeDetector
    {
        public IntTypeDetector()
        {
        }

        public bool Detect(string stringField)
        {
            int value;
            return int.TryParse(stringField, out value);
        }
    }
}