# System.Deployment.Internal.CodeSigning

``` diff
+namespace System.Deployment.Internal.CodeSigning {
+    public sealed class RSAPKCS1SHA256SignatureDescription : SignatureDescription {
+        public RSAPKCS1SHA256SignatureDescription();
+        public override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key);
+        public override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key);
+    }
+}
```

