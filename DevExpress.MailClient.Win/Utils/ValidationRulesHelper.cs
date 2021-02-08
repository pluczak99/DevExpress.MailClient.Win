using DevExpress.XtraEditors.DXErrorProvider;

namespace DevExpress.MailClient.Win
{
	public class ValidationRulesHelper {
        static ConditionValidationRule ruleIsNotBlank = null;
        public static ConditionValidationRule RuleIsNotBlank {
            get {
                if(ruleIsNotBlank == null) {
                    ruleIsNotBlank = new ConditionValidationRule();
                    ruleIsNotBlank.ConditionOperator = ConditionOperator.IsNotBlank;
                    ruleIsNotBlank.ErrorText = Properties.Resources.RuleIsNotBlankWarning;
                    ruleIsNotBlank.ErrorType = ErrorType.Critical;
                }
                return ruleIsNotBlank;
            }
        }
    }
}
