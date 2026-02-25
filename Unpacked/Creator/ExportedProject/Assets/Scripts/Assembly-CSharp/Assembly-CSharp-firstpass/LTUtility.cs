//Type is in global namespace

[Token(Token = "0x2000014")]
public class LTUtility
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000127")]
	public LTUtility() { }

	[Address(RVA = "0x2C31F0", Offset = "0x2C23F0", Length = "0xA9")]
	[CalledBy(Type = typeof(LTDescr), Member = "setDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(LTDescr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000126")]
	public static Vector3[] reverse(Vector3[] arr) { }

}

