namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x2000015")]
[VisibleToOtherModules]
internal class ThreadSafeAttribute : NativeMethodAttribute
{

	[Address(RVA = "0x1A19A80", Offset = "0x1A18C80", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	public ThreadSafeAttribute() { }

}

