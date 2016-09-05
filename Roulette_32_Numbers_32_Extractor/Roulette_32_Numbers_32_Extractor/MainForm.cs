// <copyright file="MainForm.cs" company="www.PublicDomain.tech">All rights waived.</copyright>

// Programmed by Victor L. Senior (VLS) <support@publicdomain.tech>, 2016
//
// Web: http://publicdomain.tech
//
// Sources: http://github.com/publicdomaintech/
//
// This software and associated documentation files (the "Software") is
// released under the CC0 Public Domain Dedication, version 1.0, as
// published by Creative Commons. To the extent possible under law, the
// author(s) have dedicated all copyright and related and neighboring
// rights to the Software to the public domain worldwide. The Software is
// distributed WITHOUT ANY WARRANTY.
//
// If you did not receive a copy of the CC0 Public Domain Dedication
// along with the Software, see
// <http://creativecommons.org/publicdomain/zero/1.0/>

/// <summary>
/// Roulette Numbers Extractor.
/// </summary>
namespace Roulette_32_Numbers_32_Extractor
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Drawing;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using PdBets;

    /// <summary>
    /// Main form.
    /// </summary>
    [Export(typeof(IPdBets))]
    public partial class MainForm : Form, IPdBets
    {
        /// <summary>
        /// The append string.
        /// </summary>
        private string appendString = "_extracted";

        /// <summary>
        /// The skip processed files flag.
        /// </summary>
        private bool skipProcessedFiles = true;

        /// <summary>
        /// The filter string.
        /// </summary>
        private string filterString = "*.txt";

        /// <summary>
        /// The paths list.
        /// </summary>
        private List<string> pathsList = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Roulette_32_Numbers_32_Extractor.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the module dictionary.
        /// </summary>
        /// <value>The module dictionary.</value>
        public Dictionary<string, object> ModuleDictionary { get; set; }
        /*= new Dictionary<string, object>()
        {
            ["menuPath"] = "Extractors"
        };*/

        /// <summary>
        /// Processes incoming input and bet strings.
        /// </summary>
        /// <param name="inputString">Input string.</param>
        /// <param name="betString">Bet string.</param>
        /// <returns>>The processed input string.</returns>
        public string Input(string inputString, string betString)
        {
            // The return string
            string returnString = "-K";

            try
            {
                // Check if must show
                switch (inputString)
                {
                // Show
                    case "-S":

                        // Display form
                        this.Show();

                        // Exit flow
                        break;

                // Quit 
                    case "-Q":

                        // Close form
                        this.Close();

                        // Exit flow
                        break;

                // Halt
                    case "-H":

                        // Exit application
                        Application.Exit();

                        // Exit flow
                        break;
                }    
            }
            catch (Exception)
            {
                // Set return string to error
                returnString = "-E";
            }

            // Send return string
            return returnString;
        }

        /// <summary>
        /// Populates the files.
        /// </summary>
        private void PopulateFiles()
        {
            // Show folder browser dialog and check result
            if (this.mainFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Reset the session
                this.ResetSession();

                // Set files
                string[] files = Directory.GetFiles(this.mainFolderBrowserDialog.SelectedPath, this.filterString);

                // Iterate files
                foreach (string file in files)
                {
                    // Check if it's processed
                    if (this.skipProcessedFiles && Path.GetFileNameWithoutExtension(file).EndsWith(this.appendString))
                    {
                        // Skip iteration
                        continue;   
                    }

                    // Add to files checked list box
                    this.filesCheckedListBox.Items.Add(Path.GetFileName(file));

                    // Add to paths list
                    this.pathsList.Add(file);
                }
            }
        }

        /// <summary>
        /// Resets the session.
        /// </summary>
        private void ResetSession()
        {
            // Clear files checked list box
            this.filesCheckedListBox.Items.Clear();

            // Clear paths list
            this.pathsList.Clear();
        }

        /// <summary>
        /// Raises the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Reset the session
            this.ResetSession();
        }

        /// <summary>
        /// Raises the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Populate files
            this.PopulateFiles();
        }

        /// <summary>
        /// Raises the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Hide form
            this.Hide();
        }

        /// <summary>
        /// Raises the selectall tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSelectallToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Iterate checked list box items
            for (int index = 0; index < this.filesCheckedListBox.Items.Count; ++index)
            {
                // Check current item
                this.filesCheckedListBox.SetItemChecked(index, true);
            }
        }

        /// <summary>
        /// Raises the deselect all tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDeselectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Iterate checked list box items
            for (int index = 0; index < this.filesCheckedListBox.Items.Count; ++index)
            {
                // Uncheck current item
                this.filesCheckedListBox.SetItemChecked(index, false);
            }
        }

        /// <summary>
        /// Raises the toggle tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnToggleToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Iterate checked list box items
            for (int index = 0; index < this.filesCheckedListBox.Items.Count; ++index)
            {
                // Reverse checked status
                this.filesCheckedListBox.SetItemChecked(index, !this.filesCheckedListBox.GetItemChecked(index));
            }
        }

        /// <summary>
        /// Raises the skipprocessed files tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSkipprocessedFilesToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Reverse tool strip menu item checked status
            this.skipprocessedFilesToolStripMenuItem.Checked = !this.skipprocessedFilesToolStripMenuItem.Checked;

            // Set the skip processed files flag
            this.skipProcessedFiles = this.skipprocessedFilesToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Raises the text tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTxtToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check this menu item
            this.txtToolStripMenuItem.Checked = true;

            // Unckeck all files menu item
            this.allFilesToolStripMenuItem.Checked = false;

            // Set filter string
            this.filterString = "*.txt";
        }

        /// <summary>
        /// Raises the all files tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAllFilesToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check this menu item
            this.allFilesToolStripMenuItem.Checked = true;

            // Unckeck txt menu item
            this.txtToolStripMenuItem.Checked = false;

            // Set filter string
            this.filterString = "*.*";
        }

        /// <summary>
        /// Raises the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // About message
            MessageBox.Show("Programmed by Victor L. Senior (VLS)" + Environment.NewLine + "(www.publicdomain.tech / support@publicdomain.tech)" + Environment.NewLine + Environment.NewLine + "Version 1.0 - September 2016.", "Roulette Numbers Extractor");
        }

        /// <summary>
        /// Raises the extract numbers button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExtractNumbersButtonClick(object sender, EventArgs e)
        {
            // Check there's something to work with
            if (this.filesCheckedListBox.CheckedIndices.Count == 0)
            {
                // Halt flow
            }

            // Declare numbers list
            List<string> numbersList = new List<string>();

            // Iterate checked
            foreach (int checkedIndex in this.filesCheckedListBox.CheckedIndices)
            {
                // Set file string
                string file = this.pathsList[checkedIndex];

                // Set input string
                string input = File.ReadAllText(file);

                // Set numbers string array by regex
                string[] numbers = Regex.Split(input, @"\D+");

                // Iterate captured numbers
                foreach (string numberString in numbers)
                {
                    // Check if it's null or empty
                    if (!string.IsNullOrEmpty(numberString))
                    {
                        // Parse as integer
                        int number = int.Parse(numberString);

                        // TODO Validate range [Ranges for No zero and American]
                        if (number >= 0 && number <= 36)
                        {
                            // Add to numbers list
                            numbersList.Add(number.ToString());
                        }
                    }
                }

                // TODO Save to disk [Setting for skipping empty number lists]
                File.WriteAllLines(Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + this.appendString + ".txt"), numbersList);
            }

            /* Advise user via status bar text */

            // Set status
            this.statusToolStripStatusLabel.Text = "Processed: ";

            // Set file count
            this.fileCountToolStripStatusLabel.Text = this.filesCheckedListBox.CheckedIndices.Count.ToString();

            // Turn file count red
            this.fileCountToolStripStatusLabel.ForeColor = Color.Red;

            // Set files text
            this.filesTextToolStripStatusLabel.Text = " files.";
        }

        /// <summary>
        /// Raises the main form form closing event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if it's closing by user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hide form
                this.Hide();

                // Prevent closing
                e.Cancel = true;
            }
        }
    }
}