namespace System.Runtime.Serialization.Formatters.Binary;

[ComVisible(True)]
[Token(Token = "0x2000413")]
public sealed class BinaryFormatter
{
	[Token(Token = "0x400108A")]
	private static Dictionary<Type, TypeInformation> typeNameCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001083")]
	internal ISurrogateSelector m_surrogates; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001084")]
	internal StreamingContext m_context; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001085")]
	internal SerializationBinder m_binder; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001086")]
	internal FormatterTypeStyle m_typeFormat; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001087")]
	internal FormatterAssemblyStyle m_assemblyFormat; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001088")]
	internal TypeFilterLevel m_securityLevel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001089")]
	internal Object[] m_crossAppDomainArray; //Field offset: 0x40

	[Token(Token = "0x170003D6")]
	public FormatterAssemblyStyle AssemblyFormat
	{
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E44")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003D7")]
	public override ISurrogateSelector SurrogateSelector
	{
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E45")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x139A6E0", Offset = "0x13998E0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E4F")]
	private static BinaryFormatter() { }

	[Address(RVA = "0x139A770", Offset = "0x1399970", Length = "0x69")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "DeserializeClaims", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(ObjRef))]
	[CalledBy(Type = typeof(ObjRef), Member = "SerializeType", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(MemoryStream))]
	[CalledBy(Type = typeof(CADSerializer), Member = "DeserializeObjectSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CADSerializer), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(MemoryStream))]
	[CalledBy(Type = typeof(CADSerializer), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemoryStream)}, ReturnType = typeof(object))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E46")]
	public BinaryFormatter() { }

	[Address(RVA = "0x139A7E0", Offset = "0x13999E0", Length = "0x5E")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingServices), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourceReader), Member = "ReadResources", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E47")]
	public BinaryFormatter(ISurrogateSelector selector, StreamingContext context) { }

	[Address(RVA = "0x139A090", Offset = "0x1399290", Length = "0x1D")]
	[CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(ObjRef))]
	[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CADSerializer), Member = "DeserializeObjectSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CADSerializer), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemoryStream)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ResourceReader), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(HeaderHandler), typeof(bool)}, ReturnType = typeof(object))]
	[Token(Token = "0x6001E48")]
	public override object Deserialize(Stream serializationStream) { }

	[Address(RVA = "0x1399C50", Offset = "0x1398E50", Length = "0x41D")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "DeserializeClaims", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(HeaderHandler)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HeaderHandler), typeof(__BinaryParser), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001E49")]
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	[Address(RVA = "0x139A070", Offset = "0x1399270", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(HeaderHandler), typeof(bool)}, ReturnType = typeof(object))]
	[Token(Token = "0x6001E4A")]
	public override object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	[Address(RVA = "0x139A0B0", Offset = "0x13992B0", Length = "0x261")]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSiWrite", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerObjectInfoCache), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FormatterServices), Member = "GetClrTypeFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FormatterServices), Member = "GetClrAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E4E")]
	internal static TypeInformation GetTypeInformation(Type type) { }

	[Address(RVA = "0x139A6C0", Offset = "0x13998C0", Length = "0x1F")]
	[CalledBy(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[CalledBy(Type = typeof(ObjRef), Member = "SerializeType", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(MemoryStream))]
	[CalledBy(Type = typeof(CADSerializer), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(MemoryStream))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object), typeof(Header[]), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001E4B")]
	public override void Serialize(Stream serializationStream, object graph) { }

	[Address(RVA = "0x139A320", Offset = "0x1399520", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object), typeof(Header[]), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001E4C")]
	public override void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	[Address(RVA = "0x139A340", Offset = "0x1399540", Length = "0x37F")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object), typeof(Header[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationObjectManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001E4D")]
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E44")]
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E45")]
	public override void set_SurrogateSelector(ISurrogateSelector value) { }

}

