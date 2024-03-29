namespace API_Class
{
    internal class Urls
    {
        public string original { get; set; }
        public string regular { get; set; }
        public string small { get; set; }
        public string thumb { get; set; }
        public string mini { get; set; }
    }

    internal class DataItem
    {
        public int pid { get; set; }
        public int p { get; set; }
        public int uid { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public bool r18 { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public List<string> tags { get; set; }
        public string ext { get; set; }
        public short aiType { get; set; }
        public long uploadDate { get; set; }
        public Urls urls { get; set; }
    }

    internal class Root
    {
        public string error { get; set; }
        public List<DataItem> data { get; set; }
    }
}
