using System.Collections.Generic;
using System.Linq;

namespace Infinity.Things {
    class Human : Thing {
        public Human() {
            type = "Human";
            subtype = Choose(new Dictionary<string, double>() { { "Male", 1.0 }, { "Female", 1.0 } });
            childConfigs = new List<ChildConfig>() {
                new ChildConfig() {
                    name = "Male",
                    children = new List<Child>() { }
                },
                new ChildConfig() {
                    name = "Female",
                    children = new List<Child>() { }
                }
            };

            name = getName();

            properties = new Dictionary<string, string>() {
                { "Gender", subtype },
                { "Age Range", Choose(new Dictionary<string, double>() { { "Baby", 1.0 }, { "Child", 1.0 }, { "Teenager", 1.0 }, { "Young Adult", 1.0 }, { "Adult", 1.0 }, { "Elder", 1.0 } } ) },
                { "Age", "" },
                { "Mood", Choose(new Dictionary<string, double>() { { "Great", 1.0 }, { "Good", 1.0 }, { "Moderate", 1.0 }, { "Bad", 1.0 }, { "Awful", 1.0 } } ) }
            };

            properties["Age"] = getAge();
            properties["Thoughts"] = getThoughts();
        }

        public string getName() {
            name = "";
            string region = Choose(new Dictionary<string, double>() { { "Western", 1.0 }, { "Hispanic", 1.0 }, { "Asian", 1.0 }, { "European", 1.0 } });

            List<Dictionary<string, double>> nameChoices;

            if (subtype == "Male") {
                if (region == "Western")
                    nameChoices = new List<Dictionary<string, double>>() {
                        new Dictionary<string, double>() { { "John", 1.0 }, { "Jeff", 1.0 }, { "Michael", 1.0 }, { "Gregory", 1.0 }, { "Daniel", 1.0 }, { "Jimmy", 1.0 }, { "Allen", 1.0 }, { "George", 1.0 }, { "Russ", 1.0 } },
                        new Dictionary<string, double>() { { " ", 1.0 } },
                        new Dictionary<string, double>() { { "Wilkin", 1.0 }, { "Jacob", 1.0 }, { "Eric", 1.0 }, { "Michael", 1.0 }, { "Joseph", 1.0 }, { "Schmidt", 1.0 } },
                        new Dictionary<string, double>() { { "son", 1.0 }, { "s", 1.0 }, { "", 1.0 } },
                        new Dictionary<string, double>() { { "", 1.0 }, { " Jr.", 0.5 }, { " Sr.", 0.2 } }
                    };
                else if (region == "Hispanic")
                    nameChoices = new List<Dictionary<string, double>>() {
                        new Dictionary<string, double>() { { "Carlos", 1.0 }, { "Marco", 1.0 }, { "Enrique", 1.0 }, { "Alejandro", 1.0 }, { "Gabriel", 1.0 }, { "Antonio", 1.0 }, { "Pedro", 1.0 }, { "Julio", 1.0 }, { "Tito", 1.0 }, { "Miguel", 1.0 } },
                        new Dictionary<string, double>() { { " ", 1.0 } },
                        new Dictionary<string, double>() { { "Santiago", 1.0 }, { "Rubio", 1.0 }, { "Iglesias", 1.0 }, { "Chulo", 1.0 }, { "Arturo", 1.0 }, { "Martinez", 1.0 }, { "Gonzales", 1.0 } },
                        new Dictionary<string, double>() { { "", 1.0 }, { " Jr.", 0.5 }, { " Sr.", 0.2 } }
                    };
                else if (region == "Asian")
                    nameChoices = new List<Dictionary<string, double>>() {
                        new Dictionary<string, double>() { { "Arata", 1.0 }, { "Goro", 1.0 }, { "Hideo", 1.0 }, { "Ichiro", 1.0 }, { "Joji", 1.0 }, { "Katashi", 1.0 }, { "Kichiro", 1.0 }, { "Masaki", 1.0 }, { "Osamu", 1.0 }, { "Ryo", 1.0 }, { "Yoshiaki", 1.0 } },
                        new Dictionary<string, double>() { { " ", 1.0 } },
                        new Dictionary<string, double>() { { "Nguyen", 1.0 }, { "Lee", 1.0 }, { "Kim", 1.0 }, { "Tran", 1.0 }, { "Singh", 1.0 }, { "Wu", 1.0 }, { "Zhang", 1.0 } }
                    };
                else
                    nameChoices = new List<Dictionary<string, double>>() {
                        new Dictionary<string, double>() { { "Barrington", 1.0 }, { "Bradburn", 1.0 }, { "Dayton", 1.0 }, { "Edward", 1.0 }, { "Garfield", 1.0 }, { "Harding", 1.0 }, { "Isaac", 1.0 }, { "Mansfield", 1.0 }, { "Pearson", 1.0 } },
                        new Dictionary<string, double>() { { " ", 1.0 } },
                        new Dictionary<string, double>() { { "Schneider", 1.0 }, { "Gruber", 1.0 }, { "Pichler", 1.0 }, { "Muller", 1.0 }, { "Wagner", 1.0 }, { "Bauer", 1.0 } },
                        new Dictionary<string, double>() { { "", 1.0 }, { " Jr.", 0.5 }, { " Sr.", 0.2 } }
                    };
            } else {
                if (region == "Western")
                    nameChoices = new List<Dictionary<string, double>>() {
                        new Dictionary<string, double>() { { "Emily", 1.0 }, { "Amanda", 1.0 }, { "Barbara", 1.0 }, { "Cynthia", 1.0 }, { "Michelle", 1.0 }, { "Jessica", 1.0 }, { "Denise", 1.0 }, { "Elizabeth", 1.0 }, { "Tiffany", 1.0 } },
                        new Dictionary<string, double>() { { " ", 1.0 } },
                        new Dictionary<string, double>() { { "Wilkin", 1.0 }, { "Jacob", 1.0 }, { "Eric", 1.0 }, { "Michael", 1.0 }, { "Joseph", 1.0 }, { "Schmidt", 1.0 } },
                        new Dictionary<string, double>() { { "son", 1.0 }, { "s", 1.0 }, { "", 1.0 } }
                    };
                else if (region == "Hispanic")
                    nameChoices = new List<Dictionary<string, double>>() {
                        new Dictionary<string, double>() { { "Carla", 1.0 }, { "Sofia", 1.0 }, { "Isabella", 1.0 }, { "Camila", 1.0 }, { "Victoria", 1.0 }, { "Gabriella", 1.0 }, { "Lucia", 1.0 }, { "Alejandra", 1.0 }, { "Maria", 1.0 } },
                        new Dictionary<string, double>() { { " ", 1.0 } },
                        new Dictionary<string, double>() { { "Santiago", 1.0 }, { "Rubio", 1.0 }, { "Iglesias", 1.0 }, { "Chulo", 1.0 }, { "Arturo", 1.0 }, { "Martinez", 1.0 }, { "Gonzales", 1.0 } },
                    };
                else if (region == "Asian")
                    nameChoices = new List<Dictionary<string, double>>() {
                        new Dictionary<string, double>() { { "Sumiko", 1.0 }, { "Tamayo", 1.0 }, { "Umeko", 1.0 }, { "Xiang", 1.0 }, { "Yachi", 1.0 }, { "Yoshiko", 1.0 }, { "Kosame", 1.0 }, { "Machiko", 1.0 }, { "Midori", 1.0 }, { "Akemi", 1.0 }, { "Chiharu", 1.0 } },
                        new Dictionary<string, double>() { { " ", 1.0 } },
                        new Dictionary<string, double>() { { "Nguyen", 1.0 }, { "Lee", 1.0 }, { "Kim", 1.0 }, { "Tran", 1.0 }, { "Singh", 1.0 }, { "Wu", 1.0 }, { "Zhang", 1.0 } }
                    };
                else
                    nameChoices = new List<Dictionary<string, double>>() {
                        new Dictionary<string, double>() { { "Addison", 1.0 }, { "Arlette", 1.0 }, { "Carleigh", 1.0 }, { "Delores", 1.0 }, { "Edeline", 1.0 }, { "Henrietta", 1.0 }, { "Jeraldine", 1.0 }, { "Laurianne", 1.0 }, { "Marcelina", 1.0 } },
                        new Dictionary<string, double>() { { " ", 1.0 } },
                        new Dictionary<string, double>() { { "Schneider", 1.0 }, { "Gruber", 1.0 }, { "Pichler", 1.0 }, { "Muller", 1.0 }, { "Wagner", 1.0 }, { "Bauer", 1.0 } }
                    };
            }

            nameChoices.ForEach(segment => name += Choose(segment));

            return name;
        }

