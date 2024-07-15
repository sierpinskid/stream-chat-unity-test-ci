using System.Collections.Generic;
using System.Linq;
using StreamChat.Libs.Auth;
using UnityEngine;
using Random = UnityEngine.Random;

namespace StreamChat.EditorTools
{
    public struct TestAuthData
    {
        public AuthCredentials[] Admins { get; set; }
        public AuthCredentials[] Users { get; set; }

        public TestAuthData(IEnumerable<AuthCredentials> testAdminData, IEnumerable<AuthCredentials> userSets)
        {
            Admins = testAdminData.ToArray();
            Users = userSets.ToArray();
        }

        public AuthCredentials GetAdminData(int? forceIndex = default) => GetDataSet(true, forceIndex);

        private AuthCredentials GetDataSet(bool isAdmin, int? forceIndex = default)
        {
            var sets = isAdmin ? Admins : Users;
            if (forceIndex.HasValue)
            {
                if (forceIndex < sets.Length)
                {
                    return sets[forceIndex.Value];
                }

                Debug.LogWarning(
                    $"{nameof(forceIndex)} is out of range -> given: {forceIndex} for ss admin: {isAdmin}, max allowed: {sets.Length - 1}. Using random credentials data instead.");
            }

            return sets[Random.Range(0, sets.Length)];
        }
    }
}