#if STREAM_TESTS_ENABLED
using System;
using System.IO;
using System.Text;
using StreamChat.EditorTools.CommandLineParsers;
using StreamChat.EditorTools;
using StreamChat.Libs.Auth;
using StreamChat.Libs.Serialization;
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

                Debug.Log("Data deserialized correctly. Sample: " + testAuthDataSet.Admins[0].UserId);

                return testAuthDataSet;
            }

            if (File.Exists(TestAuthDataFilePath))
            {
                var serializer = new NewtonsoftJsonSerializer();

                var base64TestData = File.ReadAllText(TestAuthDataFilePath);
                var decodedJsonTestData = Convert.FromBase64String(base64TestData);
                var serializedTestDataSet = Encoding.UTF8.GetString(decodedJsonTestData);
                Debug.Log("Decoded data set length: " + serializedTestDataSet.Length);

                var testAuthDataSet =
                    serializer.Deserialize<TestAuthDataSets>(serializedTestDataSet);

                Debug.Log("Data deserialized correctly. Sample: " + testAuthDataSet.Admins[0].UserId);

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