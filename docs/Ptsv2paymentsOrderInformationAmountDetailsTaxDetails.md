# CyberSource.Model.Ptsv2paymentsOrderInformationAmountDetailsTaxDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | This is used to determine what type of tax related data should be inclued under _taxDetails_ object.  Possible values:  - alternate  - local  - national  - vat  | [optional] 
**Amount** | **string** | Please see below table for related decription based on above _type_ field.  | type      | type description | |- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -| | alternate | Total amount of alternate tax for the order. | | local     | Sales tax for the order. | | national  | National tax for the order. | | vat       | Total amount of VAT or other tax included in the order. | | other     | Other tax. |  | [optional] 
**Rate** | **string** | Rate of VAT or other tax for the order.  Example 0.040 (&#x3D;4%)  Valid range: 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional decimal places will be truncated)  | [optional] 
**Code** | **string** | Type of tax being applied to the item. Possible values:  Below values are used by **RBS WorldPay Atlanta**, **FDC Nashville Global**, **Litle**   - 0000: unknown tax type  - 0001: federal/national sales tax  - 0002: state sales tax  - 0003: city sales tax  - 0004: local sales tax  - 0005: municipal sales tax  - 0006: other tax  - 0010: value-added tax (VAT)  - 0011: goods and services tax (GST)  - 0012: provincial sales tax  - 0013: harmonized sales tax  - 0014: Quebec sales tax (QST)  - 0020: room tax  - 0021: occupancy tax  - 0022: energy tax  - 0023: city tax  - 0024: county or parish sales tax  - 0025: county tax  - 0026: environment tax  - 0027: state and local sales tax (combined)  - Blank: Tax not supported on line item.  | [optional] 
**TaxId** | **string** | Your tax ID number to use for the alternate tax amount. Required if you set alternate tax amount to any value, including zero. You may send this field without sending alternate tax amount.  | [optional] 
**Applied** | **bool?** | The tax is applied. Valid value is &#x60;true&#x60; or &#x60;false&#x60;. | [optional] 
**ExemptionCode** | **string** | Code for exemption from sales and use tax. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor.  For possible values, see Exemption Status Values. See Numbered Elements.  Important For information about using this field, see Item-Level Tax Fields.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

