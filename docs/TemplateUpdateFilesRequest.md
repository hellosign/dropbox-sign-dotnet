# Dropbox.Sign.Model.TemplateUpdateFilesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** |  Client id of the app you&#39;re using to update this template.  | [optional] **Files** | **List&lt;System.IO.Stream&gt;** |  Use `files[]` to indicate the uploaded file(s) to use for the template.<br><br>This endpoint requires either **files** or **file_urls[]**, but not both.  | [optional] **FileUrls** | **List&lt;string&gt;** |  Use `file_urls[]` to have Dropbox Sign download the file(s) to use for the template.<br><br>This endpoint requires either **files** or **file_urls[]**, but not both.  | [optional] **Message** | **string** |  The new default template email message.  | [optional] **Subject** | **string** |  The new default template email subject.  | [optional] **TestMode** | **bool** |  Whether this is a test, the signature request created from this draft will not be legally binding if set to `true`. Defaults to `false`.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

