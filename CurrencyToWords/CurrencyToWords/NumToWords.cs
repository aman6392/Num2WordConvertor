using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyToWords
{
    public partial class numToWords : Form
    {
        public numToWords()
        {
            InitializeComponent();            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Exit from the application
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear button functionality, Clear the text from the label and display the default value in the input textbox
            textBoxNum.Text = "0.00";
            textBoxCharDisplay.Text = "";
            labelErrorText.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            String Excptn = "";
            String Words1 = "";
            String Words2 = "";
            String inpNumStr = "";
            Decimal inpNum;
            Int64 bfrDec = 0;
            Int64 aftrDec = 0;
            String dol = " DOLLAR AND ";
            String dols = " DOLLARS AND ";

            try
            {
                //Took the number in string format as per the requirement
                inpNumStr = textBoxNum.Text;

                //used regex to make sure only valid number comes into the application for processing
                String regex = @"^\d+\.{0,1}\d*$";

                Regex reg = new Regex(regex);
                if (reg.IsMatch(inpNumStr))
                {
                    //Round the number upto 2 decimal places only
                    inpNum = Math.Round(Decimal.Parse(textBoxNum.Text),2);

                    //converting number back to string to calculate the location of the decimal point
                    inpNumStr = inpNum.ToString();
                    int loc = inpNumStr.IndexOf(".");

                    if (loc < 0)
                    {
                        bfrDec = Int64.Parse(inpNumStr);
                        if (bfrDec == 0)
                        {
                            Words1 = "ZERO DOLLAR AND";
                        }
                        else
                        {
                            if (bfrDec < 10)
                            {
                                Words1 = ConvertNum(bfrDec) + dol;
                            }
                            else
                            {
                                Words1 = ConvertNum(bfrDec) + dols;
                            }
                            
                        }
                        textBoxCharDisplay.Text = Words1 + " ZERO CENTS";
                    }
                    else if (loc == 0)
                    {
                        aftrDec = Int16.Parse(inpNumStr.Substring(loc + 1));
                        
                        Words1 = ConvertNum(bfrDec);
                        Words2 = ConvertNum(aftrDec);
                        textBoxCharDisplay.Text = (Words1 + Words2 + " CENTS");
                    }
                    else if (loc > 0)
                    {
                        bfrDec = Int64.Parse(inpNumStr.Substring(0,loc));
                        aftrDec = Int16.Parse(inpNumStr.Substring(loc + 1));
                        if (bfrDec == 0 && aftrDec == 0)
                        {
                            Words1 = "ZERO DOLLAR AND ";
                            Words2 = "ZERO";
                            textBoxCharDisplay.Text = (Words1 + Words2 + " CENTS");
                        }
                        else if(aftrDec!= 0 && bfrDec != 0)
                        {
                            if (bfrDec < 10)
                            {
                                Words1 = ConvertNum(bfrDec) + dol;
                            }
                            else
                            {
                                Words1 = ConvertNum(bfrDec) + dols;
                            }
                            Words2 = ConvertNum(aftrDec);
                            textBoxCharDisplay.Text = (Words1 + Words2 + " CENTS");
                        }
                        else if (bfrDec == 0 && aftrDec != 0)
                        {
                            Words1 = "ZERO DOLLAR AND ";
                            Words2 = ConvertNum(aftrDec);
                            textBoxCharDisplay.Text = (Words1 + Words2 + " CENTS");
                        }
                        else if (bfrDec != 0 && aftrDec == 0)
                        {
                            if (bfrDec < 10)
                            {
                                Words1 = ConvertNum(bfrDec) + dol;
                            }
                            else
                            {
                                Words1 = ConvertNum(bfrDec) + dols;
                            }
                            Words2 = "ZERO";
                            textBoxCharDisplay.Text = (Words1 + Words2 + " CENTS");
                        }
                    }
                }
                else
                {
                    labelErrorText.Text = "Please Check the number you have entered!!";
                    
                }
            }
            catch(FormatException fe)
            {
                Excptn = fe.Message;
                textBoxCharDisplay.Text = Excptn+"test";
            }

        }

        public String ConvertNum(long num)
        {
            String strFinal = "";

            String[] ones = {   "", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX",
                                "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE",
                                "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN",
                                "EIGHTEEN", "NINETEEN" };

            String[] tens = {"","","TWENTY", "THIRTY", "FOURTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"};

            /*
            To convert input number to string i am doing it using input number length approach (created by me) because the input number length will be same as the length of the denominator. 
            For example: if an input number is 303.33, then before decimal has length 3 so will get divided by 100 and after decimal part has length of 2
            so it will go to case 2 and get divided by 10.
            */

            string s = num.ToString();
            int len = s.Length;

            switch (len)
            {
                case (1):                                                   //ones
                    strFinal = ones[num];
                    break;
                case (2) when (num >= 10 && num < 100):                     //tens
                    if (num >= 10 && num < 20)
                    {
                        strFinal = ones[num];
                    }
                    else
                    {
                        strFinal = tens[num / 10] + ones[num % 10];
                    }
                    break; 
                case 3:                                                     //hundreds
                    strFinal = ones[num / 100] + " HUNDRED " + ConvertNum(num % 100);
                    break;
                case 4:                                                     //thousands
                    strFinal = ConvertNum(num / 1000) + " THOUSAND " + ConvertNum(num % 1000);
                    break;
                case 5:                                                     //ten thousands
                    goto case 4;
                case 6:                                                     //hundred thousands
                    goto case 4;
                case 7:                                                     //million
                    strFinal = ConvertNum(num / 1000000) + " MILLION " + ConvertNum(num % 1000000);
                    break;
                case 8:                                                     //ten million
                    goto case 7;
                case 9:                                                     //hundred million
                    goto case 7;
                default:
                    labelErrorText.Text = "Please input a number less than a billion";
                    textBoxCharDisplay.Text = "";
                    strFinal = "";
                    break;
            }        

                return strFinal;
        }

            private void numToWords_Load(object sender, EventArgs e)
        {
            //Display application Limitations
            labelLimitations.Text = "Application Limitation(s):\r\n" +
                                    "1. This application is only designed to convert numbers less than a billion. \r\n" +
                                    "2. This application convert number value to words as per Australian Currency Standards.";

            //On form load, display default values of the following.
            textBoxNum.Text = "0.00";
            labelErrorText.Text = "";
            textBoxCharDisplay.Text = "";
        }

        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {
            textBoxCharDisplay.Text = "";
            labelErrorText.Text = "";
        }
    }
}