namespace UnityEngine.UI;

[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
[Token(Token = "0x2000046")]
public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
{

	[Address(RVA = "0x1CB3FA0", Offset = "0x1CB31A0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600029D")]
	protected HorizontalLayoutGroup() { }

	[Address(RVA = "0x1CB3F40", Offset = "0x1CB3140", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600029E")]
	public virtual void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x1CB3F70", Offset = "0x1CB3170", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600029F")]
	public virtual void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x1CB3F80", Offset = "0x1CB3180", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A0")]
	public virtual void SetLayoutHorizontal() { }

	[Address(RVA = "0x1CB3F90", Offset = "0x1CB3190", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A1")]
	public virtual void SetLayoutVertical() { }

}

