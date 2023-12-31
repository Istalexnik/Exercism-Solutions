﻿using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();

        for(int i = 0; i < identifier.Length; i++)
        {
            char c = identifier[i];

            if (c == '-')
            {
                sb.Append(char.ToUpper(identifier[++i]));
            }
            else
            {
                sb.Append(c switch
                {
                    _ when c >= 'α' && c <= 'ω' => default,
                    _ when char.IsLetter(c) => c,
                    _ when char.IsWhiteSpace(c) => '_',
                    _ when c == '\0' => "CTRL",
                    _ => default
                });
            }
        }

        return sb.ToString();      
    }
}