namespace AbstractFactoryConsole.PyamentProcessor;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}

public interface IPaymentLogger
{
    void Log(string message);
}

