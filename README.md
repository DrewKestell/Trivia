# Trivia
This is a simple trivia game built on the Unity engine.  All scripts are written in C#.  Here are a few interesting points:

The game currently contains 60 questions.  Questions are stored in JSONQuestions.json in JSON format.
In order to obfuscate the questions/answers from the player, JSONQuestions.json is encrypted using a simple ROT13 letter
substitution cipher.  This file is decrypted at runtime.  So, to add content, make necessary edits to JSONQuestions.json,
apply the ROT13 cipher, and copy the encrypted file into /Assets/Resources.  Right now I'm using SimpleJSON, a 
JSON parser I found on the unity wiki page -> http://wiki.unity3d.com/index.php/SimpleJSON

Right now, in JSONQuestions.json, each question object has a correct answer, and 3 dummy answers.  At runtime, the correct 
answer is added to one of four buttons randomly, and the 3 dummy answers populate the other 3.
I had toyed with the idea of automatically generating dummy answers based on the category of the correct answer (in order
to make adding new content easier).  For example, take the question "Which game development studio created the PC game
"Ultima Online".  The answer would be the category "game studio".  So you could include a list of all game studios, and at
run time pull 3 random game studios in for your dummy answers.  The problem with this approach is that it limits the types
of questions you can ask.  For example, take the question "Which of the following characters is playable in Super Smash Bros.
for Nintendo 64?" - the answer type would be "video game character", but you couldn't ensure the dummy answers wouldn't 
contain any characters that WERE in Smash Bros, thus creating 2 correct answers.
Now, you could certainly program a more sophisticated AI to ensure the questions weren't ambiguous, but given the scale of the 
project I didn't go that route.  Thus, all four potential answers are directly written into each question.

All sounds effects were recorded on my guitar.  Wrong answers play a nasty dissonance, while correct answers will play a
chord in the key of G Major.  I recorded a handful of chords, all within the key of G Major.  Some simple logic determines
which chord will be played on each correct answer.  G Major is always played first, followed by some random chords, but it
will always resolve to G on every 7th correct answer.  I'd like to work on this feature more at some point.

High scores are serialized and deserialized, persisting between game plays.  You may have to create an empty file called
"highScores.dat" in your user library, I haven't done much testing with that.  The persistence does work though.

The game has been successfully tested on the following platforms: Android, Windows 7, Web
  -(the high score persistence doesn't work right now on Web)
  
Right now you play until you answer 3 questions incorrectly.  The game could easily be adapted for more play modes.  
For example, at some point I'd like to add head-to-head online play (this kind of game mode is included in a lot of 
mobile apps, for example).

Question content is all video game themed, but questions of any type can easily be added.

This is a very preliminary build of the game.  I'll probably revisit this at some point to continue working on it.

KNOWN ISSUES:
The high-scores data serialization/deserialization is causing the Unity plugin to crash on Web builds.  I need to add some platform specific scripting to customize the high-scores feature on Web build.  Two ideas: 1) disable high-scores on Web altogether. 2) save and load highscores from a database somewhere, perhaps a simple text file on my web server.
