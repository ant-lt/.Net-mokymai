namespace WebApiF1.Services
{
    public interface IOperation
    {
        public string GetOperationId();
    }

    public interface IMyOperationTransient : IOperation { }
    public interface IMyOperationScoped : IOperation { }
    public interface IMyOperationSingleton : IOperation { }
}
