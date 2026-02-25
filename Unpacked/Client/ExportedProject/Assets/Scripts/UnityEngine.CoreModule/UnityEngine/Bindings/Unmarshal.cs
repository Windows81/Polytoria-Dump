namespace UnityEngine.Bindings;

[Token(Token = "0x20001D2")]
[VisibleToOtherModules]
internal struct Unmarshal
{

	[Address(RVA = "0x19938F0", Offset = "0x1992AF0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000C7B")]
	public static GCHandle FromIntPtrUnsafe(IntPtr gcHandle) { }

	[Address(RVA = "0x7C7620", Offset = "0x7C6820", Length = "0xB0")]
	[CallerCount(Count = 115)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C7A")]
	public static T UnmarshalUnityObject(IntPtr gcHandlePtr) { }

}

