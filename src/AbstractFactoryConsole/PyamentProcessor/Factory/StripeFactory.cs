using AbstractFactoryConsole.PyamentProcessor.Stripe;

namespace AbstractFactoryConsole.PyamentProcessor.Factory;

public sealed class StripeFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new StripeValidator();
    public IPaymentProcessor CreateProcessor() => new StripeProcessor();
    public IPaymentLogger CreateLogger() => new StripeLogger();
}