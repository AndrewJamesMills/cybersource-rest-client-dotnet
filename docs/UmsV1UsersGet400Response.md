# CyberSource.Model.UmsV1UsersGet400Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubmitTimeUtc** | **string** | Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Status** | **string** | The status of the submitted transaction. | [optional] 
**Reason** | **string** | The reason of the status.  | [optional] 
**Message** | **string** | The detail message related to the status and reason listed above. | [optional] 
**Details** | [**List&lt;PtsV2PayoutsPost201ResponseErrorInformationDetails&gt;**](PtsV2PayoutsPost201ResponseErrorInformationDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
