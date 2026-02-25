namespace Mono.Util;

[AttributeUsage(AttributeTargets::Method (64))]
[Conditional("UNITY")]
[Conditional("FULL_AOT_RUNTIME")]
[Conditional("MONOTOUCH")]
[Token(Token = "0x2000007")]
internal sealed class MonoPInvokeCallbackAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000022")]
	public MonoPInvokeCallbackAttribute(Type t) { }

}

