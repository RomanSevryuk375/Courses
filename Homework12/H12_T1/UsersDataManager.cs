namespace H12_T1;

public class UsersDataManager
{
    public static void Run()
    {
        do
        {
            Menu.Show();
            Menu.ReadInput();

        } while (Menu.IsActive);
    }
}
