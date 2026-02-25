namespace Unity.Burst.CompilerServices;

[AttributeUsage(10240)]
[Token(Token = "0x2000020")]
public class AssumeRangeAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public AssumeRangeAttribute(long min, long max) { }

}

