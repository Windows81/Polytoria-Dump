namespace System.Resources;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False)]
[Token(Token = "0x20004AA")]
public sealed class SatelliteContractVersionAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012B1")]
	private readonly string <Version>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x13C9E20", Offset = "0x13C9020", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020EE")]
	public SatelliteContractVersionAttribute(string version) { }

}

