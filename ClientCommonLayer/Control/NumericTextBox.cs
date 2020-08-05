using System;
using System.Windows.Forms;

public class NumericTextBox : TextBox
{
    bool allowSpace = false;
    bool allowDecimalSeparator = true;
    bool allowGroupSeparator = false;
    bool allowNegativeSign = false;
    bool allowValidationChecked = true;
    bool isValid = true;
    bool IsThereDecimalSeparator = false;
    readonly bool IsThereNegativeSign = false;

    int decimalLength = 0;

    // Restricts the entry of characters to digits (including hex), the negative sign,
    // the decimal point, and editing keystrokes (backspace).
    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);

        System.Globalization.NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
        string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
        string groupSeparator = numberFormatInfo.NumberGroupSeparator;
        string negativeSign = numberFormatInfo.NegativeSign;

        string keyInput = e.KeyChar.ToString();

        if (Char.IsDigit(e.KeyChar))
        {
            // Digits are OK
            if (allowDecimalSeparator == true)
            {
                if (this.Text.Split('.').Length == 2)
                {
                    int iLength = this.Text.Split('.').GetValue(0).ToString().Length;
                    int dLength = this.Text.Split('.').GetValue(1).ToString().Length;
                    if ((iLength == (this.MaxLength - this.DecimalLength - 1)) || (dLength == this.DecimalLength) ||
                        ((dLength == this.DecimalLength) &&
                        (iLength == (this.MaxLength - this.DecimalLength - 1)) && (this.SelectionLength != this.MaxLength)))
                        e.Handled = true;
                }
                else if ((this.Text.Length == (this.MaxLength - this.DecimalLength - 1)) && (this.SelectionLength != this.Text.Length))
                    e.Handled = true;
            }
        }
        else if ((!(this.IsThereDecimalSeparator) && this.allowDecimalSeparator && keyInput.Equals(decimalSeparator)) ||
                 (this.allowGroupSeparator && keyInput.Equals(groupSeparator)) ||
                ((!(this.IsThereNegativeSign) && this.allowNegativeSign && keyInput.Equals(negativeSign))))
        {
            // Decimal separator is OK
        }
        else if ((e.KeyChar == '\b') || (this.allowSpace && e.KeyChar == ' '))
        {
            // Backspace key is OK
        }
        else if (e.KeyChar == (char)Keys.Return)
        {
            return;
        }
        else
            e.Handled = true;
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);

        if (this.Text.IndexOf('.') == -1)
            IsThereDecimalSeparator = false;
        else
            IsThereDecimalSeparator = true;
    }

    protected override void OnValidated(EventArgs e)
    {
        DoValidating();
        base.OnValidated(e);
    }

    public int IntValue
    {
        get
        {
            if (this.Text == string.Empty)
                return (0);
            else
            {
                if (allowDecimalSeparator == true)
                {
                    if (this.Text.Split('.').Length == 2)
                    {
                        string strIntValue = this.Text.Split('.').GetValue(0).ToString();
                        return ((strIntValue == string.Empty) ? 0 : Int32.Parse(strIntValue));
                    }
                }
                return (Int32.Parse(this.Text));
            }
        }
    }

    public int DecimalValue
    {
        get
        {
            if (this.Text == string.Empty)
                return (0);
            else
            {
                if (allowDecimalSeparator == true)
                {
                    if (this.Text.Split('.').Length == 2)
                    {
                        string strDecimalValue = this.Text.Split('.').GetValue(1).ToString();
                        return ((strDecimalValue == string.Empty) ? 0 : Int32.Parse(strDecimalValue));
                    }
                }
                return (0);
            }
        }
    }

    #region Properties

    public bool AllowSpace
    {
        set
        {
            this.allowSpace = value;
        }

        get
        {
            return this.allowSpace;
        }
    }

    public bool AllowDecimalSeparator
    {
        set
        {
            this.allowDecimalSeparator = value;
        }

        get
        {
            return this.allowDecimalSeparator;
        }
    }

    public bool AllowGroupSeparator
    {
        set
        {
            this.allowGroupSeparator = value;
        }

        get
        {
            return this.allowGroupSeparator;
        }
    }

    public bool AllowNegativeSign
    {
        set
        {
            this.allowNegativeSign = value;
        }

        get
        {
            return this.allowNegativeSign;
        }
    }

    public int DecimalLength
    {
        set
        {
            this.decimalLength = value;
        }
        get
        {
            return this.decimalLength;
        }
    }

    public bool ValidationChecked
    {
        set
        {
            this.allowValidationChecked = value;
        }
        get
        {
            return this.allowValidationChecked;
        }
    }

    public bool IsValid
    {
        get
        {
            return this.isValid;
        }
    }

    private void DoValidating()
    {
        this.isValid = true;
        if (this.Text != string.Empty)
        {
            if (this.Text.IndexOf('.') >= 0)
            {
                if (this.Text == ".")
                    this.Text = "0";
                else
                    this.Text = Convert.ToSingle(this.Text).ToString();
            }
        }
        if ((allowDecimalSeparator == true) && (allowValidationChecked == true))
        {
            if (this.Text.Split('.').Length == 2)
            {
                int iLength = this.Text.Split('.').GetValue(0).ToString().Length;
                int dLength = this.Text.Split('.').GetValue(1).ToString().Length;
                if (iLength > (this.MaxLength - this.DecimalLength - 1))
                {
                    this.Select(0, iLength);
                    this.isValid = false;
                    this.Focus();
                }
                else if (dLength > this.DecimalLength)
                {
                    this.Select(iLength + 1, dLength);
                    this.isValid = false;
                    this.Focus();
                }
            }
        }
    }
    #endregion
}
