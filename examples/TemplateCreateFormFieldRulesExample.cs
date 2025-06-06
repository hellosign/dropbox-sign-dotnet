using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

using Dropbox.Sign.Api;
using Dropbox.Sign.Client;
using Dropbox.Sign.Model;

namespace Dropbox.SignSandbox;

public class TemplateCreateFormFieldRulesExample
{
    public static void Run()
    {
        var config = new Configuration();
        config.Username = "YOUR_API_KEY";
        // config.AccessToken = "YOUR_ACCESS_TOKEN";

        var formFieldRules1Triggers1 = new SubFormFieldRuleTrigger(
            id: "uniqueIdHere_1",
            varOperator: SubFormFieldRuleTrigger.OperatorEnum.Is,
            value: "foo"
        );

        var formFieldRules1Triggers = new List<SubFormFieldRuleTrigger>
        {
            formFieldRules1Triggers1,
        };

        var formFieldRules1Actions1 = new SubFormFieldRuleAction(
            hidden: true,
            type: SubFormFieldRuleAction.TypeEnum.ChangeFieldVisibility,
            fieldId: "uniqueIdHere_2"
        );

        var formFieldRules1Actions = new List<SubFormFieldRuleAction>
        {
            formFieldRules1Actions1,
        };

        var fieldOptions = new SubFieldOptions(
            dateFormat: SubFieldOptions.DateFormatEnum.DD_MM_YYYY
        );

        var signerRoles1 = new SubTemplateRole(
            name: "Client",
            order: 0
        );

        var signerRoles2 = new SubTemplateRole(
            name: "Witness",
            order: 1
        );

        var signerRoles = new List<SubTemplateRole>
        {
            signerRoles1,
            signerRoles2,
        };

        var formFieldsPerDocument1 = new SubFormFieldsPerDocumentText(
            documentIndex: 0,
            apiId: "uniqueIdHere_1",
            type: "text",
            required: true,
            signer: "0",
            width: 100,
            height: 16,
            x: 112,
            y: 328,
            name: "",
            page: 1,
            validationType: SubFormFieldsPerDocumentText.ValidationTypeEnum.NumbersOnly
        );

        var formFieldsPerDocument2 = new SubFormFieldsPerDocumentSignature(
            documentIndex: 0,
            apiId: "uniqueIdHere_2",
            type: "signature",
            required: true,
            signer: "0",
            width: 120,
            height: 30,
            x: 530,
            y: 415,
            name: "",
            page: 1
        );

        var formFieldsPerDocument = new List<SubFormFieldsPerDocumentBase>
        {
            formFieldsPerDocument1,
            formFieldsPerDocument2,
        };

        var formFieldRules1 = new SubFormFieldRule(
            id: "rule_1",
            triggerOperator: "AND",
            triggers: formFieldRules1Triggers,
            actions: formFieldRules1Actions
        );

        var formFieldRules = new List<SubFormFieldRule>
        {
            formFieldRules1,
        };

        var mergeFields1 = new SubMergeField(
            name: "Full Name",
            type: SubMergeField.TypeEnum.Text
        );

        var mergeFields2 = new SubMergeField(
            name: "Is Registered?",
            type: SubMergeField.TypeEnum.Checkbox
        );

        var mergeFields = new List<SubMergeField>
        {
            mergeFields1,
            mergeFields2,
        };

        var templateCreateRequest = new TemplateCreateRequest(
            clientId: "37dee8d8440c66d54cfa05d92c160882",
            message: "For your approval",
            subject: "Please sign this document",
            testMode: true,
            title: "Test Template",
            fileUrls: [
                "https://www.dropbox.com/s/ad9qnhbrjjn64tu/mutual-NDA-example.pdf?dl=1",
            ],
            ccRoles: [
                "Manager",
            ],
            fieldOptions: fieldOptions,
            signerRoles: signerRoles,
            formFieldsPerDocument: formFieldsPerDocument,
            formFieldRules: formFieldRules,
            mergeFields: mergeFields
        );

        try
        {
            var response = new TemplateApi(config).TemplateCreate(
                templateCreateRequest: templateCreateRequest
            );

            Console.WriteLine(response);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling TemplateApi#TemplateCreate: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}
