using System.Collections.Generic;
using System.Windows.Forms;

// How To create array of objects:
// Checkbox[] cbox = new Checkbox[100];
namespace iTool.Winform
{
    public class iCheckbox
    {
        /// <summary>
        /// Note 1: Select only one check box at a time. Note: it must be put in the Click event. | 
        /// Note 2: The auto check must be set to false.
        /// </summary>
        /// <param name="checkbox"></param>
        /// <param name="checkboxToBeTrue"></param>
        public static void Uniquify(ref CheckBox[] checkboxes, ref CheckBox checkboxToBeTrue)
        {
            foreach (var cb in checkboxes)
                if (cb != checkboxToBeTrue)
                    if (cb.AutoCheck)
                    {
                        cb.AutoCheck = false;
                        cb.Checked = false;
                    }
                    else
                        cb.Checked = false;
            
            if (checkboxToBeTrue.AutoCheck)
                checkboxToBeTrue.AutoCheck = false;
            checkboxToBeTrue.Checked = true;
        }
        /// <summary>
        /// Note 1: Select only one check box at a time. Note: it must be put in the Click event. | 
        /// Note 2: The auto check must be set to false.
        /// </summary>
        /// <param name="checkbox"></param>
        /// <param name="checkboxToBeTrue"></param>
        public static void Uniquify(ref List<CheckBox> checkBoxes, ref CheckBox checkboxToBeTrue)
        {
            foreach (var cb in checkBoxes)
                if (cb != checkboxToBeTrue)
                    if (cb.AutoCheck)
                    {
                        cb.AutoCheck = false;
                        cb.Checked = false;
                    }
                    else
                        cb.Checked = false;

            if (checkboxToBeTrue.AutoCheck)
                checkboxToBeTrue.AutoCheck = false;
            checkboxToBeTrue.Checked = true;
        }
    }
}
