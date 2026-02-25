namespace Mirror;

[Token(Token = "0x200004C")]
public class ToggleHotkey : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A3")]
	public KeyCode Key; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001A4")]
	public GameObject ToToggle; //Field offset: 0x28

	[Address(RVA = "0x1246270", Offset = "0x1245470", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000267")]
	public ToggleHotkey() { }

	[Address(RVA = "0x1246220", Offset = "0x1245420", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000266")]
	private void Update() { }

}

