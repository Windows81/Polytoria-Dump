namespace System.Runtime.Versioning;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False, Inherited = False)]
[Token(Token = "0x20003C0")]
public sealed class TargetFrameworkAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F0D")]
	private string _frameworkName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F0E")]
	private string _frameworkDisplayName; //Field offset: 0x18

	[Token(Token = "0x1700039A")]
	public string FrameworkDisplayName
	{
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CBF")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1397A00", Offset = "0x1396C00", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CBE")]
	public TargetFrameworkAttribute(string frameworkName) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CBF")]
	public void set_FrameworkDisplayName(string value) { }

}

