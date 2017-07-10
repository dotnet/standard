# System.IdentityModel.Metadata

``` diff
+namespace System.IdentityModel.Metadata {
+    public class ApplicationServiceDescriptor : WebServiceDescriptor {
+        public ApplicationServiceDescriptor();
+        public ICollection<EndpointReference> Endpoints { get; }
+        public ICollection<EndpointReference> PassiveRequestorEndpoints { get; }
+    }
+    public class ContactPerson {
+        public ContactPerson();
+        public ContactPerson(ContactType contactType);
+        public string Company { get; set; }
+        public ICollection<string> EmailAddresses { get; }
+        public string GivenName { get; set; }
+        public string Surname { get; set; }
+        public ICollection<string> TelephoneNumbers { get; }
+        public ContactType Type { get; set; }
+    }
+    public enum ContactType {
+        Administrative = 3,
+        Billing = 4,
+        Other = 5,
+        Support = 2,
+        Technical = 1,
+        Unspecified = 0,
+    }
+    public class DisplayClaim {
+        public DisplayClaim(string claimType);
+        public DisplayClaim(string claimType, string displayTag, string description);
+        public DisplayClaim(string claimType, string displayTag, string description, string displayValue);
+        public DisplayClaim(string claimType, string displayTag, string description, string displayValue, bool optional);
+        public string ClaimType { get; }
+        public string Description { get; set; }
+        public string DisplayTag { get; set; }
+        public string DisplayValue { get; set; }
+        public bool Optional { get; set; }
+        public bool WriteOptionalAttribute { get; set; }
+        public static DisplayClaim CreateDisplayClaimFromClaimType(string claimType);
+    }
+    public class EncryptionMethod {
+        public EncryptionMethod(Uri algorithm);
+        public Uri Algorithm { get; set; }
+    }
+    public class EntitiesDescriptor : MetadataBase {
+        public EntitiesDescriptor();
+        public EntitiesDescriptor(Collection<EntitiesDescriptor> entityGroupList);
+        public EntitiesDescriptor(Collection<EntityDescriptor> entityList);
+        public EntitiesDescriptor(Collection<EntityDescriptor> entityList, Collection<EntitiesDescriptor> entityGroupList);
+        public ICollection<EntityDescriptor> ChildEntities { get; }
+        public ICollection<EntitiesDescriptor> ChildEntityGroups { get; }
+        public string Name { get; set; }
+    }
+    public class EntityDescriptor : MetadataBase {
+        public EntityDescriptor();
+        public EntityDescriptor(EntityId entityId);
+        public ICollection<ContactPerson> Contacts { get; }
+        public EntityId EntityId { get; set; }
+        public string FederationId { get; set; }
+        public Organization Organization { get; set; }
+        public ICollection<RoleDescriptor> RoleDescriptors { get; }
+    }
+    public class EntityId {
+        public EntityId();
+        public EntityId(string id);
+        public string Id { get; set; }
+    }
+    public class IdentityProviderSingleSignOnDescriptor : SingleSignOnDescriptor {
+        public IdentityProviderSingleSignOnDescriptor();
+        public ICollection<ProtocolEndpoint> SingleSignOnServices { get; }
+        public ICollection<Saml2Attribute> SupportedAttributes { get; }
+        public bool WantAuthenticationRequestsSigned { get; set; }
+    }
+    public class IndexedProtocolEndpoint : ProtocolEndpoint {
+        public IndexedProtocolEndpoint();
+        public IndexedProtocolEndpoint(int index, Uri binding, Uri location);
+        public int Index { get; set; }
+        public Nullable<bool> IsDefault { get; set; }
+    }
+    public class IndexedProtocolEndpointDictionary : SortedList<int, IndexedProtocolEndpoint> {
+        public IndexedProtocolEndpointDictionary();
+        public IndexedProtocolEndpoint Default { get; }
+    }
+    public class KeyDescriptor {
+        public KeyDescriptor();
+        public KeyDescriptor(SecurityKeyIdentifier ski);
+        public ICollection<EncryptionMethod> EncryptionMethods { get; }
+        public SecurityKeyIdentifier KeyInfo { get; set; }
+        public KeyType Use { get; set; }
+    }
+    public enum KeyType {
+        Encryption = 2,
+        Signing = 1,
+        Unspecified = 0,
+    }
+    public abstract class LocalizedEntry {
+        protected LocalizedEntry();
+        protected LocalizedEntry(CultureInfo language);
+        public CultureInfo Language { get; set; }
+    }
+    public class LocalizedEntryCollection<T> : KeyedCollection<CultureInfo, T> where T : LocalizedEntry {
+        public LocalizedEntryCollection();
+        protected override CultureInfo GetKeyForItem(T item);
+    }
+    public class LocalizedName : LocalizedEntry {
+        public LocalizedName();
+        public LocalizedName(string name, CultureInfo language);
+        public string Name { get; set; }
+    }
+    public class LocalizedUri : LocalizedEntry {
+        public LocalizedUri();
+        public LocalizedUri(Uri uri, CultureInfo language);
+        public Uri Uri { get; set; }
+    }
+    public abstract class MetadataBase {
+        protected MetadataBase();
+        public SigningCredentials SigningCredentials { get; set; }
+    }
+    public class MetadataSerializationException : Exception {
+        public MetadataSerializationException();
+        protected MetadataSerializationException(SerializationInfo info, StreamingContext context);
+        public MetadataSerializationException(string message);
+        public MetadataSerializationException(string message, Exception innerException);
+    }
+    public class MetadataSerializer {
+        public const string LanguageAttribute = "xml:lang";
+        public const string LanguageLocalName = "lang";
+        public const string LanguageNamespaceUri = "http://www.w3.org/XML/1998/namespace";
+        public const string LanguagePrefix = "xml";
+        public MetadataSerializer();
+        public MetadataSerializer(SecurityTokenSerializer tokenSerializer);
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public X509CertificateValidator CertificateValidator { get; set; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public SecurityTokenSerializer SecurityTokenSerializer { get; }
+        public List<string> TrustedIssuers { get; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+        protected virtual ApplicationServiceDescriptor CreateApplicationServiceInstance();
+        protected virtual ContactPerson CreateContactPersonInstance();
+        protected virtual EntitiesDescriptor CreateEntitiesDescriptorInstance();
+        protected virtual EntityDescriptor CreateEntityDescriptorInstance();
+        protected virtual IdentityProviderSingleSignOnDescriptor CreateIdentityProviderSingleSignOnDescriptorInstance();
+        protected virtual IndexedProtocolEndpoint CreateIndexedProtocolEndpointInstance();
+        protected virtual KeyDescriptor CreateKeyDescriptorInstance();
+        protected virtual LocalizedName CreateLocalizedNameInstance();
+        protected virtual LocalizedUri CreateLocalizedUriInstance();
+        protected virtual Organization CreateOrganizationInstance();
+        protected virtual ProtocolEndpoint CreateProtocolEndpointInstance();
+        protected virtual SecurityTokenServiceDescriptor CreateSecurityTokenServiceDescriptorInstance();
+        protected virtual ServiceProviderSingleSignOnDescriptor CreateServiceProviderSingleSignOnDescriptorInstance();
+        protected virtual X509Certificate2 GetMetadataSigningCertificate(SecurityKeyIdentifier ski);
+        protected virtual ApplicationServiceDescriptor ReadApplicationServiceDescriptor(XmlReader reader);
+        protected virtual Saml2Attribute ReadAttribute(XmlReader reader);
+        protected virtual ContactPerson ReadContactPerson(XmlReader reader);
+        protected virtual void ReadCustomAttributes<T>(XmlReader reader, T target);
+        protected virtual bool ReadCustomElement<T>(XmlReader reader, T target);
+        protected virtual void ReadCustomRoleDescriptor(string xsiType, XmlReader reader, EntityDescriptor entityDescriptor);
+        protected virtual DisplayClaim ReadDisplayClaim(XmlReader reader);
+        protected virtual EntitiesDescriptor ReadEntitiesDescriptor(XmlReader reader, SecurityTokenResolver tokenResolver);
+        protected virtual EntityDescriptor ReadEntityDescriptor(XmlReader inputReader, SecurityTokenResolver tokenResolver);
+        protected virtual IdentityProviderSingleSignOnDescriptor ReadIdentityProviderSingleSignOnDescriptor(XmlReader reader);
+        protected virtual IndexedProtocolEndpoint ReadIndexedProtocolEndpoint(XmlReader reader);
+        protected virtual KeyDescriptor ReadKeyDescriptor(XmlReader reader);
+        protected virtual LocalizedName ReadLocalizedName(XmlReader reader);
+        protected virtual LocalizedUri ReadLocalizedUri(XmlReader reader);
+        public MetadataBase ReadMetadata(Stream stream);
+        public MetadataBase ReadMetadata(XmlReader reader);
+        public MetadataBase ReadMetadata(XmlReader reader, SecurityTokenResolver tokenResolver);
+        protected virtual MetadataBase ReadMetadataCore(XmlReader reader, SecurityTokenResolver tokenResolver);
+        protected virtual Organization ReadOrganization(XmlReader reader);
+        protected virtual ProtocolEndpoint ReadProtocolEndpoint(XmlReader reader);
+        protected virtual void ReadRoleDescriptorAttributes(XmlReader reader, RoleDescriptor roleDescriptor);
+        protected virtual bool ReadRoleDescriptorElement(XmlReader reader, RoleDescriptor roleDescriptor);
+        protected virtual SecurityTokenServiceDescriptor ReadSecurityTokenServiceDescriptor(XmlReader reader);
+        protected virtual ServiceProviderSingleSignOnDescriptor ReadServiceProviderSingleSignOnDescriptor(XmlReader reader);
+        protected virtual void ReadSingleSignOnDescriptorAttributes(XmlReader reader, SingleSignOnDescriptor roleDescriptor);
+        protected virtual bool ReadSingleSignOnDescriptorElement(XmlReader reader, SingleSignOnDescriptor singleSignOnDescriptor);
+        protected virtual void ReadWebServiceDescriptorAttributes(XmlReader reader, WebServiceDescriptor roleDescriptor);
+        public virtual bool ReadWebServiceDescriptorElement(XmlReader reader, WebServiceDescriptor roleDescriptor);
+        protected virtual void ValidateIssuer(X509Certificate2 signingCertificate);
+        protected virtual void ValidateSigningCredential(SigningCredentials signingCredentials);
+        protected virtual void WriteApplicationServiceDescriptor(XmlWriter writer, ApplicationServiceDescriptor appService);
+        protected virtual void WriteAttribute(XmlWriter writer, Saml2Attribute data);
+        protected virtual void WriteContactPerson(XmlWriter writer, ContactPerson contactPerson);
+        protected virtual void WriteCustomAttributes<T>(XmlWriter writer, T source);
+        protected virtual void WriteCustomElements<T>(XmlWriter writer, T source);
+        protected virtual void WriteDisplayClaim(XmlWriter writer, DisplayClaim claim);
+        protected virtual void WriteEntitiesDescriptor(XmlWriter inputWriter, EntitiesDescriptor entitiesDescriptor);
+        protected virtual void WriteEntityDescriptor(XmlWriter inputWriter, EntityDescriptor entityDescriptor);
+        protected virtual void WriteIdentityProviderSingleSignOnDescriptor(XmlWriter writer, IdentityProviderSingleSignOnDescriptor identityProviderSingleSignOnDescriptor);
+        protected virtual void WriteIndexedProtocolEndpoint(XmlWriter writer, IndexedProtocolEndpoint indexedEP, XmlQualifiedName element);
+        protected virtual void WriteKeyDescriptor(XmlWriter writer, KeyDescriptor keyDescriptor);
+        protected virtual void WriteLocalizedName(XmlWriter writer, LocalizedName name, XmlQualifiedName element);
+        protected virtual void WriteLocalizedUri(XmlWriter writer, LocalizedUri uri, XmlQualifiedName element);
+        public void WriteMetadata(Stream stream, MetadataBase metadata);
+        public void WriteMetadata(XmlWriter writer, MetadataBase metadata);
+        protected virtual void WriteMetadataCore(XmlWriter writer, MetadataBase metadataBase);
+        protected virtual void WriteOrganization(XmlWriter writer, Organization organization);
+        protected virtual void WriteProtocolEndpoint(XmlWriter writer, ProtocolEndpoint endpoint, XmlQualifiedName element);
+        protected virtual void WriteRoleDescriptorAttributes(XmlWriter writer, RoleDescriptor roleDescriptor);
+        protected virtual void WriteRoleDescriptorElements(XmlWriter writer, RoleDescriptor roleDescriptor);
+        protected virtual void WriteSecurityTokenServiceDescriptor(XmlWriter writer, SecurityTokenServiceDescriptor securityTokenServiceDescriptor);
+        protected virtual void WriteServiceProviderSingleSignOnDescriptor(XmlWriter writer, ServiceProviderSingleSignOnDescriptor serviceProviderSingleSignOnDescriptor);
+        protected virtual void WriteSingleSignOnDescriptorAttributes(XmlWriter writer, SingleSignOnDescriptor singleSignOnDescriptor);
+        protected virtual void WriteSingleSignOnDescriptorElements(XmlWriter writer, SingleSignOnDescriptor singleSignOnDescriptor);
+        protected virtual void WriteWebServiceDescriptorAttributes(XmlWriter writer, WebServiceDescriptor wsDescriptor);
+        protected virtual void WriteWebServiceDescriptorElements(XmlWriter writer, WebServiceDescriptor wsDescriptor);
+    }
+    public class Organization {
+        public Organization();
+        public Organization(LocalizedEntryCollection<LocalizedName> names, LocalizedEntryCollection<LocalizedName> displayNames, LocalizedEntryCollection<LocalizedUri> urls);
+        public LocalizedEntryCollection<LocalizedName> DisplayNames { get; }
+        public LocalizedEntryCollection<LocalizedName> Names { get; }
+        public LocalizedEntryCollection<LocalizedUri> Urls { get; }
+    }
+    public class ProtocolEndpoint {
+        public ProtocolEndpoint();
+        public ProtocolEndpoint(Uri binding, Uri location);
+        public Uri Binding { get; set; }
+        public Uri Location { get; set; }
+        public Uri ResponseLocation { get; set; }
+    }
+    public abstract class RoleDescriptor {
+        protected RoleDescriptor();
+        protected RoleDescriptor(Collection<Uri> protocolsSupported);
+        public ICollection<ContactPerson> Contacts { get; }
+        public Uri ErrorUrl { get; set; }
+        public ICollection<KeyDescriptor> Keys { get; }
+        public Organization Organization { get; set; }
+        public ICollection<Uri> ProtocolsSupported { get; }
+        public DateTime ValidUntil { get; set; }
+    }
+    public class SecurityTokenServiceDescriptor : WebServiceDescriptor {
+        public SecurityTokenServiceDescriptor();
+        public Collection<EndpointReference> PassiveRequestorEndpoints { get; }
+        public Collection<EndpointReference> SecurityTokenServiceEndpoints { get; }
+    }
+    public class ServiceProviderSingleSignOnDescriptor : SingleSignOnDescriptor {
+        public ServiceProviderSingleSignOnDescriptor();
+        public ServiceProviderSingleSignOnDescriptor(IndexedProtocolEndpointDictionary collection);
+        public IndexedProtocolEndpointDictionary AssertionConsumerServices { get; }
+        public bool AuthenticationRequestsSigned { get; set; }
+        public bool WantAssertionsSigned { get; set; }
+    }
+    public class SingleSignOnDescriptor : RoleDescriptor {
+        public SingleSignOnDescriptor();
+        public IndexedProtocolEndpointDictionary ArtifactResolutionServices { get; }
+        public ICollection<Uri> NameIdentifierFormats { get; }
+        public Collection<ProtocolEndpoint> SingleLogoutServices { get; }
+    }
+    public abstract class WebServiceDescriptor : RoleDescriptor {
+        protected WebServiceDescriptor();
+        public ICollection<DisplayClaim> ClaimTypesOffered { get; }
+        public ICollection<DisplayClaim> ClaimTypesRequested { get; }
+        public string ServiceDescription { get; set; }
+        public string ServiceDisplayName { get; set; }
+        public ICollection<EndpointReference> TargetScopes { get; }
+        public ICollection<Uri> TokenTypesOffered { get; }
+    }
+}
```

