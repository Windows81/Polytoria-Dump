namespace System.Net;

[Token(Token = "0x200026C")]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A16")]
	private bool m_closed; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A17")]
	private long m_contentLength; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A18")]
	private FileAccess m_fileAccess; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A19")]
	private WebHeaderCollection m_headers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A1A")]
	private Stream m_stream; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A1B")]
	private Uri m_uri; //Field offset: 0x48

	[Token(Token = "0x17000330")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x17F3620", Offset = "0x17F2820", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		[Token(Token = "0x6000F98")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000331")]
	public virtual Uri ResponseUri
	{
		[Address(RVA = "0x17F3640", Offset = "0x17F2840", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		[Token(Token = "0x6000F99")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x17F3330", Offset = "0x17F2530", Length = "0x2E8")]
	[CalledBy(Type = typeof(FileWebRequest), Member = "GetResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebHeaderCollectionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F94")]
	internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[Address(RVA = "0x17F30B0", Offset = "0x17F22B0", Length = "0x276")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	[Token(Token = "0x6000F95")]
	protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17F2D00", Offset = "0x17F1F00", Length = "0x81")]
	[CalledBy(Type = typeof(FileWebResponse), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
	[CalledBy(Type = typeof(FileWebResponse), Member = "get_ResponseUri", ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(FileWebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F9A")]
	private void CheckDisposed() { }

	[Address(RVA = "0x17F2D90", Offset = "0x17F1F90", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Token(Token = "0x6000F9B")]
	public virtual void Close() { }

	[Address(RVA = "0x17F3620", Offset = "0x17F2820", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Token(Token = "0x6000F98")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x17F3640", Offset = "0x17F2840", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Token(Token = "0x6000F99")]
	public virtual Uri get_ResponseUri() { }

	[Address(RVA = "0x17F2DD0", Offset = "0x17F1FD0", Length = "0x177")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F97")]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17F2F50", Offset = "0x17F2150", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000F9D")]
	public virtual Stream GetResponseStream() { }

	[Address(RVA = "0x17F2F90", Offset = "0x17F2190", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F9C")]
	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	[Address(RVA = "0x17E8170", Offset = "0x17E7370", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F96")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

