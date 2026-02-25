namespace UnityEngine;

[Token(Token = "0x20000F6")]
[UsedByNativeCode]
public struct GradientColorKey
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048A")]
	public Color color; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400048B")]
	public float time; //Field offset: 0x10

	[Address(RVA = "0x1945240", Offset = "0x1944440", Length = "0xC")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600070A")]
	public GradientColorKey(Color col, float time) { }

}

