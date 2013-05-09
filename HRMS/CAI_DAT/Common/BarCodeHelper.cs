using System;
using System.Collections.Generic;
using System.Text;

namespace EVSoft.HRMS.Common
{
    public class BarCodeHelper
    {
        /// <summary>
        /// Tạo mã check sum cho chuỗi có thể đọc từ barcode (13 ký tự)
        /// </summary>
        /// <param name="dataToEncode">Chuỗi đầu vào (12 ký tự)</param>
        /// <returns></returns>
        public static int CreateCheckCode(string dataToEncode)
        {
            StringBuilder onlyCorrectData = new StringBuilder();

            for (int i = 0; i < dataToEncode.Length; i++)
            {
                if (char.IsNumber(dataToEncode[i]))
                    onlyCorrectData.Append(dataToEncode.Substring(i, 1));
            }

            if (onlyCorrectData.Length < 12)
            {
                while (onlyCorrectData.Length < 12)
                    onlyCorrectData.Insert(0, '0');
            }
            else if (onlyCorrectData.Length == 12)
                dataToEncode = onlyCorrectData.ToString();
            else
                dataToEncode = onlyCorrectData.ToString(0, 12);

            int sum = 0;
            bool alt = true;//Số ở vị trí lẽ tính từ bên phải qua (không bao gồm check code)
            int thedigit;
            int checkDigit;

            for (int i = dataToEncode.Length - 1; i >= 0; i--)
            {
                thedigit = int.Parse(dataToEncode.Substring(i, 1));

                if (alt)
                {
                    thedigit = 3 * thedigit;
                    //if (thedigit > 9)
                    //{
                    //    thedigit -= 9;
                    //}
                }
                sum += thedigit;
                alt = !alt;
            }

            checkDigit = (sum % 10);

            if (checkDigit != 0)
                checkDigit = (10 - checkDigit);
            else
                checkDigit = 0;

            return checkDigit;
        }

        //This is a helper function that takes in a string value and determines if it is a
        //number.
        private static bool IsNumber(string InNumber)
        {
            int idx = 0;
            int strLen = InNumber.Length;
            char[] InNumber2 = InNumber.ToCharArray();
            bool RtrnValue = true;
            if (strLen > 0)
            {
                for (idx = 0; idx < strLen; idx++)
                {
                    if (Char.IsNumber(InNumber2[idx]) == false)
                        RtrnValue = false;
                }
            }
            else
            {
                RtrnValue = false;
            }
            return RtrnValue;
        } //End IsNumber function

