using System;
using System.Collections.Generic;
using System.IO;
using Dropbox.Sign.Api;
using Dropbox.Sign.Client;
using Dropbox.Sign.Model;

public class Example
{
    public static void Main()
    {
        var config = new Configuration();
        // Configure HTTP basic authorization: api_key
        config.Username = "YOUR_API_KEY";

        // or, configure Bearer (JWT) authorization: oauth2
        // config.AccessToken = "YOUR_BEARER_TOKEN";

        var templateApi = new TemplateApi(config);

        var files = new List<Stream> {
            new FileStream(
                "./example_signature_request.pdf",
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read
            )
        };

        var data = new TemplateUpdateFilesRequest(
            files: files
        );

        var templateId = "21f920ec2b7f4b6bb64d3ed79f26303843046536";

        try
        {
            var result = templateApi.TemplateUpdateFiles(templateId, data);
            Console.WriteLine(result);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling Dropbox Sign API: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}
