#if STREAM_TESTS_ENABLED
using System.IO;
using StreamChat.EditorTools.CommandLineParsers;
using StreamChat.EditorTools;
using StreamChat.Libs.Auth;
using UnityEngine;

namespace StreamChat.Tests
{
    internal static class TestUtils
    {
        public static TestAuthDataSets GetTestAuthCredentials(out int? forceDataSetIndex)
        {
            forceDataSetIndex = default;
            const string TestAuthDataFilePath = "test_auth_data_xSpgxW.txt";

            if (Application.isBatchMode)
            {
                Debug.Log("Batch mode, expecting data injected through CLI args");

                var parser = new BuildSettingsCommandLineParser();
                var argsDict = parser.GetParsedCommandLineArguments();

                var testAuthDataSet = parser.ParseTestAuthDataSetArg(argsDict, out forceDataSetIndex);

                return testAuthDataSet;
            }

            if (File.Exists(TestAuthDataFilePath))
            {
                var parser = new BuildSettingsCommandLineParser();

                var base64TestData = File.ReadAllText(TestAuthDataFilePath);


                base64TestData = "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\n";
                
                var testAuthDataSet = parser.DeserializeFromBase64(base64TestData);

                return testAuthDataSet;
            }
            
            Debug.LogWarning($"`{TestAuthDataFilePath}` File with credentials sets not found.");

            // Define manually
            const string apiKey = "";
            const string testUserId = "integration-tests-role-user";
            const string testAdminId = "integration-tests-role-admin";

            var userAuthCredentials = new AuthCredentials(
                apiKey: apiKey,
                userId: testUserId,
                userToken: "");

            var adminAuthCredentials = new AuthCredentials(
                apiKey: apiKey,
                userId: testAdminId,
                userToken: "");

            return new TestAuthDataSets(new[] { adminAuthCredentials }, new[] { userAuthCredentials });
        }
    }
}
#endif