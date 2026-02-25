namespace System.Runtime.InteropServices;

[AttributeUsage(10496, Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000452")]
public sealed class MarshalAsAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400122B")]
	public string MarshalCookie; //Field offset: 0x10
	[ComVisible(True)]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400122C")]
	public string MarshalType; //Field offset: 0x18
	[ComVisible(True)]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400122D")]
	public Type MarshalTypeRef; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400122E")]
	public Type SafeArrayUserDefinedSubType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400122F")]
	private UnmanagedType utype; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001230")]
	public UnmanagedType ArraySubType; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001231")]
	public VarEnum SafeArraySubType; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001232")]
	public int SizeConst; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001233")]
	public int IidParameterIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001234")]
	public short SizeParamIndex; //Field offset: 0x44

	[Token(Token = "0x170003EF")]
	public UnmanagedType Value
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FF7")]
		 get { } //Length: 174
	}

	[Address(RVA = "0x13BAE00", Offset = "0x13BA000", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FF6")]
	public MarshalAsAttribute(UnmanagedType unmanagedType) { }

	[Address(RVA = "0x13BADA0", Offset = "0x13B9FA0", Length = "0x57")]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FF8")]
	internal MarshalAsAttribute Copy() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FF7")]
	public UnmanagedType get_Value() { }

}

