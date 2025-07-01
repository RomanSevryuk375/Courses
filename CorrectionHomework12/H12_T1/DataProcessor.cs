using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace H12_T1;

public class DataProcessor
{
    private static string _validName;
    private static string _validEmail;
    private static int _validAge;

    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    public static void AddNewUserData()
    {
        if (TryReadValidUserName() && TryReadValidUserAge() && TryReadValidUserEmail())
        {
            AddUserToFile(new User(_validName, _validAge, _validEmail));
        }
        else
        {
            Output.Warning("Process aborted. New user's data not added.");
        }
    }

    public static bool TryReadValidUserName()
    {
        var regex = new Regex(@"^[A-Za-z\s'-]{2,}$");

        while (true)
        {
            Output.Prompt("Enter user's name: ");
            Output.Prompt("To exit this section - enter \"exit\"");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Output.Warning("Name cannot be empty. Please try again.");
                continue;
            }

            _validName = input.Trim();

            if (_validName.ToLower() == "exit") return false;

            if (regex.IsMatch(_validName)) return true;

            Output.Warning("Invalid input. Please enter a valid name " +
                  "(at least 2 letters, only letters, spaces, apostrophes, or hyphens).");
        }
    }

    public static bool TryReadValidUserAge()
    {
        while (true)
        {
            Output.Prompt("Enter user's age (integer from 1 to 150): ");
            Output.Prompt("To exit this section - enter \"exit\"");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Output.Warning("Age cannot be empty. Please try again.");
                continue;
            }

            input = input.Trim();

            if (input.ToLower() == "exit") return false;

            if (int.TryParse(input, out _validAge) && _validAge >= 1 && _validAge <= 150)
            {
                return true;
            }

            Output.Warning("Invalid input. Please enter a valid age (integer between 1 and 150).");
        }
    }

    public static bool TryReadValidUserEmail()
    {
        var regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

        while (true)
        {
            Output.Prompt("Enter user's e-mail: ");
            Output.Prompt("To exit this section - enter \"exit\"");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Output.Warning("Email cannot be empty. Please try again.");
                continue;
            }

            _validEmail = input.Trim();

            if (_validEmail.ToLower() == "exit") return false;

            if (regex.IsMatch(_validEmail)) return true;

            Output.Warning("Invalid input. Please enter a valid e-mail address.");
        }
    }

    public static void AddUserToFile(User user)
    {
        try
        {
            List<User> users = new();
            string filePath = "Users.json";

            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);

                if (!string.IsNullOrWhiteSpace(jsonContent))
                {
                    try
                    {
                        users = JsonSerializer.Deserialize<List<User>>(jsonContent) ?? new List<User>();
                    }
                    catch (JsonException)
                    {
                        // Если не получилось как массив, попробуем прочитать как одиночный объект
                        var singleUser = JsonSerializer.Deserialize<User>(jsonContent);
                        if (singleUser != null)
                        {
                            users.Add(singleUser);
                        }
                    }
                }
            }

            users.Add(user);
            string newJson = JsonSerializer.Serialize(users, _jsonOptions);
            File.WriteAllText(filePath, newJson);

            Output.Message($"User ({user}) - added to storage.");
        }
        catch (Exception ex)
        {
            Output.Error($"Error saving user data: {ex.Message}");
        }
    }

    public static List<User>? GetAllUsers()
    {
        try
        {
            string filePath = "Users.json";
            if (!File.Exists(filePath)) return null;

            string jsonContent = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(jsonContent)) return null;

            try
            {
                return JsonSerializer.Deserialize<List<User>>(jsonContent);
            }
            catch (JsonException)
            {
                var singleUser = JsonSerializer.Deserialize<User>(jsonContent);
                return singleUser != null ? new List<User> { singleUser } : null;
            }
        }
        catch (Exception ex)
        {
            Output.Error($"Error reading users data: {ex.Message}");
            return null;
        }
    }
}