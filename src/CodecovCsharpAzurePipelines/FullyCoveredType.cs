using System;

namespace CodecovCsharpAzurePipelines
{
    public class FullyCoveredType : ICoveredType
    {
        public string GetResult(Options options)
        {
            switch (options)
            {
                case Options.Yes:
                    return "Covered Yes";
                case Options.No:
                    return "Uncovered No";
                case Options.Maybe:
                    return "Covered Maybe";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
