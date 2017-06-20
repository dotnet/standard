# System.Web.Mail

``` diff
+namespace System.Web.Mail {
+    public class MailAttachment {
+        public MailAttachment(string filename);
+        public MailAttachment(string filename, MailEncoding encoding);
+        public MailEncoding Encoding { get; }
+        public string Filename { get; }
+    }
+    public enum MailEncoding {
+        Base64 = 1,
+        UUEncode = 0,
+    }
+    public enum MailFormat {
+        Html = 1,
+        Text = 0,
+    }
+    public class MailMessage {
+        public MailMessage();
+        public IList Attachments { get; }
+        public string Bcc { get; set; }
+        public string Body { get; set; }
+        public Encoding BodyEncoding { get; set; }
+        public MailFormat BodyFormat { get; set; }
+        public string Cc { get; set; }
+        public IDictionary Fields { get; }
+        public string From { get; set; }
+        public IDictionary Headers { get; }
+        public MailPriority Priority { get; set; }
+        public string Subject { get; set; }
+        public string To { get; set; }
+        public string UrlContentBase { get; set; }
+        public string UrlContentLocation { get; set; }
+    }
+    public enum MailPriority {
+        High = 2,
+        Low = 1,
+        Normal = 0,
+    }
+    public class SmtpMail {
+        public static string SmtpServer { get; set; }
+        public static void Send(string from, string to, string subject, string messageText);
+        public static void Send(MailMessage message);
+    }
+}
```

