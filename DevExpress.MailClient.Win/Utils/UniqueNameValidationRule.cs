using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;

namespace DevExpress.MailClient.Win
{
	public class UniqueNameValidationRule : ValidationRule {
        List<string> values;
        public UniqueNameValidationRule(List<string> values) {
            this.values = values;
        }
        public override bool Validate(Control control, object value) {
            string str = (string)value;
            foreach(string val in values)
                if(!ValidationHelper.Validate(str, ConditionOperator.NotEquals, val, null, null, false))
                    return false;
            return true;
        }
    }
}
