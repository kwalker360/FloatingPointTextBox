// ExtensionMethods
//
//   Author: Ken Walker, Bridge360 (http://bridge360.com)

namespace Bridge360
{
    /// <summary>
    /// Extension method to determine whether a string contains one and only one of a specified character.
    /// </summary>
    /// <param name="text">The string to examine.</param>
    /// <param name="character">The character to search for in <paramref name="text"/>.</param>
    /// <returns>
    /// <c>true</c> if one and only one of <paramref name="character"/> is found in <paramref name="text"/>;
    /// otherwise, <c>false</c>.
    /// </returns>
    public static class Bridge360
    {
        public static bool HasOnlyOne(this string text, char character)
        {
            int count = 0;
            foreach (var ch in text)
            {
                if (ch == character)
                {
                    if (count == 1)
                        return false;

                    count++;
                }
            }

            return count == 1;
        }
    }
}
