namespace TMPro;

[Token(Token = "0x2000084")]
public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400040A")]
	public bool isSelected; //Field offset: 0x20

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044D")]
	public TMP_ScrollbarEventHandler() { }

	[Address(RVA = "0x18E8C50", Offset = "0x18E7E50", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600044C")]
	public override void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x18E8CB0", Offset = "0x18E7EB0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600044A")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x18E8D10", Offset = "0x18E7F10", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600044B")]
	public override void OnSelect(BaseEventData eventData) { }

}

