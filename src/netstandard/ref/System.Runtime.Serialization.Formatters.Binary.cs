// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.Serialization.Formatters.Binary
{
    public sealed partial class BinaryFormatter : /*System.Runtime.Remoting.Messaging.IRemotingFormatter,*/ System.Runtime.Serialization.IFormatter
    {
        public BinaryFormatter() { }
        public BinaryFormatter(System.Runtime.Serialization.ISurrogateSelector selector, System.Runtime.Serialization.StreamingContext context) { }
        public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle AssemblyFormat { get { throw null; } set { } }
        public System.Runtime.Serialization.SerializationBinder Binder { get { throw null; } set { } }
        public System.Runtime.Serialization.StreamingContext Context { get { throw null; } set { } }
        public System.Runtime.Serialization.Formatters.TypeFilterLevel FilterLevel { get { throw null; } set { } }
        public System.Runtime.Serialization.ISurrogateSelector SurrogateSelector { get { throw null; } set { } }
        public System.Runtime.Serialization.Formatters.FormatterTypeStyle TypeFormat { get { throw null; } set { } }
        public object Deserialize(System.IO.Stream serializationStream) { throw null; }
//REMOTING        public object Deserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler) { throw null; }
//REMOTING        public object DeserializeMethodResponse(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler, System.Runtime.Remoting.Messaging.IMethodCallMessage methodCallMessage) { throw null; }
        public void Serialize(System.IO.Stream serializationStream, object graph) { }
//REMOTING        public void Serialize(System.IO.Stream serializationStream, object graph, System.Runtime.Remoting.Messaging.Header[] headers) { }
//REMOTING        public object UnsafeDeserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler) { throw null; }
//REMOTING        public object UnsafeDeserializeMethodResponse(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler, System.Runtime.Remoting.Messaging.IMethodCallMessage methodCallMessage) { throw null; }
    }
}
