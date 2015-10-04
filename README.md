# Eve-X-Counter
This tool is supposed to read the lines of fleet chat (in realtime (maybe (probably))) and count the number of X's in fleet.
You just need to compile it via Visual Studio and run it.

I think the only depend is .net framework 4.0 but who knows should be easy peasy at least that's what I was aiming for.

If you have questions or w.e. in game mail Kenshin Woo, I'll probably host compiled binarys "soon"tm.

PS after talking with people, we decided that there were very few cases where a word started with the letter x so instead of looking for "x" or "x " we just look at the first letter of the chat and if it's an X we count it. Later I would like to add some way to track other letters as well but untill I have an idea of how that will look on the GUI we're just going to deal with X's for now.
