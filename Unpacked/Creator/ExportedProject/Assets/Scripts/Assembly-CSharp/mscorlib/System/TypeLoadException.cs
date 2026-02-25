namespace System;

[ComVisible(True)]
[Token(Token = "0x2000196")]
public class TypeLoadException : SystemException, ISerializable
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000673")]
	private string ClassName; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000674")]
	private string AssemblyName; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000675")]
	private string MessageArg; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000676")]
	internal int ResourceId; //Field offset: 0xA8

	[Token(Token = "0x17000145")]
	public virtual string Message
	{
		[Address(RVA = "0x1505E90", Offset = "0x1505090", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TypeLoadException), Member = "SetMessageField", ReturnType = typeof(void))]
		[Token(Token = "0x6000E96")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x1505DA0", Offset = "0x1504FA0", Length = "0x4C")]
	[CalledBy(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32[])}, ReturnType = typeof(Array))]
	[CalledBy(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(Array))]
	[CalledBy(Type = typeof(RuntimeType), Member = "MakeGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E94")]
	public TypeLoadException() { }

	[Address(RVA = "0x1505D70", Offset = "0x1504F70", Length = "0x26")]
	[CalledBy(Type = typeof(DllNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DllNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryPointNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryPointNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeAccessException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeType), Member = "MakeByRefType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "MakePointerType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeTypeHandle), Member = "GetTypeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RuntimeType))]
	[CalledBy(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E95")]
	public TypeLoadException(string message) { }

	[Address(RVA = "0x1505DF0", Offset = "0x1504FF0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TypeLoadException), Member = "SetMessageField", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E98")]
	private TypeLoadException(string className, string assemblyName) { }

	[Address(RVA = "0x1505B50", Offset = "0x1504D50", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TypeLoadException), Member = "SetMessageField", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E99")]
	private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId) { }

	[Address(RVA = "0x1505C00", Offset = "0x1504E00", Length = "0x164")]
	[CalledBy(Type = typeof(DllNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryPointNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E9A")]
	protected TypeLoadException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1505E90", Offset = "0x1505090", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = "SetMessageField", ReturnType = typeof(void))]
	[Token(Token = "0x6000E96")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1505850", Offset = "0x1504A50", Length = "0x1B0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E9B")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1505A10", Offset = "0x1504C10", Length = "0x139")]
	[CalledBy(Type = typeof(TypeLoadException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000E97")]
	private void SetMessageField() { }

}

