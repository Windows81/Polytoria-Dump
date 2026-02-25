namespace Polytoria.UI;

[Token(Token = "0x20002E9")]
public class CreatorViewport : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B4A")]
	private RectTransform rect; //Field offset: 0x20

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B32")]
	public CreatorViewport() { }

	[Address(RVA = "0x407600", Offset = "0x406800", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001B30")]
	private void Awake() { }

	[Address(RVA = "0x407650", Offset = "0x406850", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "set_rect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B31")]
	private void Update() { }

}

