using System.Collections.Generic;
using Catel.Data;
using Catel.MVVM;

namespace ChildViewModelValidation;

internal class ChildViewModel: ViewModelBase
{
    public ChildViewModel(MyModel item)
    {
        HideValidationResults = false; // all validation-errors are immediately exposed to the UI 
        Item = item;
    }
    
    [Model]
    public MyModel Item { get; private set; }

    protected override void ValidateBusinessRules(List<IBusinessRuleValidationResult> validationResults)
    {
        validationResults.Add(BusinessRuleValidationResult.CreateError($"{Item.Guid} is invalid, please remove it"));
    }

}