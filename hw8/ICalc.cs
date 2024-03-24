namespace hw8
{
    internal interface ICalc
    {
        public int Less(int valueToCompare);
        public int Greater(int valueToCompare);
    }
    internal interface ICalc2
    {
        public int CountDistinct();
        public int EqualToValue(int valueToCompare);
    }
}
