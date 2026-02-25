namespace System.Reflection;

[Token(Token = "0x20004E9")]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40013A2")]
	private readonly Type[] <Types>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40013A3")]
	private readonly Exception[] <LoaderExceptions>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x17000462")]
	public Exception[] LoaderExceptions
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600221F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000463")]
	public virtual string Message
	{
		[Address(RVA = "0x13C1760", Offset = "0x13C0960", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[Token(Token = "0x6002220")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000461")]
	public Type[] Types
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600221E")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x13C16F0", Offset = "0x13C08F0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600221B")]
	public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions) { }

	[Address(RVA = "0x13C15C0", Offset = "0x13C07C0", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600221C")]
	private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13C1340", Offset = "0x13C0540", Length = "0x154")]
	[CalledBy(Type = typeof(ReflectionTypeLoadException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectionTypeLoadException), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002222")]
	private string CreateString(bool isMessage) { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600221F")]
	public Exception[] get_LoaderExceptions() { }

	[Address(RVA = "0x13C1760", Offset = "0x13C0960", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002220")]
	public virtual string get_Message() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600221E")]
	public Type[] get_Types() { }

	[Address(RVA = "0x13C14A0", Offset = "0x13C06A0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600221D")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13C15B0", Offset = "0x13C07B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002221")]
	public virtual string ToString() { }

}

