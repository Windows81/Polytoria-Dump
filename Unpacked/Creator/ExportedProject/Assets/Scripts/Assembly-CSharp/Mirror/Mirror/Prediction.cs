namespace Mirror;

[Token(Token = "0x2000073")]
public static class Prediction
{

	[Address(RVA = "0x72D610", Offset = "0x72C810", Length = "0x943")]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "OnReceivedState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.RigidbodyState"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SortedList`2), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Quaternion), Member = "Slerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180726960")]
	[Calls(Type = typeof(SortedList`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E7")]
	public static T CorrectHistory(SortedList<Double, T> history, int stateHistoryLimit, T corrected, T before, T after, int afterIndex) { }

	[Address(RVA = "0x72E490", Offset = "0x72D690", Length = "0x3CA")]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "OnReceivedState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.RigidbodyState"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C600")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C6A0")]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.RigidbodyState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.RigidbodyState"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E6")]
	public static bool Sample(SortedList<Double, T> history, double timestamp, out T before, out T after, out int afterIndex, out double t) { }

}

