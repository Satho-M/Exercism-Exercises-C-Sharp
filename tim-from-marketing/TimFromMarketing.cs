using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string printBadge = string.Empty;

        //If id is null print no id
        string stringID = $"[{id}] - ";
        if (id != null) printBadge += stringID;

        //If department is null, employee is owner
        if (department == null) department = "owner";

        string stringNameAndDepartment = $"{name} - {department.ToUpper()}";
        printBadge += stringNameAndDepartment;

        return printBadge;
    }
}
