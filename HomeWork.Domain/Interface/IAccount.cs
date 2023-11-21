

namespace HomeWork.Domain.Interface
{
    public interface IAccount
    {
        public bool PasswordChecker(string password);
        public bool EmailChecker(string password);
        public void ShowInfo();


    }
}
