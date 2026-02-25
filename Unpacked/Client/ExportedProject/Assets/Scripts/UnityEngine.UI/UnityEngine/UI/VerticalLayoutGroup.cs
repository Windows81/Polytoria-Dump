namespace UnityEngine.UI;

[AddComponentMenu("Layout/Vertical Layout Group", 151)]
[Token(Token = "0x2000054")]
public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
{

	[Address(RVA = "0x1CB3FA0", Offset = "0x1CB31A0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000339")]
	protected VerticalLayoutGroup() { }

	[Address(RVA = "0x1CC7F10", Offset = "0x1CC7110", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600033A")]
	public virtual void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x1CC7F40", Offset = "0x1CC7140", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600033B")]
	public virtual void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x1CC7F50", Offset = "0x1CC7150", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600033C")]
	public virtual void SetLayoutHorizontal() { }

	[Address(RVA = "0x1CC7F60", Offset = "0x1CC7160", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600033D")]
	public virtual void SetLayoutVertical() { }

}

