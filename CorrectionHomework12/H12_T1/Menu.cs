namespace H12_T1;

public class Menu
{
    public static bool IsActive { get; set; } = true;

    public static void Show()
    {
        Output.Header("Users data management system");
        Output.Prompt("To show all users data enter \"show\"");
        Output.Prompt("To add new user data - enter \"add\"");
        Output.Prompt("To exit this task - enter \"exit\"");
        Output.Message("Please enter a chosen option:");
    }

    public static void ReadInput()
    {
        var input = Console.ReadLine()?.ToLower();
        switch (input)
        {
            case "exit":
                {
                    IsActive = false;
                    break;
                }
            case "show":
                {
                    var users = DataProcessor.GetAllUsers();
                    if (users == null || users.Count == 0)
                    {
                        Output.Message("No users found in storage.");
                    }
                    else
                    {
                        Output.Header("List of users");
                        foreach (var user in users)
                        {
                            Output.Message(user.ToString());
                        }
                    }
                    Output.PressAndClear();
                    break;
                }
            case "add":
                {
                    DataProcessor.AddNewUserData();
                    Output.PressAndClear();
                    break;
                }
            default:
                {
                    Output.Warning("Invalid input. Try again:");
                    break;
                }
        }
    }
}