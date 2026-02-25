namespace System.IO;

[Token(Token = "0x2000629")]
public class FileNotFoundException : IOException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40018FB")]
	private readonly string <FileName>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40018FC")]
	private readonly string <FusionLog>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x170006F5")]
	public string FileName
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CD9")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170006F6")]
	public string FusionLog
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CDA")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170006F4")]
	public virtual string Message
	{
		[Address(RVA = "0x1455CA0", Offset = "0x1454EA0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Token(Token = "0x6002CD7")]
		 get { } //Length: 215
	}

	[Address(RVA = "0x1455B20", Offset = "0x1454D20", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CD4")]
	public FileNotFoundException() { }

	[Address(RVA = "0x1455C40", Offset = "0x1454E40", Length = "0x1E")]
	[CalledBy(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "GetManifestResourceStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CD5")]
	public FileNotFoundException(string message) { }

	[Address(RVA = "0x1455C60", Offset = "0x1454E60", Length = "0x3F")]
	[CalledBy(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName), typeof(Evidence)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileInfo), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002CD6")]
	public FileNotFoundException(string message, string fileName) { }

	[Address(RVA = "0x1455B70", Offset = "0x1454D70", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002CDC")]
	protected FileNotFoundException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002CD9")]
	public string get_FileName() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002CDA")]
	public string get_FusionLog() { }

	[Address(RVA = "0x1455CA0", Offset = "0x1454EA0", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002CD7")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1455750", Offset = "0x1454950", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002CDD")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1455860", Offset = "0x1454A60", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002CD8")]
	private void SetMessageField() { }

	[Address(RVA = "0x1455930", Offset = "0x1454B30", Length = "0x1EF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6002CDB")]
	public virtual string ToString() { }

}

