// <copyright file="FibonacciTextReader.cs" company="Ashi Chamarasinghe">
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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class contains different methods to calculate fibonnacci numbers. This class has two
    /// overriden functions. One function to override read line method and the other one is to override
    /// to read line to end method.
    /// </summary>
    public class FibonacciTextReader : System.IO.TextReader
    {
        /// <summary>
        /// This variable helps to keep track of number of sequences.
        /// </summary>
        private int numberSequence = 0;

        // Variables to keep track of first, second and current number in the sequence
        private System.Numerics.BigInteger firstFibNumber;
        private System.Numerics.BigInteger secondFibNumber;
        private System.Numerics.BigInteger currentFibNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciTextReader"/> class.
        /// This is the constructor for the fibonacci class.
        /// </summary>
        /// <param name="maxNumLines">
        /// Gets the maximum number of numbers in the sequence that it can generate.
        /// </param>
        public FibonacciTextReader(int maxNumLines)
        {
            // Variable to keep track first, second fibonnaci numbers
            this.firstFibNumber = 0;
            this.secondFibNumber = 0;
            this.NumberOfSequence = this.numberSequence;
            this.MaxLine = maxNumLines;
        }

        /// <summary>
        /// Gets or sets for the number of Max line property.
        /// </summary>
        public int MaxLine
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets for the number of sequences.
        /// </summary>
        public int NumberOfSequence
        {
            get { return this.numberSequence; }
            set { this.numberSequence = value; }
        }

        /// <summary>
        /// Override the ReadLine method which delivers the next number (as a string) in the Fibonaci sequence.
        /// It handles the first two numbers as special cases.
        /// </summary>
        /// <returns>
        /// Returns null after the nth call else return the overriden string.
        /// </returns>
        public override string ReadLine()
        {
            // If the number of sequence is less than the max number, calculate the fibonacci number.
            if (this.NumberOfSequence < this.MaxLine)
            {
                // Case 1 where the number of sequence is 0
                if (this.NumberOfSequence == 0)
                {
                    this.firstFibNumber = 0;
                    this.NumberOfSequence++;
                    return this.firstFibNumber.ToString();
                }

                // Case 2 where the number of sequence is 1
                else if (this.NumberOfSequence == 1)
                {
                    this.secondFibNumber = 1;
                    this.NumberOfSequence++;
                    return this.secondFibNumber.ToString();
                }

                // Case 3 where a number is not 0 or 1
                else
                {
                    this.currentFibNumber = this.firstFibNumber + this.secondFibNumber;
                    this.firstFibNumber = this.secondFibNumber;
                    this.secondFibNumber = this.currentFibNumber;
                    this.NumberOfSequence++;
                    return this.currentFibNumber.ToString();
                }
            }

            // Return null after the n-th call
            else
            {
                return null;
            }
        }

        /// <summary>
        /// This function overrides the read to end method. It repeatedly calls ReadLine and concatenates
        /// all the lines together.
        /// </summary>
        /// <returns>
        /// Output of the fibonacci sequence.
        /// </returns>
        public override string ReadToEnd()
        {
            StringBuilder fibSequence = new StringBuilder();

            // Go through the sequence until it reaches the max number of sequence and prints out
            for (int i = 0; i < this.MaxLine; i++)
            {
                fibSequence.AppendLine((i + 1) + ": " + this.ReadLine());
            }

            return fibSequence.ToString();
        }
    }
}
