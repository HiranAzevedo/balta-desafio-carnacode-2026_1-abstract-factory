namespace AbstractFactoryConsole.PyamentProcessor.Factory;

public interface IPaymentGatewayFactory
{
    IPaymentValidator CreateValidator();
    IPaymentProcessor CreateProcessor();
    IPaymentLogger CreateLogger();
}