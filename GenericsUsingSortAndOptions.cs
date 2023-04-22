using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
        internal class MaxNumGenericClass<T> where T : IComparable<T>
        {
            private readonly List<T> values;

            public MaxNumGenericClass(params T[] values)
            {
                this.values = values.ToList();
            }


            public Option<T> FindMax()
            {
                if (values.Count == 0) return Option<T>.None;

                T maxValue = values[0];
                for (int i = 1; i < values.Count; i++)
                {
                    if (values[i].CompareTo(maxValue) > 0)
                    {
                        maxValue = values[i];
                    }
                }

                return Option<T>.Some(maxValue);
            }

            public Option<T> FindMaxUsingSorting()
            {
                if (values.Count == 0) return Option<T>.None;

                var sortedValues = values.OrderBy(v => v);
                return Option<T>.Some(sortedValues.Last());
            }
        }

        internal struct Option<T>
        {
            public readonly bool HasValue;
            private readonly T value;

            private Option(T value)
            {
                HasValue = true;
                this.value = value;
            }

            public static Option<T> None => new Option<T>();

            public static Option<T> Some(T value)
            {
                return new Option<T>(value);
            }

            public T Value
            {
                get
                {
                    if (!HasValue)
                    {
                        throw new InvalidOperationException("Option has no value.");
                    }
                    return value;
                }
            }

            public T GetValueOrDefault(T defaultValue = default(T))
            {
                return HasValue ? value : defaultValue;
            }
        }

        public static class Program
        {
            public static void Main()
            {
                MaxNumGenericClass<int> intValue = new MaxNumGenericClass<int>(10, 20, 5, 30);
                Option<int> maxInt = intValue.FindMax();
                Console.WriteLine($"Max int value is: {maxInt.GetValueOrDefault()}");

                MaxNumGenericClass<float> floatValue = new MaxNumGenericClass<float>(10.0f, 20.3f, 5.3f, 30.4f);
                Option<float> maxFloat = floatValue.FindMaxUsingSorting();
                Console.WriteLine($"Max float value is: {maxFloat.GetValueOrDefault()}");

                MaxNumGenericClass<string> strValue = new MaxNumGenericClass<string>("Apple", "Banana", "Orange", "Pineapple");
                Option<string> maxStr = strValue.FindMax();
                Console.WriteLine($"Max string value is: {maxStr.GetValueOrDefault()}");
            }
        }
    }
