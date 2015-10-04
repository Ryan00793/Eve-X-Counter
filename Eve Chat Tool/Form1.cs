using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Eve_Chat_Tool
{
    public partial class Form1 : Form
    {
        #region vars
        
        int count = 0;
        
        FileStream stream;
        long lastStreamPos = 0;

        string eveChatLogDir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() + "\\EVE\\logs\\Chatlogs";
        string fleetFileName;
        string character;

        #endregion

        #region init

        public Form1()
        {
            InitializeComponent();
            start();
        }

        #endregion

        #region methods

        #region basic

        void start()
        {
            //this gets the name of the newest fleet
            fleetFileName = getNewestFleetFile();
            //this is the magic part where i parse the
            //lines of chat.
            fancy(fleetFileName);
            //start a 1s timer to re-check the file every
            //1s so that new x's are counted after init.
            tmrTick.Enabled = true;
            countReset();
        }

        void update()
        {
            //writes to the gui so that you can
            //see the number of things
            lblNumXs.Text = count.ToString();
            lblChar.Text = character;
        }

        void fullReset()
        {
            //basicly reset all vars then start over
            tmrTick.Enabled = false;
            count = 0;
            fleetFileName = "";
            lastStreamPos = 0;
            character = "";
            update();
            start();
        }

        void countReset()
        {
            //this method probably not needed
            //but this is here because why not
            count = 0;

            //push to gui
            update();
        }

        void incrementCount()
        {
            //Adds 1 to the int count
            count++;
            //pushes to the gui
            update();
        }

        #endregion

        #region file reads

        ArrayList readFile(string path)
        {
            ArrayList newLines = new ArrayList();
            //opens the file and has some flags so that
            //windows doesn't have a cow that some other
            //process is using it.
            stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //basicly checks if file is null
            if (stream.CanSeek)
            {
                //resumes at the last part that we looked at
                //so this makes it so that we're not re-reading
                //the whole file each time.
                stream.Seek(lastStreamPos, SeekOrigin.Begin);
                StreamReader reader = new StreamReader(stream, Encoding.Unicode, false);
                String line;
                //reading it via lines
                while ((line = reader.ReadLine()) != null)
                {
                    //adding new lines to the array because
                    //we're not really parseing the data
                    //here.
                    if (!newLines.Contains(line))
                    {
                        newLines.Add(line);
                    }
                }
                //setting our last position so that
                //we don't have to re-read the whole
                //file and idealy saving some cpu.
                lastStreamPos = stream.Position;
            }

            return newLines;
        }

        string getNewestFleetFile()
        {
            //this gets an array of full paths to all files
            //in the chatlog directory
            string[] files = Directory.GetFiles(eveChatLogDir);
            ArrayList fleetfiles = new ArrayList();

            //these are for limiting how many files it looks
            //for. It doesn't look at the hours but I subtract
            //2 hours here incase you joined the fleet before
            //downtime this number can be tweeked and probably
            //will be later but this was just a magic number
            //i pulled out of no where.
            string testime = DateTime.UtcNow.ToString("yyyyMMdd");
            string testTime1 = DateTime.UtcNow.AddHours(-2).ToString("yyyyMMdd");

            //loop to look check all files in dir
            foreach (string fileName in files)
            {
                //limit to only files with "Fleet" in the name
                if (fileName.Contains("Fleet"))
                {
                    //checks to limit the number of returned files (cpu time saving only)
                    if (fileName.Contains(testime) || fileName.Contains(testTime1))
                    {
                        if (!fleetfiles.Contains(fileName))
                        {
                            //these are only here for a smaller list so its less time to sort
                            fleetfiles.Add(fileName);
                        }
                    }
                }
            }

            //in practice this isn't actually needed but msdn says to not rely on
            //the returned order so .sort is here to hopfuly sort by name.
            fleetfiles.Sort();

            //returns the very last one in the array so that we get the newest file.
            return fleetfiles[fleetfiles.Count - 1].ToString();
        }

        #endregion

        #region timer

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            //just reading the file every tick (1s)
            fancy(fleetFileName);
        }

        #endregion

        #region fancy things that actually do things

        void fancy(string file)
        {
            //gets the newLines since last read
            ArrayList lines = readFile(file);

            //checks to see if there are lines in the
            //new lines so that we can not waste cpu
            //time if there are no new lines.
            if (lines.Count > 0)
            {
                //loop for all of the new lines
                foreach (string line in lines)
                {
                    //this is just so that you know which fleet
                    //the program is listening too.
                    if (line.Contains("  Listener:        "))
                    {
                        //gets the character name out of the the line
                        character = line.Substring(19, line.Length - 19);
                        //pushes to the gui
                        update();
                    }

                    //this is just a sanity check
                    if (line.Length > 25)
                    {
                        //this is a fancy way that I'm checking to
                        //make sure the line is valid since these
                        //are the brackets on the beging and end of
                        //the timestamp so that we can ignore some
                        //of the other lines that ccp puts at the
                        //begining of the file.
                        if (line[1].Equals('[') && line[23].Equals(']') || line[0].Equals('[') && line[22].Equals(']'))
                        {
                            //this gets the actual chat with out the
                            //username or any of that since we only
                            //care about the x. I did it
                            string chat = line.Substring(line.IndexOf('>') + 1, line.Length - line.IndexOf('>') - 1);

                            //so I don't have to check for two
                            //different chars
                            chat = chat.ToLower();

                            //we look for things that start with X
                            //since there are so few things that
                            //start with x, that are common use
                            //in eve that the one or two random
                            //other x's shouldn't matter all that
                            //much.
                            if (chat[1].Equals('x'))
                            {
                                //increments the count else this whole
                                //thing would be worthless
                                incrementCount();
                            }

                            //this is just a common thing that we
                            //do in eve so that we know where the
                            //new x's are as such we reset the count
                            if (chat.Contains("----"))
                            {
                                //reset count and update gui
                                countReset();
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #endregion

        #region buttons

        private void btnFullReset_Click(object sender, EventArgs e)
        {
            fullReset();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            countReset();
        }

        #endregion
    }
}
