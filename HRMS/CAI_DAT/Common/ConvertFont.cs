using System;
using System.Collections.Generic;
using System.Text;

namespace EVSoft.HRMS.Common
{
    public struct FontIndex
    {
        public const int iNotKnown = -1;
        public const int iNCR = 0;
        public const int iUTF = 1;
        public const int iTCV = 2;
        public const int iVNI = 3;
        public const int iUTH = 4;
        public const int iUNI = 5;
        public const int iNOSIGN = 6;
        public const int iVIQ = 7;
    }

    public class ConvertFont
    {
        // Fields
        private string[,] Code;
        private const int iNCR = 0;
        private const int iNOSIGN = 6;
        private const int iTCV = 2;
        private const int iUNI = 5;
        private const int iUTF = 1;
        private const int iUTH = 4;
        private const int iVIQ = 7;
        private const int iVNI = 3;
        private const int nCode = 7;

        // Methods
        public ConvertFont()
        {
            this.InitData();
        }

        public bool Convert(ref string strConv, int iSrc, int iDest)
        {
            if (strConv.Trim() == "")
            {
                return false;
            }
            if (iSrc == iDest)
            {
                return false;
            }
            string text = "";
            string text2 = "";
            if (iSrc == -1)
            {
                int num4 = this.getIntCode(this.getStringCode(strConv));
                if (num4 <= -1)
                {
                    return false;
                }
                iSrc = num4;
            }
            if (iDest == -1)
            {
                iDest = 0;
            }
            int startIndex = 0;
            int nChar = this.GetnChar(this.Code[0, iSrc]);
            int num6 = (nChar > 1) ? (nChar - 1) : 1;
            string text3 = "";
            bool flag = false;
            strConv = strConv + "       ";
            while (startIndex < (strConv.Length - 7))
            {
                for (int i = nChar; i >= num6; i--)
                {
                    text = strConv.Substring(startIndex, i);
                    text2 = "";
                    for (int j = 1; j < 0x87; j++)
                    {
                        if (text == this.Code[j, iSrc])
                        {
                            text2 = this.Code[j, iDest];
                            startIndex += i;
                            break;
                        }
                    }
                    if ((text2 != "") || (i == 5))
                    {
                        break;
                    }
                }
                if (text2 != "")
                {
                    text3 = text3 + text2;
                    flag = true;
                }
                else
                {
                    text3 = text3 + text.Substring(0, 1);
                    startIndex++;
                }
            }
            if (!flag)
            {
                strConv = strConv.Remove(strConv.Length - 7, 7);
                return false;
            }
            strConv = text3.TrimEnd(new char[0]);
            return true;
        }

        private int getIntCode(string code)
        {
            for (int i = 0; i < 7; i++)
            {
                if (this.Code[0, i] == code)
                {
                    return i;
                }
            }
            return -1;
        }

        private int GetnChar(string s)
        {
            if (s == "UTF")
            {
                return 3;
            }
            if (((s == "UNI") || (s == "UTH")) || (s == "NOSIGN"))
            {
                return 1;
            }
            if (s == "NCR")
            {
                return 7;
            }
            return 2;
        }

