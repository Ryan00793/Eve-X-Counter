# Eve-X-Counter

![](http://i.imgur.com/t3AIlti.png)   

This tool is supposed to read the lines of fleet chat (in realtime (maybe (probably))) and count the number of X's in fleet.
You just need to compile it via Visual Studio and run it.

I think the only depend is .net framework 4.0 (AKA WINDOWS and no i didn't make it work with mono if someone wants to add a path for that, it would be nice) but who knows should be easy peasy at least that's what I was aiming for.

If you have questions or w.e. in game mail Kenshin Woo, I'll probably host compiled binarys "soon"tm.

PS after talking with people, we decided that there were very few cases where a word started with the letter x so instead of looking for "x" or "x " we just look at the first letter of the chat and if it's an X we count it. Later I would like to add some way to track other letters as well but untill I have an idea of how that will look on the GUI we're just going to deal with X's for now.

# Usage

Step 1) you extract the program to somewhere

Step 2) Join or make a fleet in eve.

Step 3) Run it.

Preferably you're already in fleet because it will get the latest one that you joined aka if you make a fleet after you started, it will not be listening to that fleet. Instead of restarting the program you can just hit new fleet and it will find the next latest one that you joined. This is intentional so that we don't have issues with alts in different fleets or w.e. (this is also why i say which character it's listening to).

It will listen to the fleet for anything that starts with x and increment the counter.

To reset the counter from ingame you will need to simply put in 4 "-"s like this "----" or more like this "-------------------------------------------------------------------"

# Download

A friend pointed out the release part of github so I'ma try that out instead.

Binary (compiled release for the lazy people) this is the current Eve_X_Counter.zip md5sum 306ec2f66e2d94c1a747d3ca9ce5f812 (10/4/2015) (ver a.1.0)
https://github.com/Ryan00793/Eve-X-Counter/releases

poke around in there shouldn't be too hard to find.
