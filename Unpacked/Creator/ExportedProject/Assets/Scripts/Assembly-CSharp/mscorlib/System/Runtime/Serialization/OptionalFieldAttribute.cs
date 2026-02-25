namespace System.Runtime.Serialization;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x20003E4")]
public sealed class OptionalFieldAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F63")]
	private int versionAdded; //Field offset: 0x10

	[Token(Token = "0x170003C5")]
	public int VersionAdded
	{
		[Address(RVA = "0x13907E0", Offset = "0x138F9E0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001D90")]
		 set { } //Length: 122
	}

	[Address(RVA = "0x13907D0", Offset = "0x138F9D0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D8F")]
	public OptionalFieldAttribute() { }

	[Address(RVA = "0x13907E0", Offset = "0x138F9E0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D90")]
	public void set_VersionAdded(int value) { }

}

