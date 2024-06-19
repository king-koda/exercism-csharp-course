using System;

public static class PhoneNumber
{
   public static (bool isNewYork, bool isFake, string localNumber) Analyze(string phoneNumber)
    {
        string newYorkAreaCode = "212";
        bool isNewYork = phoneNumber.StartsWith(newYorkAreaCode);
        bool isFake = phoneNumber.Substring(4, 3) == "555";
        string localNumber = phoneNumber.Substring(phoneNumber.Length - 4, 4);

        return (isNewYork, isFake, localNumber);
    }


    public static bool IsFake((bool isNewYork, bool isFake, string localNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.isFake;
    }
}

/*
Instructions
This exercise has you analyze phone numbers.

You are asked to implement 2 features.

Phone numbers passed to the routines are guaranteed to be in the form NNN-NNN-NNNN e.g. 212-515-9876 and non-null.

1. Analyze a phone number
Your analysis should return 3 pieces of data

An indication of whether the number has a New York dialing code ie. 212 as the first 3 digits
An indication of whether the number is fake having 555 as a prefix code in positions 5 to 7 (numbering from 1)
The last 4 digits of the number.
Implement the (static) method PhoneNumber.Analyze() to produce the phone number info.

PhoneNumber.Analyze("631-555-1234");
// => (false, true, "1234")

2. Detect if a phone number has a fake prefix code (555)
Implement the (static) method PhoneNumber.IsFake() to detect whether the phone number is fake using the phone number info produced in task 1.

PhoneNumber.IsFake(PhoneNumbers.Analyze("631-555-1234"));
// => true
*/