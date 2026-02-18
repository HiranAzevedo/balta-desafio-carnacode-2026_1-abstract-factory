using AbstractFactoryConsole.PyamentProcessor.MercadoPago;

namespace AbstractFactoryConsole.PyamentProcessor.Factory;

public sealed class MercadoPagoFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new MercadoPagoValidator();
    public IPaymentProcessor CreateProcessor() => new MercadoPagoProcessor();
    public IPaymentLogger CreateLogger() => new MercadoPagoLogger();
}
