using System;
using System.Collections.Generic;
using Infinity.Things;
using System.Linq;

namespace Infinity {
    class Program {
        static Thing position;

        static void Main(string[] args) {
            Initialize();
        }

        static void Initialize() {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Thing.random = new Random();

            List<Thing> things = new List<Thing>();

            things.Add(new Multiverse());

            position = things[0];
            position.Interact();

            while (Loop()) { }
        }

        static bool Loop() {
            Display("# & Enter your command: ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            string[] command = Console.ReadLine().ToLower().Split(' ');
            Console.ForegroundColor = ConsoleColor.DarkGray;

            if (command[0] == "exit" || command[0] == "")
                return false;
            else if (command[0] == "help") {
                position.Print();
            } else if (command[0] == "down") {
                if (position.children.Count != 0) {
                    int newPosition;

                    try {
                        newPosition = int.Parse(command[1]);
                    } catch (Exception) {
                        if (position.children.Count() == 1)
                            Display(string.Format("# & To move down, enter <m> down <c> 0 </> ..."));
                        else
                            Display(string.Format("# & To move down, enter <m> down </> and a valid number between <c> 0 </> and <c> {0} </> ...", (position.children.Count - 1)));
                        return true;
                    }

                    if (newPosition < position.children.Count) {
                        position = position.children[newPosition];
                        Display(string.Format("# & Moved to <w> {0} </> !", position.name));
                        position.Interact();
                    } else {
                        if (position.children.Count() == 1)
                            Display(string.Format("# & To move down, enter <m> down <c> 0 </> ..."));
                        else
                            Display(string.Format("# & To move down, enter <m> down </> and a valid number between <c> 0 </> and <c> {0} </> ...", (position.children.Count - 1)));
                        return true;
                    }
                } else
                    Display("# & There are no places to which you can move down...");
            } else if (command[0] == "up") {
                if (position.parent != null) {
                    position = position.parent;
                    Display(string.Format("# & Moved to <w> {0} </> !", position.name));
                    position.Interact();
                } else
                    Display("# & There is no place to which you can move up...");
            } else {
                Display(string.Format("# & <m> {0} </> is not a proper command...", command));
            }

            return true;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream using custom formatting.
        /// </summary>
        /// <param name="text">The value to write.</param>
        public static void Display(string text) {
            string[] segments = text.Split(' ');

            for (int x = 0; x < segments.Count(); x++) {
                int end = segments[x].Count() - 1;
                if (end == -1)
                    continue;

                if (segments[x] == "#") {
                    Console.Write("\n");
                    continue;
                } else if (segments[x] == "&") {
                    Console.Write(" ");
                    continue;
                }

                if (segments[x] == "<r>") {
                    Console.ForegroundColor = ConsoleColor.Red;
                    continue;
                } else if (segments[x] == "<y>") {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    continue;
                } else if (segments[x] == "<g>") {
                    Console.ForegroundColor = ConsoleColor.Green;
                    continue;
                } else if (segments[x] == "<c>") {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    continue;
                } else if (segments[x] == "<b>") {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    continue;
                } else if (segments[x] == "<m>") {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    continue;
                } else if (segments[x] == "<w>") {
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                } else if (segments[x] == "</>") {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    continue;
                }

                Console.Write(segments[x]);

                if ((segments[segments.Count() - 2] == "</>" && x == segments.Count() - 3) && segments[segments.Count() - 1] != "")
                    continue;

                Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;

            if (segments[segments.Count() - 1] != "")
                Console.Write("\n");
        }
    }
}