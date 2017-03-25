using System.Collections.Generic;

namespace Logic.DataTypeDetector
{
    public class DataTypeDetectorsRepository
    {
        private readonly List<ITypeDetector> _detectors;

        public DataTypeDetectorsRepository(List<ITypeDetector> detectors)
        {
            _detectors = detectors;
        }

        public string FormatField(string s)
        {
            var returnValue = "";
            foreach (var detector in _detectors)
            {
                if (!detector.Detect(s)) continue;
                returnValue = detector.Parse(s);
                break;
            }
            return returnValue;
        }
    }
}