﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.LessonsExamples.Domain
{

    public static class CharacterValidator
    {
        public const int MaxHealth = 100;
        public const int MinHealth = 0;

        public static string ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name.Trim())
                throw new ArgumentException("name cannot be empty or null");
            return name;
        }

        // TODO: Add validate health method
    }
}
