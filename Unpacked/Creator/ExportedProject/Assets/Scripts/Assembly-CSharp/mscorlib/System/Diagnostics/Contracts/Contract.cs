namespace System.Diagnostics.Contracts;

[Token(Token = "0x2000582")]
public static class Contract
{

	[Address(RVA = "0x68A480", Offset = "0x689680", Length = "0x207")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6002851")]
	public static bool ForAll(IEnumerable<T> collection, Predicate<T> predicate) { }

}

