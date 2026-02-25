namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Property (128))]
[Token(Token = "0x2000197")]
public sealed class NotifyParentPropertyAttribute : Attribute
{
	[Token(Token = "0x4000661")]
	public static readonly NotifyParentPropertyAttribute Yes; //Field offset: 0x0
	[Token(Token = "0x4000662")]
	public static readonly NotifyParentPropertyAttribute No; //Field offset: 0x8
	[Token(Token = "0x4000663")]
	public static readonly NotifyParentPropertyAttribute Default; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000664")]
	private bool notifyParent; //Field offset: 0x10

	[Token(Token = "0x170001CF")]
	public bool NotifyParent
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17A2530", Offset = "0x17A1730", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009CC")]
	private static NotifyParentPropertyAttribute() { }

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C7")]
	public NotifyParentPropertyAttribute(bool notifyParent) { }

	[Address(RVA = "0x17A2420", Offset = "0x17A1620", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009C9")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C8")]
	public bool get_NotifyParent() { }

	[Address(RVA = "0x177CCF0", Offset = "0x177BEF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x17A24C0", Offset = "0x17A16C0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009CB")]
	public virtual bool IsDefaultAttribute() { }

}

