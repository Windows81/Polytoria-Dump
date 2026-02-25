namespace Polytoria.Controllers;

[Token(Token = "0x20003FF")]
public class GlobalStateController : MonoBehaviour
{
	[Token(Token = "0x40010C2")]
	public static GlobalStateController instance; //Field offset: 0x0
	[Token(Token = "0x40010C3")]
	private const float ScrollViewSpeed = 15; //Field offset: 0x0

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AFA")]
	public GlobalStateController() { }

	[Address(RVA = "0x4C1320", Offset = "0x4C0520", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002AF8")]
	private void Awake() { }

	[Address(RVA = "0x4C1380", Offset = "0x4C0580", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002AF9")]
	private void Start() { }

}

