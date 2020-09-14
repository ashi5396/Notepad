// <copyright file="Form1.cs" company="Ashi Chamarasinghe">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

/*
  Kadupitige Ashi Chamarasinghe
  011611751
 */

namespace Homework3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// This class is where the GUI is desgined. It has different functions that are related to different features in
    /// the GUI.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// Constructor of the GUI form.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// This function reads information from the text reader object and
        /// loads the proper information to the text box in the GUI.
        /// </summary>
        /// <param name="read">
        /// Reads the informations from the text reader object.
        /// </param>
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword. Justification<Doesn't need to have the word new>
        private void Load(TextReader read)
        {
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword. Justification<Doesn't need to have the word new>
            this.textBox1.Text = read.ReadToEnd();
        }

        /// <summary>
        /// This function opens the first 50 fibonacci numbers and shows on the notepad.
        /// </summary>
        /// <param name="sender">
        /// sender contains a reference to the control/object that raised the event.
        /// </param>
        /// <param name="e">
        ///  e containts the event data.
        /// </param>
        private void loadFibonacciNumbersfirst50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FibonacciTextReader fib = new FibonacciTextReader(50);
            this.Load(fib);
        }

        /// <summary>
        /// This function loads a text from the file to the notepad.
        /// </summary>
        /// <param name="sender">
        /// Sender contains a reference to the control/object that raised the event.
        /// </param>
        /// <param name="e">
        /// e contains the event data.
        /// </param>
#pragma warning disable SA1300 // Element should begin with upper-case letter. Justification <This methods are written by form when a button is clicked.Therefore, can not change names>
        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore SA1300 // Element should begin with upper-case letter Justification <This methods are written by form when a button is clicked.Therefore, can not change names>
        {
            // Pop up the open file dialog to show different file options to open
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the file
                StreamReader openFile = new StreamReader(this.openFileDialog1.FileName);

                // Send file information to the notepad to open
                this.Load(openFile);
            }
        }

        /// <summary>
        /// This function opens the first 100 fibonacci numbers and shows on the notepad.
        /// </summary>
        /// <param name="sender">
        /// sender contains a reference to the control/object that raised the event.
        /// </param>
        /// <param name="e">
        ///  e containts the event data.
        /// </param>
        private void loadFibonacciNumbersfirst100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FibonacciTextReader fib = new FibonacciTextReader(100);
            this.Load(fib);
        }

        /// <summary>
        /// This function helps to save information to a text file.
        /// </summary>
        /// <param name="sender">
        /// sender contains a reference to the control/object that raised the event.
        /// </param>
        /// <param name="e">
        /// e containts the event data.
        /// </param>
        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pop up the save dialog form
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Saves data in a text file
                File.WriteAllText(this.saveFileDialog1.FileName, this.textBox1.Text);
            }
        }

        /// <summary>
        /// If the user chose exit option, it would simply close the form.
        /// </summary>
        /// <param name="sender">
        /// sender contains a reference to the control/object that raised the event.
        /// </param>
        /// <param name="e">
        ///  e containts the event data.
        /// </param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// If the user clicks help from the menu, this function will show information that will help
        /// the user to understand what this program does and it's features.
        /// </summary>
        /// <param name="sender">
        /// sender contains a reference to the control/object that raised the event.
        /// </param>
        /// <param name="e">
        ///  e containts the event data.
        /// </param>
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show information about the program.
            MessageBox.Show(
                "This notepad has five different functions." + Environment.NewLine
               + "1. Load from a file " + Environment.NewLine
               + "2. Load first 50 fibonacci numbers" + Environment.NewLine
               + "3. Load first 100 fibonacci numbers" + Environment.NewLine
               + "4. Save to a file"
               + "5. Exit" + Environment.NewLine + "Chose any option you like. ", "View Help");
        }

        /// <summary>
        /// If the user chose the "About" option from the menu, it would show information about the notepad.
        /// </summary>
        /// <param name="sender">
        /// sender contains a reference to the control/object that raised the event.
        /// </param>
        /// <param name="e">
        ///  e containts the event data.
        /// </param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
             "This notepad was created by Ashi Chamarasinghe for Cpts 321 HW3. The notepad has "
             + "five different functions. Those are " + Environment.NewLine
             + "1. Load from a file " + Environment.NewLine
             + "2. Load first 50 fibonacci numbers" + Environment.NewLine
             + "3. Load first 100 fibonacci numbers" + Environment.NewLine
             + "4. Save to a file" + Environment.NewLine
             + "5. Exit" + Environment.NewLine
             + "Furthermore, the user has the abilty to view help and see information about notepad." + Environment.NewLine, "About Notepad");
        }
    }
}
