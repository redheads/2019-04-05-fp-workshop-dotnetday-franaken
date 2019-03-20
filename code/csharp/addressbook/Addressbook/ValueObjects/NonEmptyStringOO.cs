using System;
using System.Collections.Generic;
using LaYumba.Functional;
using Newtonsoft.Json;
using static LaYumba.Functional.F;

namespace Addressbook.ValueObjects
{
    // Object-Oriented solution
    // - Value Object
    // - private ctor
    // - validation in ctor
    public class NonEmptyStringOO : ValueObject
    {
        [JsonConstructor] 
        private NonEmptyStringOO(string potentialString)
        {
            if (!IsValid(potentialString))
                throw new ArgumentException("String may not be empty or null!");

            Value = potentialString;
        }

        private static bool IsValid(string potentialString) => !string.IsNullOrWhiteSpace(potentialString);

        public string Value { get; }

        public static Option<NonEmptyStringOO> Create(string potentialString)
        {
            Option<NonEmptyStringOO> result;

            try
            {
                result = Some(new NonEmptyStringOO(potentialString));
            }
            catch (Exception)
            {
                result = None;
            }

            return result;
        }

        public static NonEmptyStringOO CreateBang(string potentialString)
        {
            return new NonEmptyStringOO(potentialString);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}