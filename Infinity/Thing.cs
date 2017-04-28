using Infinity.Things;
using System;
using System.Collections.Generic;

namespace Infinity {
    abstract class Thing {
        public static Random random;

        public Thing parent;
        public List<Thing> children = new List<Thing>();
        public List<ChildConfig> childConfigs = new List<ChildConfig>();

        public string type, subtype, name;
        public Dictionary<string, string> properties = new Dictionary<string, string>();
        public bool initialized = false;
        
        public void Interact() {
            if (!initialized) {
                foreach (Child child in 
                    childConfigs[childConfigs.FindIndex(x => x.name == subtype)].children)
                    MakeChildren(child);

                initialized = true;
            }

            if (parent != null)
                Program.Display(string.Format("# & & & <y> Up <g> {0} <w> {1} </>", parent.type, parent.name));

            Program.Display(string.Format("# & & & <g> {0} <w> {1} </> #", type, name));

            int position = 0;

            if (children.Count > 0)
                children.ForEach(child => { Program.Display(string.Format("& & & <y> Down <c> {0} </> - <g> {1} <w> {2} </>", position, child.type, child.name)); position++; });
            else
                Program.Display("& & & <r> No lower levels... </>");
        }

        public void MakeChildren(Child child) {
            if (child.min == 1 && child.max == 1) {
                string childType = Choose(child.classes);
                if (childType != null) {
                    Thing newChild = (Thing)Activator.CreateInstance(Type.GetType(childType));
                    newChild.parent = this;

                    children.Add(newChild);
                }
            } else {
                int total = RandomNumber(child.min, child.max);

                if (total != 0)
                    for (var x = 0; x <= total; x++) {
                        string childType = Choose(child.classes);
                        if (childType != null) {
                            Thing newChild = (Thing)Activator.CreateInstance(Type.GetType(Choose(child.classes)));
                            newChild.parent = this;

                            children.Add(newChild);
                        }
                    }
            }
        }

        public void Print() {
            Program.Display(string.Format("# & & & <g> {0} <w> {1} </> #", type, name));

            foreach (KeyValuePair<string, string> property in properties)
                Program.Display(string.Format("& & & <m> {0} </> - <c> {1} </>", property.Key, property.Value));
        }

        public T Choose<T>(Dictionary<T, double> choices) {
            List<T> newChoices = new List<T>();

            foreach (KeyValuePair<T, double> choice in choices) {
                for (int x = 0; x < choice.Value * 10; x++)
                    newChoices.Add(choice.Key);
            }

            return newChoices[random.Next(0, newChoices.Count)];
        }

        public int RandomNumber(int min, int max) {
            return (random.Next(min, max + 1));
        }
    }
}
