namespace Unity.Hierarchy;

[IsReadOnly]
[Token(Token = "0x200000F")]
public struct HierarchyPropertyUnmanaged : IEquatable<HierarchyPropertyUnmanaged`1<T>>, IHierarchyProperty<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000022")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000023")]
	internal readonly HierarchyPropertyId m_Property; //Field offset: 0x0

	[Address(RVA = "0xC85EB0", Offset = "0xC850B0", Length = "0xDF")]
	[CalledBy(Type = typeof(Hierarchy), Member = "GetOrCreatePropertyUnmanaged", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyStorageType)}, ReturnType = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyPropertyId), Member = "get_Null", ReturnType = typeof(HierarchyPropertyId&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	internal HierarchyPropertyUnmanaged`1(Hierarchy hierarchy, in HierarchyPropertyId property) { }

	[Address(RVA = "0xC853D0", Offset = "0xC845D0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	[Token(Token = "0x600003B")]
	public override bool Equals(HierarchyPropertyUnmanaged<T> other) { }

	[Address(RVA = "0xC85400", Offset = "0xC84600", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	[Token(Token = "0x600003D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xC85650", Offset = "0xC84850", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	[Token(Token = "0x600003E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xC858B0", Offset = "0xC84AB0", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "GetPropertyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyPropertyId&), typeof(HierarchyNode&), typeof(Int32&)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	public T GetValue(in HierarchyNode node) { }

	[Address(RVA = "0xC859D0", Offset = "0xC84BD0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "SetPropertyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyPropertyId&), typeof(HierarchyNode&), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public void SetValue(in HierarchyNode node, T value) { }

	[Address(RVA = "0xC85BF0", Offset = "0xC84DF0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HierarchyPropertyId), Member = "ToString", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	[Token(Token = "0x600003C")]
	public virtual string ToString() { }

	[Address(RVA = "0xC85C00", Offset = "0xC84E00", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B6AD0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600003F")]
	private override T Unity.Hierarchy.IHierarchyProperty<T>.GetValue(in HierarchyNode node) { }

	[Address(RVA = "0xC85E50", Offset = "0xC85050", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B6BF0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	private override void Unity.Hierarchy.IHierarchyProperty<T>.SetValue(in HierarchyNode node, T value) { }

}

