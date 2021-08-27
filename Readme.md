<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128614102/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5178)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DiscountFunction.cs](./CS/UDF_Discount/DiscountFunction.cs) (VB: [DiscountFunction.vb](./VB/UDF_Discount/DiscountFunction.vb))
* [Form1.cs](./CS/UDF_Discount/Form1.cs) (VB: [Form1.vb](./VB/UDF_Discount/Form1.vb))
* [Program.cs](./CS/UDF_Discount/Program.cs) (VB: [Program.vb](./VB/UDF_Discount/Program.vb))
<!-- default file list end -->
# UDF (Custom Function) - How to replace Excel XLL Add-in UDF with a custom function


<p>This example defines a custom worksheet function named <strong>Discount</strong><strong> </strong>and adds it to the collection of worksheet functions in the SpreadsheetControl. The SpreadsheetControl loads a document with formulas which reference the Discount function defined in the external Excel XLL Add-in.  After loading the document,  function names in formulas are corrected to remove the "_xll.DiscountXLL.MyFunctions." name prefix, leaving only the function name <strong>Discount</strong>. Finally the worksheet formulas are calculated using the custom <strong>Discount</strong> function defined in this example.</p>

<br/>


