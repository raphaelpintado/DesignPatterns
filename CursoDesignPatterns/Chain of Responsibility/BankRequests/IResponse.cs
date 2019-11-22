namespace CursoDesignPatterns.Chain_of_Responsibility.BankRequests
{
  public interface IResponse
  {
    void Answer(Request request, Account account);
  }
}
