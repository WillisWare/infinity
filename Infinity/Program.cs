using System;
using System.Linq;
using Infinity.Interfaces;
using Infinity.Objects;

namespace Infinity
{
    public static class Program
    {
        #region Members

        private static IMatter _position;

        #endregion

        #region Methods

        public static void Main(string[] args)
        {
            Initialize();

            while (ListenForUserInput())
            {
                // Weird...?
            }
        }

        private static void Initialize()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            _position = new Multiverse();
            _position.Initialize();

            if (_position.Parent != null)
            {
                Display($"# & & & <y> Up <g> {_position.Parent.Type} <w> {_position.Parent.Name} </>");
            }

            Display($"# & & & <g> {_position.Type} <w> {_position.Name} </> #");

            var position = 0;

            if (_position.Children.Any())
            {
                _position.Children.ToList().ForEach(child =>
                {
                    Display($"& & & <y> Down <c> {position} </> - <g> {child.Type} <w> {child.Name} </>");
                    position++;
                });
            }
            else
            {
                Display("& & & <r> No lower levels... </>");
            }
        }

        private static bool ListenForUserInput()
        {
            Display("# & Enter your command: ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return true;
            }

            var command = input.ToLower().Split(' ');
            Console.ForegroundColor = ConsoleColor.DarkGray;

            switch (command[0].ToLowerInvariant())
            {
                case "exit":
                    return false;

                case "help":
                    PrintMatter(_position);
                    return true;

                case "down":
                    return MoveDown(command);

                case "up":
                    return MoveUp(command);

                default:
                    Display($"# & <m> {command} </> is not a proper command...");
                    return true;
            }
        }

        private static bool MoveUp(string[] command)
        {
            if (_position.Parent != null)
            {
                _position = _position.Parent;
                Display($"# & Moved to <w> {_position.Name} </> !");
                _position.Initialize();
            }
            else
            {
                Display("# & There is no place to which you can move up...");
            }

            return true;
        }

        private static bool MoveDown(string[] command)
        {
            if (_position.Children.Count != 0)
            {
                int newPosition;

                try
                {
                    newPosition = int.Parse(command[1]);
                }
                catch (Exception)
                {
                    Display((
                        _position.Children.Count == 1 ? "# & To move down, enter <m> down <c> 0 </> ..." : $"# & To move down, enter <m> down </> and a valid number between <c> 0 </> and <c> {(_position.Children.Count - 1)} </> ..."
                    ));
                    return true;
                }

                if (newPosition < _position.Children.Count)
                {
                    _position = _position.Children[newPosition];
                    Display($"# & Moved to <w> {_position.Name} </> !");
                    _position.Initialize();
                }
                else
                {
                    if (_position.Children.Count == 1)
                        Display("# & To move down, enter <m> down <c> 0 </> ...");
                    else
                        Display($"# & To move down, enter <m> down </> and a valid number between <c> 0 </> and <c> {(_position.Children.Count - 1)} </> ...");
                    return true;
                }
            }
            else
                Display("# & There are no places to which you can move down...");
            return false;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream using custom formatting.
        /// </summary>
        /// <param name="text">The value to write.</param>
        public static void Display(string text)
        {
            var segments = text.Split(' ');

            for (var x = 0; x < segments.Length; x++)
            {
                var end = segments[x].Length - 1;
                if (end == -1)
                    continue;

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

                if ((segments[segments.Length - 2] == "</>" && x == segments.Length - 3) && segments[segments.Length - 1] != "")
                {
                    continue;
                }

                Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;

            if (segments[segments.Length - 1] != "")
            {
                Console.Write("\n");
            }
        }

        private static void PrintMatter(IMatter matter)
        {
            Display($"# & & & <g> {matter.Type} <w> {matter.Name} </> #");

            foreach (var property in matter.Properties)
            {
                Display($"& & & <m> {property.Key} </> - <c> {property.Value} </>");
            }
        }

        #endregion
    }
}