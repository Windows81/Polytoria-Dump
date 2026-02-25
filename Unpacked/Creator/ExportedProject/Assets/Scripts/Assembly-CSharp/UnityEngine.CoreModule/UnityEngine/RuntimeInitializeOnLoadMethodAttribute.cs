namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = False)]
[RequiredByNativeCode]
[Token(Token = "0x2000156")]
public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000578")]
	private RuntimeInitializeLoadType m_LoadType; //Field offset: 0x10

	[Token(Token = "0x1700019A")]
	private RuntimeInitializeLoadType loadType
	{
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E8")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x196EE30", Offset = "0x196E030", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009E6")]
	public RuntimeInitializeOnLoadMethodAttribute() { }

	[Address(RVA = "0x196EE50", Offset = "0x196E050", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009E7")]
	public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E8")]
	private void set_loadType(RuntimeInitializeLoadType value) { }

}

