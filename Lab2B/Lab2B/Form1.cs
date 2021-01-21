﻿/*
Class: Form1.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is one subclass of Form and it displays controls in the forms and perform any requests from user,
         such as calculate the total price, clear the values and exit the program.
         
I, Zhiping Yu, 000822513 certify that this material is my original work.  
No other person's work has been used without due acknowledgement.

*/

using System;
using System.Windows.Forms;

namespace Lab2B
{
    
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor   set up a form with controls
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When user click the calculate button, computing the total fees which customers have to pay based on their
        /// selections for the barber, services, type of customers and how many of them visiting the shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            decimal totalPrice; // the total price which a customer has to pay
            decimal discountRate;


            // choose different barber and pay different fee and only one can be chosen
            if (janRB.Checked)
            {
                totalPrice = 30;
            }
            else if (patRB.Checked)
            {
                totalPrice = 45;

            }else if (ronRB.Checked)
            {
                totalPrice = 40;
            }else if (sueRB.Checked)
            {
                totalPrice = 50;
            }
            else
            {
                totalPrice = 55;
            }

            // choose at least one service, otherwise show error message and check one service for the user
           

            if(cutCB.Checked == false && colourCB.Checked==false && highCB.Checked== false
                && extensionsCB.Checked == false)
            {
                MessageBox.Show("You must select at least one service", "Missing Service(s)", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cutCB.Checked = true;
              //  cutCB.Focus();   

            }
            else
            {
                // different services charge different fees, but user can choose more than one services
                if (cutCB.Checked)
                {
                    totalPrice += 30;
                }
                if (colourCB.Checked)
                {
                    totalPrice += 40;
                }
                if (highCB.Checked)
                {
                    totalPrice += 50;
                }
                if (extensionsCB.Checked)
                {
                    totalPrice += 200;
                }

                // differnt group of customer has different discount
                
                if (adultRB.Checked)
                {
                    discountRate = 0;
                }
                else if (childRB.Checked)
                {
                    discountRate = 0.1M;
                }else if (studentRB.Checked)
                {
                    discountRate = 0.05M;
                }
                else
                {
                    discountRate = 0.15M;
                }

                // offer discounts to different number of customers visiting the shop and calculate the final total fees
                if(int.TryParse(numTB.Text,out int number)== true)
                {
                    if (1 <= number && number <= 3)
                    {
                        GetTotalPrice(totalPrice, discountRate, 0);
                        
                    }
                    else if (4 <= number && number <= 8)
                    {
                        GetTotalPrice(totalPrice, discountRate, 0.05M);
                       
                    }
                    else if (9 <= number && number <= 13)
                    {
                        GetTotalPrice(totalPrice, discountRate, 0.10M);
                        
                    }
                    else if (number >= 14)
                    {
                         GetTotalPrice(totalPrice, discountRate,0.15M);
                       
                    }
                    // if number of visits is equal or less than 0, show an error message
                    else if (number <= 0)
                    {
                        MessageBox.Show("Number of Visits must be an integer greater than 0!", "Incorrect input",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        numTB.Focus();

                    }
                }
                // if user's input is string, show error message
                else
                {

                    MessageBox.Show("Number of Visits must be an integer greater than 0!", "Incorrect input",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numTB.Focus();

                }
            }

        }
        private void GetTotalPrice(decimal totalPrice, decimal orgDiscountRate, decimal
            extraDicountRate)
        {
            decimal newDiscountRate = orgDiscountRate + extraDicountRate;
            totalPrice *= (1 - newDiscountRate);
            priceTB.Text = totalPrice.ToString("C");
        }

        /// <summary>
        /// After user clicks the clear button, uncheck any services and clear the number of visits in the textbox. 
        /// However, choose the first radios in the haridresser and client-type group
        /// box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            janRB.Checked = true;
            janRB.Focus();
            cutCB.Checked = false;
            colourCB.Checked = false;
            highCB.Checked = false;
            extensionsCB.Checked = false;
            adultRB.Checked = true;
            numTB.Clear();
            priceTB.Clear();
        }

        
        /// <summary>
        /// After clicking the exit button, and directly exiting the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBtn_Click(object sender, EventArgs e)
           
        {
            Application.Exit();

        }
    }
}