        private string getStringCode(string str)
        {
            if (str.Trim() == "")
            {
                return "";
            }
            int num = -1;
            string s = "";
            str = str + "       ";
            for (int i = 0; i < (str.Length - 7); i++)
            {
                for (int j = 7; j > 0; j--)
                {
                    s = str.Substring(i, j);
                    for (int k = 0; k < 6; k++)
                    {
                        if (((j == 4) || (j == 5)) || ((j >= 6) && (k != 0)))
                        {
                            break;
                        }
                        if (((j != 3) || (k == 1)) && ((((k != 3) && (k != 2)) && (k != 4)) || (j <= 2)))
                        {
                            for (int m = 1; m < 0x87; m++)
                            {
                                if (s == this.Code[m, k])
                                {
                                    if (!this.isSpecialChar(s, (k == 4) || (k == 5)))
                                    {
                                        return this.Code[0, k];
                                    }
                                    num = k;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return ((num >= 0) ? this.Code[0, num] : "");
        }

        private void InitData()
        {
            this.Code = new string[0x87, 7];
            this.Code[0, 0] = "NCR";
            this.Code[0, 1] = "UTF";
            this.Code[0, 2] = "TCV";
            this.Code[0, 3] = "VNI";
            this.Code[0, 4] = "UTH";
            this.Code[0, 5] = "UNI";
            this.Code[0, 6] = "NOSIGN";
            this.MapUnicode();
            this.MapVNI();
            this.MapTCV();
            this.MapUTH();
            this.MapUTF8();
            this.MapNCR();
            this.MapNoSign();
        }

        private bool isSpecialChar(string s)
        {
            return this.isSpecialChar(s, false);
        }

        private bool isSpecialChar(string s, bool isUNI)
        {
            if (s.Length <= 2)
            {
                string[] textArray3;
                string[] textArray = new string[] { 
                "\x00ed", "\x00ec", "\x00f3", "\x00f2", "\x00f4", "\x00f1", "\x00ee", "\x00ca", "\x00c8", "\x00c9", "\x00e1", "\x00e0", "\x00e2", "\x00e8", "\x00e9", "\x00ea", 
                "\x00f9", "\x00fd", "\x00fa", "\x00f6", "\x00cd", "\x00cc", "\x00d3", "\x00d2", "\x00d4", "\x00d1", "\x00ce", "\x00d5", "\x00dd", "\x00c3", "o\x00e0", "o\x00e1", 
                "o\x00e3", "u\x00fb", "O\x00c1", "O\x00c0", "O\x00c3"
             };
                string[] textArray2 = new string[] { 
                "ă", "\x00e2", "\x00ea", "\x00f4", "ơ", "ư", "đ", "\x00ed", "\x00ec", "\x00f3", "\x00f2", "\x00f4", "\x00f1", "\x00ee", "\x00ca", "\x00c8", 
                "\x00c9", "\x00e1", "\x00e0", "\x00e2", "\x00e8", "\x00e9", "\x00ea", "\x00f9", "\x00fd", "\x00fa", "\x00f6", "\x00cd", "\x00cc", "\x00d3", "\x00d2", "\x00d4", 
                "\x00d1", "\x00ce", "\x00d5", "\x00dd", "\x00c3", "o\x00e0", "o\x00e1", "o\x00e3", "u\x00fb", "O\x00c1", "O\x00c0", "O\x00c3"
             };
                if (!isUNI)
                {
                    textArray3 = textArray;
                }
                else
                {
                    textArray3 = textArray2;
                }
                for (int i = 0; i < textArray3.Length; i++)
                {
                    if (string.Compare(s, textArray3[i], true) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool isVietnamese(string s)
        {
            return (this.getStringCode(s) != "");
        }

        public bool isVietnamese(string s, ref int code)
        {
            string text = this.getStringCode(s);
            code = this.getIntCode(text);
            return (code > -1);
        }

        private void MapNCR()
        {
            this.Code[1, 0] = "&#225;";
            this.Code[2, 0] = "&#224;";
            this.Code[3, 0] = "&#7843;";
            this.Code[4, 0] = "&#227;";
            this.Code[5, 0] = "&#7841;";
            this.Code[6, 0] = "&#259;";
            this.Code[7, 0] = "&#7855;";
            this.Code[8, 0] = "&#7857;";
            this.Code[9, 0] = "&#7859;";
            this.Code[10, 0] = "&#7861;";
            this.Code[11, 0] = "&#7863;";
            this.Code[12, 0] = "&#226;";
            this.Code[13, 0] = "&#7845;";
            this.Code[14, 0] = "&#7847;";
            this.Code[15, 0] = "&#7849;";
            this.Code[0x10, 0] = "&#7851;";
            this.Code[0x11, 0] = "&#7853;";
            this.Code[0x12, 0] = "&#233;";
            this.Code[0x13, 0] = "&#232;";
            this.Code[20, 0] = "&#7867;";
            this.Code[0x15, 0] = "&#7869;";
            this.Code[0x16, 0] = "&#7865;";
            this.Code[0x17, 0] = "&#234;";
            this.Code[0x18, 0] = "&#7871;";
            this.Code[0x19, 0] = "&#7873;";
            this.Code[0x1a, 0] = "&#7875;";
            this.Code[0x1b, 0] = "&#7877;";
            this.Code[0x1c, 0] = "&#7879;";
            this.Code[0x1d, 0] = "&#237;";
            this.Code[30, 0] = "&#236;";
            this.Code[0x1f, 0] = "&#7881;";
            this.Code[0x20, 0] = "&#297;";
            this.Code[0x21, 0] = "&#7883;";
            this.Code[0x22, 0] = "&#243;";
            this.Code[0x23, 0] = "&#242;";
            this.Code[0x24, 0] = "&#7887;";
            this.Code[0x25, 0] = "&#245;";
            this.Code[0x26, 0] = "&#7885;";
            this.Code[0x27, 0] = "&#244;";
            this.Code[40, 0] = "&#7889;";
            this.Code[0x29, 0] = "&#7891;";
            this.Code[0x2a, 0] = "&#7893;";
            this.Code[0x2b, 0] = "&#7895;";
            this.Code[0x2c, 0] = "&#7897;";
            this.Code[0x2d, 0] = "&#417;";
            this.Code[0x2e, 0] = "&#7899;";
            this.Code[0x2f, 0] = "&#7901;";
            this.Code[0x30, 0] = "&#7903;";
            this.Code[0x31, 0] = "&#7905;";
            this.Code[50, 0] = "&#7907;";
            this.Code[0x33, 0] = "&#250;";
            this.Code[0x34, 0] = "&#249;";
            this.Code[0x35, 0] = "&#7911;";
            this.Code[0x36, 0] = "&#361;";
            this.Code[0x37, 0] = "&#7909;";
            this.Code[0x38, 0] = "&#432;";
            this.Code[0x39, 0] = "&#7913;";
            this.Code[0x3a, 0] = "&#7915;";
            this.Code[0x3b, 0] = "&#7917;";
            this.Code[60, 0] = "&#7919;";
            this.Code[0x3d, 0] = "&#7921;";
            this.Code[0x3e, 0] = "&#253;";
            this.Code[0x3f, 0] = "&#7923;";
            this.Code[0x40, 0] = "&#7927;";
            this.Code[0x41, 0] = "&#7929;";
            this.Code[0x42, 0] = "&#7925;";
            this.Code[0x43, 0] = "&#273;";
            this.Code[0x44, 0] = "&#193;";
            this.Code[0x45, 0] = "&#192;";
            this.Code[70, 0] = "&#7842;";
            this.Code[0x47, 0] = "&#195;";
            this.Code[0x48, 0] = "&#7840;";
            this.Code[0x49, 0] = "&#258;";
            this.Code[0x4a, 0] = "&#7854;";
            this.Code[0x4b, 0] = "&#7856;";
            this.Code[0x4c, 0] = "&#7858;";
            this.Code[0x4d, 0] = "&#7860;";
            this.Code[0x4e, 0] = "&#7862;";
            this.Code[0x4f, 0] = "&#194;";
            this.Code[80, 0] = "&#7844;";
            this.Code[0x51, 0] = "&#7846;";
            this.Code[0x52, 0] = "&#7848;";
            this.Code[0x53, 0] = "&#7850;";
            this.Code[0x54, 0] = "&#7852;";
            this.Code[0x55, 0] = "&#201;";
            this.Code[0x56, 0] = "&#200;";
            this.Code[0x57, 0] = "&#7866;";
            this.Code[0x58, 0] = "&#7868;";
            this.Code[0x59, 0] = "&#7864;";
            this.Code[90, 0] = "&#202;";
            this.Code[0x5b, 0] = "&#7870;";
            this.Code[0x5c, 0] = "&#7872;";
            this.Code[0x5d, 0] = "&#7874;";
            this.Code[0x5e, 0] = "&#7876;";
            this.Code[0x5f, 0] = "&#7878;";
            this.Code[0x60, 0] = "&#205;";
            this.Code[0x61, 0] = "&#204;";
            this.Code[0x62, 0] = "&#7880;";
            this.Code[0x63, 0] = "&#296;";
            this.Code[100, 0] = "&#7882;";
            this.Code[0x65, 0] = "&#211;";
            this.Code[0x66, 0] = "&#210;";
            this.Code[0x67, 0] = "&#7886;";
            this.Code[0x68, 0] = "&#213;";
            this.Code[0x69, 0] = "&#7884;";
            this.Code[0x6a, 0] = "&#212;";
            this.Code[0x6b, 0] = "&#7888;";
            this.Code[0x6c, 0] = "&#7890;";
            this.Code[0x6d, 0] = "&#7892;";
            this.Code[110, 0] = "&#7894;";
            this.Code[0x6f, 0] = "&#7896;";
            this.Code[0x70, 0] = "&#416;";
            this.Code[0x71, 0] = "&#7898;";
            this.Code[0x72, 0] = "&#7900;";
            this.Code[0x73, 0] = "&#7902;";
            this.Code[0x74, 0] = "&#7904;";
            this.Code[0x75, 0] = "&#7906;";
            this.Code[0x76, 0] = "&#218;";
            this.Code[0x77, 0] = "&#217;";
            this.Code[120, 0] = "&#7910;";
            this.Code[0x79, 0] = "&#360;";
            this.Code[0x7a, 0] = "&#7908;";
            this.Code[0x7b, 0] = "&#431;";
            this.Code[0x7c, 0] = "&#7912;";
            this.Code[0x7d, 0] = "&#7914;";
            this.Code[0x7e, 0] = "&#7916;";
            this.Code[0x7f, 0] = "&#7918;";
            this.Code[0x80, 0] = "&#7920;";
            this.Code[0x81, 0] = "&#221;";
            this.Code[130, 0] = "&#7922;";
            this.Code[0x83, 0] = "&#7926;";
            this.Code[0x84, 0] = "&#7928;";
            this.Code[0x85, 0] = "&#7924;";
            this.Code[0x86, 0] = "&#272;";
        }

        private void MapNoSign()
        {
            this.Code[1, 6] = "a";
            this.Code[2, 6] = "a";
            this.Code[3, 6] = "a";
            this.Code[4, 6] = "a";
            this.Code[5, 6] = "a";
            this.Code[6, 6] = "a";
            this.Code[7, 6] = "a";
            this.Code[8, 6] = "a";
            this.Code[9, 6] = "a";
            this.Code[10, 6] = "a";
            this.Code[11, 6] = "a";
            this.Code[12, 6] = "a";
            this.Code[13, 6] = "a";
            this.Code[14, 6] = "a";
            this.Code[15, 6] = "a";
            this.Code[0x10, 6] = "a";
            this.Code[0x11, 6] = "a";
            this.Code[0x12, 6] = "a";
            this.Code[0x13, 6] = "e";
            this.Code[20, 6] = "e";
            this.Code[0x15, 6] = "e";
            this.Code[0x16, 6] = "e";
            this.Code[0x17, 6] = "e";
            this.Code[0x18, 6] = "e";
            this.Code[0x19, 6] = "e";
            this.Code[0x1a, 6] = "e";
            this.Code[0x1b, 6] = "e";
            this.Code[0x1c, 6] = "e";
            this.Code[0x1d, 6] = "i";
            this.Code[30, 6] = "i";
            this.Code[0x1f, 6] = "i";
            this.Code[0x20, 6] = "i";
            this.Code[0x21, 6] = "i";
            this.Code[0x22, 6] = "o";
            this.Code[0x23, 6] = "o";
            this.Code[0x24, 6] = "o";
            this.Code[0x25, 6] = "o";
            this.Code[0x26, 6] = "o";
            this.Code[0x27, 6] = "o";
            this.Code[40, 6] = "o";
            this.Code[0x29, 6] = "o";
            this.Code[0x2a, 6] = "o";
            this.Code[0x2b, 6] = "o";
            this.Code[0x2c, 6] = "o";
            this.Code[0x2d, 6] = "o";
            this.Code[0x2e, 6] = "o";
            this.Code[0x2f, 6] = "o";
            this.Code[0x30, 6] = "o";
            this.Code[0x31, 6] = "o";
            this.Code[50, 6] = "o";
            this.Code[0x33, 6] = "u";
            this.Code[0x34, 6] = "u";
            this.Code[0x35, 6] = "u";
            this.Code[0x36, 6] = "u";
            this.Code[0x37, 6] = "u";
            this.Code[0x38, 6] = "u";
            this.Code[0x39, 6] = "u";
            this.Code[0x3a, 6] = "u";
            this.Code[0x3b, 6] = "u";
            this.Code[60, 6] = "u";
            this.Code[0x3d, 6] = "u";
            this.Code[0x3e, 6] = "y";
            this.Code[0x3f, 6] = "y";
            this.Code[0x40, 6] = "y";
            this.Code[0x41, 6] = "y";
            this.Code[0x42, 6] = "y";
            this.Code[0x43, 6] = "d";
            this.Code[0x44, 6] = "A";
            this.Code[0x45, 6] = "A";
            this.Code[70, 6] = "A";
            this.Code[0x47, 6] = "A";
            this.Code[0x48, 6] = "A";
            this.Code[0x49, 6] = "A";
            this.Code[0x4a, 6] = "A";
            this.Code[0x4b, 6] = "A";
            this.Code[0x4c, 6] = "A";
            this.Code[0x4d, 6] = "A";
            this.Code[0x4e, 6] = "A";
            this.Code[0x4f, 6] = "A";
            this.Code[80, 6] = "A";
            this.Code[0x51, 6] = "A";
            this.Code[0x52, 6] = "A";
            this.Code[0x53, 6] = "A";
            this.Code[0x54, 6] = "A";
            this.Code[0x55, 6] = "E";
            this.Code[0x56, 6] = "E";
            this.Code[0x57, 6] = "E";
            this.Code[0x58, 6] = "E";
            this.Code[0x59, 6] = "E";
            this.Code[90, 6] = "E";
            this.Code[0x5b, 6] = "E";
            this.Code[0x5c, 6] = "E";
            this.Code[0x5d, 6] = "E";
            this.Code[0x5e, 6] = "E";
            this.Code[0x5f, 6] = "E";
            this.Code[0x60, 6] = "I";
            this.Code[0x61, 6] = "I";
            this.Code[0x62, 6] = "I";
            this.Code[0x63, 6] = "I";
            this.Code[100, 6] = "I";
            this.Code[0x65, 6] = "O";
            this.Code[0x66, 6] = "O";
            this.Code[0x67, 6] = "O";
            this.Code[0x68, 6] = "O";
            this.Code[0x69, 6] = "O";
            this.Code[0x6a, 6] = "O";
            this.Code[0x6b, 6] = "O";
            this.Code[0x6c, 6] = "O";
            this.Code[0x6d, 6] = "O";
            this.Code[110, 6] = "O";
            this.Code[0x6f, 6] = "O";
            this.Code[0x70, 6] = "O";
            this.Code[0x71, 6] = "O";
            this.Code[0x72, 6] = "O";
            this.Code[0x73, 6] = "O";
            this.Code[0x74, 6] = "O";
            this.Code[0x75, 6] = "O";
            this.Code[0x76, 6] = "U";
            this.Code[0x77, 6] = "U";
            this.Code[120, 6] = "U";
            this.Code[0x79, 6] = "U";
            this.Code[0x7a, 6] = "U";
            this.Code[0x7b, 6] = "U";
            this.Code[0x7c, 6] = "U";
            this.Code[0x7d, 6] = "U";
            this.Code[0x7e, 6] = "U";
            this.Code[0x7f, 6] = "U";
            this.Code[0x80, 6] = "U";
            this.Code[0x81, 6] = "Y";
            this.Code[130, 6] = "Y";
            this.Code[0x83, 6] = "Y";
            this.Code[0x84, 6] = "Y";
            this.Code[0x85, 6] = "Y";
            this.Code[0x86, 6] = "D";
        }

        private void MapTCV()
        {
            this.Code[1, 2] = "\x00b8";
            this.Code[2, 2] = "\x00b5";
            this.Code[3, 2] = "\x00b6";
            this.Code[4, 2] = "\x00b7";
            this.Code[5, 2] = "\x00b9";
            this.Code[6, 2] = "\x00a8";
            this.Code[7, 2] = "\x00be";
            this.Code[8, 2] = "\x00bb";
            this.Code[9, 2] = "\x00bc";
            this.Code[10, 2] = "\x00bd";
            this.Code[11, 2] = "\x00c6";
            this.Code[12, 2] = "\x00a9";
            this.Code[13, 2] = "\x00ca";
            this.Code[14, 2] = "\x00c7";
            this.Code[15, 2] = "\x00c8";
            this.Code[0x10, 2] = "\x00c9";
            this.Code[0x11, 2] = "\x00cb";
            this.Code[0x12, 2] = "\x00d0";
            this.Code[0x13, 2] = "\x00cc";
            this.Code[20, 2] = "\x00ce";
            this.Code[0x15, 2] = "\x00cf";
            this.Code[0x16, 2] = "\x00d1";
            this.Code[0x17, 2] = "\x00aa";
            this.Code[0x18, 2] = "\x00d5";
            this.Code[0x19, 2] = "\x00d2";
            this.Code[0x1a, 2] = "\x00d3";
            this.Code[0x1b, 2] = "\x00d4";
            this.Code[0x1c, 2] = "\x00d6";
            this.Code[0x1d, 2] = "\x00dd";
            this.Code[30, 2] = "\x00d7";
            this.Code[0x1f, 2] = "\x00d8";
            this.Code[0x20, 2] = "\x00dc";
            this.Code[0x21, 2] = "\x00de";
            this.Code[0x22, 2] = "\x00e3";
            this.Code[0x23, 2] = "\x00df";
            this.Code[0x24, 2] = "\x00e1";
            this.Code[0x25, 2] = "\x00e2";
            this.Code[0x26, 2] = "\x00e4";
            this.Code[0x27, 2] = "\x00ab";
            this.Code[40, 2] = "\x00e8";
            this.Code[0x29, 2] = "\x00e5";
            this.Code[0x2a, 2] = "\x00e6";
            this.Code[0x2b, 2] = "\x00e7";
            this.Code[0x2c, 2] = "\x00e9";
            this.Code[0x2d, 2] = "\x00ac";
            this.Code[0x2e, 2] = "\x00ed";
            this.Code[0x2f, 2] = "\x00ea";
            this.Code[0x30, 2] = "\x00eb";
            this.Code[0x31, 2] = "\x00ec";
            this.Code[50, 2] = "\x00ee";
            this.Code[0x33, 2] = "\x00f3";
            this.Code[0x34, 2] = "\x00ef";
            this.Code[0x35, 2] = "\x00f1";
            this.Code[0x36, 2] = "\x00f2";
            this.Code[0x37, 2] = "\x00f4";
            this.Code[0x38, 2] = "\x00ad";
            this.Code[0x39, 2] = "\x00f8";
            this.Code[0x3a, 2] = "\x00f5";
            this.Code[0x3b, 2] = "\x00f6";
            this.Code[60, 2] = "\x00f7";
            this.Code[0x3d, 2] = "\x00f9";
            this.Code[0x3e, 2] = "\x00fd";
            this.Code[0x3f, 2] = "\x00fa";
            this.Code[0x40, 2] = "\x00fb";
            this.Code[0x41, 2] = "\x00fc";
            this.Code[0x42, 2] = "\x00fe";
            this.Code[0x43, 2] = "\x00ae";
            this.Code[0x44, 2] = "\x00b8";
            this.Code[0x45, 2] = "\x00b5";
            this.Code[70, 2] = "\x00b6";
            this.Code[0x47, 2] = "\x00b7";
            this.Code[0x48, 2] = "\x00b9";
            this.Code[0x49, 2] = "\x00a1";
            this.Code[0x4a, 2] = "\x00be";
            this.Code[0x4b, 2] = "\x00bb";
            this.Code[0x4c, 2] = "\x00bc";
            this.Code[0x4d, 2] = "\x00bd";
            this.Code[0x4e, 2] = "\x00c6";
            this.Code[0x4f, 2] = "\x00a2";
            this.Code[80, 2] = "\x00ca";
            this.Code[0x51, 2] = "\x00c7";
            this.Code[0x52, 2] = "\x00c8";
            this.Code[0x53, 2] = "\x00c9";
            this.Code[0x54, 2] = "\x00cb";
            this.Code[0x55, 2] = "\x00d0";
            this.Code[0x56, 2] = "\x00cc";
            this.Code[0x57, 2] = "\x00ce";
            this.Code[0x58, 2] = "\x00cf";
            this.Code[0x59, 2] = "\x00d1";
            this.Code[90, 2] = "\x00a3";
            this.Code[0x5b, 2] = "\x00d5";
            this.Code[0x5c, 2] = "\x00d2";
            this.Code[0x5d, 2] = "\x00d3";
            this.Code[0x5e, 2] = "\x00d4";
            this.Code[0x5f, 2] = "\x00d6";
            this.Code[0x60, 2] = "\x00dd";
            this.Code[0x61, 2] = "\x00d7";
            this.Code[0x62, 2] = "\x00d8";
            this.Code[0x63, 2] = "\x00dc";
            this.Code[100, 2] = "\x00de";
            this.Code[0x65, 2] = "\x00e3";
            this.Code[0x66, 2] = "\x00df";
            this.Code[0x67, 2] = "\x00e1";
            this.Code[0x68, 2] = "\x00e2";
            this.Code[0x69, 2] = "\x00e4";
            this.Code[0x6a, 2] = "\x00a4";
            this.Code[0x6b, 2] = "\x00e8";
            this.Code[0x6c, 2] = "\x00e5";
            this.Code[0x6d, 2] = "\x00e6";
            this.Code[110, 2] = "\x00e7";
            this.Code[0x6f, 2] = "\x00e9";
            this.Code[0x70, 2] = "\x00a5";
            this.Code[0x71, 2] = "\x00ed";
            this.Code[0x72, 2] = "\x00ea";
            this.Code[0x73, 2] = "\x00eb";
            this.Code[0x74, 2] = "\x00ec";
            this.Code[0x75, 2] = "\x00ee";
            this.Code[0x76, 2] = "\x00f3";
            this.Code[0x77, 2] = "\x00ef";
            this.Code[120, 2] = "\x00f1";
            this.Code[0x79, 2] = "\x00f2";
            this.Code[0x7a, 2] = "\x00f4";
            this.Code[0x7b, 2] = "\x00a6";
            this.Code[0x7c, 2] = "\x00f8";
            this.Code[0x7d, 2] = "\x00f5";
            this.Code[0x7e, 2] = "\x00f6";
            this.Code[0x7f, 2] = "\x00f7";
            this.Code[0x80, 2] = "\x00f9";
            this.Code[0x81, 2] = "\x00fd";
            this.Code[130, 2] = "\x00fa";
            this.Code[0x83, 2] = "\x00fb";
            this.Code[0x84, 2] = "\x00fc";
            this.Code[0x85, 2] = "\x00fe";
            this.Code[0x86, 2] = "\x00a7";
        }

        private void MapUnicode()
        {
            this.Code[1, 5] = "\x00e1";
            this.Code[2, 5] = "\x00e0";
            this.Code[3, 5] = "ả";
            this.Code[4, 5] = "\x00e3";
            this.Code[5, 5] = "ạ";
            this.Code[6, 5] = "ă";
            this.Code[7, 5] = "ắ";
            this.Code[8, 5] = "ằ";
            this.Code[9, 5] = "ẳ";
            this.Code[10, 5] = "ẵ";
            this.Code[11, 5] = "ặ";
            this.Code[12, 5] = "\x00e2";
            this.Code[13, 5] = "ấ";
            this.Code[14, 5] = "ầ";
            this.Code[15, 5] = "ẩ";
            this.Code[0x10, 5] = "ẫ";
            this.Code[0x11, 5] = "ậ";
            this.Code[0x12, 5] = "\x00e9";
            this.Code[0x13, 5] = "\x00e8";
            this.Code[20, 5] = "ẻ";
            this.Code[0x15, 5] = "ẽ";
            this.Code[0x16, 5] = "ẹ";
            this.Code[0x17, 5] = "\x00ea";
            this.Code[0x18, 5] = "ế";
            this.Code[0x19, 5] = "ề";
            this.Code[0x1a, 5] = "ể";
            this.Code[0x1b, 5] = "ễ";
            this.Code[0x1c, 5] = "ệ";
            this.Code[0x1d, 5] = "\x00ed";
            this.Code[30, 5] = "\x00ec";
            this.Code[0x1f, 5] = "ỉ";
            this.Code[0x20, 5] = "ĩ";
            this.Code[0x21, 5] = "ị";
            this.Code[0x22, 5] = "\x00f3";
            this.Code[0x23, 5] = "\x00f2";
            this.Code[0x24, 5] = "ỏ";
            this.Code[0x25, 5] = "\x00f5";
            this.Code[0x26, 5] = "ọ";
            this.Code[0x27, 5] = "\x00f4";
            this.Code[40, 5] = "ố";
            this.Code[0x29, 5] = "ồ";
            this.Code[0x2a, 5] = "ổ";
            this.Code[0x2b, 5] = "ỗ";
            this.Code[0x2c, 5] = "ộ";
            this.Code[0x2d, 5] = "ơ";
            this.Code[0x2e, 5] = "ớ";
            this.Code[0x2f, 5] = "ờ";
            this.Code[0x30, 5] = "ở";
            this.Code[0x31, 5] = "ỡ";
            this.Code[50, 5] = "ợ";
            this.Code[0x33, 5] = "\x00fa";
            this.Code[0x34, 5] = "\x00f9";
            this.Code[0x35, 5] = "ủ";
            this.Code[0x36, 5] = "ũ";
            this.Code[0x37, 5] = "ụ";
            this.Code[0x38, 5] = "ư";
            this.Code[0x39, 5] = "ứ";
            this.Code[0x3a, 5] = "ừ";
            this.Code[0x3b, 5] = "ử";
            this.Code[60, 5] = "ữ";
            this.Code[0x3d, 5] = "ự";
            this.Code[0x3e, 5] = "\x00fd";
            this.Code[0x3f, 5] = "ỳ";
            this.Code[0x40, 5] = "ỷ";
            this.Code[0x41, 5] = "ỹ";
            this.Code[0x42, 5] = "ỵ";
            this.Code[0x43, 5] = "đ";
            this.Code[0x44, 5] = "\x00c1";
            this.Code[0x45, 5] = "\x00c0";
            this.Code[70, 5] = "Ả";
            this.Code[0x47, 5] = "\x00c3";
            this.Code[0x48, 5] = "Ạ";
            this.Code[0x49, 5] = "Ă";
            this.Code[0x4a, 5] = "Ắ";
            this.Code[0x4b, 5] = "Ằ";
            this.Code[0x4c, 5] = "Ẳ";
            this.Code[0x4d, 5] = "Ẵ";
            this.Code[0x4e, 5] = "Ặ";
            this.Code[0x4f, 5] = "\x00c2";
            this.Code[80, 5] = "Ấ";
            this.Code[0x51, 5] = "Ầ";
            this.Code[0x52, 5] = "Ẩ";
            this.Code[0x53, 5] = "Ẫ";
            this.Code[0x54, 5] = "Ậ";
            this.Code[0x55, 5] = "\x00c9";
            this.Code[0x56, 5] = "\x00c8";
            this.Code[0x57, 5] = "Ẻ";
            this.Code[0x58, 5] = "Ẽ";
            this.Code[0x59, 5] = "Ẹ";
            this.Code[90, 5] = "\x00ca";
            this.Code[0x5b, 5] = "Ế";
            this.Code[0x5c, 5] = "Ề";
            this.Code[0x5d, 5] = "Ể";
            this.Code[0x5e, 5] = "Ễ";
            this.Code[0x5f, 5] = "Ệ";
            this.Code[0x60, 5] = "\x00cd";
            this.Code[0x61, 5] = "\x00cc";
            this.Code[0x62, 5] = "Ỉ";
            this.Code[0x63, 5] = "Ĩ";
            this.Code[100, 5] = "Ị";
            this.Code[0x65, 5] = "\x00d3";
            this.Code[0x66, 5] = "\x00d2";
            this.Code[0x67, 5] = "Ỏ";
            this.Code[0x68, 5] = "\x00d5";
            this.Code[0x69, 5] = "Ọ";
            this.Code[0x6a, 5] = "\x00d4";
            this.Code[0x6b, 5] = "Ố";
            this.Code[0x6c, 5] = "Ồ";
            this.Code[0x6d, 5] = "Ổ";
            this.Code[110, 5] = "Ỗ";
            this.Code[0x6f, 5] = "Ộ";
            this.Code[0x70, 5] = "Ơ";
            this.Code[0x71, 5] = "Ớ";
            this.Code[0x72, 5] = "Ờ";
            this.Code[0x73, 5] = "Ở";
            this.Code[0x74, 5] = "Ỡ";
            this.Code[0x75, 5] = "Ợ";
            this.Code[0x76, 5] = "\x00da";
            this.Code[0x77, 5] = "\x00d9";
            this.Code[120, 5] = "Ủ";
            this.Code[0x79, 5] = "Ũ";
            this.Code[0x7a, 5] = "Ụ";
            this.Code[0x7b, 5] = "Ư";
            this.Code[0x7c, 5] = "Ứ";
            this.Code[0x7d, 5] = "Ừ";
            this.Code[0x7e, 5] = "Ử";
            this.Code[0x7f, 5] = "Ữ";
            this.Code[0x80, 5] = "Ự";
            this.Code[0x81, 5] = "\x00dd";
            this.Code[130, 5] = "Ỳ";
            this.Code[0x83, 5] = "Ỷ";
            this.Code[0x84, 5] = "Ỹ";
            this.Code[0x85, 5] = "Ỵ";
            this.Code[0x86, 5] = "Đ";
        }

        private void MapUTF8()
        {
            this.Code[1, 1] = "\x00c3\x00a1";
            this.Code[2, 1] = "\x00c3\x00a0";
            this.Code[3, 1] = "\x00e1\x00ba\x00a3";
            this.Code[4, 1] = "\x00c3\x00a3";
            this.Code[5, 1] = "\x00e1\x00ba\x00a1";
            this.Code[6, 1] = "\x00c4ƒ";
            this.Code[7, 1] = "\x00e1\x00ba\x00af";
            this.Code[8, 1] = "\x00e1\x00ba\x00b1";
            this.Code[9, 1] = "\x00e1\x00ba\x00b3";
            this.Code[10, 1] = "\x00e1\x00ba\x00b5";
            this.Code[11, 1] = "\x00e1\x00ba\x00b7";
            this.Code[12, 1] = "\x00c3\x00a2";
            this.Code[13, 1] = "\x00e1\x00ba\x00a5";
            this.Code[14, 1] = "\x00e1\x00ba\x00a7";
            this.Code[15, 1] = "\x00e1\x00ba\x00a9";
            this.Code[0x10, 1] = "\x00e1\x00ba\x00ab";
            this.Code[0x11, 1] = "\x00e1\x00ba\x00ad";
            this.Code[0x12, 1] = "\x00c3\x00a9";
            this.Code[0x13, 1] = "\x00c3\x00a8";
            this.Code[20, 1] = "\x00e1\x00ba\x00bb";
            this.Code[0x15, 1] = "\x00e1\x00ba\x00bd";
            this.Code[0x16, 1] = "\x00e1\x00ba\x00b9";
            this.Code[0x17, 1] = "\x00c3\x00aa";
            this.Code[0x18, 1] = "\x00e1\x00ba\x00bf";
            this.Code[0x19, 1] = "\x00e1\x00bb\x0081";
            this.Code[0x1a, 1] = "\x00e1\x00bbƒ";
            this.Code[0x1b, 1] = "\x00e1\x00bb…";
            this.Code[0x1c, 1] = "\x00e1\x00bb‡";
            this.Code[0x1d, 1] = "\x00c3\x00ad";
            this.Code[30, 1] = "\x00c3\x00ac";
            this.Code[0x1f, 1] = "\x00e1\x00bb‰";
            this.Code[0x20, 1] = "\x00c4\x00a9";
            this.Code[0x21, 1] = "\x00e1\x00bb‹";
            this.Code[0x22, 1] = "\x00c3\x00b3";
            this.Code[0x23, 1] = "\x00c3\x00b2";
            this.Code[0x24, 1] = "\x00e1\x00bb\x008f";
            this.Code[0x25, 1] = "\x00c3\x00b5";
            this.Code[0x26, 1] = "\x00e1\x00bb\x008d";
            this.Code[0x27, 1] = "\x00c3\x00b4";
            this.Code[40, 1] = "\x00e1\x00bb‘";
            this.Code[0x29, 1] = "\x00e1\x00bb“";
            this.Code[0x2a, 1] = "\x00e1\x00bb•";
            this.Code[0x2b, 1] = "\x00e1\x00bb—";
            this.Code[0x2c, 1] = "\x00e1\x00bb™";
            this.Code[0x2d, 1] = "\x00c6\x00a1";
            this.Code[0x2e, 1] = "\x00e1\x00bb›";
            this.Code[0x2f, 1] = "\x00e1\x00bb\x009d";
            this.Code[0x30, 1] = "\x00e1\x00bbŸ";
            this.Code[0x31, 1] = "\x00e1\x00bb\x00a1";
            this.Code[50, 1] = "\x00e1\x00bb\x00a3";
            this.Code[0x33, 1] = "\x00c3\x00ba";
            this.Code[0x34, 1] = "\x00c3\x00b9";
            this.Code[0x35, 1] = "\x00e1\x00bb\x00a7";
            this.Code[0x36, 1] = "\x00c5\x00a9";
            this.Code[0x37, 1] = "\x00e1\x00bb\x00a5";
            this.Code[0x38, 1] = "\x00c6\x00b0";
            this.Code[0x39, 1] = "\x00e1\x00bb\x00a9";
            this.Code[0x3a, 1] = "\x00e1\x00bb\x00ab";
            this.Code[0x3b, 1] = "\x00e1\x00bb\x00ad";
            this.Code[60, 1] = "\x00e1\x00bb\x00af";
            this.Code[0x3d, 1] = "\x00e1\x00bb\x00b1";
            this.Code[0x3e, 1] = "\x00c3\x00bd";
            this.Code[0x3f, 1] = "\x00e1\x00bb\x00b3";
            this.Code[0x40, 1] = "\x009d\x00e1\x00bb\x00b7".Substring(1);
            this.Code[0x41, 1] = "\x00e1\x00bb\x00b9";
            this.Code[0x42, 1] = "\x00e1\x00bb\x00b5";
            this.Code[0x43, 1] = "\x00c4‘";
            this.Code[0x44, 1] = "\x00c3\x0081";
            this.Code[0x45, 1] = "\x00c3€";
            this.Code[70, 1] = "\x00e1\x00ba\x00a2";
            this.Code[0x47, 1] = "\x00c3ƒ";
            this.Code[0x48, 1] = "\x00e1\x00ba ";
            this.Code[0x49, 1] = "\x00c4‚";
            this.Code[0x4a, 1] = "\x00e1\x00ba\x00ae";
            this.Code[0x4b, 1] = "\x00e1\x00ba\x00b0";
            this.Code[0x4c, 1] = "\x00e1\x00ba\x00b2";
            this.Code[0x4d, 1] = "\x00e1\x00ba\x00b4";
            this.Code[0x4e, 1] = "\x00e1\x00ba\x00b6";
            this.Code[0x4f, 1] = "\x00c3‚";
            this.Code[80, 1] = "\x00e1\x00ba\x00a4";
            this.Code[0x51, 1] = "\x00e1\x00ba\x00a6";
            this.Code[0x52, 1] = "\x00e1\x00ba\x00a8";
            this.Code[0x53, 1] = "\x00e1\x00ba\x00aa";
            this.Code[0x54, 1] = "\x00e1\x00ba\x00ac";
            this.Code[0x55, 1] = "\x00c3‰";
            this.Code[0x56, 1] = "\x00c3ˆ";
            this.Code[0x57, 1] = "\x00e1\x00ba\x00ba";
            this.Code[0x58, 1] = "\x00e1\x00ba\x00bc";
            this.Code[0x59, 1] = "\x00e1\x00ba\x00b8";
            this.Code[90, 1] = "\x00c3Š";
            this.Code[0x5b, 1] = "\x00e1\x00ba\x00be";
            this.Code[0x5c, 1] = "\x00e1\x00bb€";
            this.Code[0x5d, 1] = "\x00e1\x00bb‚";
            this.Code[0x5e, 1] = "\x00e1\x00bb„";
            this.Code[0x5f, 1] = "\x00e1\x00bb†";
            this.Code[0x60, 1] = "\x00c3\x008d";
            this.Code[0x61, 1] = "\x00c3Œ";
            this.Code[0x62, 1] = "\x00e1\x00bbˆ";
            this.Code[0x63, 1] = "\x00c4\x00a8";
            this.Code[100, 1] = "\x00e1\x00bbŠ";
            this.Code[0x65, 1] = "\x00c3“";
            this.Code[0x66, 1] = "\x00c3’";
            this.Code[0x67, 1] = "\x00e1\x00bbŽ";
            this.Code[0x68, 1] = "\x00c3•";
            this.Code[0x69, 1] = "\x00e1\x00bbŒ";
            this.Code[0x6a, 1] = "\x00c3”";
            this.Code[0x6b, 1] = "\x00e1\x00bb\x0090";
            this.Code[0x6c, 1] = "\x00e1\x00bb’";
            this.Code[0x6d, 1] = "\x00e1\x00bb”";
            this.Code[110, 1] = "\x00e1\x00bb–";
            this.Code[0x6f, 1] = "\x00e1\x00bb˜";
            this.Code[0x70, 1] = "\x00c6 ";
            this.Code[0x71, 1] = "\x00e1\x00bbš";
            this.Code[0x72, 1] = "\x00e1\x00bbœ";
            this.Code[0x73, 1] = "\x00e1\x00bbž";
            this.Code[0x74, 1] = "\x00e1\x00bb ";
            this.Code[0x75, 1] = "\x00e1\x00bb\x00a2";
            this.Code[0x76, 1] = "\x00c3š";
            this.Code[0x77, 1] = "\x00c3™";
            this.Code[120, 1] = "\x00e1\x00bb\x00a6";
            this.Code[0x79, 1] = "\x00c5\x00a8";
            this.Code[0x7a, 1] = "\x00e1\x00bb\x00a4";
            this.Code[0x7b, 1] = "\x00c6\x00af";
            this.Code[0x7c, 1] = "\x00e1\x00bb\x00a8";
            this.Code[0x7d, 1] = "\x00e1\x00bb\x00aa";
            this.Code[0x7e, 1] = "\x00e1\x00bb\x00ac";
            this.Code[0x7f, 1] = "\x00e1\x00bb\x00ae";
            this.Code[0x80, 1] = "\x00e1\x00bb\x00b0";
            this.Code[0x81, 1] = "\x00c3\x009d";
            this.Code[130, 1] = "\x00e1\x00bb\x00b2";
            this.Code[0x83, 1] = "\x00e1\x00bb\x00b6";
            this.Code[0x84, 1] = "\x00e1\x00bb\x00b8";
            this.Code[0x85, 1] = "\x00e1\x00bb\x00b4";
            this.Code[0x86, 1] = "\x00c4\x0090";
        }

        private void MapUTH()
        {
            this.Code[1, 4] = "á";
            this.Code[2, 4] = "à";
            this.Code[3, 4] = "ả";
            this.Code[4, 4] = "ã";
            this.Code[5, 4] = "ạ";
            this.Code[6, 4] = "ă";
            this.Code[7, 4] = "ắ";
            this.Code[8, 4] = "ằ";
            this.Code[9, 4] = "ẳ";
            this.Code[10, 4] = "ẵ";
            this.Code[11, 4] = "ặ";
            this.Code[12, 4] = "\x00e2";
            this.Code[13, 4] = "\x00e2́";
            this.Code[14, 4] = "\x00e2̀";
            this.Code[15, 4] = "\x00e2̉";
            this.Code[0x10, 4] = "\x00e2̃";
            this.Code[0x11, 4] = "\x00e2̣";
            this.Code[0x12, 4] = "é";
            this.Code[0x13, 4] = "è";
            this.Code[20, 4] = "ẻ";
            this.Code[0x15, 4] = "ẽ";
            this.Code[0x16, 4] = "ẹ";
            this.Code[0x17, 4] = "\x00ea";
            this.Code[0x18, 4] = "\x00eá";
            this.Code[0x19, 4] = "\x00eà";
            this.Code[0x1a, 4] = "\x00eả";
            this.Code[0x1b, 4] = "\x00eã";
            this.Code[0x1c, 4] = "\x00eạ";
            this.Code[0x1d, 4] = "í";
            this.Code[30, 4] = "ì";
            this.Code[0x1f, 4] = "ỉ";
            this.Code[0x20, 4] = "ĩ";
            this.Code[0x21, 4] = "ị";
            this.Code[0x22, 4] = "ó";
            this.Code[0x23, 4] = "ò";
            this.Code[0x24, 4] = "ỏ";
            this.Code[0x25, 4] = "õ";
            this.Code[0x26, 4] = "ọ";
            this.Code[0x27, 4] = "\x00f4";
            this.Code[40, 4] = "\x00f4́";
            this.Code[0x29, 4] = "\x00f4̀";
            this.Code[0x2a, 4] = "\x00f4̉";
            this.Code[0x2b, 4] = "\x00f4̃";
            this.Code[0x2c, 4] = "\x00f4̣";
            this.Code[0x2d, 4] = "ơ";
            this.Code[0x2e, 4] = "ớ";
            this.Code[0x2f, 4] = "ờ";
            this.Code[0x30, 4] = "ở";
            this.Code[0x31, 4] = "ỡ";
            this.Code[50, 4] = "ợ";
            this.Code[0x33, 4] = "ú";
            this.Code[0x34, 4] = "ù";
            this.Code[0x35, 4] = "ủ";
            this.Code[0x36, 4] = "ũ";
            this.Code[0x37, 4] = "ụ";
            this.Code[0x38, 4] = "ư";
            this.Code[0x39, 4] = "ứ";
            this.Code[0x3a, 4] = "ừ";
            this.Code[0x3b, 4] = "ử";
            this.Code[60, 4] = "ữ";
            this.Code[0x3d, 4] = "ự";
            this.Code[0x3e, 4] = "ý";
            this.Code[0x3f, 4] = "ỳ";
            this.Code[0x40, 4] = "ỷ";
            this.Code[0x41, 4] = "ỹ";
            this.Code[0x42, 4] = "ỵ";
            this.Code[0x43, 4] = "đ";
            this.Code[0x44, 4] = "Á";
            this.Code[0x45, 4] = "À";
            this.Code[70, 4] = "Ả";
            this.Code[0x47, 4] = "Ã";
            this.Code[0x48, 4] = "Ạ";
            this.Code[0x49, 4] = "Ă";
            this.Code[0x4a, 4] = "Ắ";
            this.Code[0x4b, 4] = "Ằ";
            this.Code[0x4c, 4] = "Ẳ";
            this.Code[0x4d, 4] = "Ẵ";
            this.Code[0x4e, 4] = "Ặ";
            this.Code[0x4f, 4] = "\x00c2";
            this.Code[80, 4] = "\x00c2́";
            this.Code[0x51, 4] = "\x00c2̀";
            this.Code[0x52, 4] = "\x00c2̉";
            this.Code[0x53, 4] = "\x00c2̃";
            this.Code[0x54, 4] = "\x00c2̣";
            this.Code[0x55, 4] = "É";
            this.Code[0x56, 4] = "È";
            this.Code[0x57, 4] = "Ẻ";
            this.Code[0x58, 4] = "Ẽ";
            this.Code[0x59, 4] = "Ẹ";
            this.Code[90, 4] = "\x00ca";
            this.Code[0x5b, 4] = "\x00cá";
            this.Code[0x5c, 4] = "\x00cà";
            this.Code[0x5d, 4] = "\x00cả";
            this.Code[0x5e, 4] = "\x00cã";
            this.Code[0x5f, 4] = "\x00cạ";
            this.Code[0x60, 4] = "Í";
            this.Code[0x61, 4] = "Ì";
            this.Code[0x62, 4] = "Ỉ";
            this.Code[0x63, 4] = "Ĩ";
            this.Code[100, 4] = "Ị";
            this.Code[0x65, 4] = "Ó";
            this.Code[0x66, 4] = "Ò";
            this.Code[0x67, 4] = "Ỏ";
            this.Code[0x68, 4] = "Õ";
            this.Code[0x69, 4] = "Ọ";
            this.Code[0x6a, 4] = "\x00d4";
            this.Code[0x6b, 4] = "\x00d4́";
            this.Code[0x6c, 4] = "\x00d4̀";
            this.Code[0x6d, 4] = "\x00d4̉";
            this.Code[110, 4] = "\x00d4̃";
            this.Code[0x6f, 4] = "\x00d4̣";
            this.Code[0x70, 4] = "Ơ";
            this.Code[0x71, 4] = "Ớ";
            this.Code[0x72, 4] = "Ờ";
            this.Code[0x73, 4] = "Ở";
            this.Code[0x74, 4] = "Ỡ";
            this.Code[0x75, 4] = "Ợ";
            this.Code[0x76, 4] = "Ú";
            this.Code[0x77, 4] = "Ù";
            this.Code[120, 4] = "Ủ";
            this.Code[0x79, 4] = "Ũ";
            this.Code[0x7a, 4] = "Ụ";
            this.Code[0x7b, 4] = "Ư";
            this.Code[0x7c, 4] = "Ứ";
            this.Code[0x7d, 4] = "Ừ";
            this.Code[0x7e, 4] = "Ử";
            this.Code[0x7f, 4] = "Ữ";
            this.Code[0x80, 4] = "Ự";
            this.Code[0x81, 4] = "Ý";
            this.Code[130, 4] = "Ỳ";
            this.Code[0x83, 4] = "Ỷ";
            this.Code[0x84, 4] = "Ỹ";
            this.Code[0x85, 4] = "Ỵ";
            this.Code[0x86, 4] = "Đ";
        }

        private void MapVIQR()
        {
            this.Code[1, 7] = "a'";
            this.Code[2, 7] = "a`";
            this.Code[3, 7] = "a?";
            this.Code[4, 7] = "a~";
            this.Code[5, 7] = "a.";
            this.Code[6, 7] = "a(";
            this.Code[7, 7] = "a('";
            this.Code[8, 7] = "a(`";
            this.Code[9, 7] = "a(?";
            this.Code[10, 7] = "a(~";
            this.Code[11, 7] = "a(.";
            this.Code[12, 7] = "a^";
            this.Code[13, 7] = "a^'";
            this.Code[14, 7] = "a^`";
            this.Code[15, 7] = "a^?";
            this.Code[0x10, 7] = "a^~";
            this.Code[0x11, 7] = "a^.";
            this.Code[0x12, 7] = "e'";
            this.Code[0x13, 7] = "e`";
            this.Code[20, 7] = "e?";
            this.Code[0x15, 7] = "e~";
            this.Code[0x16, 7] = "e.";
            this.Code[0x17, 7] = "e^";
            this.Code[0x18, 7] = "e^'";
            this.Code[0x19, 7] = "e^`";
            this.Code[0x1a, 7] = "e^?";
            this.Code[0x1b, 7] = "e^~";
            this.Code[0x1c, 7] = "e^.";
            this.Code[0x1d, 7] = "i'";
            this.Code[30, 7] = "i`";
            this.Code[0x1f, 7] = "i?";
            this.Code[0x20, 7] = "i~";
            this.Code[0x21, 7] = "i.";
            this.Code[0x22, 7] = "o'";
            this.Code[0x23, 7] = "o`";
            this.Code[0x24, 7] = "o?";
            this.Code[0x25, 7] = "o~";
            this.Code[0x26, 7] = "o.";
            this.Code[0x27, 7] = "o^";
            this.Code[40, 7] = "o^'";
            this.Code[0x29, 7] = "o^`";
            this.Code[0x2a, 7] = "o^?";
            this.Code[0x2b, 7] = "o^~";
            this.Code[0x2c, 7] = "o^.";
            this.Code[0x2d, 7] = "o+";
            this.Code[0x2e, 7] = "o+'";
            this.Code[0x2f, 7] = "o+`";
            this.Code[0x30, 7] = "o+?";
            this.Code[0x31, 7] = "o+~";
            this.Code[50, 7] = "o+.";
            this.Code[0x33, 7] = "u'";
            this.Code[0x34, 7] = "u`";
            this.Code[0x35, 7] = "u?";
            this.Code[0x36, 7] = "u~";
            this.Code[0x37, 7] = "u.";
            this.Code[0x38, 7] = "u+";
            this.Code[0x39, 7] = "u+'";
            this.Code[0x3a, 7] = "u+`";
            this.Code[0x3b, 7] = "u+?";
            this.Code[60, 7] = "u+~";
            this.Code[0x3d, 7] = "u+.";
            this.Code[0x3e, 7] = "y'";
            this.Code[0x3f, 7] = "y`";
            this.Code[0x40, 7] = "y?";
            this.Code[0x41, 7] = "y~";
            this.Code[0x42, 7] = "y.";
            this.Code[0x43, 7] = "dd";
            this.Code[0x44, 7] = "A'";
            this.Code[0x45, 7] = "A`";
            this.Code[70, 7] = "A?";
            this.Code[0x47, 7] = "A~";
            this.Code[0x48, 7] = "A.";
            this.Code[0x49, 7] = "A(";
            this.Code[0x4a, 7] = "A('";
            this.Code[0x4b, 7] = "A(`";
            this.Code[0x4c, 7] = "A(?";
            this.Code[0x4d, 7] = "A(~";
            this.Code[0x4e, 7] = "A(.";
            this.Code[0x4f, 7] = "A^";
            this.Code[80, 7] = "A^'";
            this.Code[0x51, 7] = "A^`";
            this.Code[0x52, 7] = "A^?";
            this.Code[0x53, 7] = "A^~";
            this.Code[0x54, 7] = "A^.";
            this.Code[0x55, 7] = "E'";
            this.Code[0x56, 7] = "E`";
            this.Code[0x57, 7] = "E?";
            this.Code[0x58, 7] = "E~";
            this.Code[0x59, 7] = "E.";
            this.Code[90, 7] = "E^";
            this.Code[0x5b, 7] = "E^'";
            this.Code[0x5c, 7] = "E^`";
            this.Code[0x5d, 7] = "E^?";
            this.Code[0x5e, 7] = "E^~";
            this.Code[0x5f, 7] = "E^.";
            this.Code[0x60, 7] = "I'";
            this.Code[0x61, 7] = "I`";
            this.Code[0x62, 7] = "I?";
            this.Code[0x63, 7] = "I~";
            this.Code[100, 7] = "I.";
            this.Code[0x65, 7] = "O'";
            this.Code[0x66, 7] = "O`";
            this.Code[0x67, 7] = "O?";
            this.Code[0x68, 7] = "O~";
            this.Code[0x69, 7] = "O.";
            this.Code[0x6a, 7] = "O^";
            this.Code[0x6b, 7] = "O^'";
            this.Code[0x6c, 7] = "O^`";
            this.Code[0x6d, 7] = "O^?";
            this.Code[110, 7] = "O^~";
            this.Code[0x6f, 7] = "O^.";
            this.Code[0x70, 7] = "O+";
            this.Code[0x71, 7] = "O+'";
            this.Code[0x72, 7] = "O+`";
            this.Code[0x73, 7] = "O+?";
            this.Code[0x74, 7] = "O+~";
            this.Code[0x75, 7] = "O+.";
            this.Code[0x76, 7] = "U'";
            this.Code[0x77, 7] = "U`";
            this.Code[120, 7] = "U?";
            this.Code[0x79, 7] = "U~";
            this.Code[0x7a, 7] = "U.";
            this.Code[0x7b, 7] = "U+";
            this.Code[0x7c, 7] = "U+'";
            this.Code[0x7d, 7] = "U+`";
            this.Code[0x7e, 7] = "U+?";
            this.Code[0x7f, 7] = "U+~";
            this.Code[0x80, 7] = "U+.";
            this.Code[0x81, 7] = "Y'";
            this.Code[130, 7] = "Y`";
            this.Code[0x83, 7] = "Y?";
            this.Code[0x84, 7] = "Y~";
            this.Code[0x85, 7] = "Y.";
            this.Code[0x86, 7] = "DD";
        }

        private void MapVNI()
        {
            this.Code[1, 3] = "a\x00f9";
            this.Code[2, 3] = "a\x00f8";
            this.Code[3, 3] = "a\x00fb";
            this.Code[4, 3] = "a\x00f5";
            this.Code[5, 3] = "a\x00ef";
            this.Code[6, 3] = "a\x00ea";
            this.Code[7, 3] = "a\x00e9";
            this.Code[8, 3] = "a\x00e8";
            this.Code[9, 3] = "a\x00fa";
            this.Code[10, 3] = "a\x00fc";
            this.Code[11, 3] = "a\x00eb";
            this.Code[12, 3] = "a\x00e2";
            this.Code[13, 3] = "a\x00e1";
            this.Code[14, 3] = "a\x00e0";
            this.Code[15, 3] = "a\x00e5";
            this.Code[0x10, 3] = "a\x00e3";
            this.Code[0x11, 3] = "a\x00e4";
            this.Code[0x12, 3] = "e\x00f9";
            this.Code[0x13, 3] = "e\x00f8";
            this.Code[20, 3] = "e\x00fb";
            this.Code[0x15, 3] = "e\x00f5";
            this.Code[0x16, 3] = "e\x00ef";
            this.Code[0x17, 3] = "e\x00e2";
            this.Code[0x18, 3] = "e\x00e1";
            this.Code[0x19, 3] = "e\x00e0";
            this.Code[0x1a, 3] = "e\x00e5";
            this.Code[0x1b, 3] = "e\x00e3";
            this.Code[0x1c, 3] = "e\x00e4";
            this.Code[0x1d, 3] = "\x00ed";
            this.Code[30, 3] = "\x00ec";
            this.Code[0x1f, 3] = "\x00e6";
            this.Code[0x20, 3] = "\x00f3";
            this.Code[0x21, 3] = "\x00f2";
            this.Code[0x22, 3] = "o\x00f9";
            this.Code[0x23, 3] = "o\x00f8";
            this.Code[0x24, 3] = "o\x00fb";
            this.Code[0x25, 3] = "o\x00f5";
            this.Code[0x26, 3] = "o\x00ef";
            this.Code[0x27, 3] = "o\x00e2";
            this.Code[40, 3] = "o\x00e1";
            this.Code[0x29, 3] = "o\x00e0";
            this.Code[0x2a, 3] = "o\x00e5";
            this.Code[0x2b, 3] = "o\x00e3";
            this.Code[0x2c, 3] = "o\x00e4";
            this.Code[0x2d, 3] = "\x00f4";
            this.Code[0x2e, 3] = "\x00f4\x00f9";
            this.Code[0x2f, 3] = "\x00f4\x00f8";
            this.Code[0x30, 3] = "\x00f4\x00fb";
            this.Code[0x31, 3] = "\x00f4\x00f5";
            this.Code[50, 3] = "\x00f4\x00ef";
            this.Code[0x33, 3] = "u\x00f9";
            this.Code[0x34, 3] = "u\x00f8";
            this.Code[0x35, 3] = "u\x00fb";
            this.Code[0x36, 3] = "u\x00f5";
            this.Code[0x37, 3] = "u\x00ef";
            this.Code[0x38, 3] = "\x00f6";
            this.Code[0x39, 3] = "\x00f6\x00f9";
            this.Code[0x3a, 3] = "\x00f6\x00f8";
            this.Code[0x3b, 3] = "\x00f6\x00fb";
            this.Code[60, 3] = "\x00f6\x00f5";
            this.Code[0x3d, 3] = "\x00f6\x00ef";
            this.Code[0x3e, 3] = "y\x00f9";
            this.Code[0x3f, 3] = "y\x00f8";
            this.Code[0x40, 3] = "y\x00fb";
            this.Code[0x41, 3] = "y\x00f5";
            this.Code[0x42, 3] = "\x00ee";
            this.Code[0x43, 3] = "\x00f1";
            this.Code[0x44, 3] = "A\x00d9";
            this.Code[0x45, 3] = "A\x00d8";
            this.Code[70, 3] = "A\x00db";
            this.Code[0x47, 3] = "A\x00d5";
            this.Code[0x48, 3] = "A\x00cf";
            this.Code[0x49, 3] = "A\x00ca";
            this.Code[0x4a, 3] = "A\x00c9";
            this.Code[0x4b, 3] = "A\x00c8";
            this.Code[0x4c, 3] = "A\x00da";
            this.Code[0x4d, 3] = "A\x00dc";
            this.Code[0x4e, 3] = "A\x00cb";
            this.Code[0x4f, 3] = "A\x00c2";
            this.Code[80, 3] = "A\x00c1";
            this.Code[0x51, 3] = "A\x00c0";
            this.Code[0x52, 3] = "A\x00c5";
            this.Code[0x53, 3] = "A\x00c3";
            this.Code[0x54, 3] = "A\x00c4";
            this.Code[0x55, 3] = "E\x00d9";
            this.Code[0x56, 3] = "E\x00d8";
            this.Code[0x57, 3] = "E\x00db";
            this.Code[0x58, 3] = "E\x00d5";
            this.Code[0x59, 3] = "E\x00cf";
            this.Code[90, 3] = "E\x00c2";
            this.Code[0x5b, 3] = "E\x00c1";
            this.Code[0x5c, 3] = "E\x00c0";
            this.Code[0x5d, 3] = "E\x00c5";
            this.Code[0x5e, 3] = "E\x00c3";
            this.Code[0x5f, 3] = "E\x00c4";
            this.Code[0x60, 3] = "\x00cd";
            this.Code[0x61, 3] = "\x00cc";
            this.Code[0x62, 3] = "\x00c6";
            this.Code[0x63, 3] = "\x00d3";
            this.Code[100, 3] = "\x00d2";
            this.Code[0x65, 3] = "O\x00d9";
            this.Code[0x66, 3] = "O\x00d8";
            this.Code[0x67, 3] = "O\x00db";
            this.Code[0x68, 3] = "O\x00d5";
            this.Code[0x69, 3] = "O\x00cf";
            this.Code[0x6a, 3] = "O\x00c2";
            this.Code[0x6b, 3] = "O\x00c1";
            this.Code[0x6c, 3] = "O\x00c0";
            this.Code[0x6d, 3] = "O\x00c5";
            this.Code[110, 3] = "O\x00c3";
            this.Code[0x6f, 3] = "O\x00c4";
            this.Code[0x70, 3] = "\x00d4";
            this.Code[0x71, 3] = "\x00d4\x00d9";
            this.Code[0x72, 3] = "\x00d4\x00d8";
            this.Code[0x73, 3] = "\x00d4\x00db";
            this.Code[0x74, 3] = "\x00d4\x00d5";
            this.Code[0x75, 3] = "\x00d4\x00cf";
            this.Code[0x76, 3] = "U\x00d9";
            this.Code[0x77, 3] = "U\x00d8";
            this.Code[120, 3] = "U\x00db";
            this.Code[0x79, 3] = "U\x00d5";
            this.Code[0x7a, 3] = "U\x00cf";
            this.Code[0x7b, 3] = "\x00d6";
            this.Code[0x7c, 3] = "\x00d6\x00d9";
            this.Code[0x7d, 3] = "\x00d6\x00d8";
            this.Code[0x7e, 3] = "\x00d6\x00db";
            this.Code[0x7f, 3] = "\x00d6\x00d5";
            this.Code[0x80, 3] = "\x00d6\x00cf";
            this.Code[0x81, 3] = "Y\x00d9";
            this.Code[130, 3] = "Y\x00d8";
            this.Code[0x83, 3] = "Y\x00db";
            this.Code[0x84, 3] = "Y\x00d5";
            this.Code[0x85, 3] = "\x00ce";
            this.Code[0x86, 3] = "\x00d1";
        }
    }
}
