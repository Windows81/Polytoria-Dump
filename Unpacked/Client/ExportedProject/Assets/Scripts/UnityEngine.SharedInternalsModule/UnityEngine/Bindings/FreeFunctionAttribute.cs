namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x2000014")]
[VisibleToOtherModules]
internal class FreeFunctionAttribute : NativeMethodAttribute
{

	[Address(RVA = "0x1A19360", Offset = "0x1A18560", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002A")]
	public FreeFunctionAttribute() { }

	[Address(RVA = "0x1A19380", Offset = "0x1A18580", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600002B")]
	public FreeFunctionAttribute(string name) { }

	[Address(RVA = "0x1A193A0", Offset = "0x1A185A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600002C")]
	public FreeFunctionAttribute(string name, bool isThreadSafe) { }

}