        public string getAge() {
            if (properties["Age Range"] == "Baby")
                return RandomNumber(1, 23) + " Months";
            else if (properties["Age Range"] == "Child")
                return RandomNumber(2, 12) + " Years";
            else if (properties["Age Range"] == "Teenager")
                return RandomNumber(13, 19) + " Years";
            else if (properties["Age Range"] == "Young Adult")
                return RandomNumber(20, 35) + " Years";
            else if (properties["Age Range"] == "Adult")
                return RandomNumber(36, 64) + " Years";
            else
                return RandomNumber(65, 90) + " Years";
        }

        public string getThoughts() {
            List<string> uncomposed = new List<string>();

            int total = 1;

            for (int x = 0; x < total; x++) {
                if (properties["Age Range"] == "Baby") {
                    if (properties["Mood"] == "Great")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Goo goo!  Gah gah...!", 1.0 }, { "Gah gah!  Gahhhhhh!", 1.0 }, { "Gee-gee-gah...goo!", 1.0 } }));
                    else if (properties["Mood"] == "Good")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Goo goo...", 1.0 }, { "Gah gah...", 1.0 }, { "Gah. Gah. Goo.", 1.0 } }));
                    else if (properties["Mood"] == "Moderate")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Gah?", 1.0 }, { "Goo goo...?", 1.0 }, { "...Goo.", 1.0 } }));
                    else if (properties["Mood"] == "Bad")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Wahh...  Wah!", 1.0 }, { "Gah......", 1.0 }, { "Wahhhhhh...", 1.0 } }));
                    else
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "WAHHH!!", 1.0 }, { "Wh-wh-whaaaa...!", 1.0 }, { "Wah!!!  ...Gah!", 1.0 } }));
                } else if (properties["Age Range"] == "Child") {
                    if (properties["Mood"] == "Great")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "I got an A+ on my test!", 1.0 }, { "I can't wait for recess!", 1.0 }, { "Ooh a " + Choose(new Dictionary<string, double>() { { "puppy", 1.0 }, { "kitty", 1.0 }, { "squirrel", 1.0 } }) + "!  So cute!", 1.0 } }));
                    else if (properties["Mood"] == "Good")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "I love my " + Choose(new Dictionary<string, double>() { { "mommy", 1.0 }, { "daddy", 1.0 }, { "grandma", 1.0 }, { "grandpa", 1.0 } }) + "!", 1.0 }, { "The sky is so pretty today!", 1.0 }, { "This new video game is so much fun!", 1.0 } }));
                    else if (properties["Mood"] == "Moderate")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "What did mommy pack me for lunch?", 1.0 }, { "I'm kind of bored...", 1.0 }, { "I wonder where babies come from...", 1.0 } }));
                    else if (properties["Mood"] == "Bad")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Ow!  I stubbed my toe...", 1.0 }, { "Oh no!  I lost my favorite toy...", 1.0 }, { "GAH!  A spider!  RUN!", 1.0 } }));
                    else
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Uh oh...  I didn't make it to the bathroom in time...", 1.0 }, { "Stupid bully...  That really hurt...", 1.0 }, { "I really miss " + Choose(new Dictionary<string, double>() { { "Fido", 1.0 }, { "Fluffy", 1.0 }, { "Peaches", 1.0 } }) + "...", 1.0 } }));
                } else if (properties["Age Range"] == "Teenager") {
                    if (properties["Mood"] == "Great")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "My crush likes me back!  I'm so happy!", 1.0 }, { "Yes!  We got out of school early!", 1.0 }, { "My parents just got me a new " + Choose(new Dictionary<string, double>() { { "car", 1.0 }, { "motorcycle", 1.0 }, { "computer", 1.0 } }) + "!", 1.0 } }));
                    else if (properties["Mood"] == "Good")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { Choose(new Dictionary<string, double>() { { "Rock/Slash", 1.0 }, { "Sandy Crash", 1.0 }, { "Shredder", 1.0 } }) + " just released a new album!  It's so good!", 1.0 }, { "Yes!  I got paid today!", 1.0 }, { "I have the last block of the day off!", 1.0 } }));
                    else if (properties["Mood"] == "Moderate")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Oh crap...  I forgot that test was today...  Oh, wait...  It's tomorrow...  Never mind!", 1.0 }, { "I can't remember when that appointment is...  Oh well.", 1.0 }, { "Oops...  Wrong classroom.", 1.0 } }));
                    else if (properties["Mood"] == "Bad")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "I missed the bus...  Now I have to walk home...", 1.0 }, { "Oh my gosh...  " + Choose(new Dictionary<string, double>() { { "Jimmy", 1.0 }, { "Jessica", 1.0 }, { "Anthony", 1.0 }, { "Christina", 1.0 } }) + " is so awful...", 1.0 }, { "Ugh this day is going by so slowly...", 1.0 } }));
                    else
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "I loved " + Choose(new Dictionary<string, double>() { { "him and he", 1.0 }, { "her and she", 1.0 } }) + " just broke my heart...", 1.0 }, { "Sigh...  My dad is going to kill me when he finds out I'm failing " + Choose(new Dictionary<string, double>() { { "World History", 1.0 }, { "Algebra", 1.0 }, { "Phys Ed", 1.0 } }) + "...", 1.0 }, { "I can't believe that my " + Choose(new Dictionary<string, double>() { { "mom", 1.0 }, { "dad", 1.0 }, { "grandma", 1.0 }, { "grandpa", 1.0 } }) + " just passed away...", 1.0 } }));
                } else if (properties["Age Range"] == "Young Adult") {
                    if (properties["Mood"] == "Great")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Yes!  I nailed that interview and got the job!", 1.0 }, { Choose(new Dictionary<string, double>() { { "She", 1.0 }, { "He", 1.0 } }) + " said yes!  We're getting married!", 1.0 }, { "I had such a great time at the " + Choose(new Dictionary<string, double>() { { "gym", 1.0 }, { "mall", 1.0 }, { "movies", 1.0 } }) + " today!", 1.0 } }));
                    else if (properties["Mood"] == "Good")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { Choose(new Dictionary<string, double>() { { "Ice cream", 1.0 }, { "Pizza", 1.0 }, { "A burger", 1.0 } }) + " sounds delicious right about now...", 1.0 }, { "I've got to make sure I stop by that new cafe today!", 1.0 }, { "Woohoo!  Overtime pay is the best!", 1.0 } }));
                    else if (properties["Mood"] == "Moderate")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Did I leave the stove on...?  No, I don't think so...  Did I...?", 1.0 }, { Choose(new Dictionary<string, double>() { { "Carly", 1.0 }, { "Jeff", 1.0 }, { "Sandra", 1.0 }, { "Brad", 1.0 } }) + "'s " + Choose(new Dictionary<string, double>() { { "breath", 1.0 }, { "hair", 1.0 }, { "outfit", 1.0 } }) + " is horrible today...", 1.0 }, { "I could totally become " + Choose(new Dictionary<string, double>() { { "an actor", 1.0 }, { "a rocket scientist", 1.0 }, { "a college professor", 1.0 }, { "an investor", 1.0 } }) + "...  That's just so much work though...", 1.0 } }));
                    else if (properties["Mood"] == "Bad")
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "Oof...  I could really use a drink right now...", 1.0 }, { "My " + Choose(new Dictionary<string, double>() { { "dog", 1.0 }, { "cat", 1.0 } }) + " just peed on the carpet again...", 1.0 }, { "Ugh...  My " + Choose(new Dictionary<string, double>() { { "head is", 1.0 }, { "back is", 1.0 }, { "legs are", 1.0 } }) + " killing me...  I need to lie down...", 1.0 } }));
                    else
                        uncomposed.Add(Choose(new Dictionary<string, double>() { { "My car is totaled...  No way is my insurance going to cover this...", 1.0 }, { "$0!?  Where did all of my money go?", 1.0 }, { "No!  I'm going to miss my " + Choose(new Dictionary<string, double>() { { "bus", 1.0 }, { "flight", 1.0 } }) + "!  I'll never make it in time...", 1.0 } }));
                } else if (properties["Age Range"] == "Adult")
                    uncomposed.Add("[(Adult) Placeholder] //I'll add these later...");
                else
                    uncomposed.Add("[(Elder) Placeholder] //I'll add these later...");
            }
            string thoughts = "";

            foreach (string thought in uncomposed.Distinct()) {
                thoughts += thought + " # & & & ";
            }

            return thoughts;
        }
    }
}