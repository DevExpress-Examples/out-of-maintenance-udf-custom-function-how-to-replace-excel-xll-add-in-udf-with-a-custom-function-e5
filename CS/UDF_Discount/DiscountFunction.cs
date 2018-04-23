using DevExpress.Spreadsheet.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDF_Discount
{
    #region #DiscountFunction
    // Inheritance from Object is required for correct automatic VB.NET conversion
    public class DiscountFunction : Object, ICustomFunction
    {
        const string functionName = "Discount";
        readonly ParameterInfo[] functionParameters;

        public DiscountFunction()
        {
            this.functionParameters = new ParameterInfo[] { new ParameterInfo(ParameterType.Value, ParameterAttributes.Required), 
            new ParameterInfo(ParameterType.Value, ParameterAttributes.Required)};
        }

        public string Name { get { return functionName; } }
        ParameterInfo[] IFunction.Parameters { get { return functionParameters; } }
        ParameterType IFunction.ReturnType { get { return ParameterType.Value; } }
        // Reevaluate cells on every recalculation. 
        // The SpreadsheetControl ignores this value and assumes that the Volatile is always true.
        bool IFunction.Volatile { get { return true; } }

        ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
        {
            double quantity;
            double price;
            ParameterValue quantityParameter;
            ParameterValue priceParameter;

            quantityParameter = parameters[0];
            if (quantityParameter.IsError)
                return quantityParameter;
                else
                quantity = quantityParameter.NumericValue;

            priceParameter = parameters[1];
            if (priceParameter.IsError)
                return priceParameter;
            else
                price = priceParameter.NumericValue;

            if (quantity >= 50) return Math.Round(quantity * price * 0.25, 2);
            if (quantity >= 20) return Math.Round(quantity * price * 0.1, 2);
            return 0;

        }
        string IFunction.GetName(System.Globalization.CultureInfo culture)
        {
            return functionName;
        }
    }
    #endregion #DiscountFunction


}
