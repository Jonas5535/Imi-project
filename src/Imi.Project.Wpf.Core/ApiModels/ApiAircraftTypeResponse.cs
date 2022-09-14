namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiAircraftTypeResponse
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string IcaoCode { get; set; }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
