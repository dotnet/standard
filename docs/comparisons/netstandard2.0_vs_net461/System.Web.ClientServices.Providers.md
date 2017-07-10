# System.Web.ClientServices.Providers

``` diff
+namespace System.Web.ClientServices.Providers {
+    public class ClientFormsAuthenticationCredentials {
+        public ClientFormsAuthenticationCredentials(string username, string password, bool rememberMe);
+        public string Password { get; set; }
+        public bool RememberMe { get; set; }
+        public string UserName { get; set; }
+    }
+    public class ClientFormsAuthenticationMembershipProvider : MembershipProvider {
+        public ClientFormsAuthenticationMembershipProvider();
+        public override string ApplicationName { get; set; }
+        public override bool EnablePasswordReset { get; }
+        public override bool EnablePasswordRetrieval { get; }
+        public override int MaxInvalidPasswordAttempts { get; }
+        public override int MinRequiredNonAlphanumericCharacters { get; }
+        public override int MinRequiredPasswordLength { get; }
+        public override int PasswordAttemptWindow { get; }
+        public override MembershipPasswordFormat PasswordFormat { get; }
+        public override string PasswordStrengthRegularExpression { get; }
+        public override bool RequiresQuestionAndAnswer { get; }
+        public override bool RequiresUniqueEmail { get; }
+        public string ServiceUri { get; set; }
+        public event EventHandler<UserValidatedEventArgs> UserValidated;
+        public override bool ChangePassword(string username, string oldPassword, string newPassword);
+        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer);
+        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status);
+        public override bool DeleteUser(string username, bool deleteAllRelatedData);
+        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
+        public override int GetNumberOfUsersOnline();
+        public override string GetPassword(string username, string answer);
+        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline);
+        public override MembershipUser GetUser(string username, bool userIsOnline);
+        public override string GetUserNameByEmail(string email);
+        public override void Initialize(string name, NameValueCollection config);
+        public void Logout();
+        public override string ResetPassword(string username, string answer);
+        public override bool UnlockUser(string username);
+        public override void UpdateUser(MembershipUser user);
+        public override bool ValidateUser(string username, string password);
+        public bool ValidateUser(string username, string password, bool rememberMe);
+        public static bool ValidateUser(string username, string password, string serviceUri);
+    }
+    public class ClientRoleProvider : RoleProvider {
+        public ClientRoleProvider();
+        public override string ApplicationName { get; set; }
+        public string ServiceUri { get; set; }
+        public override void AddUsersToRoles(string[] usernames, string[] roleNames);
+        public override void CreateRole(string roleName);
+        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole);
+        public override string[] FindUsersInRole(string roleName, string usernameToMatch);
+        public override string[] GetAllRoles();
+        public override string[] GetRolesForUser(string username);
+        public override string[] GetUsersInRole(string roleName);
+        public override void Initialize(string name, NameValueCollection config);
+        public override bool IsUserInRole(string username, string roleName);
+        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames);
+        public void ResetCache();
+        public override bool RoleExists(string roleName);
+    }
+    public class ClientSettingsProvider : SettingsProvider, IApplicationSettingsProvider {
+        public ClientSettingsProvider();
+        public override string ApplicationName { get; set; }
+        public static string ServiceUri { get; set; }
+        public event EventHandler<SettingsSavedEventArgs> SettingsSaved;
+        public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);
+        public static SettingsPropertyCollection GetPropertyMetadata(string serviceUri);
+        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection propertyCollection);
+        public override void Initialize(string name, NameValueCollection config);
+        public void Reset(SettingsContext context);
+        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection propertyValueCollection);
+        public void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
+    }
+    public class ClientWindowsAuthenticationMembershipProvider : MembershipProvider {
+        public ClientWindowsAuthenticationMembershipProvider();
+        public override string ApplicationName { get; set; }
+        public override bool EnablePasswordReset { get; }
+        public override bool EnablePasswordRetrieval { get; }
+        public override int MaxInvalidPasswordAttempts { get; }
+        public override int MinRequiredNonAlphanumericCharacters { get; }
+        public override int MinRequiredPasswordLength { get; }
+        public override int PasswordAttemptWindow { get; }
+        public override MembershipPasswordFormat PasswordFormat { get; }
+        public override string PasswordStrengthRegularExpression { get; }
+        public override bool RequiresQuestionAndAnswer { get; }
+        public override bool RequiresUniqueEmail { get; }
+        public override bool ChangePassword(string username, string oldPassword, string newPassword);
+        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer);
+        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status);
+        public override bool DeleteUser(string username, bool deleteAllRelatedData);
+        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
+        public override int GetNumberOfUsersOnline();
+        public override string GetPassword(string username, string answer);
+        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline);
+        public override MembershipUser GetUser(string username, bool userIsOnline);
+        public override string GetUserNameByEmail(string email);
+        public void Logout();
+        public override string ResetPassword(string username, string answer);
+        public override bool UnlockUser(string username);
+        public override void UpdateUser(MembershipUser user);
+        public override bool ValidateUser(string username, string password);
+    }
+    public interface IClientFormsAuthenticationCredentialsProvider {
+        ClientFormsAuthenticationCredentials GetCredentials();
+    }
+    public class SettingsSavedEventArgs : EventArgs {
+        public SettingsSavedEventArgs(IEnumerable<string> failedSettingsList);
+        public ReadOnlyCollection<string> FailedSettingsList { get; }
+    }
+    public class UserValidatedEventArgs : EventArgs {
+        public UserValidatedEventArgs(string username);
+        public string UserName { get; }
+    }
+}
```

