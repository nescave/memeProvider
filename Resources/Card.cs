namespace memeProvider.Resources
{
    public class Card
    {
        public string name;
        public string url;
        public string description;
        public int id;

        public Card(string n, string u, string d, int i){
            name = n;
            url = u;
            description = d;
            id = i;
        }
    }
}