using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var delimiter = '-';
        (bool IsNewYork, bool IsFake, string LocalNumber) tuple =
        (phoneNumber.Split(delimiter)[0].Equals("212"),
        phoneNumber.Split(delimiter)[1].Equals("555"),
        phoneNumber.Split(delimiter)[2]);

        return tuple;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    => phoneNumberInfo.IsFake;
}
