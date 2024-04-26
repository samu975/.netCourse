namespace ClassLibrary1;

public class Class1
{
    public static string GetMessage(string userName)
    {
        string currentTime = DateTime.Now.ToString("hh:mm:ss");
        return $"{currentTime} Hello, {userName}!";
    }
}