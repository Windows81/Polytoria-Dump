namespace Unity.Profiling;

[AttributeUsage(76, AllowMultiple = False)]
[RequiredByNativeCode]
[Token(Token = "0x200001D")]
public sealed class IgnoredByDeepProfilerAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public IgnoredByDeepProfilerAttribute() { }

}

