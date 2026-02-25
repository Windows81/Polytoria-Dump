namespace AOT;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
[Token(Token = "0x2000004")]
public class MonoPInvokeCallbackAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public MonoPInvokeCallbackAttribute(Type type) { }

}

