namespace System.IO;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x20001ED")]
public class IODescriptionAttribute : DescriptionAttribute
{

	[Token(Token = "0x17000265")]
	public virtual string Description
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C52")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17C14B0", Offset = "0x17C06B0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C51")]
	public IODescriptionAttribute(string description) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C52")]
	public virtual string get_Description() { }

}

