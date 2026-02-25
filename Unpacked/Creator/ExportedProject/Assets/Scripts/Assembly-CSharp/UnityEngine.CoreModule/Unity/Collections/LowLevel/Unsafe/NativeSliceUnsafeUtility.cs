namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[Token(Token = "0x200005B")]
public static class NativeSliceUnsafeUtility
{

	[Address(RVA = "0x706B60", Offset = "0x705D60", Length = "0x132")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D4")]
	public static NativeSlice<T> ConvertExistingDataToNativeSlice(Void* dataPointer, int stride, int length) { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60000D5")]
	public static Void* GetUnsafePtr(NativeSlice<T> nativeSlice) { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60000D6")]
	public static Void* GetUnsafeReadOnlyPtr(NativeSlice<T> nativeSlice) { }

}