        /// <summary>
        /// Tạo chuỗi barcode để thực hiện in trên form
        /// </summary>
        /// <param name="dataToEncode"></param>
        /// <returns></returns>
        public static string CreateBarCodeStringToPrintSakureJAN(string inputString)
        {
            string OutData = "";		//this is the return value of the function
            string GoodData = "";		//This is the InputValue stripped of invalid characters
            int LenOfData = 0;			//Length of a string
            int idx = 0;				//for loop counter
            int WeightedTotal = 0;		//Weighted Total for check digit
            int WeightFactor = 0;		//The multiplier to determine the check digit.
            int iCurrentChar = 0;		//Integer value of current number in InputValue
            int CheckDigit = 0;			//Ascii value of check digit
            string EAN5AddOn = "";		//Add on characters for longer EAN symbols
            string EAN2AddOn = "";		//Add on characters for longer EAN symbols
            string Encoding = "";		//Encoding format 
            int LeadingDigit = 0;		//Ascii value of leading digit
            char[] cInputValue;			//Character array of a string
            string CurrentEncoding = "";//encoding in looop 
            string temp = "";			//Temp string 
            string EANAddOnToPrint = "";//Extended EAN information
            char EANaddchar;			//Character to add to extended EAN information
            int iEANaddchar = 0;		//integer value of above character
            char[] tempArray;			//array to hold character of strings

            /* Check to make sure data is numeric and remove dashes, etc. */
            LenOfData = inputString.Length;
            for (idx = 0; idx < LenOfData; idx++)
            {
                /* Add all numbers to GoodData string */
                if ((IsNumber(inputString.Substring(idx, 1))) == true)
                    GoodData = GoodData + inputString.Substring(idx, 1);
            }

            /* DataToEncode = OnlyCorrectData */
            /* Remove check digits if they added one */
            //The value passed in will only be 12, 13, 15, or 18 digits.  The 
            LenOfData = GoodData.Length;
            if (LenOfData == 13)  //we have the 12 digit EAN plus a check digit
                GoodData = GoodData.Substring(0, 12);
            else if (LenOfData == 15) //we have the 12 digit EAN plus a check digit plus a 2 digit add on
                GoodData = GoodData.Substring(0, 12) + GoodData.Substring(13, 2);
            else if (LenOfData == 18) //we have the 12 digit EAN plus a check digit plus a 5 digit add on
                GoodData = GoodData.Substring(0, 12) + GoodData.Substring(13, 5);

            //Now based on the new length of Good Data we can determine what the Add on value is.
            /* End sub if incorrect number */
            if (GoodData.Length == 17)
                //Check digit has already been eliminated so this is just the EAN code and the 5 digit add on
                EAN5AddOn = GoodData.Substring(12, 5);
            else if (GoodData.Length == 14)
                //Check digit has already been eliminated so this is just the EAN code and the 2 digit add on
                EAN2AddOn = GoodData.Substring(12, 2);

            //Now set GoodData to only the EAN code (the first 12 characters
            GoodData = GoodData.Substring(0, 12);

            /* ' */
            WeightFactor = 3;
            WeightedTotal = 0;

            /* <<<< Calculate Check Digit >>>> */
            /* Get the value of each number starting at the end */
            LenOfData = GoodData.Length;
            cInputValue = GoodData.ToCharArray();

            for (idx = (LenOfData - 1); idx >= 0; idx--)
            {
                /* Get the ascii value of each number starting at the end */
                iCurrentChar = ((int)cInputValue[idx]) - 48;
                /* multiply by the weighting factor which is 3,1,3,1... */
                /* and add the sum together */
                WeightedTotal = WeightedTotal + (iCurrentChar * WeightFactor);
                /* change factor for next calculation */
                WeightFactor = 4 - WeightFactor;
            }

            /* Find the CheckDigitValue by finding the number + weightedTotal that = a multiple of 10 */
            /* divide by 10, get the remainder and subtract from 10 */
            CheckDigit = WeightedTotal % 10;
            if (CheckDigit != 0)
                CheckDigit = (10 - CheckDigit);
            else
                CheckDigit = 0;

            /* Now we must encode the leading digit into the left half of the EAN-13 symbol */
            /* by using variable parity between character sets A and B */
            cInputValue = GoodData.ToCharArray();

            LeadingDigit = Convert.ToInt32(GoodData.Substring(0, 1));

            switch (LeadingDigit)
            {
                case 0:
                    Encoding = "AAAAAACCCCCC";
                    break;
                case 1:
                    Encoding = "AABABBCCCCCC";
                    break;
                case 2:
                    Encoding = "AABBABCCCCCC";
                    break;
                case 3:
                    Encoding = "AABBBACCCCCC";
                    break;
                case 4:
                    Encoding = "ABAABBCCCCCC";
                    break;
                case 5:
                    Encoding = "ABBAABCCCCCC";
                    break;
                case 6:
                    Encoding = "ABBBAACCCCCC";
                    break;
                case 7:
                    Encoding = "ABABABCCCCCC";
                    break;
                case 8:
                    Encoding = "ABABBACCCCCC";
                    break;
                case 9:
                    Encoding = "ABBABACCCCCC";
                    break;
            }  //end switch addresseing encoding type

            /* add the check digit to the end of the barcode & remove the leading digit */
            GoodData = GoodData.Substring(1, 11) + (CheckDigit.ToString());

            /* Now that we have the total number including the check digit, determine character to print for proper barcoding: */
            LenOfData = GoodData.Length;
            cInputValue = GoodData.ToCharArray();

            for (idx = 0; idx < LenOfData; idx++)
            {
                /* Get the ASCII value of each number excluding the first number because it is encoded with variable parity */
                iCurrentChar = (int)cInputValue[idx];
                CurrentEncoding = Encoding.Substring(idx, 1);

                /* Print different barcodes according to the location of the CurrentChar and CurrentEncoding */
                switch (CurrentEncoding)
                {
                    case "A":
                        OutData = OutData + cInputValue[idx];
                        break;
                    case "B":
                        iCurrentChar = iCurrentChar + 17;
                        OutData = OutData + ((char)iCurrentChar);
                        break;

                    case "C":
                        iCurrentChar = iCurrentChar + 27;
                        OutData = OutData + ((char)iCurrentChar);
                        break;
                    default:
                        break;
                } //end switch to checking encoding type
                /* add in the 1st character along with guard patterns */
                switch (idx)
                {
                    case 0:
                        // For the LeadingDigit print the human readable character, the normal guard pattern and then the rest of the barcode
                        //This is the character we will put before OutData
                        temp = LeadingDigit.ToString();
                        tempArray = temp.ToCharArray();
                        iCurrentChar = ((int)tempArray[0]);
                        if ((char)iCurrentChar == '0')
                            iCurrentChar += 48;
                        else iCurrentChar += 38;
                        OutData = ((char)iCurrentChar) + "V" + OutData;
                        break;
                    case 5:			/* Print the center guard pattern after the 6th character */
                        OutData = OutData + "U";
                        break;
                    case 11:	/* For the last character (12) print the the normal guard pattern after the barcode */
                        OutData = OutData + "V";
                        break;
                    default:
                        break;
                }  //end switch for determining main output for EAN code				
            }  //end for loop that encodes the data

            /* Process 5 digit add on if it exists */
            if (EAN5AddOn.Length == 5)
            {
                /* Get check digit for add on */
                WeightFactor = 3;
                WeightedTotal = 0;
                for (idx = (EAN5AddOn.Length - 1); idx >= 0; idx--)
                {
                    /* Get the value of each number starting at the end */
                    iCurrentChar = Convert.ToInt32(EAN5AddOn.Substring(idx, 1));

                    /* multiply by the weighting factor which is 3,9,3,9. */
                    /* and add the sum together */
                    if (WeightFactor == 3)
                    {
                        WeightedTotal = WeightedTotal + (iCurrentChar * 3);
                    }
                    if (WeightFactor == 1)
                    {
                        WeightedTotal = WeightedTotal + (iCurrentChar * 9);
                    }
                    /* change factor for next calculation */
                    WeightFactor = 4 - WeightFactor;
                }  //end check digit for loop for EAN 5 character add on

                /* Find the CheckDigit by extracting the right-most number from weightedTotal */
                temp = WeightedTotal.ToString();
                CheckDigit = Convert.ToInt32(temp.Substring(temp.Length - 1, 1));

                /* Now we must encode the add-on CheckDigit into the number sets */
                /* by using variable parity between character sets A and B */
                switch (CheckDigit)
                {
                    case 0:
                        Encoding = "BBAAA";
                        break;
                    case 1:
                        Encoding = "BABAA";
                        break;
                    case 2:
                        Encoding = "BAABA";
                        break;
                    case 3:
                        Encoding = "BAAAB";
                        break;
                    case 4:
                        Encoding = "ABBAA";
                        break;
                    case 5:
                        Encoding = "AABBA";
                        break;
                    case 6:
                        Encoding = "AAABB";
                        break;
                    case 7:
                        Encoding = "ABABA";
                        break;
                    case 8:
                        Encoding = "ABAAB";
                        break;
                    case 9:
                        Encoding = "AABAB";
                        break;
                } //end switch for EAN 5 encoding type

                /* Now that we have the total number including the check digit, determine character to print for proper barcoding: */
                LenOfData = EAN5AddOn.Length;
                EANAddOnToPrint = "";
                for (idx = 0; idx < LenOfData; idx++)
                {
                    /* Get the value of each number it is encoded with variable parity */
                    iCurrentChar = Convert.ToInt32(EAN5AddOn.Substring(idx, 1));
                    CurrentEncoding = Encoding.Substring(idx, 1);

                    if (CurrentEncoding == "A") /* Print different barcodes according to the location of the CurrentChar and CurrentEncoding */
                    {
                        switch (iCurrentChar)
                        {
                            case 0:
                                iEANaddchar = 34;
                                break;
                            case 1:
                                iEANaddchar = 35;
                                break;
                            case 2:
                                iEANaddchar = 36;
                                break;
                            case 3:
                                iEANaddchar = 37;
                                break;
                            case 4:
                                iEANaddchar = 38;
                                break;
                            case 5:
                                iEANaddchar = 44;
                                break;
                            case 6:
                                iEANaddchar = 46;
                                break;
                            case 7:
                                iEANaddchar = 47;
                                break;
                            case 8:
                                iEANaddchar = 58;
                                break;
                            case 9:
                                iEANaddchar = 59;
                                break;

                        } //end character switch for EAN 5 character for encoding A
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    } //End if Encoding A for EAN 5 character add on
                    else if (CurrentEncoding == "B")
                    {
                        switch (iCurrentChar)
                        {
                            case 0:
                                iEANaddchar = 122;
                                break;
                            case 1:
                                iEANaddchar = 61;
                                break;
                            case 2:
                                iEANaddchar = 63;
                                break;
                            case 3:
                                iEANaddchar = 64;
                                break;
                            case 4:
                                iEANaddchar = 91;
                                break;
                            case 5:
                                iEANaddchar = 92;
                                break;
                            case 6:
                                iEANaddchar = 93;
                                break;
                            case 7:
                                iEANaddchar = 95;
                                break;
                            case 8:
                                iEANaddchar = 123;
                                break;
                            case 9:
                                iEANaddchar = 125;
                                break;

                        }//End switch for EAN5 add on w/ B encoding
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    } //end else for Encoding B for EAN add on 5 characters

                    switch (idx)/* add in the space & add-on guard pattern */
                    {
                        case 0:
                            iEANaddchar = 43;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANaddchar + EANAddOnToPrint;
                            iEANaddchar = 32;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANaddchar + EANAddOnToPrint;
                            iEANaddchar = 33;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                            break;
                        case 1:
                            iEANaddchar = 33;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                            break;
                        case 2:
                            iEANaddchar = 33;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                            break;
                        case 3:
                            iEANaddchar = 33;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                            break;
                        case 4:
                            //do nothing
                            break;
                    }  //end add character switch
                } //end for loop to determine encoding characters
            } //end EAN length = 5

            /* Process 2 digit add on if it exists */
            if (EAN2AddOn.Length == 2)
            {
                //Get the actual value of the EAN2 add on
                iEANaddchar = Convert.ToInt32(EAN2AddOn);

                /* Get encoding for add on */
                for (idx = 0; idx <= 99; idx = idx + 4)
                {
                    if (iEANaddchar == idx)
                        Encoding = "AA";
                    else if (iEANaddchar == (idx + 1))
                        Encoding = "AB";
                    else if (iEANaddchar == (idx + 2))
                        Encoding = "BA";
                    else if (iEANaddchar == (idx + 3))
                        Encoding = "BB";
                } //end for loop determining encoding type

                LenOfData = EAN2AddOn.Length;  /* Now that we have the total number including the encoding determine what to print */
                for (idx = 0; idx < LenOfData; idx++)
                {
                    /* Get the value of each number it is encoded with variable parity */
                    iCurrentChar = Convert.ToInt32(EAN2AddOn.Substring(idx, 1));
                    CurrentEncoding = Encoding.Substring(idx, 1);

                    /* Print different barcodes according to the location of the CurrentChar and CurrentEncoding */
                    if (CurrentEncoding == "A")
                    {
                        switch (iCurrentChar)
                        {
                            case 0:
                                iEANaddchar = 34;
                                break;
                            case 1:
                                iEANaddchar = 35;
                                break;
                            case 2:
                                iEANaddchar = 36;
                                break;
                            case 3:
                                iEANaddchar = 37;
                                break;
                            case 4:
                                iEANaddchar = 38;
                                break;
                            case 5:
                                iEANaddchar = 44;
                                break;
                            case 6:
                                iEANaddchar = 46;
                                break;
                            case 7:
                                iEANaddchar = 47;
                                break;
                            case 8:
                                iEANaddchar = 58;
                                break;
                            case 9:
                                iEANaddchar = 59;
                                break;
                        }  //end switch encoding A
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    }//End if Encoding A
                    else if (CurrentEncoding == "B")
                    {
                        switch (iCurrentChar)
                        {
                            case 0:
                                iEANaddchar = 122;
                                break;
                            case 1:
                                iEANaddchar = 61;
                                break;
                            case 2:
                                iEANaddchar = 63;
                                break;
                            case 3:
                                iEANaddchar = 64;
                                break;
                            case 4:
                                iEANaddchar = 91;
                                break;
                            case 5:
                                iEANaddchar = 92;
                                break;
                            case 6:
                                iEANaddchar = 93;
                                break;
                            case 7:
                                iEANaddchar = 95;
                                break;
                            case 8:
                                iEANaddchar = 123;
                                break;
                            case 9:
                                iEANaddchar = 125;
                                break;
                        } //end switch encoding B
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    }  //end else if for encoding B
                    /* add in the space & add-on guard pattern */
                    if (idx == 0)
                    {
                        iEANaddchar = 43;
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANaddchar + EANAddOnToPrint;

                        iEANaddchar = 33;
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    }  //end if idx ==1

                }//End for loop through characters for EAN Add of length 2
            } //End if EANAdd On Length is 2


            /* Get OutData String */
            OutData = OutData + EANAddOnToPrint;
            /* Return OutData */
            return OutData;
        }

