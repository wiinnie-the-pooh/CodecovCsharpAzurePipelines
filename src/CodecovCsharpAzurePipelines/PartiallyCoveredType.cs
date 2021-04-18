using System;

namespace CodecovCsharpAzurePipelines
{
    public class PartiallyCoveredType : ICoveredType
    {
        public string GetResult(Options options)
        {
            switch (options)
            {
                case Options.Yes:
                    return "Partially Yes";
                case Options.No:
                    return "Partially No";
                case Options.Maybe:
                    return "Partially Maybe";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
