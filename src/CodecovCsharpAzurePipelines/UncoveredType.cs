namespace CodecovCsharpAzurePipelines
{
    public class UncoveredType : ICoveredType
    {
        public string GetResult(Options options)
        {
            switch (options)
            {
                case Options.Yes:
                    return "Uncovered Yes";
                case Options.No:
                    return "Uncovered No";
                case Options.Maybe:
                    return "Uncovered Maybe";
                default:
                    return "Uncovered Unknown";
            }
        }
    }
}
