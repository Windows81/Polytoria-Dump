namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x2000165")]
public sealed class ExtenderProvidedPropertyAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000606")]
	private IExtenderProvider <Provider>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700019F")]
	public IExtenderProvider Provider
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60008AC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AC")]
	public IExtenderProvider get_Provider() { }

}

