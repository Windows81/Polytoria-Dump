namespace UnityEngine.Bindings;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20001D8")]
[VisibleToOtherModules]
internal struct BlittableListWrapper
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000675")]
	private BlittableArrayWrapper arrayWrapper; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000676")]
	private int listSize; //Field offset: 0x10

	[Address(RVA = "0x88C310", Offset = "0x88B510", Length = "0xB")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C83")]
	public BlittableListWrapper(BlittableArrayWrapper arrayWrapper, int listSize) { }

	[Address(RVA = "0x684CB0", Offset = "0x683EB0", Length = "0x204")]
	[CalledBy(Type = "UnityEngine.PhysicsScene2D", Member = "RaycastList_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.PhysicsScene2D", typeof(Vector2), typeof(Vector2), typeof(float), "UnityEngine.ContactFilter2D", "System.Collections.Generic.List`1<RaycastHit2D>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002A250")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(BindingsAllocator), Member = "FreeNativeOwnedMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingsAllocator), Member = "GetNativeOwnedDataPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002A260")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C84")]
	internal void Unmarshal(List<T> list) { }

}

