namespace UnityEngine;

[Token(Token = "0x200014F")]
public struct LazyLoadReference
{
	[Token(Token = "0x400056A")]
	private const int kInstanceID_None = 0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400056B")]
	private int m_InstanceID; //Field offset: 0x0

	[Token(Token = "0x17000194")]
	public T asset
	{
		[Address(RVA = "0xCE74E0", Offset = "0xCE66E0", Length = "0xC1")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+AssetEntry", Member = "get_asset", ReturnType = typeof(Object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "ForceLoadFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009A2")]
		 get { } //Length: 193
		[Address(RVA = "0xCE7600", Offset = "0xCE6800", Length = "0xF6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "IsPersistent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009A3")]
		 set { } //Length: 246
	}

	[Token(Token = "0x17000193")]
	public bool isSet
	{
		[Address(RVA = "0x2FC900", Offset = "0x2FBB00", Length = "0x7")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60009A1")]
		 get { } //Length: 7
	}

	[Address(RVA = "0xCE74E0", Offset = "0xCE66E0", Length = "0xC1")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+AssetEntry", Member = "get_asset", ReturnType = typeof(Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "ForceLoadFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A2")]
	public T get_asset() { }

	[Address(RVA = "0x2FC900", Offset = "0x2FBB00", Length = "0x7")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A1")]
	public bool get_isSet() { }

	[Address(RVA = "0xCE75B0", Offset = "0xCE67B0", Length = "0x48")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+AssetEntry", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800C9F40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A4")]
	public static LazyLoadReference<T> op_Implicit(T asset) { }

	[Address(RVA = "0xCE7600", Offset = "0xCE6800", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "IsPersistent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A3")]
	public void set_asset(T value) { }

}

