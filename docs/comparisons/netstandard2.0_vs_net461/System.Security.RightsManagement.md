# System.Security.RightsManagement

``` diff
+namespace System.Security.RightsManagement {
+    public enum AuthenticationType {
+        Internal = 3,
+        Passport = 1,
+        Windows = 0,
+        WindowsPassport = 2,
+    }
+    public class ContentGrant {
+        public ContentGrant(ContentUser user, ContentRight right);
+        public ContentGrant(ContentUser user, ContentRight right, DateTime validFrom, DateTime validUntil);
+        public ContentRight Right { get; }
+        public ContentUser User { get; }
+        public DateTime ValidFrom { get; }
+        public DateTime ValidUntil { get; }
+    }
+    public enum ContentRight {
+        DocumentEdit = 11,
+        Edit = 1,
+        Export = 12,
+        Extract = 3,
+        Forward = 7,
+        ObjectModel = 4,
+        Owner = 5,
+        Print = 2,
+        Reply = 8,
+        ReplyAll = 9,
+        Sign = 10,
+        View = 0,
+        ViewRightsData = 6,
+    }
+    public class ContentUser {
+        public ContentUser(string name, AuthenticationType authenticationType);
+        public static ContentUser AnyoneUser { get; }
+        public AuthenticationType AuthenticationType { get; }
+        public string Name { get; }
+        public static ContentUser OwnerUser { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public bool IsAuthenticated();
+    }
+    public class CryptoProvider : IDisposable {
+        public int BlockSize { get; }
+        public ReadOnlyCollection<ContentGrant> BoundGrants { get; }
+        public bool CanDecrypt { get; }
+        public bool CanEncrypt { get; }
+        public bool CanMergeBlocks { get; }
+        public byte[] Decrypt(byte[] cryptoText);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public byte[] Encrypt(byte[] clearText);
+        ~CryptoProvider();
+    }
+    public class LocalizedNameDescriptionPair {
+        public LocalizedNameDescriptionPair(string name, string description);
+        public string Description { get; }
+        public string Name { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class PublishLicense {
+        public PublishLicense(string signedPublishLicense);
+        public Guid ContentId { get; }
+        public string ReferralInfoName { get; }
+        public Uri ReferralInfoUri { get; }
+        public Uri UseLicenseAcquisitionUrl { get; }
+        public UseLicense AcquireUseLicense(SecureEnvironment secureEnvironment);
+        public UseLicense AcquireUseLicenseNoUI(SecureEnvironment secureEnvironment);
+        public UnsignedPublishLicense DecryptUnsignedPublishLicense(CryptoProvider cryptoProvider);
+        public override string ToString();
+    }
+    public class RightsManagementException : Exception {
+        public RightsManagementException();
+        protected RightsManagementException(SerializationInfo info, StreamingContext context);
+        public RightsManagementException(RightsManagementFailureCode failureCode);
+        public RightsManagementException(RightsManagementFailureCode failureCode, Exception innerException);
+        public RightsManagementException(RightsManagementFailureCode failureCode, string message);
+        public RightsManagementException(RightsManagementFailureCode failureCode, string message, Exception innerException);
+        public RightsManagementException(string message);
+        public RightsManagementException(string message, Exception innerException);
+        public RightsManagementFailureCode FailureCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum RightsManagementFailureCode {
+        Aborted = -2147168447,
+        ActivationFailed = -2147168448,
+        AdEntryNotFound = -2147168419,
+        AlreadyInProgress = -2147168456,
+        AuthenticationFailed = -2147168445,
+        BadGetInfoQuery = -2147168494,
+        BindAccessPrincipalNotEnabling = -2147168478,
+        BindAccessUnsatisfied = -2147168477,
+        BindContentNotInEndUseLicense = -2147168479,
+        BindIndicatedPrincipalMissing = -2147168476,
+        BindIntervalTimeViolated = -2147168465,
+        BindMachineNotFoundInGroupIdentity = -2147168475,
+        BindNoApplicableRevocationList = -2147168472,
+        BindNoSatisfiedRightsGroup = -2147168464,
+        BindPolicyViolation = -2147168485,
+        BindRevocationListStale = -2147168473,
+        BindRevokedIssuer = -2147168483,
+        BindRevokedLicense = -2147168484,
+        BindRevokedModule = -2147168480,
+        BindRevokedPrincipal = -2147168482,
+        BindRevokedResource = -2147168481,
+        BindSpecifiedWorkMissing = -2147168463,
+        BindValidityTimeViolated = -2147168488,
+        BrokenCertChain = -2147168487,
+        ClockRollbackDetected = -2147168491,
+        CryptoOperationUnsupported = -2147168492,
+        DebuggerDetected = -2147168416,
+        EmailNotVerified = -2147168422,
+        EnablingPrincipalFailure = -2147168496,
+        EncryptionNotPermitted = -2147168508,
+        EnvironmentCannotLoad = -2147168501,
+        EnvironmentNotLoaded = -2147168502,
+        ExpiredOfficialIssuanceLicenseTemplate = -2147168425,
+        GlobalOptionAlreadySet = -2147168396,
+        GroupIdentityNotSet = -2147168455,
+        HidCorrupted = -2147168442,
+        HidInvalid = -2147168423,
+        IdMismatch = -2147168459,
+        IncompatibleObjects = -2147168498,
+        InfoNotInLicense = -2147168511,
+        InfoNotPresent = -2147168495,
+        InstallationFailed = -2147168443,
+        InvalidAlgorithmType = -2147168503,
+        InvalidClientLicensorCertificate = -2147168424,
+        InvalidEmail = -2147168437,
+        InvalidEncodingType = -2147168505,
+        InvalidHandle = -2147168468,
+        InvalidIssuanceLicenseTemplate = -2147168428,
+        InvalidKeyLength = -2147168427,
+        InvalidLicense = -2147168512,
+        InvalidLicenseSignature = -2147168510,
+        InvalidLockboxPath = -2147168399,
+        InvalidLockboxType = -2147168400,
+        InvalidNumericalValue = -2147168504,
+        InvalidRegistryPath = -2147168398,
+        InvalidServerResponse = -2147168441,
+        InvalidTimeInfo = -2147168431,
+        InvalidVersion = -2147168506,
+        KeyTypeUnsupported = -2147168493,
+        LibraryFail = -2147168497,
+        LibraryUnsupportedPlugIn = -2147168474,
+        LicenseAcquisitionFailed = -2147168460,
+        LicenseBindingToWindowsIdentityFailed = -2147168429,
+        ManifestPolicyViolation = -2147183860,
+        MetadataNotSet = -2147168433,
+        NeedsGroupIdentityActivation = -2147168450,
+        NeedsMachineActivation = -2147168451,
+        NoAesCryptoProvider = -2147168397,
+        NoConnect = -2147168453,
+        NoDistributionPointUrlFound = -2147168457,
+        NoLicense = -2147168452,
+        NoMoreData = -2147168461,
+        NotAChain = -2147168418,
+        NotSet = -2147168434,
+        OutdatedModule = -2147168435,
+        OutOfQuota = -2147168446,
+        OwnerLicenseNotFound = -2147168395,
+        QueryReportsNoResults = -2147168490,
+        RecordNotFound = -2147168454,
+        RequestDenied = -2147168417,
+        RevocationInfoNotSet = -2147168432,
+        RightNotGranted = -2147168507,
+        RightNotSet = -2147168430,
+        ServerError = -2147168444,
+        ServerNotFound = -2147168438,
+        ServiceGone = -2147168420,
+        ServiceMoved = -2147168421,
+        ServiceNotFound = -2147168440,
+        Success = 0,
+        TooManyCertificates = -2147168458,
+        TooManyLoadedEnvironments = -2147168500,
+        UnexpectedException = -2147168489,
+        UseDefault = -2147168439,
+        ValidityTimeViolation = -2147168436,
+    }
+    public class SecureEnvironment : IDisposable {
+        public string ApplicationManifest { get; }
+        public ContentUser User { get; }
+        public static SecureEnvironment Create(string applicationManifest, AuthenticationType authentication, UserActivationMode userActivationMode);
+        public static SecureEnvironment Create(string applicationManifest, ContentUser user);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static ReadOnlyCollection<ContentUser> GetActivatedUsers();
+        public static bool IsUserActivated(ContentUser user);
+        public static void RemoveActivatedUser(ContentUser user);
+    }
+    public class UnsignedPublishLicense {
+        public UnsignedPublishLicense();
+        public UnsignedPublishLicense(string publishLicenseTemplate);
+        public Guid ContentId { get; set; }
+        public ICollection<ContentGrant> Grants { get; }
+        public IDictionary<int, LocalizedNameDescriptionPair> LocalizedNameDescriptionDictionary { get; }
+        public ContentUser Owner { get; set; }
+        public string ReferralInfoName { get; set; }
+        public Uri ReferralInfoUri { get; set; }
+        public PublishLicense Sign(SecureEnvironment secureEnvironment, out UseLicense authorUseLicense);
+        public override string ToString();
+    }
+    public class UseLicense {
+        public UseLicense(string useLicense);
+        public IDictionary<string, string> ApplicationData { get; }
+        public Guid ContentId { get; }
+        public ContentUser Owner { get; }
+        public CryptoProvider Bind(SecureEnvironment secureEnvironment);
+        public override bool Equals(object x);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public enum UserActivationMode {
+        Permanent = 0,
+        Temporary = 1,
+    }
+}
```

