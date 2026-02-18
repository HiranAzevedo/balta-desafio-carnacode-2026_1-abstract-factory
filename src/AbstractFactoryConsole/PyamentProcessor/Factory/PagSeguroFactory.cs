using AbstractFactoryConsole.PyamentProcessor.PagSeguro;

namespace AbstractFactoryConsole.PyamentProcessor.Factory;

public sealed class PagSeguroFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new PagSeguroValidator();
    public IPaymentProcessor CreateProcessor() => new PagSeguroProcessor();
    public IPaymentLogger CreateLogger() => new PagSeguroLogger();
}
