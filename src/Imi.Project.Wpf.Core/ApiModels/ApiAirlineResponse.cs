namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiAirlineResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IataCode { get; set; }
        public string IcaoCode { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
