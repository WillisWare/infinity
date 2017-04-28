using System.Collections.Generic;

namespace Infinity.Things {
    class ChildConfig {
        public string name;
        public List<Child> children;
    }

    class Child {
        public Dictionary<string, double> classes = new Dictionary<string, double>();
        public int min, max;

        public Child(int max) {
            min = 1;
            this.max = max;
        }

        public Child(int min, int max) {
            this.min = min;
            this.max = max;
        }
    }
}
