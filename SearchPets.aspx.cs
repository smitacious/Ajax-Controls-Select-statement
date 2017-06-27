using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShop
{
    public partial class SearchPets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // do something when button pushed
        }

        [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
        public static string[] GetHint(string prefixText, int count, string contextKey)
        {
            // Create array of pets
            string[] pets = {"Bugs Bunny", "Daffy Duck", "Porky Pig", "Elmer Fudd", "Tweety", "Sylvester", "Road Runner",
          "Wile E. Coyote", "Tazmanian Devil", "Yosemite Sam", "Pepe Le Pew", "Marvin the Martian",
          "Foghorn Leghorn", "Speedy Gonzales", "Bosko", "Buddy", "Egghead", "Sniffles", "Cecil Turtle",
          "Mac 'n Tosh", "The Three Bears", "Henery Hawk", "Beaky Buzzard", "Witch Hazel", "Gossamer",
          "Cool Cat", "Merlin the Magic Mouse", "Michigan J. Frog", "Pete Puma", "Playboy Penguin",
          "Rocky and Mugsy", "The Crusher", "Hubie and Bertie", "Claude Cat", "Marc Antony", "Pussyfoot",
          "Claude Hopper"};
            // Return matching pets
            return (from m in pets
                    where m.StartsWith(prefixText,
                        StringComparison.CurrentCultureIgnoreCase)
                    select m).Take(count).ToArray();
        }
    }
}