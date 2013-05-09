using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EVSoft.HRMSLicense
{
    public partial class SerialBox : UserControl
    {
        private TextBox[] _Boxes = new TextBox[5];

        #region -> Behavior
        /// <summary>
        /// The text is Readonly
        /// </summary>
        [Category("Behavior"), DefaultValue(false),
            Description("The text is Readonly")]
        public bool ReadOnly
        {
            get
            {
                return _Boxes[0].ReadOnly;
            }
            set
            {
                foreach (TextBox FT in _Boxes)
                    FT.ReadOnly = value;
            }
        }

        #endregion

        public SerialBox()
        {
            InitializeComponent();
            // Set Array of boxes for easier working
            _Boxes[0] = textBox1;
            _Boxes[1] = textBox2;
            _Boxes[2] = textBox3;
            _Boxes[3] = textBox4;
            _Boxes[4] = textBox5;
        }

        #region -> Events

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.SelectAll();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Trim().Length == 5)
                SendKeys.Send("{TAB}");
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        #endregion

        #region -> Overrides

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text + "-" + textBox4.Text + "-" + textBox5.Text;
            }
            set
            {
                try
                {
                    textBox1.TextChanged -= new EventHandler(TextBox_TextChanged);
                    textBox2.TextChanged -= new EventHandler(TextBox_TextChanged);
                    textBox3.TextChanged -= new EventHandler(TextBox_TextChanged);
                    textBox4.TextChanged -= new EventHandler(TextBox_TextChanged);
                    ClearBoxes();
                    textBox1.Text = value.Split(new char[] {'-'})[0].ToUpper();
                    textBox2.Text = value.Split(new char[] {'-'})[1].ToUpper();
                    textBox3.Text = value.Split(new char[] {'-'})[2].ToUpper();
                    textBox4.Text = value.Split(new char[] {'-'})[3].ToUpper();
                    textBox5.Text = value.Split(new char[] {'-'})[4].ToUpper();

                    textBox1.TextChanged += new EventHandler(TextBox_TextChanged);
                    textBox2.TextChanged += new EventHandler(TextBox_TextChanged);
                    textBox3.TextChanged += new EventHandler(TextBox_TextChanged);
                    textBox4.TextChanged += new EventHandler(TextBox_TextChanged);
                }
                catch( Exception ex)
                {
                }
            }
        }

        #endregion

        public void ClearBoxes()
        {
            foreach (TextBox txt in _Boxes)
                txt.Text = string.Empty;
        }

        public void FocusBox()
        {
            textBox1.Focus();
        }
    }
}
