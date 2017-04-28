using System;

namespace Infinity.Extensions
{
    public static class ConsoleExtensions
    {
        #region Methods

        public static void WriteFormatted(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            var segments = text.Split(' ');

            for (var x = 0; x < segments.Length; x++)
            {
                var end = segments[x].Length - 1;
                if (end == -1)
                {
                    continue;
                }

                switch (segments[x])
                {
                    case "#":
                        Console.Write("\n");
                        continue;
                    case "&":
                        Console.Write(" ");
                        continue;
                    case "<r>":
                        Console.ForegroundColor = ConsoleColor.Red;
                        continue;
                    case "<y>":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        continue;
                    case "<g>":
                        Console.ForegroundColor = ConsoleColor.Green;
                        continue;
                    case "<c>":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        continue;
                    case "<b>":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        continue;
                    case "<m>":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        continue;
                    case "<w>":
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    case "</>":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        continue;
                    default:
                        break;
                }

                Console.Write(segments[x]);

                if ((segments[segments.Length - 2] == "</>" && x == segments.Length - 3) && !string.IsNullOrWhiteSpace(segments[segments.Length - 1]))
                {
                    continue;
                }

                Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;

            if (!string.IsNullOrWhiteSpace(segments[segments.Length - 1]))
            {
                Console.Write("\n");
            }
        }

        #endregion
    }
}
