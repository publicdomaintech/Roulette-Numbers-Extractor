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
    using System.Windows.Forms;
    using PdBets;

    /// <summary>
    /// Main form.
    /// </summary>
    [Export(typeof(IPdBets))]
    public partial class MainForm : Form, IPdBets
    {
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
        public Dictionary<string, object> ModuleDictionary { get; set; } = new Dictionary<string, object>()
        {
            ["menuPath"] = "Extractors"
        };

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
        /// Raises the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the selectall tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSelectallToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the deselect all tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDeselectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the toggle tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnToggleToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the skipprocessed files tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSkipprocessedFilesToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the text tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTxtToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the all files tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAllFilesToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the about tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
			
        }

        /// <summary>
        /// Raises the extract numbers button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExtractNumbersButtonClick(object sender, EventArgs e)
        {
			
        }
    }
}