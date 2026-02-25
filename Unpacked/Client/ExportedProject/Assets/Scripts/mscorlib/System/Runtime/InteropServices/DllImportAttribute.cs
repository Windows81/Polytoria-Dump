namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000447")]
public sealed class DllImportAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001207")]
	internal string _val; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001208")]
	public string EntryPoint; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001209")]
	public CharSet CharSet; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400120A")]
	public bool SetLastError; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x400120B")]
	public bool ExactSpelling; //Field offset: 0x25
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x400120C")]
	public bool PreserveSig; //Field offset: 0x26
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400120D")]
	public CallingConvention CallingConvention; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400120E")]
	public bool BestFitMapping; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x400120F")]
	public bool ThrowOnUnmappableChar; //Field offset: 0x2D

	[Token(Token = "0x170003EA")]
	public string Value
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F82")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x13B7EA0", Offset = "0x13B70A0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F80")]
	internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F81")]
	public DllImportAttribute(string dllName) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F82")]
	public string get_Value() { }

	[Address(RVA = "0x13B7BF0", Offset = "0x13B6DF0", Length = "0x258")]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetPInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PInvokeAttributes&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001F7E")]
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	[Address(RVA = "0x13B7E70", Offset = "0x13B7070", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001F7F")]
	internal static bool IsDefined(RuntimeMethodInfo method) { }

}

