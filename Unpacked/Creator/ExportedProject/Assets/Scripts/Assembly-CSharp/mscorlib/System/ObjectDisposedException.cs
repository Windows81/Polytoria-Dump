namespace System;

[Token(Token = "0x200011E")]
public class ObjectDisposedException : InvalidOperationException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000449")]
	private string _objectName; //Field offset: 0x90

	[Token(Token = "0x17000097")]
	public virtual string Message
	{
		[Address(RVA = "0x14BAF20", Offset = "0x14BA120", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000919")]
		 get { } //Length: 169
	}

	[Token(Token = "0x17000098")]
	public string ObjectName
	{
		[Address(RVA = "0x14BAFD0", Offset = "0x14BA1D0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091A")]
		 get { } //Length: 36
	}

	[Address(RVA = "0x14BAE00", Offset = "0x14BA000", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000914")]
	private ObjectDisposedException() { }

	[Address(RVA = "0x14BAEB0", Offset = "0x14BA0B0", Length = "0x65")]
	[CallerCount(Count = 120)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000915")]
	public ObjectDisposedException(string objectName) { }

	[Address(RVA = "0x14BAE60", Offset = "0x14BA060", Length = "0x45")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000916")]
	public ObjectDisposedException(string objectName, string message) { }

	[Address(RVA = "0x14BAD60", Offset = "0x14B9F60", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000917")]
	protected ObjectDisposedException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x14BAF20", Offset = "0x14BA120", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000919")]
	public virtual string get_Message() { }

	[Address(RVA = "0x14BAFD0", Offset = "0x14BA1D0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091A")]
	public string get_ObjectName() { }

	[Address(RVA = "0x14BAC70", Offset = "0x14B9E70", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000918")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

