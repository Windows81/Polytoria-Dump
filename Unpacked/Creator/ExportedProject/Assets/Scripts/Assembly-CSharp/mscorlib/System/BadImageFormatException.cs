namespace System;

[Token(Token = "0x20000C0")]
public class BadImageFormatException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002C6")]
	private string _fileName; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40002C7")]
	private string _fusionLog; //Field offset: 0x98

	[Token(Token = "0x17000060")]
	public virtual string Message
	{
		[Address(RVA = "0x140B710", Offset = "0x140A910", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(FileLoadException), Member = "FormatFileLoadExceptionMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
		[Token(Token = "0x600044A")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x140B6C0", Offset = "0x140A8C0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000444")]
	public BadImageFormatException() { }

	[Address(RVA = "0x140B660", Offset = "0x140A860", Length = "0x1E")]
	[CalledBy(Type = typeof(ResourceReader), Member = "SkipString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ResourceReader), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourceReader), Member = "FindType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RuntimeType))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000445")]
	public BadImageFormatException(string message) { }

	[Address(RVA = "0x140B640", Offset = "0x140A840", Length = "0x1E")]
	[CalledBy(Type = typeof(ResourceReader), Member = "LoadObjectV1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ResourceReader), Member = "LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ResourceReader), Member = "ReadResources", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000446")]
	public BadImageFormatException(string message, Exception inner) { }

	[Address(RVA = "0x140B680", Offset = "0x140A880", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000447")]
	public BadImageFormatException(string message, string fileName) { }

	[Address(RVA = "0x140B570", Offset = "0x140A770", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000448")]
	protected BadImageFormatException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x140B710", Offset = "0x140A910", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileLoadException), Member = "FormatFileLoadExceptionMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x600044A")]
	public virtual string get_Message() { }

	[Address(RVA = "0x140B1E0", Offset = "0x140A3E0", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000449")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x140B2F0", Offset = "0x140A4F0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileLoadException), Member = "FormatFileLoadExceptionMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x600044B")]
	private void SetMessageField() { }

	[Address(RVA = "0x140B380", Offset = "0x140A580", Length = "0x1EF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600044C")]
	public virtual string ToString() { }

}

