namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[Token(Token = "0x20004BF")]
public sealed class AssemblyFileVersionAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012EB")]
	private readonly string <Version>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x13B4F90", Offset = "0x13B4190", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002146")]
	public AssemblyFileVersionAttribute(string version) { }

}

