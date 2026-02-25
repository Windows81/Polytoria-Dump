namespace Battlehub.UIControls.MenuControl;

[Token(Token = "0x2000053")]
public class ContextMenuTrigger : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000178")]
	private Menu m_menu; //Field offset: 0x20

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600039B")]
	public ContextMenuTrigger() { }

	[Address(RVA = "0x5E6B40", Offset = "0x5E5D40", Length = "0x229")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Menu), Member = "Open", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600039A")]
	private void Update() { }

}

