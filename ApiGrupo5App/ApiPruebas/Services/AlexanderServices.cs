namespace ApiPruebas.Services
{
    public interface IAlexanderService
    {
        string SaludoAlexander();
    }
    public class AlexanderServices : IAlexanderService
    {
        //private readonly IAlexanderService _alexanderInterface;

        //public AlexanderServices(IAlexanderService alexanderInterface)
        //{
        //    _alexanderInterface = alexanderInterface;
        //}

        public string SaludoAlexander() 
        {
            return "Hola, soy Alexander";
        }

    }
}