        public static string CreateBarCodeStringToPrintIDAutomation(string inputString)
        {
            string OutData = "";		//this is the return value of the function
            string GoodData = "";		//This is the InputValue stripped of invalid characters
            int LenOfData = 0;			//Length of a string
            int idx = 0;				//for loop counter
            int WeightedTotal = 0;		//Weighted Total for check digit
            int WeightFactor = 0;		//The multiplier to determine the check digit.
            int iCurrentChar = 0;		//Integer value of current number in InputValue
            int CheckDigit = 0;			//Ascii value of check digit
            string EAN5AddOn = "";		//Add on characters for longer EAN symbols
            string EAN2AddOn = "";		//Add on characters for longer EAN symbols
            string Encoding = "";		//Encoding format 
            int LeadingDigit = 0;		//Ascii value of leading digit
            char[] cInputValue;			//Character array of a string
            string CurrentEncoding = "";//encoding in looop 
            string temp = "";			//Temp string 
            string EANAddOnToPrint = "";//Extended EAN information
            char EANaddchar;			//Character to add to extended EAN information
            int iEANaddchar = 0;		//integer value of above character
            char[] tempArray;			//array to hold character of strings

            /* Check to make sure data is numeric and remove dashes, etc. */
            LenOfData = inputString.Length;
            for (idx = 0; idx < LenOfData; idx++)
            {
                /* Add all numbers to GoodData string */
                if ((IsNumber(inputString.Substring(idx, 1))) == true)
                    GoodData = GoodData + inputString.Substring(idx, 1);
            }

            /* DataToEncode = OnlyCorrectData */
            /* Remove check digits if they added one */
            //The value passed in will only be 12, 13, 15, or 18 digits.  The 
            LenOfData = GoodData.Length;
            if (LenOfData == 13)  //we have the 12 digit EAN plus a check digit
                GoodData = GoodData.Substring(0, 12);
            else if (LenOfData == 15) //we have the 12 digit EAN plus a check digit plus a 2 digit add on
                GoodData = GoodData.Substring(0, 12) + GoodData.Substring(13, 2);
            else if (LenOfData == 18) //we have the 12 digit EAN plus a check digit plus a 5 digit add on
                GoodData = GoodData.Substring(0, 12) + GoodData.Substring(13, 5);

            //Now based on the new length of Good Data we can determine what the Add on value is.
            /* End sub if incorrect number */
            if (GoodData.Length == 17)
                //Check digit has already been eliminated so this is just the EAN code and the 5 digit add on
                EAN5AddOn = GoodData.Substring(12, 5);
            else if (GoodData.Length == 14)
                //Check digit has already been eliminated so this is just the EAN code and the 2 digit add on
                EAN2AddOn = GoodData.Substring(12, 2);

            //Now set GoodData to only the EAN code (the first 12 characters
            GoodData = GoodData.Substring(0, 12);

            /* ' */
            WeightFactor = 3;
            WeightedTotal = 0;

            /* <<<< Calculate Check Digit >>>> */
            /* Get the value of each number starting at the end */
            LenOfData = GoodData.Length;
            cInputValue = GoodData.ToCharArray();

            for (idx = (LenOfData - 1); idx >= 0; idx--)
            {
                /* Get the ascii value of each number starting at the end */
                iCurrentChar = ((int)cInputValue[idx]) - 48;
                /* multiply by the weighting factor which is 3,1,3,1... */
                /* and add the sum together */
                WeightedTotal = WeightedTotal + (iCurrentChar * WeightFactor);
                /* change factor for next calculation */
                WeightFactor = 4 - WeightFactor;
            }

            /* Find the CheckDigitValue by finding the number + weightedTotal that = a multiple of 10 */
            /* divide by 10, get the remainder and subtract from 10 */
            CheckDigit = WeightedTotal % 10;
            if (CheckDigit != 0)
                CheckDigit = (10 - CheckDigit);
            else
                CheckDigit = 0;

            /* Now we must encode the leading digit into the left half of the EAN-13 symbol */
            /* by using variable parity between character sets A and B */
            cInputValue = GoodData.ToCharArray();

            LeadingDigit = Convert.ToInt32(GoodData.Substring(0, 1));

            switch (LeadingDigit)
            {
                case 0:
                    Encoding = "AAAAAACCCCCC";
                    break;
                case 1:
                    Encoding = "AABABBCCCCCC";
                    break;
                case 2:
                    Encoding = "AABBABCCCCCC";
                    break;
                case 3:
                    Encoding = "AABBBACCCCCC";
                    break;
                case 4:
                    Encoding = "ABAABBCCCCCC";
                    break;
                case 5:
                    Encoding = "ABBAABCCCCCC";
                    break;
                case 6:
                    Encoding = "ABBBAACCCCCC";
                    break;
                case 7:
                    Encoding = "ABABABCCCCCC";
                    break;
                case 8:
                    Encoding = "ABABBACCCCCC";
                    break;
                case 9:
                    Encoding = "ABBABACCCCCC";
                    break;
            }  //end switch addresseing encoding type

            /* add the check digit to the end of the barcode & remove the leading digit */
            GoodData = GoodData.Substring(1, 11) + (CheckDigit.ToString());

            /* Now that we have the total number including the check digit, determine character to print for proper barcoding: */
            LenOfData = GoodData.Length;
            cInputValue = GoodData.ToCharArray();

            for (idx = 0; idx < LenOfData; idx++)
            {
                /* Get the ASCII value of each number excluding the first number because it is encoded with variable parity */
                iCurrentChar = (int)cInputValue[idx];
                CurrentEncoding = Encoding.Substring(idx, 1);

                /* Print different barcodes according to the location of the CurrentChar and CurrentEncoding */
                switch (CurrentEncoding)
                {
                    case "A":
                        OutData = OutData + cInputValue[idx];
                        break;
                    case "B":
                        iCurrentChar = iCurrentChar + 17;
                        OutData = OutData + ((char)iCurrentChar);
                        break;

                    case "C":
                        iCurrentChar = iCurrentChar + 27;
                        OutData = OutData + ((char)iCurrentChar);
                        break;
                    default:
                        break;
                } //end switch to checking encoding type
                /* add in the 1st character along with guard patterns */
                switch (idx)
                {
                    case 0:
                        /* For the LeadingDigit print the human readable character, the normal guard pattern and then the rest of the barcode */
                        //This is the character we will put before OutData
                        if (LeadingDigit > 4)
                        {
                            temp = LeadingDigit.ToString();
                            tempArray = temp.ToCharArray();
                            iCurrentChar = ((int)tempArray[0]);
                            iCurrentChar = iCurrentChar + 64;
                            OutData = ((char)iCurrentChar) + "(" + OutData;
                        }
                        else if (LeadingDigit < 5)
                        {
                            temp = LeadingDigit.ToString();
                            tempArray = temp.ToCharArray();
                            iCurrentChar = ((int)tempArray[0]);
                            iCurrentChar = iCurrentChar + 37;
                            OutData = ((char)iCurrentChar) + "(" + OutData;
                        }
                        break;
                    case 5:			/* Print the center guard pattern after the 6th character */
                        OutData = OutData + "*";
                        break;
                    case 11:	/* For the last character (12) print the the normal guard pattern after the barcode */
                        OutData = OutData + "(";
                        break;
                    default:
                        break;
                }  //end switch for determining main output for EAN code				
            }  //end for loop that encodes the data

            /* Process 5 digit add on if it exists */
            if (EAN5AddOn.Length == 5)
            {
                /* Get check digit for add on */
                WeightFactor = 3;
                WeightedTotal = 0;
                for (idx = (EAN5AddOn.Length - 1); idx >= 0; idx--)
                {
                    /* Get the value of each number starting at the end */
                    iCurrentChar = Convert.ToInt32(EAN5AddOn.Substring(idx, 1));

                    /* multiply by the weighting factor which is 3,9,3,9. */
                    /* and add the sum together */
                    if (WeightFactor == 3)
                    {
                        WeightedTotal = WeightedTotal + (iCurrentChar * 3);
                    }
                    if (WeightFactor == 1)
                    {
                        WeightedTotal = WeightedTotal + (iCurrentChar * 9);
                    }
                    /* change factor for next calculation */
                    WeightFactor = 4 - WeightFactor;
                }  //end check digit for loop for EAN 5 character add on

                /* Find the CheckDigit by extracting the right-most number from weightedTotal */
                temp = WeightedTotal.ToString();
                CheckDigit = Convert.ToInt32(temp.Substring(temp.Length - 1, 1));

                /* Now we must encode the add-on CheckDigit into the number sets */
                /* by using variable parity between character sets A and B */
                switch (CheckDigit)
                {
                    case 0:
                        Encoding = "BBAAA";
                        break;
                    case 1:
                        Encoding = "BABAA";
                        break;
                    case 2:
                        Encoding = "BAABA";
                        break;
                    case 3:
                        Encoding = "BAAAB";
                        break;
                    case 4:
                        Encoding = "ABBAA";
                        break;
                    case 5:
                        Encoding = "AABBA";
                        break;
                    case 6:
                        Encoding = "AAABB";
                        break;
                    case 7:
                        Encoding = "ABABA";
                        break;
                    case 8:
                        Encoding = "ABAAB";
                        break;
                    case 9:
                        Encoding = "AABAB";
                        break;
                } //end switch for EAN 5 encoding type

                /* Now that we have the total number including the check digit, determine character to print for proper barcoding: */
                LenOfData = EAN5AddOn.Length;
                EANAddOnToPrint = "";
                for (idx = 0; idx < LenOfData; idx++)
                {
                    /* Get the value of each number it is encoded with variable parity */
                    iCurrentChar = Convert.ToInt32(EAN5AddOn.Substring(idx, 1));
                    CurrentEncoding = Encoding.Substring(idx, 1);

                    if (CurrentEncoding == "A") /* Print different barcodes according to the location of the CurrentChar and CurrentEncoding */
                    {
                        switch (iCurrentChar)
                        {
                            case 0:
                                iEANaddchar = 34;
                                break;
                            case 1:
                                iEANaddchar = 35;
                                break;
                            case 2:
                                iEANaddchar = 36;
                                break;
                            case 3:
                                iEANaddchar = 37;
                                break;
                            case 4:
                                iEANaddchar = 38;
                                break;
                            case 5:
                                iEANaddchar = 44;
                                break;
                            case 6:
                                iEANaddchar = 46;
                                break;
                            case 7:
                                iEANaddchar = 47;
                                break;
                            case 8:
                                iEANaddchar = 58;
                                break;
                            case 9:
                                iEANaddchar = 59;
                                break;

                        } //end character switch for EAN 5 character for encoding A
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    } //End if Encoding A for EAN 5 character add on
                    else if (CurrentEncoding == "B")
                    {
                        switch (iCurrentChar)
                        {
                            case 0:
                                iEANaddchar = 122;
                                break;
                            case 1:
                                iEANaddchar = 61;
                                break;
                            case 2:
                                iEANaddchar = 63;
                                break;
                            case 3:
                                iEANaddchar = 64;
                                break;
                            case 4:
                                iEANaddchar = 91;
                                break;
                            case 5:
                                iEANaddchar = 92;
                                break;
                            case 6:
                                iEANaddchar = 93;
                                break;
                            case 7:
                                iEANaddchar = 95;
                                break;
                            case 8:
                                iEANaddchar = 123;
                                break;
                            case 9:
                                iEANaddchar = 125;
                                break;

                        }//End switch for EAN5 add on w/ B encoding
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    } //end else for Encoding B for EAN add on 5 characters

                    switch (idx)/* add in the space & add-on guard pattern */
                    {
                        case 0:
                            iEANaddchar = 43;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANaddchar + EANAddOnToPrint;
                            iEANaddchar = 32;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANaddchar + EANAddOnToPrint;
                            iEANaddchar = 33;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                            break;
                        case 1:
                            iEANaddchar = 33;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                            break;
                        case 2:
                            iEANaddchar = 33;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                            break;
                        case 3:
                            iEANaddchar = 33;
                            EANaddchar = (char)iEANaddchar;
                            EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                            break;
                        case 4:
                            //do nothing
                            break;
                    }  //end add character switch
                } //end for loop to determine encoding characters
            } //end EAN length = 5

            /* Process 2 digit add on if it exists */
            if (EAN2AddOn.Length == 2)
            {
                //Get the actual value of the EAN2 add on
                iEANaddchar = Convert.ToInt32(EAN2AddOn);

                /* Get encoding for add on */
                for (idx = 0; idx <= 99; idx = idx + 4)
                {
                    if (iEANaddchar == idx)
                        Encoding = "AA";
                    else if (iEANaddchar == (idx + 1))
                        Encoding = "AB";
                    else if (iEANaddchar == (idx + 2))
                        Encoding = "BA";
                    else if (iEANaddchar == (idx + 3))
                        Encoding = "BB";
                } //end for loop determining encoding type

                LenOfData = EAN2AddOn.Length;  /* Now that we have the total number including the encoding determine what to print */
                for (idx = 0; idx < LenOfData; idx++)
                {
                    /* Get the value of each number it is encoded with variable parity */
                    iCurrentChar = Convert.ToInt32(EAN2AddOn.Substring(idx, 1));
                    CurrentEncoding = Encoding.Substring(idx, 1);

                    /* Print different barcodes according to the location of the CurrentChar and CurrentEncoding */
                    if (CurrentEncoding == "A")
                    {
                        switch (iCurrentChar)
                        {
                            case 0:
                                iEANaddchar = 34;
                                break;
                            case 1:
                                iEANaddchar = 35;
                                break;
                            case 2:
                                iEANaddchar = 36;
                                break;
                            case 3:
                                iEANaddchar = 37;
                                break;
                            case 4:
                                iEANaddchar = 38;
                                break;
                            case 5:
                                iEANaddchar = 44;
                                break;
                            case 6:
                                iEANaddchar = 46;
                                break;
                            case 7:
                                iEANaddchar = 47;
                                break;
                            case 8:
                                iEANaddchar = 58;
                                break;
                            case 9:
                                iEANaddchar = 59;
                                break;
                        }  //end switch encoding A
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    }//End if Encoding A
                    else if (CurrentEncoding == "B")
                    {
                        switch (iCurrentChar)
                        {
                            case 0:
                                iEANaddchar = 122;
                                break;
                            case 1:
                                iEANaddchar = 61;
                                break;
                            case 2:
                                iEANaddchar = 63;
                                break;
                            case 3:
                                iEANaddchar = 64;
                                break;
                            case 4:
                                iEANaddchar = 91;
                                break;
                            case 5:
                                iEANaddchar = 92;
                                break;
                            case 6:
                                iEANaddchar = 93;
                                break;
                            case 7:
                                iEANaddchar = 95;
                                break;
                            case 8:
                                iEANaddchar = 123;
                                break;
                            case 9:
                                iEANaddchar = 125;
                                break;
                        } //end switch encoding B
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    }  //end else if for encoding B
                    /* add in the space & add-on guard pattern */
                    if (idx == 0)
                    {
                        iEANaddchar = 43;
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANaddchar + EANAddOnToPrint;

                        iEANaddchar = 33;
                        EANaddchar = (char)iEANaddchar;
                        EANAddOnToPrint = EANAddOnToPrint + EANaddchar;
                    }  //end if idx ==1

                }//End for loop through characters for EAN Add of length 2
            } //End if EANAdd On Length is 2


            /* Get OutData String */
            OutData = OutData + EANAddOnToPrint;
            /* Return OutData */
            return OutData;
        }

        /// <summary>
        /// Hàm kiểm tra xem một chuỗi barcode có hợp lệ không
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static bool IsBarCodeValid(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return false;

            digits = digits.Trim();

            StringBuilder onlyCorrectData = new StringBuilder();

            for (int i = 0; i < digits.Length; i++)
            {
                if (char.IsNumber(digits[i]))
                    onlyCorrectData.Append(digits.Substring(i, 1));
            }

            digits = onlyCorrectData.ToString();

            int sum = 0;
            bool alt = false;//Số ở vị trí lẽ tính từ bên phải qua (không bao gồm check code)
            int thedigit;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                thedigit = int.Parse(digits.Substring(i, 1));

                if (alt)
                {
                    thedigit = 3 * thedigit;
                    //if (thedigit > 9)
                    //{
                    //    thedigit -= 9;
                    //}
                }
                sum += thedigit;
                alt = !alt;
            }
            return sum % 10 == 0;
        }
    }
}
