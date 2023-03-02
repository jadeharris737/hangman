using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Abbreviated from system input/output, this namespace contains classes and structures (etc.) 
to perform reading and write operations on difference sources. In this case enables it the external text file to be read into the program*/
using System.IO;
/*This provides a class for controlling and accessing threads among other abilities, used in the program to pause the interface and create
a 'thinking' loading screen with Thread.Sleep()*/
using System.Threading;

namespace _Jade_Harris_Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Required method for designer support
            InitializeComponent();
            /*When the program is launched, hide all of the elements (rather than setting them all to visible
             - for program readabiltiy and logic*/
            MakeInvisible();
        }

        //Letter which the player wishes to test against the word they are guessing --> global as necessary for numerous functions
        Button guessedLetter;
        //Current letter --> global as necessary for numerous functions
        char guessedLetterChar;
        //Word which the player will guess --> global as necessary for numerous functions
        string targetWord = "";
        //String represents the target word which will display --> global as necessary for numerous functions
        string placeholders = "";
        //Integer which contains number of guessesLeft --> global as necessary for nuemrous functions
        int guessesLeft;

        private void MakeInvisible() //Make all of the gameplay interface elements invisible
        {
            /*Make all of the gameplay objects on the screen invisible to create 
            a cut-screen or transition or title screen effect that is clearly
            different from the gameplay screen*/
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            d.Visible = false;
            e.Visible = false;
            f.Visible = false;
            g.Visible = false;
            h.Visible = false;
            i.Visible = false;
            j.Visible = false;
            k.Visible = false;
            l.Visible = false;
            m.Visible = false;
            n.Visible = false;
            o.Visible = false;
            p.Visible = false;
            q.Visible = false;
            r.Visible = false;
            s.Visible = false;
            t.Visible = false;
            u.Visible = false;
            v.Visible = false;
            w.Visible = false;
            x.Visible = false;
            y.Visible = false;
            z.Visible = false;
            submitButton.Visible = false;
            deleteButton.Visible = false;
            letterGuessed.Visible = false;
            resetButton.Visible = false;
            placeholderDisplay.Visible = false;
            keyboardBackground.Visible = false;
            guessedLetterBackground.Visible = false;
            staticImage.Visible = false;
            icon.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e) //Start the game when start is clicked
        {
            //Hide start button and title screen image once the player has chosen to begin
            startButton.Visible = false;
            titleScreen.Visible = false;
            //Call start function
            Start();
        }

        private void Start() //This is the central module to start/setup the gameplay
        {
            //Create a seamless transition effect
            LoadingScreen();
            //Set or reset the number of guessesLeft to 11
            guessesLeft = 11; 
            //Set the image of the static hangman to Static0 - a blank box - so that it is invisible
            staticImage.Image = Properties.Resources.Static0;
            //Set the image of the icon to Icon0 - the first icon
            icon.Image = Properties.Resources.Icon1;
            //Prevent the animated .gif from beginning
            animatedImage.Enabled = false;
            //Make the submit button disabled until the player clicks a letter
            submitButton.Enabled = false;
            //Make the delete button disabled until the player clicks a letter
            deleteButton.Enabled = false;
            //Reset letter chosen textbox
            letterGuessed.Text = "";
            //Access external sequential file to randomly select and set the target word
            SelectTargetWord();
            //Activate all of the keyboard buttons so the player can begin guessing
            ActivateButtons();
        }

        public void LoadingScreen() //Display the 'thinking loading screen'
        {
            //Make all of the objects invisible to create a loading screen 'loading screen' effect
            MakeInvisible();
            //Make the textbox which will contain the '...' visible
            loadingScreen.Visible = true;
            //To add the 3 dots which indicate a loading screen, this for loop adds a dot then waits to create an animated 'thinking' effect
            for (int i = 0; i < 4; i++)
            {
                /* issue with using Thread.Sleep is that it pauses the thread which displays the textbox before updating it. 
                As a solution, Application.DoEvents() allows the message loop to display the picture box before the thread is paused.*/
                Application.DoEvents();
                //Display a dot or if one already exists, add the next dot
                loadingScreen.Text += ". ";
                //Wait 0.5 seconds before displaying the next '.' for the 'thinking' effect (500 miliseconds)
                Thread.Sleep(500);
            }
            //Reset the text box to empty so that the next time the loading screen is displayed, the dots start from 0
            loadingScreen.Text = "";
            //Wait another 0.5 seconds to add a longer delay
            Thread.Sleep(500);
            //Make the textbox invisible so it does not interupt the player's next guess
            loadingScreen.Visible = false;
            //Make all of the gameplay elements visible again like the on-screen keyboard so that the player can make a guess
            MakeVisible();
        }

        private void MakeVisible() //Show all of the gameplay interface elements 
        {
            /*Return all of the objects on-screen to visible following a cut-scene
            or loading screen effect to allow the player to make another guess*/
            a.Visible = true;
            b.Visible = true;
            c.Visible = true;
            d.Visible = true;
            e.Visible = true;
            f.Visible = true;
            g.Visible = true;
            h.Visible = true;
            i.Visible = true;
            j.Visible = true;
            k.Visible = true;
            l.Visible = true;
            m.Visible = true;
            n.Visible = true;
            o.Visible = true;
            p.Visible = true;
            q.Visible = true;
            r.Visible = true;
            s.Visible = true;
            t.Visible = true;
            u.Visible = true;
            v.Visible = true;
            w.Visible = true;
            x.Visible = true;
            y.Visible = true;
            z.Visible = true;
            submitButton.Visible = true;
            deleteButton.Visible = true;
            letterGuessed.Visible = true;
            resetButton.Visible = true;
            keyboardBackground.Visible = true;
            placeholderDisplay.Visible = true;
            guessedLetterBackground.Visible = true;
            staticImage.Visible = true;
            icon.Visible = true;
        }

        private void SelectTargetWord() //Access an external sequential file 
        {
            //Path to file which all possible words to be guessed are placed
            string path = @"words.txt";
            //A list which will soon be populated with each word from the file to form a pool where one will be randomly selected and become the word the player must guess
            List<string> wordPool = new List<string>();
            //Access the external sequential file then create list with all of the lines in the file
            List<string> lines = File.ReadAllLines(path).ToList();
            //Initalise number of words in pool outside of for each loop so it can be outside of the local loop
            int numberOfWordsInPool = 0;
            //For each line in the file
            foreach (string line in lines)
            {
                //An array of strings is formed by splitting each line of the file at each comma as the .Split() function creates an array (and a comma splits each word in the file)
                string[] wordsInFile = line.Split(',');
                //Set the number of possible words for the word pool to the number of words in the file
                numberOfWordsInPool = wordsInFile.Length;
                //For each word in the file (- 1 from that length as if there are 5 words, because array indexs start at 0, there will only be 4 possible indexs not 5),
                for (int i = 0; i < numberOfWordsInPool - 1; i++)
                {
                    //Add each word from the file into the word pool list
                    wordPool.Add(wordsInFile[i]);
                }
            }

            //Define the variable 'randomIndex' as type class Random to generate a random number which will serve as an index to choose a randomized word from WordPool
            Random randomIndex = new Random();
            //Word that the player must guess is randomly selected 
            targetWord = wordPool[randomIndex.Next(0, numberOfWordsInPool - 1)];

            //Reset displayedWord - necessary for the function if it is being run after the first time to prevent the '_' combining
            placeholders = "";
            //For each letter in the word (calculated by using the .Count() function to return the number of characters in a string(elements in a sequence))
            for (int i = 0; i < targetWord.Count(); i++)
            {
                //The word which the player must guess becomes hidden by underscores
                placeholders += "_";
            }

            //Display the target word hidden with underscores and add a space in between for visual aesthetics
            AddSpacesForDisplay();
        }

        private void AddSpacesForDisplay() //Add a space between each underscore or character before displaying the hidden target word for visual aesthetics, usability and readability
        {
            //Convert each '_' or revealed letter, also known as a character in the string, to an array of characters (basically split the string)
            char[] shownText = placeholders.ToCharArray();
            //Empty the display string so the += doesn't keep adding to a prexisting string
            string display = "";
            //For each _ in the target word (calcuated by counting the characters in the split string) 
            for (int i = 0; i < placeholders.Count(); i++)
            {
                //Add a space between each character and combine the string again
                display += shownText[i] + " ";
            }
            //Set text of the secret word to the underscores with spaces in between
            placeholderDisplay.Text = display;
        }

        private void ActivateButtons() //Activate/Re-activate all of the buttons
        {
            //Enable all letter buttons on the on-screen keyboard
            a.Enabled = true;
            b.Enabled = true;
            c.Enabled = true;
            d.Enabled = true;
            e.Enabled = true;
            f.Enabled = true;
            g.Enabled = true;
            h.Enabled = true;
            i.Enabled = true;
            j.Enabled = true;
            k.Enabled = true;
            l.Enabled = true;
            m.Enabled = true;
            n.Enabled = true;
            o.Enabled = true;
            p.Enabled = true;
            q.Enabled = true;
            r.Enabled = true;
            s.Enabled = true;
            t.Enabled = true;
            u.Enabled = true;
            v.Enabled = true;
            w.Enabled = true;
            x.Enabled = true;
            y.Enabled = true;
            z.Enabled = true;
        }

        private void Letter_Click(object sender, EventArgs e) //When the player chooses any letter
        {
            //Initialise 'letter' as type class 'button' object which was clicked (passed through the function as sender)
            Button letter = sender as Button;

            //Display the player's current chosen letter as the letter they have chosen with the keyboard
            letterGuessed.Text = letter.Text;
            //Set the button of the player's guess to the sender button (for use when submit is clicked)
            guessedLetter = letter;
            //Stores the guessed letter as a character
            guessedLetterChar = Convert.ToChar(letter.Text.ToLower());
            //Enable submit button now a guess has been inserted
            submitButton.Enabled = true;
            //Enable submit button now a guess has been inserted
            deleteButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e) //When delete button is clicked
        {
            //Remove any letter chosen (current guess is displayed in the letterGuessed textbox)
            letterGuessed.Text = "";
            //Make submit and delete button disabled until letter is clicked again to prevent excessive use that may result in software malfunction
            submitButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e) //Player submits a guess
        {
            //Prevents error if player submits when no letter is selected by checking if the text is empty
            if (letterGuessed.Text != "")
            {
                //Once letter has been guessed, clears textbox to enable next guess
                letterGuessed.Text = "";
                //Using the button variable of the guessed letter (declared when any letter is clicked), access its properties and disable the letter (to prevent same letter being chosen again)
                guessedLetter.Enabled = false;
                //Call the submit guess function - this mainly makes the code more readable
                SubmitGuess();
            }
        }


        private void SubmitGuess() //Submit the contents of letterGuessed text as the guessed letter
        {
            //Convert the target word to an array of its characters
            char[] lettersInTargetWord = targetWord.ToCharArray();
            //Create a new list of integers which will record all the positions where the letter which the player has guessed matches with the target word
            List<int> positionsOfGuessedLetter = new List<int>();
            //Create an integer which represents the index for the letter the for loop is currently on
            int letterPosition = 0;
            //Display the processing '...' to increase suspense and create a more engaging interface
            LoadingScreen();

            //For each letter in the target word
            foreach (char letter in lettersInTargetWord)
            {
                //If guessedLetterChar (the guessed letter as a character  which is set when a letter is clicked) is the same as the letter in the target word
                if (guessedLetterChar == letter)
                {
                    //Add the position of the current letter in the for each loop to the positions (add a position where the guessed letter matches the target word)
                    positionsOfGuessedLetter.Add(letterPosition);
                    //Small confirmation message that they got the correct letter
                    letterGuessed.Text = "Correct!";
                }
                //Because the for each loop is incrementing to the next letter in the target word, add 1 to the position
                letterPosition += 1;
            }

            //If there are no positions where the guessed letter matches a letter in the target word (.Count() of the list == 0 because no positions recorded) (player made a bad guess)
            if (positionsOfGuessedLetter.Count() == 0)
            {
                FailedGuess();
            }

            //For each position where the guessed letter is in the target word
            foreach (int position in positionsOfGuessedLetter)
            {
                //Modify the displayed text to remove the underscore at the position and then insert the guessed letter character instead
                placeholders = placeholders.Remove(position, 1).Insert(position, $"{guessedLetterChar}");
            }
            //Clear/reset the list of positions of the current guessed letter in preparation for the next guessed letter
            positionsOfGuessedLetter.Clear();

            //Display the updated hidden word with the now revealed letters and add a space in between for visual aesthetics
            AddSpacesForDisplay();

            //Check if the player has won
            CheckForWin();

            //Make submit and delete button disabled until letter is clicked again to prevent excessive use that may result in software malfunction
            submitButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        public void FailedGuess() //Display condolence message
        {
            //Subtract one guess
            guessesLeft -= 1;
            //Play the appropriate .gif animation to the guessesLeft left
            PlayAnimation();
            //Check if the number of guesses is <1 (0)
            CheckForLoss();
        }

        public void PlayAnimation() //Display the animated 'drawing' of the hangman body part
        {
            //Make the next button visible and so it can be used
            nextButton.Visible = true;
            //Make all other objects invisible to create a cutscreen effect
            MakeInvisible();
            //Show the image box for the .gif's to display in
            animatedImage.Visible = true;
            //Enable the image box so that the .gif's can play
            animatedImage.Enabled = true;
            //Depending on the number of guessesLeft the player has left, display a different .gif image
            switch (guessesLeft)
            {
                case 10:
                    //If the player has 10 guesses left, set the image box to the .gif with the first beam being drawn
                    animatedImage.Image = Properties.Resources.Frame1;
                    break;
                case 9:
                    //If the player has 9 guesses left, set the image box to the .gif with the next beam being drawn
                    animatedImage.Image = Properties.Resources.Frame21;
                    break;
                case 8:
                    //If the player has 8 guesses left, set the image box to the .gif with the bracket for the frame beam being drawn
                    animatedImage.Image = Properties.Resources.Frame31;
                    break;
                case 7:
                    //If the player has 7 guesses left, set the image box to the .gif with the rope being drawn
                    animatedImage.Image = Properties.Resources.Frame4;
                    break;
                case 6:
                    //If the player has 6 guesses left, set the image box to the .gif with the base being drawn
                    animatedImage.Image = Properties.Resources.Frame5;
                    break;
                case 5:
                    //If the player has 5 guesses left, set the image box to the .gif with the head being drawn
                    animatedImage.Image = Properties.Resources.Frame6;
                    break;
                case 4:
                    //If the player has 4 guesses left, set the image box to the .gif with the body being drawn
                    animatedImage.Image = Properties.Resources.frame71;
                    break;
                case 3:
                    //If the player has 3 guesses left, set the image box to the .gif with the first arm being drawn
                    animatedImage.Image = Properties.Resources.Frame81;
                    break;
                case 2:
                    //If the player has 2 guesses left, set the image box to the .gif with the second arm being drawn
                    animatedImage.Image = Properties.Resources.Frame9;
                    break;
                case 1:
                    //If the player has 1 guess left, set the image box to the .gif with the first leg being drawn
                    animatedImage.Image = Properties.Resources.Frame10;
                    break;
                case 0:
                    //If the player has no guesses left, set the image box to the .gif with the last leg being drawn and a stylistic 'dead' emotion
                    animatedImage.Image = Properties.Resources.LoseFull;
                    break;
            }
        }

        private void Next_Click(object sender, EventArgs e) //Display the static hangman image and return to the gameplay interface
        {
            //If the player has selected next, make the button invisible so they can't click next again
            nextButton.Visible = false;
            //Show all of the gameplay elements again
            MakeVisible();
            //Hide the image box for the animation
            animatedImage.Visible = false;
            //Disable the image box for the animation so that it stops looping
            animatedImage.Enabled = false;
            //Show the image box for the static image of the hangman
            staticImage.Visible = true;
            //Depending on the number of guesses left, a different .gif image will play and thus a different static hangman will display on the main gameplay interface
            switch (guessesLeft)
            {
                case 10:
                    //If the player has 10 guesses left, set the image box to the static image with the beam as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static1;
                    break;
                case 9:
                    //If the player has 9 guesses left, set the image box to the static image with the next beam as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static2;
                    break;
                case 8:
                    //If the player has 8 guesses left, set the image box to the static image with the third beam as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static3;
                    break;
                case 7:
                    //If the player has 7 guesses left, set the image box to the static image with the rope as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static4;
                    break;
                case 6:
                    //If the player has 6 guesses left, set the image box to the static image with the base as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static5;
                    break;
                case 5:
                    //If the player has 5 guesses left, set the image box to the static image with the head as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static6;
                    break;
                case 4:
                    //If the player has 4 guesses left, set the image box to the static image with the body as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static7;
                    break;
                case 3:
                    //If the player has 3 guesses left, set the image box to the static image with the first arm as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static8;
                    break;
                case 2:
                    //If the player has 2 guesses left, set the image box to the static image with the next arm as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static9;
                    break;
                case 1:
                    //If the player has 1 guess left, set the image box to the static image with the first leg as drawn in the .gif
                    staticImage.Image = Properties.Resources.Static10;
                    break;
                case 0:
                    //If the player has no guesses left, set the image box to the static image with the last leg and stylistic 'dead' emotion as drawn in the .gif
                    staticImage.Image = Properties.Resources.StaticLose;
                    /*Reveal to the player the target word that they failed to guess --> THIS IS DONE separately to the CheckForLoss function as that module
                    is executed straight after the letter has been submitted, whereas this waits for the next button to be clicked (basically necessary for program timing*/
                    correctWord.Visible = true;
                    //Set the textbox which conveys this to say that THE WORD WAS <WORD>
                    correctWord.Text = "THE WORD WAS " + targetWord.ToUpper();
                    //Set the icon image to a different image as the purple textbox means that the icon image needed to incorporate the purple textbox (aesthetics)
                    icon.Image = Properties.Resources.icon21;
                    break;
            }
        }

        public void CheckForLoss() //Check if the player has lost (no guesses left) and give condolence message
        {
            //If player has no guessesLeft left (<1) then game is over
            if (guessesLeft < 1)
            {
                //Display loss condolence message
                letterGuessed.Text = "YOU LOSE";
                //As game is over, deactivate all buttons until player begins a new round by clicking play or reset
                DeactivateButtons();
            }
        }

        public void CheckForWin() //Check if the player has won and display congratulory message
        {
            //If the display string does not contain an '_' (therefore the player has guessed all of the letters in the target word because they have all switched with the underscores)
            if (placeholders.Contains('_') == false)
            {
                //Then display congratulatory message
                letterGuessed.Text = "YOU WIN!";
                //Deactivate all buttons until reset or play again is selected to prevent errors rising from use
                DeactivateButtons();
            }
        }

        private void DeactivateButtons() //Deactivate the on-screen keyboard
        {
            //Disable all buttons on the on-screen keyboard
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
            e.Enabled = false;
            f.Enabled = false;
            g.Enabled = false;
            h.Enabled = false;
            i.Enabled = false;
            j.Enabled = false;
            k.Enabled = false;
            l.Enabled = false;
            m.Enabled = false;
            n.Enabled = false;
            o.Enabled = false;
            p.Enabled = false;
            q.Enabled = false;
            r.Enabled = false;
            s.Enabled = false;
            t.Enabled = false;
            u.Enabled = false;
            v.Enabled = false;
            w.Enabled = false;
            x.Enabled = false;
            y.Enabled = false;
            z.Enabled = false;
        }
        private void FormClose(object sender, FormClosingEventArgs e) //Enhance program usability by preventing accidental closure when player clicks close
        {
            /*Display windows message box with title "Close Confirmation" confirming their attempt to exit with buttons Yes and No.
              If the result of this dialogue box is no, then enable the user to return to hangman by cancelling the 'FormClosingEventArgs' event*/
            if (MessageBox.Show("Are you sure you want to exit?", "Close Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //Cancel the 'FormClosingEventArgs' 
                e.Cancel = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) //Reset game (same functionality as start)
        {
            if (MessageBox.Show("Are you sure you want to reset?", "Restart Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Make the purple textbox which states the correct word (if the player has lost) invisible again
                correctWord.Visible = false;
                //Call start function and restart the game - this mainly gives the possibility for an add-on to prevent the repeated selection of words
                Start();
            }
        }
    }
}