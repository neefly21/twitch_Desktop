using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace Twitch_Desktop
{
    public partial class twitchDesktop : Form
    {
        WebClient client;
        bool streamsParsed = false;
        bool updateList;

        static List<String> gameName = new List<String>();
        static List<String> displayName = new List<String>();
        static List<String> streamerLink = new List<String>();
        static List<int> indexOfActive = new List<int>();

        public twitchDesktop()
        {
            InitializeComponent();
            client = new WebClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(LoadAPI));
            thread.Start();
            //Used to fill the list with the active streams.
            while (streamsParsed == false)
            {
                if (updateList == true)
                {
                    fill();
                    streamsParsed = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }   

        private void streamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Will load the pages api and json
        void LoadAPI()
        {
            //Temp variables to sort the items into their corresponding list.
            String gameNames = "";
            String streamerName = "";
            String streamLink = "";

            //Variables to help iterate through the json
            int offset = 0;
            int currGame = 0;

            
            //Itterates through the game titles
            while (offset < 50)
            {
                var gameUrl = "https://api.twitch.tv/kraken/games/top?limit=10&offset=" + offset;
                String jsonGame = client.DownloadString(gameUrl);
                var jsonParsedGame = JObject.Parse(jsonGame);
                var dataGame = jsonParsedGame["top"];

                //Assigns the game names to the string
                for (int i = 0; i < 10; i++)
                {
                    gameNames = gameNames + " " + dataGame[i]["game"]["name"] + " | ";
                }
                offset = offset + 10;
            }


            //Splits the games into their own name, and assigns to list after
            String[] games = gameNames.Split('|');


            //Formats Names to fit the websearch
            for (int i = 0; i < games.Length; i++)
            {

                games[i] = games[i].Trim();

                while (games[i].Contains(' '))
                {
                    games[i] = games[i].Replace(' ', '+');
                }

                Console.WriteLine(games[i]);
            }

            //Gets streamer name
            while (currGame < 50)
            {
                var streamerUrl = "https://api.twitch.tv/kraken/streams?game=" + games[currGame];
                String jsonStreamer = client.DownloadString(streamerUrl);
                var jsonParsedStreamer = JObject.Parse(jsonStreamer);
                var dataStreamer = jsonParsedStreamer["streams"];

                for (int i = 0; i < 30; i++)
                {
                    try
                    {
                        streamerName = streamerName + " " + dataStreamer[i]["channel"]["display_name"] + " | ";
                        streamLink = streamLink + " " + dataStreamer[i]["channel"]["_links"]["self"] + " | ";
                    }
                    catch (Exception e)
                    {
                        
                    }
                }
                currGame++;
            }

            //Seperates the name from string, splits, then adds it to array
            String[] streamers = streamerName.Split('|');

            //Streamer Name
            for (int i = 0; i < streamers.Length; i++)
            {
                if (streamers[i].Equals(" "))
                {}
                else
                {
                    streamers[i] = streamers[i].Trim();
                    displayName.Add(streamers[i]);
                }
            }

            Console.WriteLine("Streamer Names Parsed");

            //Streamer Link
            String[] link = streamLink.Split('|');
            for (int i = 0; i < link.Length; i++)
            {
                if (link[i].Equals(" "))
                {
                    
                }
                else
                {
                    link[i] = link[i].Trim();
                    streamerLink.Add(link[i]);
                }
           }

            //Marks end of parsing and tells the loop at begging to fill list.
            Console.WriteLine("Streamer Links Parsed");
            updateList = true;

            //For debugging
            Console.WriteLine("Number of streams:" + displayName.Count);

        }

        void fill()
        {
            for (int i = 0; i < displayName.Count; i++)
            {
                activeStreams.Items.Add(displayName[i]);
            }
        }

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Favorite button actions
        private void favButton_Click(object sender, EventArgs e)
        {
            int index = activeStreams.SelectedIndex;

            try
            {
                favorites.Items.Add(displayName[index]);
                indexOfActive.Add(index);
            }
            catch (Exception ee)
            {
                MessageBox.Show("No user selected!");
            }

            activeStreams.SetSelected(activeStreams.SelectedIndex, false);

        }

        //Remove Favorite button actions
        private void removeFavorite_Click(object sender, EventArgs e)
        {
            int index = favorites.SelectedIndex;

            try
            {
                favorites.Items.RemoveAt(index);
                indexOfActive.Remove(index);
            }
            catch (Exception eer)
            {
                MessageBox.Show("No user selected or no favorited users!");
            }

        }

        //View Stream button actions
        private void streamLink_Click(object sender, EventArgs e)
        {
            int indexActive = activeStreams.SelectedIndex;
            int indexFavorite = favorites.SelectedIndex;

            MessageBox.Show("Stream launched in default browser.");

            Console.WriteLine("Active Streamer Index: " + indexActive);
            Console.WriteLine("Favorite Streamer Index: " + indexFavorite);

            //Check weather the stream is in favorites or not..
            try
            {
                if (indexActive >= 0)
                {
                    System.Diagnostics.Process.Start("http://twitch.tv/" + streamerLink[indexActive].Substring(37));
                }
                else if (indexFavorite >= 0 && indexActive == -1)
                {
                    System.Diagnostics.Process.Start("http://twitch.tv/" + streamerLink[indexOfActive[indexFavorite]].Substring(37));
                }

                activeStreams.SetSelected(activeStreams.SelectedIndex, false);
                favorites.SetSelected(favorites.SelectedIndex, false);
            }
            catch (Exception exMouse)
            {

            }
        }

        private void activeStreams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void favorites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
