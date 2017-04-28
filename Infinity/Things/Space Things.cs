using System.Collections.Generic;

namespace Infinity.Things {
    class Multiverse : Thing {
        public Multiverse() {
            type = "Multiverse";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(10) {
                            classes = { { "Infinity.Things.Universe", 1.0 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Universe : Thing {
        public Universe() {
            type = "Universe";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(10) {
                            classes = { { "Infinity.Things.Galaxy_Filament", 1.0 } }
                        },
                        new Child(5) {
                            classes = { { "Infinity.Things.Super_Void", 0.25 }, { "Infinity.Things.Void", 0.5 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Super_Void : Thing {
        public Super_Void() {
            type = "Super Void";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(20) {
                            classes = { { "Infinity.Things.Dark_Energy", 1.0 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Void : Thing {
        public Void() {
            type = "Void";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(10) {
                            classes = { { "Infinity.Things.Dark_Energy", 1.0 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Dark_Energy : Thing {
        public Dark_Energy() {
            type = "Dark Energy";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() { }
                }
            };
            name = "";
        }
    }

    class Galaxy_Filament : Thing {
        public Galaxy_Filament() {
            type = "Galaxy Filament";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(10) {
                            classes = { { "Infinity.Things.Galactic_Supercluster", 1.0 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Galactic_Supercluster : Thing {
        public Galactic_Supercluster() {
            type = "Galactic Supercluster";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(10) {
                            classes = { { "Infinity.Things.Galaxy", 1.0 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Galaxy : Thing {
        public Galaxy() {
            type = "Galaxy";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(10) {
                            classes = { { "Infinity.Things.Star_System", 1.0 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Star_System : Thing {
        public Star_System() {
            type = "Star System";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(2) {
                            classes = { { "Infinity.Things.Star", 1.0 } }
                        },
                        new Child(10) {
                            classes = { { "Infinity.Things.Planet", 1.0 } }
                        },
                        new Child(3) {
                            classes = { { "Infinity.Things.Asteroid_Belt", 0.5 }, { "Infinity.Things.Space_Station", 0.3 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Star : Thing {
        public Star() {
            type = "Star";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() { }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Planet : Thing {
        public Planet() {
            type = "Planet";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(5) {
                            classes = { { "Infinity.Things.Moon", 1.0 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Asteroid_Belt : Thing {
        public Asteroid_Belt() {
            type = "Asteroid Belt";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(15) {
                            classes = { { "Infinity.Things.Asteroid", 1.0 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Space_Station : Thing {
        public Space_Station() {
            type = "Space Station";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() {
                        new Child(5) {
                            classes = { { "Infinity.Things.Human", 1.0 } }
                        }
                    }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Moon : Thing {
        public Moon() {
            type = "Moon";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() { }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }

    class Asteroid : Thing {
        public Asteroid() {
            type = "Asteroid";
            subtype = Choose(new Dictionary<string, double>() { { "Default", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Default",
                    children = new List<Child>() { }
                }
            };
            name = "";

            List<Dictionary<string, double>> nameChoices = new List<Dictionary<string, double>>() {
                new Dictionary<string, double>() { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double>() { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double>() { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double>() { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => name += Choose(segment));
        }
    }
}
