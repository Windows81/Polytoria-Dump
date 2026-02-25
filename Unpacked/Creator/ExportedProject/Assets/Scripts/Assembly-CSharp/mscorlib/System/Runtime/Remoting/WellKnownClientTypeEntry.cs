namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000351")]
public class WellKnownClientTypeEntry : TypeEntry
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E12")]
	private Type obj_type; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E13")]
	private string obj_url; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E14")]
	private string app_url; //Field offset: 0x30

	[Token(Token = "0x170002DC")]
	public string ApplicationUrl
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8D")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170002DD")]
	public Type ObjectType
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002DE")]
	public string ObjectUrl
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1378090", Offset = "0x1377290", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Assembly), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A8C")]
	public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8D")]
	public string get_ApplicationUrl() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8E")]
	public Type get_ObjectType() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8F")]
	public string get_ObjectUrl() { }

	[Address(RVA = "0x1378050", Offset = "0x1377250", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001A90")]
	public virtual string ToString() { }

}

