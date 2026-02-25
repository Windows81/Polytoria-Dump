namespace System.Runtime.Serialization;

[Token(Token = "0x20003C6")]
public class SerializationException : SystemException
{
	[Token(Token = "0x4000F11")]
	private static string s_nullMessage; //Field offset: 0x0

	[Address(RVA = "0x13930E0", Offset = "0x13922E0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001CCE")]
	private static SerializationException() { }

	[Address(RVA = "0x1393170", Offset = "0x1392370", Length = "0x66")]
	[CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CCA")]
	public SerializationException() { }

	[Address(RVA = "0x1393150", Offset = "0x1392350", Length = "0x1E")]
	[CallerCount(Count = 136)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CCB")]
	public SerializationException(string message) { }

	[Address(RVA = "0x13931E0", Offset = "0x13923E0", Length = "0x1E")]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransitionTime), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteISerializableObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CCC")]
	public SerializationException(string message, Exception innerException) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CCD")]
	protected SerializationException(SerializationInfo info, StreamingContext context) { }

}

