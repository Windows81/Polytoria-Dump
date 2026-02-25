namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000243")]
public abstract class BaseFieldMouseDragger
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8B")]
	protected BaseFieldMouseDragger() { }

	[Token(Token = "0x6000F8A")]
	public abstract void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	[Address(RVA = "0x1C48F00", Offset = "0x1C48100", Length = "0x2F")]
	[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "OnIsReadOnlyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "EnableLabelDragger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F89")]
	public void SetDragZone(VisualElement dragElement) { }

}

