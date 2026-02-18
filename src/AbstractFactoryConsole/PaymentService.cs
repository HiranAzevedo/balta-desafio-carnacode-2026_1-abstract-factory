using AbstractFactoryConsole.PyamentProcessor;
using AbstractFactoryConsole.PyamentProcessor.Factory;

namespace AbstractFactoryConsole;

public sealed class PaymentService(IPaymentGatewayFactory factory)
{
    private readonly IPaymentValidator _validator = factory.CreateValidator();
    private readonly IPaymentProcessor _processor = factory.CreateProcessor();
    private readonly IPaymentLogger _logger = factory.CreateLogger();

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if (!_validator.ValidateCard(cardNumber))
        {
            _logger.Log("Cartão inválido");
            return;
        }

        var result = _processor.ProcessTransaction(amount, cardNumber);
        _logger.Log($"Transação processada: {result}");
    }
}

