namespace Polytoria.UI;

[Token(Token = "0x20002EA")]
public class MenuButtonAnimation : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B4B")]
	private Animator anim; //Field offset: 0x20

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B35")]
	public MenuButtonAnimation() { }

	[Address(RVA = "0x40FAF0", Offset = "0x40ECF0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001B33")]
	private void Awake() { }

	[Address(RVA = "0x40FB40", Offset = "0x40ED40", Length = "0x56")]
	[CalledBy(Type = typeof(UIController), Member = "SetPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Animator), Member = "SetInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B34")]
	public void SetOpen(bool open) { }

}

