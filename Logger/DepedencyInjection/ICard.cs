namespace DepedencyInjection;

public interface ICard
{
    int GetValue();
    string GetDescription();
    bool Equals(object? obj);
    int GetHashCode();
    CardStatus GetStatus();
    void SetStatus(CardStatus status);
}
