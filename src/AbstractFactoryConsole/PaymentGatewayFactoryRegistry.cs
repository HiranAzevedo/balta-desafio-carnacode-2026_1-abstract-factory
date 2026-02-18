using AbstractFactoryConsole.PyamentProcessor.Factory;

namespace AbstractFactoryConsole;

public static class PaymentGatewayFactoryRegistry
{
    private static readonly Dictionary<string, Func<IPaymentGatewayFactory>> _map =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["pagseguro"] = () => new PagSeguroFactory(),
            ["mercadopago"] = () => new MercadoPagoFactory(),
            ["stripe"] = () => new StripeFactory(),
        };

    public static IPaymentGatewayFactory Resolve(string gateway)
    {
        if (_map.TryGetValue(gateway, out var ctor))
        {
            return ctor();
        }

        throw new ArgumentException("Gateway não suportado");
    }
}