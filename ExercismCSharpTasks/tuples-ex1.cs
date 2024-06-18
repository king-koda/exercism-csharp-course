using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string newYorkAreaCode = "212";
        bool isNewYork = phoneNumber.StartsWith(newYorkAreaCode);
        bool isFake = phoneNumber.Substring(5, 3) == "555";
        string lastFourDigits = phoneNumber.Substring(phoneNumber.Length - 4, phoneNumber.Length);

        return (isNewYork, isFake, lastFourDigits);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
