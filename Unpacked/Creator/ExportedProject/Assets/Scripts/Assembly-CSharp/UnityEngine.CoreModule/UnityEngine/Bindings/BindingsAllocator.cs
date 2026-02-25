namespace UnityEngine.Bindings;

[NativeHeader("Runtime/Scripting/Marshalling/BindingsAllocator.h")]
[StaticAccessor("Marshalling::BindingsAllocator", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x20001D4")]
[VisibleToOtherModules]
internal static class BindingsAllocator
{
	[Token(Token = "0x20001D5")]
	private struct NativeOwnedMemory
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400066A")]
		public Void* data; //Field offset: 0x0

	}


	[Address(RVA = "0x197B7F0", Offset = "0x197A9F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000C7E")]
	public static void Free(Void* ptr) { }

	[Address(RVA = "0x197B7B0", Offset = "0x197A9B0", Length = "0x33")]
	[CalledBy(Type = typeof(BlittableArrayWrapper), Member = "Unmarshal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BlittableListWrapper), Member = "Unmarshal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Accessibility.ServiceManager", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000C7F")]
	public static void FreeNativeOwnedMemory(Void* ptr) { }

	[Address(RVA = "0x197B830", Offset = "0x197AA30", Length = "0x16")]
	[CalledBy(Type = typeof(BlittableArrayWrapper), Member = "Unmarshal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BlittableListWrapper), Member = "Unmarshal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Accessibility.ServiceManager", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C80")]
	public static Void* GetNativeOwnedDataPointer(Void* ptr) { }

}

