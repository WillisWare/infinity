using System;
using System.Linq;
using Infinity.Extensions;
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

            Console.Write("\nPress any key to exit");
            Console.ReadLine();
        }

        private static void Initialize()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BufferHeight = 60;
            Console.BufferWidth = 160;
            Console.WindowHeight = 60;
            Console.WindowWidth = 160;

            _position = new Multiverse();
            _position.Initialize();

            if (_position.Parent != null)
            {
                $"# & & & <y> Up <g> {_position.Parent.Type} <w> {_position.Parent.Name} </>".WriteFormatted();
            }

            $"# & & & <g> {_position.Type} <w> {_position.Name} </> #".WriteFormatted();

            var position = 0;

            if (_position.Children.Any())
            {
                _position.Children.ToList().ForEach(child =>
                {
                    $"& & & <y> Down <c> {position} </> - <g> {child.Type} <w> {child.Name} </>".WriteFormatted();
                    position++;
                });
            }
            else
            {
                "& & & <r> No lower levels... </>".WriteFormatted();
            }
        }

        private static bool ListenForUserInput()
        {
            "# & Enter your command: ".WriteFormatted();

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
                    $"# & <m> {command[0]} </> is not a proper command...".WriteFormatted();
                    return true;
            }
        }

        private static bool MoveUp(string[] command)
        {
            if (_position.Parent != null)
            {
                _position = _position.Parent;
                $"# & Moved to <w> {_position.Name} </> !".WriteFormatted();
                _position.Initialize();
            }
            else
            {
                "# & There is no place to which you can move up...".WriteFormatted();
            }

            return true;
        }

        private static bool MoveDown(string[] command)
        {
            if (_position.Children.Any())
            {
                int newPosition;

                try
                {
                    newPosition = int.Parse(command[1]);
                }
                catch
                {
                    (
                        _position.Children.Count == 1 ?
                        "# & To move down, enter <m> down <c> 0 </> ..." :
                        $"# & To move down, enter <m> down </> and a valid number between <c> 0 </> and <c> {(_position.Children.Count - 1)} </> ..."
                    ).WriteFormatted();
                    return true;
                }

                if (newPosition < _position.Children.Count)
                {
                    _position = _position.Children[newPosition];
                    $"# & Moved to <w> {_position.Name} </> !".WriteFormatted();
                    _position.Initialize();
                }
                else
                {
                    if (_position.Children.Count == 1)
                    {
                        "# & To move down, enter <m> down <c> 0 </> ...".WriteFormatted();
                    }
                    else
                    {
                        $"# & To move down, enter <m> down </> and a valid number between <c> 0 </> and <c> {(_position.Children.Count - 1)} </> ...".WriteFormatted();
                    }
                }
            }
            else
            {
                "# & There are no places to which you can move down...".WriteFormatted();
            }

            return true;
        }

        private static void PrintMatter(IMatter matter)
        {
            $"# & & & <g> {matter.Type} <w> {matter.Name} </> #".WriteFormatted();

            foreach (var property in matter.Properties)
            {
                $"& & & <m> {property.Key} </> - <c> {property.Value} </>".WriteFormatted();
            }
        }

        #endregion
    }
}