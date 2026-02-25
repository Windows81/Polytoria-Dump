namespace System.Diagnostics;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x200010A")]
public class MonitoringDescriptionAttribute : DescriptionAttribute
{

	[Token(Token = "0x17000102")]
	public virtual string Description
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000662")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x177F240", Offset = "0x177E440", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000661")]
	public MonitoringDescriptionAttribute(string description) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000662")]
	public virtual string get_Description() { }

}

