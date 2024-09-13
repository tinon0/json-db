namespace PruebaTecninca.Response
{
    public class ResultBase
    {
        public int StatusCode { get; set; }
        public bool Ok { get; set; }
        public string Error { get; set; }
        public string MessageInfo { get; set; }
        public object Result { get; set; }

    }
}
