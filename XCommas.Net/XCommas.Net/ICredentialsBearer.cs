namespace XCommas.Net
{
    public interface ICredentialsBearer
    {
        string ApiKey { get; }
        string Secret { get; }
    }
}
