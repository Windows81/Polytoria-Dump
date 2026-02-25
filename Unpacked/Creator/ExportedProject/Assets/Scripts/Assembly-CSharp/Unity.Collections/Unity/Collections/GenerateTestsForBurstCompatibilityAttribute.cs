namespace Unity.Collections;

[AttributeUsage(236, AllowMultiple = True)]
[Token(Token = "0x200001D")]
public class GenerateTestsForBurstCompatibilityAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000055")]
	private Type[] <GenericTypeArguments>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700000A")]
	public Type[] GenericTypeArguments
	{
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000041")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000042")]
	public GenerateTestsForBurstCompatibilityAttribute() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public void set_GenericTypeArguments(Type[] value) { }

}

