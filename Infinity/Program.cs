using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Infinity.Classes.Interfaces;
using Infinity.Classes.Objects;
using Infinity.Extensions;
using Newtonsoft.Json;

namespace Infinity
{
    /// <summary>
    /// Main entry point for the application.
    /// </summary>
    public static class Program
    {
        #region Members

        private const string SAVES_DIR = ".\\saves\\";

        private static IMatter _currentMatter;

        #endregion

        #region Methods

        /// <summary>
        /// Startup method for execution.
        /// </summary>
        /// <param name="args">An <see cref="Array"/> of <see cref="string"/> containing the sartup arguments for execution.</param>
        public static void Main(string[] args)
        {
            Initialize();

            while (ListenForUserInput())
            {
                // Weird...?
            }

            Console.Write("\nSave current multiverse (y/n)? ");
            var input = Console.ReadLine();
            if (input.StartsWith("y", StringComparison.InvariantCultureIgnoreCase))
            {
                SaveMultiverse();
            }

            $"# & <g> Press any key to exit </>".WriteFormatted();
            Console.ReadLine();
        }

        private static string GetSavesDirectory()
        {
            if (!Directory.Exists(SAVES_DIR))
            {
                Directory.CreateDirectory(SAVES_DIR);
            }
            return SAVES_DIR;
        }

        /// <summary>
        /// Configures the console and prepares the application for interaction with a top-level Multiverse instance.
        /// </summary>
        private static void Initialize()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BufferHeight = 60;
            Console.BufferWidth = 160;
            Console.WindowHeight = 60;
            Console.WindowWidth = 160;

            var files = Directory.EnumerateFiles(GetSavesDirectory());
            if (files.Any())
            {
                Console.Write("\nWould you like to open the last saved multiverse (y/n)? ");
                var input = Console.ReadLine();
                if (input.StartsWith("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    LoadLastSave(files);
                }
            }

            if (_currentMatter == null)
            {
                _currentMatter = new Multiverse();
                _currentMatter.Initialize();
            }

            PrintMatter(_currentMatter);
        }

        /// <summary>
        /// Lists UI menu options and accepts input via keyboard.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether or not the user has opted to continue execution.</returns>
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
                    PrintMatter(_currentMatter);
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

        private static void LoadLastSave(IEnumerable<string> files)
        {
            var lastSave = files.OrderByDescending(s => s).First();
            try
            {
                using (var file = File.OpenRead(lastSave))
                {
                    using (var reader = new StreamReader(file))
                    {
                        var serializationSettings = new JsonSerializerSettings
                        {
                            TypeNameHandling = TypeNameHandling.Auto
                        };
                        _currentMatter = JsonConvert.DeserializeObject<Multiverse>(reader.ReadToEnd(), serializationSettings);
                    }
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                $"# & Could not load {lastSave}: <r> {ex.Message} </>".WriteFormatted();
            }
        }

        /// <summary>
        /// Selects the parent <see cref="IMatter"/> instance, if one exists, and lists its properties in the console.
        /// </summary>
        /// <param name="command">An <see cref="Array"/> of <see cref="string"/> containing the user-specified options for the command.</param>
        /// <returns>A <see cref="bool"/> value indicating whether or not execution should continue.</returns>
        private static bool MoveUp(string[] command)
        {
            if (_currentMatter.Parent != null)
            {
                _currentMatter = _currentMatter.Parent;
                $"# & Moved to <w> {_currentMatter.Name} </> !".WriteFormatted();
                _currentMatter.Initialize();
            }
            else
            {
                "# & There is no place to which you can move up...".WriteFormatted();
            }

            return true;
        }

        /// <summary>
        /// Selects the specified child <see cref="IMatter"/> instance, if one exists, and lists its properties in the console.
        /// </summary>
        /// <param name="command">An <see cref="Array"/> of <see cref="string"/> containing the user-specified options for the command.</param>
        /// <returns>A <see cref="bool"/> value indicating whether or not execution should continue.</returns>
        private static bool MoveDown(string[] command)
        {
            if (_currentMatter.Children.Any())
            {
                int newPosition;

                try
                {
                    newPosition = int.Parse(command[1]);
                }
                catch
                {
                    (
                        _currentMatter.Children.Count == 1 ?
                        "# & To move down, enter <m> down <c> 0 </> ..." :
                        $"# & To move down, enter <m> down </> and a valid number between <c> 0 </> and <c> {(_currentMatter.Children.Count - 1)} </> ..."
                    ).WriteFormatted();
                    return true;
                }

                if (newPosition < _currentMatter.Children.Count)
                {
                    _currentMatter = _currentMatter.Children[newPosition];
                    $"# & Moved to <w> {_currentMatter.Name} </> !".WriteFormatted();
                    _currentMatter.Initialize();
                }
                else
                {
                    if (_currentMatter.Children.Count == 1)
                    {
                        "# & To move down, enter <m> down <c> 0 </> ...".WriteFormatted();
                    }
                    else
                    {
                        $"# & To move down, enter <m> down </> and a valid number between <c> 0 </> and <c> {(_currentMatter.Children.Count - 1)} </> ...".WriteFormatted();
                    }
                }
            }
            else
            {
                "# & There are no places to which you can move down...".WriteFormatted();
            }

            return true;
        }

        /// <summary>
        /// Prints the properties of the specified <see cref="IMatter"/> instance and its parent, if one exists.
        /// </summary>
        /// <param name="matter">An <see cref="IMatter"/> implementation whose properties will be displayed.</param>
        private static void PrintMatter(IMatter matter)
        {
            if (matter.Parent != null)
            {
                $"# & & & <y> Parent: <g> {_currentMatter.Parent.Type} <w> {_currentMatter.Parent.Name} </>".WriteFormatted();
            }

            $"# & & & <g> {matter.Type} <w> {matter.Name} </> #".WriteFormatted();

            foreach (var property in matter.Properties)
            {
                $"& & & <m> {property.Key} </> - <c> {property.Value} </>".WriteFormatted();
            }

            var position = 0;
            if (matter.Children.Any())
            {
                matter.Children.ToList().ForEach(child =>
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

        private static void SaveMultiverse()
        {
            while (_currentMatter.Parent != null)
            {
                _currentMatter = _currentMatter.Parent;
            }

            var multiverse = _currentMatter;
            try
            {
                var contents = multiverse.ToString();
                var fileName = $"{GetSavesDirectory()}{DateTime.Now.ToString("yyyy-MM-dd.HHmmss")}_{multiverse.Name}.json";
                using (var file = File.OpenWrite(fileName))
                {
                    file.Write(Encoding.UTF8.GetBytes(contents), 0, contents.Length);
                    file.Flush();
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                $"# & Could not save file: <r> {ex.Message} </>".WriteFormatted();
            }
        }

        #endregion
    }
}