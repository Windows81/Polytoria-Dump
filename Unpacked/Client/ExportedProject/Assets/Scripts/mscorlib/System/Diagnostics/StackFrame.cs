namespace System.Diagnostics;

[ComVisible(True)]
[MonoTODO("Serialized objects are not compatible with MS.NET")]
[Token(Token = "0x200057F")]
public class StackFrame
{
	[Token(Token = "0x4001766")]
	public const int OFFSET_UNKNOWN = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001767")]
	private int ilOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001768")]
	private int nativeOffset; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001769")]
	private long methodAddress; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400176A")]
	private uint methodIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400176B")]
	private MethodBase methodBase; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400176C")]
	private string fileName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400176D")]
	private int lineNumber; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400176E")]
	private int columnNumber; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400176F")]
	private string internalMethodName; //Field offset: 0x40

	[Address(RVA = "0x144A380", Offset = "0x1449580", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802120F0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002836")]
	public StackFrame() { }

	[Address(RVA = "0x144A300", Offset = "0x1449500", Length = "0x79")]
	[CalledBy(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802120F0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002837")]
	public StackFrame(int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x144A3E0", Offset = "0x14495E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802120F0")]
	[Token(Token = "0x6002835")]
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002838")]
	public override int GetFileLineNumber() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002839")]
	public override string GetFileName() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600283B")]
	public override int GetILOffset() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002840")]
	internal string GetInternalMethodName() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600283C")]
	public override MethodBase GetMethod() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600283E")]
	internal long GetMethodAddress() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600283F")]
	internal uint GetMethodIndex() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600283D")]
	public override int GetNativeOffset() { }

	[Address(RVA = "0x144A090", Offset = "0x1449290", Length = "0x60")]
	[CalledBy(Type = typeof(StackFrame), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600283A")]
	internal string GetSecureFileName() { }

	[Address(RVA = "0x144A0F0", Offset = "0x14492F0", Length = "0x200")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StackFrame), Member = "GetSecureFileName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002841")]
	public virtual string ToString() { }

}

