# CyberSource.Model.Ptsv2paymentsClientReferenceInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Client-generated order reference or tracking number. CyberSource recommends that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  For information about tracking orders, see Getting Started with CyberSource Advanced for the SCMP API.  **FDC Nashville Global**\\ Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports.  | [optional] 
**TransactionId** | **string** | Identifier that you assign to the transaction.  **Note** Use this field only if you want to support merchant-initiated reversal and void operations . See \&quot;Merchant-Initiated Reversals and Voids,\&quot; page 176.  | [optional] 
**Comments** | **string** | Comments | [optional] 
**Partner** | [**Ptsv2paymentsClientReferenceInformationPartner**](Ptsv2paymentsClientReferenceInformationPartner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

